using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StubGen
{
    class Parser
    {
        public static string ParseType(string type)
        {
            type = type.Trim('*', ' ');
            switch(type)
            {
                case "id":
                    return "dynamic";
                case "_Bool":
                    return "bool";
                default:
                    return type;
            }
        }

        public static string ParseInterface(StreamReader reader, string currLine)
        {
            var output = "class " + Regex.Split(currLine, "@interface ")[1].Split(' ')[0];
            var superclass = currLine.Split(':');
            if(superclass.Length > 1)
            {
                output += ": " + superclass[1].Split('<')[0].Trim();
            }
            output += " {\r\n";

            while (true)
            {
                var line = reader.ReadLine();
                if (line == null) break;
                else line = line.Trim();

                if(line == "@end")
                {
                    return output + "}\r\n";
                }
                
                if(line.StartsWith("+") || line.StartsWith("-"))
                {
                    output += "public " + (line.StartsWith("+") ? "static " : "");
                    var retType = ParseType(line.Split('(')[1].Split(')')[0]);
                    output += retType.TrimEnd(';');

                    var name = line.Split(')')[1].Split(':')[0].TrimEnd(';');
                    /*if(name.Contains("With"))
                    {
                        name = name.Substring(0, name.IndexOf("With"));
                    }
                    else if (name.Contains("For"))
                    {
                        name = name.Substring(0, name.IndexOf("For"));
                    }
                    else if (name.Contains("To"))
                    {
                        name = name.Substring(0, name.IndexOf("To"));
                    }
                    else if (name.Contains("Using"))
                    {
                        name = name.Substring(0, name.IndexOf("Using"));
                    }
                    else if (name.Contains("InRange"))
                    {
                        name = name.Substring(0, name.IndexOf("InRange"));
                    }
                    else if (name.Contains("FromIndex"))
                    {
                        name = name.Substring(0, name.IndexOf("FromIndex"));
                    }
                    else if (name.Contains("ToIndex"))
                    {
                        name = name.Substring(0, name.IndexOf("ToIndex"));
                    }*/

                    output += " " + name + "(";

                    if(line.Contains(":"))
                    {
                        var args = line.Split(':');
                        for (var a = 0; a < (args.Length - 1);a++)
                        {
                            var argName = "";
                            var argType = ParseType(args[a + 1].Split('(')[1].Split(')')[0]);

                            var currArg = args[a];
                            if(a == 0)
                            {
                                if(currArg.Contains("With"))
                                {
                                    argName = "w" + currArg.Substring(currArg.IndexOf("With")).Substring(1);
                                }
                                else if (currArg.Contains("For"))
                                {
                                    argName = "f" + currArg.Substring(currArg.IndexOf("For")).Substring(1);
                                }
                                else if (currArg.Contains("To"))
                                {
                                    argName = "t" + currArg.Substring(currArg.IndexOf("To")).Substring(1);
                                }
                                else if (currArg.Contains("Using"))
                                {
                                    argName = "u" + currArg.Substring(currArg.IndexOf("Using")).Substring(1);
                                }
                                else if (currArg.Contains("InRange"))
                                {
                                    argName = "i" + currArg.Substring(currArg.IndexOf("InRange")).Substring(1);
                                }
                                else if (currArg.Contains("FromIndex"))
                                {
                                    argName = "f" + currArg.Substring(currArg.IndexOf("FromIndex")).Substring(1);
                                }
                                else if (currArg.Contains("ToIndex"))
                                {
                                    argName = "t" + currArg.Substring(currArg.IndexOf("ToIndex")).Substring(1);
                                }
                                else
                                {
                                    argName = currArg.Split(')').Last();
                                }
                            }
                            else
                            {
                                argName = currArg.Split(' ').Last();
                            }

                            output += argType.Trim() + " " + argName.Trim() + ", ";
                        }
                        output = output.TrimEnd(' ', ',');
                    }
                    output += ") {\r\n";

                    switch(retType)
                    {
                        case "string":
                            output += "return String.Empty;";
                            break;
                        case "int":
                        case "double":
                        case "float":
                            output += "return 0;";
                            break;
                        case "bool":
                            output += "return false;";
                            break;
                        case "void":
                            output += "return;";
                            break;
                        default:
                            output += "return null;";
                            break;
                    }
                    output += "\r\n}\r\n";
                }
            }
            return output + "}\r\n";
        }

        public static string ParseFile(string path)
        {
            var output = "namespace Foundation {\r\n";
            using(var reader = new StreamReader(path))
            {
                while (true)
                {
                    var currLine = reader.ReadLine();
                    if (currLine == null) break;
                    else currLine = currLine.Trim();

                    if (currLine.StartsWith("#include "))
                    {
                        var includedFile = currLine.Split('"')[1].Split('"')[0]; //TODO: detect escaped quotes within includes
                        //TODO: do some kind of namespace stuff here, obj-c is pretty crappy w/ that
                    }
                    if(currLine.StartsWith("@interface "))
                    {
                        output += ParseInterface(reader, currLine);
                    }
                }
            }
            return output + "}";
        }
    }
}
