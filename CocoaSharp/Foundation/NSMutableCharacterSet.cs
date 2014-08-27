using ObjectiveC;using System;using SharpSwift.Attributes;using System.Collections.Generic;namespace Foundation{    /// <summary>    /// The NSMutableCharacterSet class declares the programmatic interface to objects that manage a modifiable set of Unicode characters. You can add or remove characters from a mutable character set as numeric values in NSRange structures or as character values in strings, combine character sets by union or intersection, and invert a character set.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Classes/NSMutableCharacterSet_Class/index.html#//apple_ref/occ/cl/NSMutableCharacterSet"/>    [iOSVersion(2)]    public class NSMutableCharacterSet : NSCharacterSet//, AnyObject, NSCoding, NSCopying, NSMutableCopying, NSObjectProtocol    {        //NOTE: added this        public NSMutableCharacterSet() : base("") { }        /// <summary>        /// Adds to the receiver the characters whose Unicode values are in a given range.        /// </summary>        /// <param name="aRange">The range of characters to add.        ///   aRange.location is the value of the first character to add; aRange.location + aRange.length– 1 is the value of the last. If aRange.length is 0, this method has no effect.</param>        [iOSVersion(2)]        [Export("addCharactersInRange")]        public void AddCharactersInRange(NSRange aRange) {  }                /// <summary>        /// Removes from the receiver the characters whose Unicode values are in a given range.        /// </summary>        /// <param name="aRange">The range of characters to remove.        ///   aRange.location is the value of the first character to remove; aRange.location + aRange.length– 1 is the value of the last. If aRange.length is 0, this method has no effect.</param>        [iOSVersion(2)]        [Export("removeCharactersInRange")]        public void RemoveCharactersInRange(NSRange aRange) {  }                /// <summary>        /// Adds to the receiver the characters in a given string.        /// </summary>        /// <param name="aString">The characters to add to the receiver.</param>        [iOSVersion(2)]        [Export("addCharactersInString")]        public void AddCharactersInString(string aString) {  }                /// <summary>        /// Removes from the receiver the characters in a given string.        /// </summary>        /// <param name="aString">The characters to remove from the receiver.</param>        [iOSVersion(2)]        [Export("removeCharactersInString")]        public void RemoveCharactersInString(string aString) {  }                /// <summary>        /// Modifies the receiver so it contains only characters that exist in both the receiver and otherSet.        /// </summary>        /// <param name="otherSet">The character set with which to perform the intersection.</param>        [iOSVersion(2)]        [Export("formIntersectionWithCharacterSet")]        public void FormIntersectionWithCharacterSet(NSCharacterSet otherSet) {  }                /// <summary>        /// Modifies the receiver so it contains all characters that exist in either the receiver or otherSet.        /// </summary>        /// <param name="otherSet"></param>        [iOSVersion(2)]        [Export("formUnionWithCharacterSet")]        public void FormUnionWithCharacterSet(NSCharacterSet otherSet) {  }                /// <summary>        /// Replaces all the characters in the receiver with all the characters it didn’t previously contain.        /// </summary>        [iOSVersion(2)]        [Export("invert")]        public void Invert() {  }    }}