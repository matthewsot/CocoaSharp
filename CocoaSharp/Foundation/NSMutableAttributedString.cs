using ObjectiveC;
using SwiftSharp.Attributes;

namespace Foundation
{
    //https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Classes/NSMutableAttributedString_Class/index.html#//apple_ref/occ/cl/NSMutableAttributedString
    /// <summary>
    /// NSMutableAttributedString declares the programmatic interface to objects that manage mutable attributed strings. You can add and remove characters (raw strings) and attributes separately or together as attributed strings. See the class description for NSAttributedString for more information about attributed strings.
    /// </summary>
    [iOSVersion(3.2)]
    public class NSMutableAttributedString : NSAttributedString
    {
        //TODO: figure out what the NSMutableAttributedString constructors should be
        
        /// <summary>
        /// Returns an NSAttributedString object initialized with the characters of a given string and no attribute information.
        /// </summary>
        /// <param name="aString">The characters for the new object.</param>
        /// <returns>An NSAttributedString object initialized with the characters of aString and no attribute information The returned object might be different than the original receiver.</returns>
        [iOSVersion(3.2)]
        public NSMutableAttributedString (string @string) : base(@string) { }

        /// <summary>
        /// Returns an NSAttributedString object initialized with the characters and attributes of another given attributed string.
        /// </summary>
        /// <param name="attributedString">An attributed string.</param>
        /// <returns>An NSAttributedString object initialized with the characters and attributes of attributedString. The returned object might be different than the original receiver.</returns>
        [iOSVersion(3.2)]
        public NSMutableAttributedString (NSAttributedString attributedString) : base(attributedString) { }

        /// <summary>
        /// Returns an NSAttributedString object initialized with a given string and attributes.
        /// </summary>
        /// <param name="string">The string for the new attributed string.</param>
        /// <param name="attributes">The attributes for the new attributed string. For information about where to find the attribute keys you can include in this dictionary, see the overview section of this document.</param>
        [iOSVersion(3.2)]
        public NSMutableAttributedString(string @string, NSDictionary attributes) : base(@string, attributes) { }

        /// <summary>
        /// Returns the character contents of the receiver as an NSMutableString object.
        /// </summary>
        /// <returns>The mutable string object.</returns>
        [iOSVersion(3.2)]
        [Export("mutableString")]
        public NSMutableString MutableString { get; private set; }

        /// <summary>
        /// Replaces the characters in the given range with the characters of the given string.
        /// </summary>
        /// <param name="aRange">A range specifying the characters to replace.</param>
        /// <param name="withString">A string specifying the characters to replace those in aRange.</param>
        [iOSVersion(3.2)]
        [Export("replaceCharactersInRange")]
        public void ReplaceCharactersInRange(NSRange aRange, string withString) { }

        /// <summary>
        /// Deletes the characters in the given range along with their associated attributes.
        /// </summary>
        /// <param name="aRange">A range specifying the characters to delete.</param>
        [iOSVersion(3.2)]
        [Export("deleteCharactersInRange")]
        public void DeleteCharactersInRange(NSRange aRange) { }

        /// <summary>
        /// Sets the attributes for the characters in the specified range to the specified attributes.
        /// </summary>
        /// <param name="attributes">A dictionary containing the attributes to set. Attribute keys can be supplied by another framework or can be custom ones you define. For information about where to find the system-supplied attribute keys, see the overview section in NSAttributedString Class Reference.</param>
        /// <param name="range">The range of characters whose attributes are set.</param>
        [iOSVersion(3.2)]
        [Export("setAttributes")]
        public void SetAttributes(NSDictionary attributes, NSRange range) { }

        /// <summary>
        /// Adds an attribute with the given name and value to the characters in the specified range.
        /// </summary>
        /// <param name="name">A string specifying the attribute name. Attribute keys can be supplied by another framework or can be custom ones you define. For information about where to find the system-supplied attribute keys, see the overview section in NSAttributedString Class Reference.</param>
        /// <param name="value">The attribute value associated with name.</param>
        /// <param name="range">The range of characters to which the specified attribute/value pair applies.</param>
        [iOSVersion(3.2)]
        [Export("addAttribute")]
        public void AddAttribute(string name, AnyObject value, NSRange range) { }

        /// <summary>
        /// Adds the given collection of attributes to the characters in the specified range.
        /// </summary>
        /// <param name="attributes">A dictionary containing the attributes to add. Attribute keys can be supplied by another framework or can be custom ones you define. For information about where to find the system-supplied attribute keys, see the overview section in NSAttributedString Class Reference.</param>
        /// <param name="range">The range of characters to which the specified attributes apply.</param>
        [iOSVersion(3.2)]
        [Export("addAttributes")]
        public void AddAttributes(NSDictionary attributes, NSRange range) { }

        /// <summary>
        /// Removes the named attribute from the characters in the specified range.
        /// </summary>
        /// <param name="name">A string specifying the attribute name to remove. Attribute keys can be supplied by another framework or can be custom ones you define. For information about where to find the system-supplied attribute keys, see the overview section in NSAttributedString Class Reference.</param>
        /// <param name="range">The range of characters from which the specified attribute is removed.</param>
        [iOSVersion(3.2)]
        [Export("removeAttribute")]
        public void RemoveAttribute(string name, NSRange range) { }

        /// <summary>
        /// Adds the characters and attributes of a given attributed string to the end of the receiver.
        /// </summary>
        /// <param name="attributedString">The string whose characters and attributes are added.</param>
        [iOSVersion(3.2)]
        [Export("appendAttributedString")]
        public void AppendAttributedString(NSAttributedString attributedString) { }

        /// <summary>
        /// Inserts the characters and attributes of the given attributed string into the receiver at the given index.
        /// </summary>
        /// <param name="attributedString">The string whose characters and attributes are inserted.</param>
        /// <param name="atIndex">The index at which the characters and attributes are inserted.</param>
        [iOSVersion(3.2)]
        [Export("insertAttributedString")]
        public void InsertAttributedString(NSAttributedString attributedString, int atIndex) { }

        /// <summary>
        /// Replaces the characters and attributes in a given range with the characters and attributes of the given attributed string.
        /// </summary>
        /// <param name="aRange">The range of characters and attributes replaced.</param>
        /// <param name="withAttributedString">The attributed string whose characters and attributes replace those in the specified range.</param>
        [iOSVersion(3.2)]
        [Export("replaceCharactersInRange")]
        public void ReplaceCharactersInRange(NSRange aRange, NSAttributedString withAttributedString) { }

        /// <summary>
        /// Replaces the receiver’s entire contents with the characters and attributes of the given attributed string.
        /// </summary>
        /// <param name="attributedString">The attributed string whose characters and attributes replace those in the receiver.</param>
        [iOSVersion(3.2)]
        [Export("setAttributedString")]
        public void SetAttributedString(NSAttributedString attributedString) { }

        /// <summary>
        /// Overridden by subclasses to buffer or optimize a series of changes to the receiver’s characters or attributes, until it receives a matching endEditing message, upon which it can consolidate changes and notify any observers that it has changed.
        /// </summary>
        [iOSVersion(3.2)]
        [Export("beginEditing")]
        public void BeginEditing() { }

        /// <summary>
        /// Overridden by subclasses to consolidate changes made since a previous beginEditing message and to notify any observers of the changes.
        /// </summary>
        [iOSVersion(3.2)]
        [Export("endEditing")]
        public void EndEditing() { }
    }
}
