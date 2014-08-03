using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StubGen.Scrapers.Finals
{
    partial class Finals
    {
        public static string Notification(ScrapedNotification notification, ScrapedClass parent, bool isInterface)
        {
            var output = "";
            output += notification.GetTrivia();

            output += "public class " + notification.CSharpName + " : NSNotification" + NewLine + "{" + NewLine;
            output += "public " + notification.CSharpName + "() : base(\"\", null) { }" + NewLine + "}" + NewLine;
            return output;
        }
    }
}
