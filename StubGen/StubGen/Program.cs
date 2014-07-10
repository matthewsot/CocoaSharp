using System;
using System.IO;

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
            var m = Scraper.Class("https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Classes/NSArray_Class/index.html#//apple_ref/occ/instm/NSArray/initWithContentsOfFile:",
                new[]
                {
                    "ObjectiveC",
                    "System",
                    "SwiftSharp.Attributes",
                    //"Foundation",
                    //"CoreGraphics",
                    //"UIKit"
                });

            using (var writer = new StreamWriter("OUTPUT.cs"))
            {
                writer.Write(IndentDocument(m));
                writer.Flush();
            }
            Console.WriteLine("Done!");
            Console.ReadLine();
        }
    }
}
