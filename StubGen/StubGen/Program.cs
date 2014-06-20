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
        static void Main(string[] args)
        {
            using (StreamWriter writer = new StreamWriter("output.cs"))
            {
                writer.Write(Scraper.ScrapeToCSFile(Console.ReadLine()));
                writer.Flush();
            }
        }
    }
}
