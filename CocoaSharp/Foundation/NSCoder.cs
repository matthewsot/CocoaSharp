using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Foundation
{
    public class NSCoder
    {
        [Export("var allowsKeyedCoding: Bool { get } ")]
        public bool AllowsKeyedCoding { get; private set; }

        [Export("containsValueForKey")]
        public bool ContainsValueForKey(string key) { return false; }

        [Export("encodeArrayOfObjCType")]
        public void EncodeArrayOfObjCType(CString type, int count, CConstVoidPointer array) { return; }


    }
}
