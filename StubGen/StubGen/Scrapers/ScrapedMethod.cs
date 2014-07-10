using System.Collections.Generic;
using System.Linq;
using HtmlAgilityPack;

namespace StubGen
{
    public class ScrapedMethod : ScrapedMember
    {
        public List<ScrapedParameter> Parameters { get; set; }
        public string ReturnDescription { get; set; }
        public ScrapedType ReturnType { get; set; }
        public bool IsConstructor { get { return CSharpName == "init"; } }

        public ScrapedMethod(ScrapedMember baseValues, HtmlNode node) : base(baseValues)
        {
            Description = node.SelectSingleNode("./div[@class='abstract']/p").RealInnerText();
            Deprecated = Description.ToLower().Contains("deprecat");
            RawName = Declaration.Split('(')[0].Split("func ").Last();
            CSharpName = RawName.ToUpper()[0] + RawName.Substring(1);
            if (Declaration.ToLower().Contains("init("))
            {
                CSharpName = "init";
            }


            var parameters = Declaration.Substring(Declaration.IndexOf('(') + 1);
            parameters = parameters.Substring(0, parameters.LastIndexOf(')'));

            var separatedParameters = ScrapedParameter.ScrapeParameters(parameters);
            Parameters = new List<ScrapedParameter>();
            foreach (var param in separatedParameters)
            {
                Parameters.Add(new ScrapedParameter(param));
            }

            var parameterTableRows = node.SelectNodes("./div[@class='parameters']/table/tbody/tr");
            if (parameterTableRows != null)
            {
                foreach (var row in parameterTableRows)
                {
                    var name = row.SelectNodes("./td").First().RealInnerText().Trim();
                    var definition = row.SelectNodes("./td").Last().RealInnerText().Trim();
                    if (name != definition)
                    {
                        var matchingParameter = Parameters.FirstOrDefault(param => param.InternalName == name);
                        if (matchingParameter != null)
                        {
                            matchingParameter.Description = definition;
                        }
                    }
                }
            }

            var returns = node.SelectSingleNode("./result-description/p");
            if (returns != null)
            {
                ReturnDescription = returns.RealInnerText().Trim();
            }
            else
            {
                ReturnDescription = null;
            }

            if (Declaration.Contains("->"))
            {
                var returnType = Declaration.Split("->").Last();
                if (!returnType.EndsWith(")"))
                {
                    ReturnType = ScrapedType.ScrapeType(returnType);
                }
            }
            if (ReturnType == null)
            {
                ReturnType = ScrapedType.ScrapeType("void");
            }

            var objCDeclaration =
                node.SelectSingleNode("./div[@class='declaration']/div[@class='Objective-C']/p[@class='para']").RealInnerText().Trim();

            if (objCDeclaration.StartsWith("-") || !Declaration.Contains("class "))
            {
                Static = false;
            }
            else
            {
                Static = true;
            }
            Public = true;
        }
    }
}
