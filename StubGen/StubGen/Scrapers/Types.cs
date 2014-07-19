using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace StubGen
{
    public class ScrapedGeneric : ScrapedType
    {
        public ScrapedType Name { get; set; }
        public List<ScrapedType> Types { get; set; }

        public ScrapedGeneric(string type)
        {
            RawSwift = type;

            Name = ScrapeType(Helpers.ParseType(type.Split("<").First()));

            var insideOfTypes = type.Substring(type.IndexOf('<') + 1);
            insideOfTypes = insideOfTypes.Substring(0, insideOfTypes.Length - 1);
            var types = ScrapedParameter.ScrapeParameters(insideOfTypes);
            Types = new List<ScrapedType>();
            foreach (var genType in types)
            {
                Types.Add(ScrapeType(genType));
            }

            CSharpType = Name.CSharpType + "<" + string.Join(", ", Types.Select(genType => genType.CSharpType)) + ">";
        }
    }

    public class ScrapedArray : ScrapedType
    {
        public ScrapedType ValueType { get; set; }

        public ScrapedArray(string type)
        {
            RawSwift = type;

            type = type.Substring(1, type.Length - 2);
            ValueType = ScrapeType(type);
            CSharpType = ValueType.CSharpType + "[]";
        }
    }

    public class ScrapedDictionary : ScrapedType
    {
        public ScrapedType KeyType { get; set; }
        public ScrapedType ValueType { get; set; }

        public ScrapedDictionary(string type)
        {
            RawSwift = type;

            type = type.Substring(1, type.Length - 2);
            KeyType = ScrapeType(type.Split(':')[0].Trim());
            ValueType = ScrapeType(type.Split(':')[1].Trim());
            CSharpType = "Dictionary<" + KeyType.CSharpType + ", " + ValueType.CSharpType + ">";
        }
    }

    public class ScrapedBlock : ScrapedType
    {
        public ScrapedType Returns { get; set; }
        public List<ScrapedType> Parameters { get; set; }

        public ScrapedBlock(string type)
        {
            RawSwift = type;

            type = "(" + type.Trim(new[] {'(', ')', '!'}); //todo: lol this

            var returnType = type.Split("->").Last().Trim();
            if (returnType == "(")
            {
                CSharpType = "Action";
                Returns = ScrapeType("void");
                Parameters = new List<ScrapedType>();
                return;
            }
            Returns = ScrapeType(returnType);

            var parameters = ScrapedParameter.ScrapeParameters(type.Split("->")[0].Trim().Trim('(', ')'));
            Parameters = new List<ScrapedType>();
            foreach (var param in parameters)
            {
                Parameters.Add(ScrapeType(param.Trim()));
            }

            if (returnType == "void" || Returns.CSharpType == "void")
            {
                if (Parameters.Count == 0)
                {
                    CSharpType = "Action";
                }
                else
                {
                    CSharpType = "Action<" + string.Join(", ", Parameters.Select(param => param.CSharpType)) + ">";
                }
            }
            else
            {
                CSharpType = "Func<" + string.Join(", ", Parameters.Select(param => param.CSharpType)) + ", " + Returns.CSharpType + ">";
            }
        }
    }

    public class ScrapedType
    {
        public string CSharpType { get; set; }
        public string RawSwift { get; set; }

        public ScrapedType() { }

        public ScrapedType(string type)
        {
            RawSwift = type;

            CSharpType = Helpers.ParseType(type);
        }

        public static ScrapedType ScrapeType(string type)
        {
            type = Helpers.ParseType(type);
            if (type == "" || type == ")" || type == "(AnyObject!," || type == "([NSObject" || type == "(ConstUnsafePointer<()>" || (type.StartsWith("(") && type.Count(chr => chr == ')') == 0))
            {
                return new ScrapedType("WEIRD");
            }

            if (type.StartsWith("[") && type.EndsWith("]"))
            {
                //This is an array or a dictionary!
                if (type.Contains(':'))
                {
                    //TODO: what if it's a dictionary of dictionarys? O:
                    //or array of dictionaries

                    return new ScrapedDictionary(type);
                }
                return new ScrapedArray(type);
            }

            if (type.StartsWith("("))
            {
                //this is a block
                return new ScrapedBlock(type);
            }

            if (type.Contains('<') && type.Contains('>'))
            {
                return new ScrapedGeneric(type);
            }

            return new ScrapedType(type);
        }
    }
}
