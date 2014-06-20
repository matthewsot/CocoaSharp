using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Foundation
{
    //https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/NSTextStorage_Class_TextKit/index.html#//apple_ref/occ/cl/NSTextStorage
    /// <summary>
    ///
    /// </summary>
    class NSTextStorage : NSMutableAttributedString
    {
        //TODO: figure out what the NSMutableAttributedString constructors should be

        /// <summary>
        /// Returns an NSMutableAttributedString object initialized with the characters of a given string and no attribute information.
        /// </summary>
        /// <param name="aString">The characters for the new object.</param>
        /// <returns>An NSMutableAttributedString object initialized with the characters of aString and no attribute information The returned object might be different than the original receiver.</returns>
        //[Export("init")]
        public NSTextStorage(string @string) : base(@string) { }

        /// <summary>
        /// Returns an NSAttributedString object initialized with the characters and attributes of another given attributed string.
        /// </summary>
        /// <param name="attributedString">An attributed string.</param>
        /// <returns>An NSAttributedString object initialized with the characters and attributes of attributedString. The returned object might be different than the original receiver.</returns>
        //[Export("init")]
        public NSTextStorage (NSAttributedString attributedString) : base(attributedString) { }

        /// <summary>
        /// Returns an NSAttributedString object initialized with a given string and attributes.
        /// </summary>
        /// <param name="aString">The string for the new attributed string.</param>
        /// <param name="attributes">The attributes for the new attributed string. For information about where to find the attribute keys you can include in this dictionary, see the overview section of this document.</param>
        //[Export("init")]
        public NSTextStorage (string @string, NSDictionary attributes) : base(@string, attributes) { }
    }
}
