using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using HtmlAgilityPack;

namespace StubGen
{
    partial class Program
    {
        static void Main(string[] args)
        {
            ScrapeFramework(new FoundationData());

            Console.WriteLine("Done!");
            Console.ReadLine();
        }
    }
}
