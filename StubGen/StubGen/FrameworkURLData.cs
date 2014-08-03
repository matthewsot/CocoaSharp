using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StubGen
{
    interface IFrameworkURLData
    {
        string URL { get; }
        Dictionary<string, string> Extra { get; }
        Dictionary<string, string> LinkReplaces { get; }
    }

    public class FoundationData : IFrameworkURLData
    {
        public string URL {
            get
            {
                return
                    "https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/ObjC_classic/index.html";
            }
        }

        public Dictionary<string, string> Extra
        {
            get
            {
                return new Dictionary<string, string>
                {
                    {
                        "DataTypes",
                        "https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Miscellaneous/Foundation_DataTypes/index.html#//apple_ref/doc/uid/TP40003794"
                    },
                    {
                        "Constants",
                        "https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Miscellaneous/Foundation_Constants/index.html#//apple_ref/doc/uid/TP40003793"
                    }
                };
            }
        }

        public Dictionary<string, string> LinkReplaces
        {
            get
            {
                return new Dictionary<string, string>
                {
                    //https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/ObjC_classic/index.html
                    { "../../../../..", "https://developer.apple.com/library/prerelease/ios" },
                    { "../../../..", "https://developer.apple.com/library/prerelease/ios/documentation" },
                    { "../../..", "https://developer.apple.com/library/prerelease/ios/documentation/Cocoa" },
                    { "../..", "https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference" },
                    { "..", "https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation" }
                };
            }
        } 
    }
}
