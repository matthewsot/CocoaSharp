﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StubGen.Scrapers.Finals
{
    partial class Finals
    {
        public static string Method(ScrapedMethod method, ScrapedClass parent, bool isInterface)
        {
            var output = "";
            var toOutput = method.GetTrivia();

            var toAddAfterSummary = NewLine;
            foreach (var param in method.Parameters)
            {
                if (param.Description == null)
                {
                    param.Description = "";
                }
                toAddAfterSummary += "/// <param name=\"" + param.Name + "\">" + ParseAsDescription(param.Description) +
                          "</param>" + NewLine;
            }

            var differentiator = Differentiate(method);
            if (differentiator != "")
            {
                toAddAfterSummary +=
                    "/// <param name=\"NAME_YOUR_PARAMS\">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>" +
                    NewLine;
            }
            if (method.ReturnDescription != null)
            {
                toAddAfterSummary += "/// <returns>" + ParseAsDescription(method.ReturnDescription) + "</returns>" +
                          NewLine;
            }
            
            if (method.IsOptional)
            {
                toOutput += "[InheritOptional]" + NewLine;
            }

            //Deal with optional/unwrapped return values using attributes
            if (method.ReturnType.Optional)
            {
                toOutput += "[return:Optional]" + NewLine;
            }
            if (method.ReturnType.Unwrapped)
            {
                toOutput += "[return:Unwrapped]" + NewLine;
            }

            if (differentiator != "")
            {
                toOutput += "[IgnoreParameter(\"NAME_YOUR_PARAMS\")]" + NewLine;
            }

            if (isInterface && (method.Static || method.IsConstructor || method.IsOptional))
            {
                //csharp doesn't allow static things in interfaces
                toOutput = toOutput.Replace("[", "//[");
            }
            output += toOutput.Replace("/// </summary>" + NewLine, "/// </summary>" + toAddAfterSummary);

            if (isInterface && (method.Static || method.IsConstructor || method.IsOptional))
            {
                output += "//";
            }

            if (!method.IsConstructor)
            {
                if (!isInterface) //TODO: comment out private/static methods
                {
                    output += method.Public ? "public " : "private ";
                    output += method.Static ? "static " : "virtual ";
                }

                if (method.ReturnType.CSharpType == "Self")
                {
                    method.ReturnType.CSharpType = parent.CSharpName;
                }

                output += method.ReturnType.CSharpType + " ";
                output += method.CSharpName + "(";

                output += string.Join(", ",
                    method.Parameters.Select(param => 
                    (param.Type.Optional ? "[Optional] " : "") + (param.Type.Unwrapped ? "[Unwrapped] " : "") +
                    (param.Type.CSharpType == "Self" ? parent.CSharpName : param.Type.CSharpType) + " " + param.Name));

                output += differentiator + ")";
                if (!isInterface)
                {
                    output += " { ";
                    if (method.ReturnType.CSharpType != "void")
                    {
                        output += "return default(" + method.ReturnType.CSharpType + ");";
                    }
                    output += " }";
                }
                else
                {
                    output += ";";
                }
                output += NewLine + NewLine;
            }
            else if (method.IsConstructor)
            {
                output += "public " + parent.Name + "(";
                output += string.Join(", ",
                    method.Parameters.Select(param =>
                    (param.Type.Optional ? "[Optional] " : "") + (param.Type.Unwrapped ? "[Unwrapped] " : "") +
                    (param.Type.CSharpType == "Self" ? parent.CSharpName : param.Type.CSharpType) + " " + param.Name));
                output += differentiator + ") { }" + NewLine + NewLine;
            }
            return output;
        }
    }
}
