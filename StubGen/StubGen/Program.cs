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
        //TODO: this is all extremely sketch. Should re-write it w/ ANTLR & Roslyn sometime
        static void Main(string[] args)
        {
            var output = Parser.ParseFile(@"C:\Users\Matthew\Git\CocoaSharp\Headers\Frameworks\Foundation\NSObject-NSObject.h");
            using(StreamWriter writer = new StreamWriter("output.cs"))
            {
                writer.Write(output);
                writer.Flush();
            }
        }
    }
}
