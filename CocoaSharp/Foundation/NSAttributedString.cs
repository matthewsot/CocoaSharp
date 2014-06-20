using ObjectiveC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Foundation
{
    //https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Classes/NSAttributedString_Class/index.html#//apple_ref/occ/cl/NSAttributedString
    /// <summary>
    /// An NSAttributedString object manages character strings and associated sets of attributes (for example, font and kerning) that apply to individual characters or ranges of characters in the string. An association of characters and their attributes is called an attributed string. The cluster’s two public classes, NSAttributedString and NSMutableAttributedString, declare the programmatic interface for read-only attributed strings and modifiable attributed strings, respectively.
    /// </summary>
    public class NSAttributedString : NSObject
    {
        /// <summary>
        /// Returns an NSAttributedString object initialized with the characters of a given string and no attribute information.
        /// </summary>
        /// <param name="aString">The characters for the new object.</param>
        /// <returns>An NSAttributedString object initialized with the characters of aString and no attribute information The returned object might be different than the original receiver.</returns>
        [Export("init")]
        public void Init(string aString) { }

        /// <summary>
        /// Returns an NSAttributedString object initialized with the characters and attributes of another given attributed string.
        /// </summary>
        /// <param name="attributedString">An attributed string.</param>
        /// <returns>An NSAttributedString object initialized with the characters and attributes of attributedString. The returned object might be different than the original receiver.</returns>
        [Export("init")]
        public void Init(NSAttributedString attributedString) { }

        /// <summary>
        /// Returns an NSAttributedString object initialized with a given string and attributes.
        /// </summary>
        /// <param name="aString">The string for the new attributed string.</param>
        /// <param name="attributes">The attributes for the new attributed string. For information about where to find the attribute keys you can include in this dictionary, see the overview section of this document.</param>
        [Export("init")]
        public void Init(string aString, NSDictionary attributes) { }

        /// <summary>
        /// Returns the character contents of the receiver as an NSString object.
        /// </summary>
        /// <returns>The character contents of the receiver as an NSString object.</returns>
        [Export("string")]
        public static string String { get; private set; }

        /// <summary>
        /// Returns the length of the receiver’s string object.
        /// </summary>
        [Export("length")]
        public static int Length { get; private set; }

        /// <summary>
        /// Returns the attributes for the character at a given index.
        /// </summary>
        /// <param name="index">The index for which to return attributes. This value must lie within the bounds of the receiver.</param>
        /// <param name="aRange">Upon return, the range over which the attributes and values are the same as those at index. This range isn’t necessarily the maximum range covered, and its extent is implementation-dependent. If you need the maximum range, use attributesAtIndex:longestEffectiveRange:inRange:. If you don't need this value, pass NULL.</param>
        /// <returns>The attributes for the character at index.</returns>
        [Export("attributesAtIndex")]
        public NSDictionary AttributesAtIndex(int index, CMutablePointer<NSRange> aRange) { return null; }

        /// <summary>
        /// Returns the attributes for the character at a given index, and by reference the range over which the attributes apply.
        /// </summary>
        /// <param name="index">The index for which to return attributes. This value must not exceed the bounds of the receiver.</param>
        /// <param name="aRange">If non-NULL, upon return contains the maximum range over which the attributes and values are the same as those at index, clipped to rangeLimit.</param>
        /// <param name="rangeLimit">The range over which to search for continuous presence of the attributes at index. This value must not exceed the bounds of the receiver.</param>
        [Export("attributesAtIndex")]
        public NSDictionary AttributesAtIndex(int index, CMutablePointer<NSRange> aRange, NSRange rangeLimit) { return null; }

        /// <summary>
        /// Returns the value for an attribute with a given name of the character at a given index, and by reference the range over which the attribute applies.
        /// </summary>
        /// <param name="attributeName">The name of an attribute.</param>
        /// <param name="index">The index for which to return attributes. This value must not exceed the bounds of the receiver.</param>
        /// <param name="aRange">If non-NULL: If the named attribute exists at index, upon return aRange contains a range over which the named attribute’s value applies. If the named attribute does not exist at index, upon return aRange contains the range over which the attribute does not exist. The range isn’t necessarily the maximum range covered by attributeName, and its extent is implementation-dependent. If you need the maximum range, use attribute:atIndex:longestEffectiveRange:inRange:. If you don't need this value, pass NULL.</param>
        /// <returns>The value for the attribute named attributeName of the character at index index, or nil if there is no such attribute.</returns>
        [Export("attribute")]
        public AnyObject Attribute(string attributeName, int index, CMutablePointer<NSRange> aRange) { return null; }

        /// <summary>
        /// Returns the value for the attribute with a given name of the character at a given index, and by reference the range over which the attribute applies.
        /// </summary>
        /// <param name="attributeName">The name of an attribute.</param>
        /// <param name="index">The index at which to test for attributeName.</param>
        /// <param name="aRange">If non-NULL: If the named attribute exists at index, upon return aRange contains the full range over which the value of the named attribute is the same as that at index, clipped to rangeLimit. If the named attribute does not exist at index, upon return aRange contains the full range over which the attribute does not exist, clipped to rangeLimit. If you don't need this value, pass NULL.</param>
        /// <param name="rangeLimit">The range over which to search for continuous presence of attributeName. This value must not exceed the bounds of the receiver.</param>
        /// <returns>The value for the attribute named attributeName of the character at index, or nil if there is no such attribute.</returns>
        [Export("attribute")]
        public AnyObject Attribute(string attributeName, int index, CMutablePointer<NSRange> aRange, NSRange rangeLimit) { return null; }

        /// <summary>
        /// Returns a Boolean value that indicates whether the receiver is equal to another given attributed string.
        /// </summary>
        /// <param name="otherString">The attributed string with which to compare the receiver.</param>
        /// <returns>true if the receiver is equal to otherString, otherwise false.</returns>
        [Export("isEqualToAttributedString")]
        public bool IsEqualToAttributedString(NSAttributedString otherString) { return false; }

        /// <summary>
        /// Returns an NSAttributedString object consisting of the characters and attributes within a given range in the receiver.
        /// </summary>
        /// <param name="aRange">The range from which to create a new attributed string. aRange must lie within the bounds of the receiver.</param>
        /// <returns>An NSAttributedString object consisting of the characters and attributes within aRange in the receiver.</returns>
        [Export("attributedSubstringFromRange")]
        public NSAttributedString AttributedSubstringFromRange(NSRange aRange) { return null; }

        //TODO: Fix this
        /// <summary>
        /// Executes the Block for the specified attribute run in the specified range.
        /// </summary>
        /// <param name="attrName">The name of an attribute.</param>
        /// <param name="enumerationRange">If non-NULL, contains the maximum range over which the attributes and values are enumerated, clipped to enumerationRange.</param>
        /// <param name="opts">The options used by the enumeration. The values can be combined using C-bitwise OR. The values are described in NSAttributedStringEnumerationOptions.</param>
        /// <param name="block">The Block to apply to ranges of the attribute in the attributed string. The Block takes three arguments:
        /// value: The attrName value.
        /// range: An NSRange indicating the run of the attribute.
        /// stop: A reference to a Boolean value. The block can set the value to true to stop further processing of the set. The stop argument is an out-only argument. You should only ever set this Boolean to YES within the Block.</param>
        //[Export("enumerateAttribute")]
        //public Void)!) EnumerateAttribute(string attrName, NSRange enumerationRange, NSAttributedStringEnumerationOptions opts, block) { return null; }

        //TODO: fix that
        /// <summary>
        /// Executes the Block for each attribute in the range.
        /// </summary>
        /// <param name="enumerationRange">If non-NULL, contains the maximum range over which the attributes and values are enumerated, clipped to enumerationRange.</param>
        /// <param name="opts">The options used by the enumeration. The values can be combined using C-bitwise OR. The values are described in NSAttributedStringEnumerationOptions.</param>
        /// <param name="block">The Block to apply to ranges of the attribute in the attributed string. The Block takes three arguments:
        /// attrs: An NSDictionary that contains the attributes for the range.
        /// range: An NSRange indicating the run of the attribute.
        /// stop: A reference to a Boolean value. The block can set the value to true to stop further processing of the set. The stop argument is an out-only argument. You should only ever set this Boolean to true within the Block.</param>
        //[Export("enumerateAttributesInRange")]
        //public Void)!) EnumerateAttributesInRange(NSRange enumerationRange, NSAttributedStringEnumerationOptions opts, block) { return null; }

        //TODO: add this
        /// <summary>
        /// These constants describe the options available to the enumerateAttribute:inRange:options:usingBlock: and enumerateAttributesInRange:options:usingBlock: methods.
        /// </summary>
        //public 
    }
}
