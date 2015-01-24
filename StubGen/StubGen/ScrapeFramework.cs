using System;
using System.CodeDom;
using System.IO;
using System.Net.Http;
using HtmlAgilityPack;
using StubGen.Scrapers.Finals;

namespace StubGen
{
    partial class Program
    {
        public enum RowType
        {
            Class,
            Interface
        }

        public static void ScrapeRow(IFrameworkURLData data, HtmlNode row, RowType type)
        {
            var cell = row.SelectSingleNode("./td");
            var name = cell.RealInnerText().Trim();

            string link;
            try
            {
                link = cell.SelectSingleNode("./p/code/a").GetAttributeValue("href", "");
            }
            catch
            {
                Console.WriteLine("No link for " + name);
                return;
            }

            foreach (var replace in data.LinkReplaces)
            {
                link = link.Replace(replace.Key, replace.Value);
            }

            var outputPath = @"Output\";
            if (type == RowType.Interface)
            {
                outputPath += @"Protocols\" + (name.ToLower().Contains("delegate") ? @"Delegates\" : "");
            }

            Directory.CreateDirectory(outputPath);

            using (var writer = new StreamWriter(outputPath + name + ".cs"))
            {
                writer.Write(Indenter.IndentDocument(
                    Finals.Class(link,
                        type == RowType.Interface, data.Usings)));

                writer.Flush();
            }
        }

        public static void ScrapeFramework(IFrameworkURLData data)
        {
            Directory.Delete(@"Output\");
            Directory.CreateDirectory(@"Output\");

            using (var client = new HttpClient())
            {
                var resp = client.GetStringAsync(data.URL).Result;
                var doc = new HtmlDocument { OptionFixNestedTags = true };
                doc.LoadHtml(resp);

                var tables = doc.DocumentNode.SelectNodes("//table[@class='collection-table Objective-C']");

                var classRows = tables[0].SelectNodes("./tbody/tr");
                foreach (var classRow in classRows)
                {
                    ScrapeRow(data, classRow, RowType.Class);
                }

                var interfaceRows = tables[1].SelectNodes("./tbody/tr");
                foreach (var interfaceRow in interfaceRows)
                {
                    ScrapeRow(data, interfaceRow, RowType.Interface);
                }

                foreach (var extra in data.Extra)
                {
                    using (var writer = new StreamWriter("Output\\" + extra.Key + ".cs"))
                    {
                        writer.Write(Indenter.IndentDocument(
                            Finals.Class(extra.Value,
                                false, data.Usings)));

                        writer.Flush();
                    }
                }
            }
        }

    }
}
