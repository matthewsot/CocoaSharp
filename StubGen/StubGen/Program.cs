using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
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
                    try
                    {
                        currIndent = currIndent.Substring(1);
                    }
                    catch
                    {
                    }
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
            using (var writer = new StreamWriter("OUTPUT.cs"))
            {
                writer.Write(IndentDocument(Scraper.Class("https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Classes/NSBundle_Class/index.html#//apple_ref/occ/cl/NSBundle",
                false,
                new[]
                {
                    "ObjectiveC",
                    "System",
                    "SwiftSharp.Attributes",
                    //"Foundation",
                    //"CoreGraphics",
                    //"UIKit"
                })));
                writer.Flush();
            }
            Console.ReadLine();
            return;

            using (var client = new HttpClient())
            {
                var resp = client.GetStringAsync("https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/ObjC_classic/index.html").Result;
                var doc = new HtmlDocument { OptionFixNestedTags = true };
                doc.LoadHtml(resp);
                var rows = doc.DocumentNode.SelectNodes("//table[@class='collection-table Objective-C']")[0].SelectNodes("./tbody/tr");
                foreach (var row in rows)
                {
                    var td = row.SelectSingleNode("./td");
                    var name = td.RealInnerText().Trim();

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
                    //https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/ObjC_classic/index.html
                    link = link.Replace("../../../../..", "https://developer.apple.com/library/prerelease/ios");
                    link = link.Replace("../../../..", "https://developer.apple.com/library/prerelease/ios/documentation");
                    link = link.Replace("../../..", "https://developer.apple.com/library/prerelease/ios/documentation/Cocoa");
                    link = link.Replace("../..", "https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference");
                    link = link.Replace("..", "https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation");
                    using (var writer = new StreamWriter("Output\\" + name + ".cs"))
                    {
                        bool isInterface = false;
                        writer.Write(IndentDocument(Scraper.Class(link, isInterface,
                        new[]
                        {
                            "ObjectiveC",
                            "System",
                            "SwiftSharp.Attributes",
                            "System.Collections.Generic",
                            //"Foundation",
                            //"CoreGraphics",
                            //"UIKit"
                        })));
                        writer.Flush();
                    }
                }
            }

            Console.WriteLine("Done!");
            Console.ReadLine();
        }
    }
}
