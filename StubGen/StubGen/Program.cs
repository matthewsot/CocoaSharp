using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Console.WriteLine("What is Self?");
            var self = Console.ReadLine();
            using (var writer = new StreamWriter(self + ".cs"))
            {
                writer.Write(IndentDocument(Scraper.ScrapeToCSFile(scrape, self)));
                writer.Flush();
            }
        }
    }
}
