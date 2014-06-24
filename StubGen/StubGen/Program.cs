using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace StubGen
{
    class Program
    {
        public static string IndentDocument(string swift)
        {
            var output = "";
            var lines = swift.Split('\n');
            var currIndent = "";

            foreach (var line in lines)
            {
                if (line.Contains("}") && !line.Contains("{"))
                {
                    currIndent = currIndent.Substring(1);
                }

                output += currIndent + line;

                if (line.Contains("{") && !line.Contains("}"))
                {
                    currIndent += '\t';
                }
            }

            return output;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("What to scrape?");
            var scrape = Console.ReadLine();
            //Console.WriteLine("What's Self?");
            //var self = Console.ReadLine();
            //Console.WriteLine("What's the parent?");
            //var parent = Console.ReadLine();

            //var input = new List<string>();
            //using (var reader = new StreamReader("input.txt"))
            //{
            //    input.AddRange(reader.ReadToEnd().Split('\n'));
            //    input = input.Select(line => line.Trim()).ToList();
            //}

            //foreach(var line in input)
            //{
            //    if (line.Trim() == "") continue;

            //    var parts = line.Split(' ');

            //    using (var writer = new StreamWriter("Output\\" + parts[0] + ".cs"))
            //    {
            //        writer.Write(IndentDocument(Scraper.ScrapeToCSFile(parts[1], parts[0], parts[2])));
            //        writer.Flush();
            //    }
            //}

            using (var client = new HttpClient())
            {
                var resp = client.GetStringAsync(scrape).Result;
                var doc = new HtmlDocument{OptionFixNestedTags = true};
                doc.LoadHtml(resp);
                var rows = doc.DocumentNode.SelectNodes("//table[@class='collection-table Objective-C']")[1].SelectNodes("./tbody/tr");
                var parents = new Dictionary<int, string> {{1, ""}};
                var currDepth = 0;
                foreach (var row in rows)
                {
                    var td = row.SelectSingleNode("./td");
                    var name = Scraper.RemoveHTMLTags(td.InnerHtml).Trim();
                    var depth = int.Parse(td.GetAttributeValue("class", "depth0").Split('h')[1].Split(' ')[0]);
                    parents[depth] = name;
                    //var parent = parents[depth - 1];
                    var parent = "";
                    
                    //todo: make sure to change the href base path
                    string link;
                    try
                    {
                        link = td.SelectSingleNode("./p/code/a").GetAttributeValue("href", "");
                    }
                    catch
                    {
                        Console.WriteLine("No link for " + name);
                        continue;
                    }
                    link = link.Replace("../../../../..", "https://developer.apple.com/library/prerelease/ios");
                    link = link.Replace("../../../..", "https://developer.apple.com/library/prerelease/ios/documentation");
                    link = link.Replace("../../..", "https://developer.apple.com/library/prerelease/ios/documentation/Cocoa");
                    link = link.Replace("../..", "https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference");
                    link = link.Replace("..", "https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation");
                    using (var writer = new StreamWriter("Output\\" + name + ".cs"))
                    {
                        writer.Write(IndentDocument(Scraper.ScrapeToCSFile(link, name, parent)));
                        writer.Flush();
                    }
                }
            }
            Console.WriteLine("Done!");
            Console.ReadLine();
        }
    }
}
