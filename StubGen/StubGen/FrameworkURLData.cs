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
        string[] Usings { get; }
    }

    public class FoundationData : IFrameworkURLData
    {
        public string[] Usings
        {
            get
            {
                return new[]
                {
                    "ObjectiveC",
                    "System",
                    "SwiftSharp.Attributes",
                    "System.Collections.Generic",
                };
            }
        }

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

    public class UIKitData : IFrameworkURLData
    {
        public string[] Usings
        {
            get
            {
                return new[]
                {
                    "ObjectiveC",
                    "System",
                    "SwiftSharp.Attributes",
                    "System.Collections.Generic",
                    "Foundation",
                    "CoreGraphics"
                };
            }
        }

        public string URL
        {
            get
            {
                return
                    "https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UIKit_Framework/index.html#//apple_ref/doc/uid/TP40006955";
            }
        }

        public Dictionary<string, string> Extra
        {
            get
            {
                return new Dictionary<string, string>
                {
                    {
                        "Additions\\NSAttributedString", "https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/NSAttributedString_UIKit_Additions/index.html#//apple_ref/doc/uid/TP40011688"
                    },
                    {
                        "Additions\\NSBundle", "https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/NSBundle_UIKitAdditions/index.html#//apple_ref/doc/uid/TP40007485"
                    },
                    {
                        "Additions\\NSCoder", "https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/NSCoder_UIKit_Additions/index.html#//apple_ref/doc/uid/TP40007292"
                    },
                    {
                        "Additions\\NSIndexPath", "https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/NSIndexPath_UIKitAdditions/index.html#//apple_ref/doc/uid/TP40007175"
                    },
                    {
                        "Additions\\NSMutableAttributedString", "https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/NSMutableAttributedString_UIKit_Additions/index.html#//apple_ref/doc/uid/TP40013287"
                    },
                    {
                        "Additions\\NSObject", "https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/NSObject_UIKitAdditions/index.html#//apple_ref/doc/uid/TP40007486"
                    },
                    {
                        "Additions\\NSString", "https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/NSString_UIKit_Additions/index.html#//apple_ref/doc/uid/TP40006893"
                    },
                    {
                        "Additions\\NSValue", "https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/NSValue_UIKit_Additions/index.html#//apple_ref/doc/uid/TP40007293"
                    },
                    {
                        "DataTypes", "https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UIKitDataTypesReference/index.html#//apple_ref/doc/uid/TP40007525"
                    },
                    {
                        "Constants", "https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UIKitConstantsReference/index.html#//apple_ref/doc/uid/TP40007526"
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
                    //https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UIKit_Framework/index.html
                    { "../../../../..", "https://developer.apple.com/library/prerelease" },
                    { "../../../..", "https://developer.apple.com/library/prerelease/ios" },
                    { "../../..", "https://developer.apple.com/library/prerelease/ios/documentation" },
                    { "../..", "https://developer.apple.com/library/prerelease/ios/documentation/UIKit" },
                    { "..", "https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference" }
                };
            }
        }
    }
}
