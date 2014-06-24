using ObjectiveC;
using System;
using SwiftSharp.Attributes;

namespace Foundation
{
    //https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Classes/NSString_Class/index.html#//apple_ref/occ/cl/NSString
    /// <summary>
    /// The NSString class declares the programmatic interface for an object that manages immutable strings. An immutable string is a text string that is defined when it is created and subsequently cannot be changed. NSString is implemented to represent an array of Unicode characters, in other words, a text string.
    /// </summary>
    [iOSVersion(2)]
    public class NSString : NSObject
    {
        /// <summary>
        /// Returns an empty string.
        /// </summary>
        /// <returns>An empty string.</returns>
        [iOSVersion(2)]
        [Export("string")]
        public static NSString String() { return null; }
        
        /// <summary>
        /// Returns an initialized NSString object that contains no characters.
        /// </summary>
        /// <returns>An initialized NSString object that contains no characters. The returned object may be different from the original receiver.</returns>
        [iOSVersion(2)]
        public NSString() { }
        
        /// <summary>
        /// Returns an initialized NSString object containing a given number of bytes from a given buffer of bytes interpreted in a given encoding.
        /// </summary>
        /// <param name="bytes">A buffer of bytes interpreted in the encoding specified by encoding.</param>
        /// <param name="length">The number of bytes to use from bytes.</param>
        /// <param name="encoding">The character encoding applied to bytes.</param>
        /// <returns>An initialized NSString object containing length bytes from bytes interpreted using the encoding encoding. The returned object may be different from the original receiver.</returns>
        [iOSVersion(2)]
        public NSString(CConstVoidPointer bytes, int length, uint encoding) { }
        
        /// <summary>
        /// Returns an initialized NSString object that contains a given number of bytes from a given buffer of bytes interpreted in a given encoding, and optionally frees the buffer.
        /// </summary>
        /// <param name="bytesNoCopy">A buffer of bytes interpreted in the encoding specified by encoding.</param>
        /// <param name="length">The number of bytes to use from bytes.</param>
        /// <param name="encoding">The character encoding of bytes.</param>
        /// <param name="freeWhenDone">If true, the receiver frees the memory when it no longer needs the data; if false it won’t.</param>
        /// <returns>An initialized NSString object containing length bytes from bytes interpreted using the encoding encoding. The returned object may be different from the original receiver.</returns>
        [iOSVersion(2)]
        public NSString(CMutableVoidPointer bytesNoCopy, int length, uint encoding, bool freeWhenDone) { }
        
        /// <summary>
        /// Returns an initialized NSString object that contains a given number of characters from a given C array of Unicode characters.
        /// </summary>
        /// <param name="characters">A C array of Unicode characters; the value must not be NULL.       Important     Raises an exception if characters is NULL, even if length is 0.</param>
        /// <param name="length">The number of characters to use from characters.</param>
        /// <returns>An initialized NSString object containing length characters taken from characters. The returned object may be different from the original receiver.</returns>
        [iOSVersion(2)]
        public NSString(CConstPointer<char> characters, int length) { }
        
        /// <summary>
        /// Returns an initialized NSString object that contains a given number of characters from a given C array of Unicode characters.
        /// </summary>
        /// <param name="charactersNoCopy">A C array of Unicode characters.</param>
        /// <param name="length">The number of characters to use from characters.</param>
        /// <param name="freeWhenDone">If true, the receiver will free the memory when it no longer needs the characters; if false it won’t.</param>
        /// <returns>An initialized NSString object that contains length characters from characters. The returned object may be different from the original receiver.</returns>
        [iOSVersion(2)]
        public NSString(CMutablePointer<char> charactersNoCopy, int length, bool freeWhenDone) { }
        
        /// <summary>
        /// Returns an NSString object initialized by copying the characters from another given string.
        /// </summary>
        /// <param name="string">The string from which to copy characters. This value must not be nil.       Important     Raises an NSInvalidArgumentException if aString is nil.</param>
        /// <returns>An NSString object initialized by copying the characters from aString. The returned object may be different from the original receiver.</returns>
        [iOSVersion(2)]
        public NSString(string @string) { }

        /// <summary>
        /// !! IMPORTANT !! Do not use the second parameter
        /// 
        /// Initializes the receiver, a newly allocated NSString object, by reading data from the file named by path.	
        /// Deprecation Statement: Use initWithContentsOfFile:encoding:error: or initWithContentsOfFile:usedEncoding:error: instead.
        /// </summary>
        [Obsolete]
        [iOSVersion(2)]
        public NSString(string contentsOfFile, bool IGNORETHIS = true) { }
        
        /// <summary>
        /// Returns an NSString object initialized using the characters in a given C array, interpreted according to a given encoding.
        /// </summary>
        /// <param name="CString">A C array of characters. The array must end with a NULL character; intermediate NULL characters are not allowed.</param>
        /// <param name="encoding">The encoding of nullTerminatedCString.</param>
        /// <returns>An NSString object initialized using the characters from nullTerminatedCString. The returned object may be different from the original receiver</returns>
        [iOSVersion(2)]
        public NSString(CString CString, uint encoding) { }
        
        /// <summary>
        /// Returns an NSString object initialized by copying the characters from a given C array of UTF8-encoded bytes.
        /// </summary>
        /// <param name="UTF8String">A NULL-terminated C array of bytes in UTF-8 encoding. This value must not be NULL.       Important     Raises an exception if bytes is NULL.</param>
        /// <returns>An NSString object initialized by copying the bytes from bytes. The returned object may be different from the original receiver.</returns>
        [iOSVersion(2)]
        public NSString(CString UTF8String) { }

        /// <summary>
        /// !! IMPORTANT !! Do not use the second parameter
        /// 
        /// Initializes the receiver, a newly allocated NSString object, by converting the data in a given C-string from the default C-string encoding into the Unicode character encoding.
        /// Deprecation Statement: Use initWithCString:encoding: instead.
        /// </summary>
        [Obsolete]
        [iOSVersion(2)]
        public NSString(CString CString, bool IGNORETHIS = true) { }
        
        /// <summary>
        /// Returns an NSString object initialized by using a given format string as a template into which the remaining argument values are substituted according to the user’s default locale.
        /// </summary>
        /// <param name="format">A format string. See Formatting String Objects for examples of how to use this method, and String Format Specifiers for a list of format specifiers. This value must not be nil.       Important     Raises an NSInvalidArgumentException if format is nil.</param>
        /// <param name="arguments">A list of arguments to substitute into format.</param>
        /// <returns>An NSString object initialized by using format as a template into which the values in argList are substituted according to the user’s default locale. The returned object may be different from the original receiver.</returns>
        [iOSVersion(2)]
        public NSString(string format, CVaListPointer arguments) { }
        
        /// <summary>
        /// Returns an NSString object initialized by using a given format string as a template into which the remaining argument values are substituted according to given locale information.
        /// </summary>
        /// <param name="format">A format string. See Formatting String Objects for examples of how to use this method, and String Format Specifiers for a list of format specifiers. This value must not be nil.       Important     Raises an NSInvalidArgumentException if format is nil.</param>
        /// <param name="locale">An NSLocale object specifying the locale to use. If nil, uses the system locale.   For legacy support, this may be an instance of NSDictionary containing locale information.</param>
        /// <param name="arguments">A list of arguments to substitute into format.</param>
        /// <returns>An NSString object initialized by using format as a template into which values in argList are substituted according the locale information in locale. The returned object may be different from the original receiver.</returns>
        [iOSVersion(2)]
        public NSString(string format, AnyObject locale, CVaListPointer arguments) { }
        
        /// <summary>
        /// Returns an NSString object initialized by converting given data into Unicode characters using a given encoding.
        /// </summary>
        /// <param name="data">An NSData object containing bytes in encoding and the default plain text format (that is, pure content with no attributes or other markups) for that encoding.</param>
        /// <param name="encoding">The encoding used by data.</param>
        /// <returns>An NSString object initialized by converting the bytes in data into Unicode characters using encoding. The returned object may be different from the original receiver. Returns nil if the initialization fails for some reason (for example if data does not represent valid data for encoding).</returns>
        [iOSVersion(2)]
        public NSString(NSData data, uint encoding) { }
        
        /// <summary>
        /// Returns a string containing a given number of characters taken from a given C array of Unicode characters.
        /// </summary>
        /// <param name="chars">A C array of Unicode characters; the value must not be NULL.       Important     Raises an exception if chars is NULL, even if length is 0.</param>
        /// <param name="length">The number of characters to use from chars.</param>
        /// <returns>A string containing length Unicode characters taken (starting with the first) from chars.</returns>
        [iOSVersion(2)]
        [Export("stringWithCharacters")]
        public static NSString StringWithCharacters(CConstPointer<char> chars, int length) { return null; }
        
        /// <summary>
        /// Returns a string created by copying the characters from another given string.
        /// </summary>
        /// <param name="aString">The string from which to copy characters. This value must not be nil.       Important     Raises an NSInvalidArgumentException if aString is nil.</param>
        /// <returns>A string created by copying the characters from aString.</returns>
        [iOSVersion(2)]
        [Export("stringWithString")]
        public static NSString StringWithString(string aString) { return null; }
        
        /// <summary>
        /// Returns a string containing the bytes in a given C array, interpreted according to a given encoding.
        /// </summary>
        /// <param name="cString">A C array of bytes. The array must end with a NULL byte; intermediate NULL bytes are not allowed.</param>
        /// <param name="encoding">The encoding of cString.</param>
        /// <returns>A string containing the characters described in cString.</returns>
        [iOSVersion(2)]
        [Export("stringWithCString")]
        public static NSString StringWithCString(CString cString, uint encoding) { return null; }
        
        /// <summary>
        /// Returns a string created by copying the data from a given C array of UTF8-encoded bytes.
        /// </summary>
        /// <param name="bytes">A NULL-terminated C array of bytes in UTF8 encoding.       Important     Raises an exception if bytes is NULL.</param>
        /// <returns>A string created by copying the data from bytes.</returns>
        [iOSVersion(2)]
        [Export("stringWithUTF8String")]
        public static NSString StringWithUTF8String(CString bytes) { return null; }
        
        /// <summary>
        /// Creates a new string using a given C-string.				 		  Deprecation Statement		  		 Use stringWithCString:encoding: instead.
        /// </summary>
        [Obsolete]
        [iOSVersion(2)]
        [Export("stringWithCString")]
        public static AnyObject StringWithCString(CString bytes) { return null; }
        
        /// <summary>
        /// Returns a string containing the characters in a given C-string. 				 		  Deprecation Statement		  		 Use stringWithCString:encoding: instead.
        /// </summary>
        [Obsolete]
        [iOSVersion(2)]
        [Export("stringWithCString")]
        public static AnyObject StringWithCString(CString bytes, int length) { return null; }
        
        /// <summary>
        /// Initializes the receiver, a newly allocated NSString object, by converting the data in a given C-string from the default C-string encoding into the Unicode character encoding.				 		  Deprecation Statement		  		 Use initWithBytes:length:encoding: instead.
        /// </summary>
        [Obsolete]
        [iOSVersion(2)]
        public NSString(CString CString, int length) { }
        
        /// <summary>
        /// Initializes the receiver, a newly allocated NSString object, by converting the data in a given C-string from the default C-string encoding into the Unicode character encoding.				 		  Deprecation Statement		  		 Use initWithBytesNoCopy:length:encoding:freeWhenDone: instead.
        /// </summary>
        [Obsolete]
        [iOSVersion(2)]
        public NSString(CMutablePointer<CChar> CStringNoCopy, int length, bool freeWhenDone) { }
        
        /// <summary>
        /// Returns a string created by reading data from the file at a given path interpreted using a given encoding.
        /// </summary>
        /// <param name="path">A path to a file.</param>
        /// <param name="encoding">The encoding of the file at path.</param>
        /// <param name="error">If an error occurs, upon returns contains an NSError object that describes the problem. If you are not interested in possible errors, pass in NULL.</param>
        /// <returns>A string created by reading data from the file named by path using the encoding, enc. If the file can’t be opened or there is an encoding error, returns nil.</returns>
        [iOSVersion(2)]
        [Export("stringWithContentsOfFile")]
        public static NSString StringWithContentsOfFile(string path, uint encoding, NSErrorPointer error) { return null; }
        
        /// <summary>
        /// Returns an NSString object initialized by reading data from the file at a given path using a given encoding.
        /// </summary>
        /// <param name="contentsOfFile">A path to a file.</param>
        /// <param name="encoding">The encoding of the file at path.</param>
        /// <param name="error">If an error occurs, upon return contains an NSError object that describes the problem. If you are not interested in possible errors, pass in NULL.</param>
        /// <returns>An NSString object initialized by reading data from the file named by path using the encoding, enc. The returned object may be different from the original receiver. If the file can’t be opened or there is an encoding error, returns nil.</returns>
        [iOSVersion(2)]
        public NSString(string contentsOfFile, uint encoding, NSErrorPointer error) { }
        
        /// <summary>
        /// Returns a string created by reading data from the file at a given path and returns by reference the encoding used to interpret the file.
        /// </summary>
        /// <param name="path">A path to a file.</param>
        /// <param name="usedEncoding">Upon return, if the file is read successfully, contains the encoding used to interpret the file at path.</param>
        /// <param name="error">If an error occurs, upon returns contains an NSError object that describes the problem. If you are not interested in possible errors, you may pass in NULL.</param>
        /// <returns>A string created by reading data from the file named by path. If the file can’t be opened or there is an encoding error, returns nil.</returns>
        [iOSVersion(2)]
        [Export("stringWithContentsOfFile")]
        public static NSString StringWithContentsOfFile(string path, CMutablePointer<uint> usedEncoding, NSErrorPointer error) { return null; }
        
        /// <summary>
        /// Returns an NSString object initialized by reading data from the file at a given path and returns by reference the encoding used to interpret the characters.
        /// </summary>
        /// <param name="contentsOfFile">A path to a file.</param>
        /// <param name="usedEncoding">Upon return, if the file is read successfully, contains the encoding used to interpret the file at path.</param>
        /// <param name="error">If an error occurs, upon returns contains an NSError object that describes the problem. If you are not interested in possible errors, pass in NULL.</param>
        /// <returns>An NSString object initialized by reading data from the file named by path. The returned object may be different from the original receiver. If the file can’t be opened or there is an encoding error, returns nil.</returns>
        [iOSVersion(2)]
        public NSString(string contentsOfFile, CMutablePointer<uint> usedEncoding, NSErrorPointer error) { }
        
        /// <summary>
        /// Returns a string created by reading data from the file named by a given path.				 		  Deprecation Statement		  		 Use stringWithContentsOfFile:encoding:error: or stringWithContentsOfFile:usedEncoding:error: instead.
        /// </summary>
        [Obsolete]
        [iOSVersion(2)]
        [Export("stringWithContentsOfFile")]
        public static AnyObject StringWithContentsOfFile(string path) { return null; }
        
        /// <summary>
        /// Returns a string created by reading data from a given URL interpreted using a given encoding.
        /// </summary>
        /// <param name="url">The URL to read.</param>
        /// <param name="encoding">The encoding of the data at url.</param>
        /// <param name="error">If an error occurs, upon returns contains an NSError object that describes the problem. If you are not interested in possible errors, you may pass in NULL.</param>
        /// <returns>A string created by reading data from URL using the encoding, enc. If the URL can’t be opened or there is an encoding error, returns nil.</returns>
        [iOSVersion(2)]
        [Export("stringWithContentsOfURL")]
        public static NSString StringWithContentsOfURL(NSURL url, uint encoding, NSErrorPointer error) { return null; }
        
        /// <summary>
        /// Returns an NSString object initialized by reading data from a given URL interpreted using a given encoding.
        /// </summary>
        /// <param name="contentsOfURL">The URL to read.</param>
        /// <param name="encoding">The encoding of the file at path.</param>
        /// <param name="error">If an error occurs, upon returns contains an NSError object that describes the problem. If you are not interested in possible errors, pass in NULL.</param>
        /// <returns>An NSString object initialized by reading data from url. The returned object may be different from the original receiver. If the URL can’t be opened or there is an encoding error, returns nil.</returns>
        [iOSVersion(2)]
        public NSString(NSURL contentsOfURL, uint encoding, NSErrorPointer error) { }
        
        /// <summary>
        /// Returns a string created by reading data from a given URL and returns by reference the encoding used to interpret the data.
        /// </summary>
        /// <param name="url">The URL from which to read data.</param>
        /// <param name="usedEncoding">Upon return, if url is read successfully, contains the encoding used to interpret the data.</param>
        /// <param name="error">If an error occurs, upon returns contains an NSError object that describes the problem. If you are not interested in possible errors, you may pass in NULL.</param>
        /// <returns>A string created by reading data from url. If the URL can’t be opened or there is an encoding error, returns nil.</returns>
        [iOSVersion(2)]
        [Export("stringWithContentsOfURL")]
        public static NSString StringWithContentsOfURL(NSURL url, CMutablePointer<uint> usedEncoding, NSErrorPointer error) { return null; }
        
        /// <summary>
        /// Returns an NSString object initialized by reading data from a given URL and returns by reference the encoding used to interpret the data.
        /// </summary>
        /// <param name="contentsOfURL">The URL from which to read data.</param>
        /// <param name="usedEncoding">Upon return, if url is read successfully, contains the encoding used to interpret the data.</param>
        /// <param name="error">If an error occurs, upon returns contains an NSError object that describes the problem. If you are not interested in possible errors, pass in NULL.</param>
        /// <returns>An NSString object initialized by reading data from url. If url can’t be opened or the encoding cannot be determined, returns nil. The returned initialized object might be different from the original receiver</returns>
        [iOSVersion(2)]
        public NSString(NSURL contentsOfURL, CMutablePointer<uint> usedEncoding, NSErrorPointer error) { }
        
        /// <summary>
        /// Returns a string created by reading data from the file named by a given URL. 				 		  Deprecation Statement		  		 Use stringWithContentsOfURL:encoding:error: or stringWithContentsOfURL:usedEncoding:error: instead.
        /// </summary>
        [Obsolete]
        [iOSVersion(2)]
        [Export("stringWithContentsOfURL")]
        public static AnyObject StringWithContentsOfURL(NSURL url) { return null; }
        
        /// <summary>
        /// Initializes the receiver, a newly allocated NSString object, by reading data from the location named by a given URL.				 		  Deprecation Statement		  		 Use initWithContentsOfURL:encoding:error: or initWithContentsOfURL:usedEncoding:error: instead.
        /// </summary>
        [Obsolete]
        [iOSVersion(2)]
        public NSString(NSURL contentsOfURL) { }
        
        /// <summary>
        /// Writes the contents of the receiver to a file at a given path using a given encoding.
        /// </summary>
        /// <param name="path">The file to which to write the receiver. If path contains a tilde (~) character, you must expand it with stringByExpandingTildeInPath before invoking this method.</param>
        /// <param name="atomically">If true, the receiver is written to an auxiliary file, and then the auxiliary file is renamed to path. If false, the receiver is written directly to path. The true option guarantees that path, if it exists at all, won’t be corrupted even if the system should crash during writing.</param>
        /// <param name="encoding">The encoding to use for the output.</param>
        /// <param name="error">If there is an error, upon return contains an NSError object that describes the problem. If you are not interested in details of errors, you may pass in NULL.</param>
        /// <returns>true if the file is written successfully, otherwise false (if there was a problem writing to the file or with the encoding).</returns>
        [iOSVersion(2)]
        [Export("writeToFile")]
        public bool WriteToFile(string path, bool atomically, uint encoding, NSErrorPointer error) { return false; }
        
        /// <summary>
        /// Writes the contents of the receiver to the file specified by a given path.				 		  Deprecation Statement		  		 Use writeToFile:atomically:encoding:error: instead.
        /// </summary>
        /// <returns>true if the file is written successfully, otherwise false.</returns>
        [Obsolete]
        [iOSVersion(2)]
        [Export("writeToFile")]
        public bool WriteToFile(string path, bool atomically) { return false; }
        
        /// <summary>
        /// Writes the contents of the receiver to the URL specified by url using the specified encoding.
        /// </summary>
        /// <param name="url">The URL to which to write the receiver. Only file URLs are supported.</param>
        /// <param name="atomically">If true, the receiver is written to an auxiliary file, and then the auxiliary file is renamed to url. If false, the receiver is written directly to url. The true option guarantees that url, if it exists at all, won’t be corrupted even if the system should crash during writing.   The useAuxiliaryFile parameter is ignored if url is not of a type that can be accessed atomically.</param>
        /// <param name="encoding">The encoding to use for the output.</param>
        /// <param name="error">If there is an error, upon return contains an NSError object that describes the problem. If you are not interested in details of errors, you may pass in NULL.</param>
        /// <returns>true if the URL is written successfully, otherwise false (if there was a problem writing to the URL or with the encoding).</returns>
        [iOSVersion(2)]
        [Export("writeToURL")]
        public bool WriteToURL(NSURL url, bool atomically, uint encoding, NSErrorPointer error) { return false; }
        
        /// <summary>
        /// Writes the contents of the receiver to the location specified by a given URL.				 		  Deprecation Statement		  		 Use writeToURL:atomically:encoding:error: instead.
        /// </summary>
        /// <returns>true if the location is written successfully, otherwise false.</returns>
        [Obsolete]
        [iOSVersion(2)]
        [Export("writeToURL")]
        public bool WriteToURL(NSURL url, bool atomically) { return false; }
        
        /// <summary>
        /// Returns the number of Unicode characters in the receiver.
        /// </summary>
        /// <returns>The number of Unicode characters in the receiver.</returns>
        [iOSVersion(2)]
        [Export("length")]
        public int Length { get; private set; }
        
        /// <summary>
        /// Returns the number of bytes required to store the receiver in a given encoding.
        /// </summary>
        /// <param name="enc">The encoding for which to determine the receiver's length.</param>
        /// <returns>The number of bytes required to store the receiver in the encoding enc in a non-external representation. The length does not include space for a terminating NULL character. Returns 0 if the specified encoding cannot be used to convert the receiver or if the amount of memory required for storing the results of the encoding conversion would exceed NSintegerMax.</returns>
        [iOSVersion(2)]
        [Export("lengthOfBytesUsingEncoding")]
        public int LengthOfBytesUsingEncoding(uint enc) { return 0; }
        
        /// <summary>
        /// Returns the maximum number of bytes needed to store the receiver in a given encoding.
        /// </summary>
        /// <param name="enc">The encoding for which to determine the receiver's length.</param>
        /// <returns>The maximum number of bytes needed to store the receiver in encoding in a non-external representation. The length does not include space for a terminating NULL character. Returns 0 if the amount of memory required for storing the results of the encoding conversion would exceed NSintegerMax.</returns>
        [iOSVersion(2)]
        [Export("maximumLengthOfBytesUsingEncoding")]
        public int MaximumLengthOfBytesUsingEncoding(uint enc) { return 0; }
        
        /// <summary>
        /// Returns the character at a given array position.
        /// </summary>
        /// <param name="index">The index of the character to retrieve. The index value must not lie outside the bounds of the receiver.</param>
        /// <returns>The character at the array position given by index.</returns>
        [iOSVersion(2)]
        [Export("characterAtIndex")]
        public char CharacterAtIndex(int index) { return ' '; }
        
        /// <summary>
        /// Copies all characters from the receiver into a given buffer.				 		  Deprecation Statement		  		 This method is unsafe because it could potentially cause buffer overruns. Use getCharacters:range: instead.
        /// </summary>
        /// <param name="buffer">Upon return, contains the characters from the receiver. buffer must be large enough to contain all characters in the string ([string length]*sizeof(char)).</param>
        [Obsolete]
        [iOSVersion(2)]
        [Export("getCharacters")]
        public void GetCharacters(CMutablePointer<char> buffer) { }
        
        /// <summary>
        /// Copies characters from a given range in the receiver into a given buffer.
        /// </summary>
        /// <param name="buffer">Upon return, contains the characters from the receiver. buffer must be large enough to contain the characters in the range aRange (aRange.length*sizeof(char)).</param>
        /// <param name="range">The range of characters to retrieve. The range must not exceed the bounds of the receiver.       Important     Raises an NSRangeException if any part of aRange lies beyond the bounds of the receiver.</param>
        [iOSVersion(2)]
        [Export("getCharacters")]
        public void GetCharacters(CMutablePointer<char> buffer, NSRange range) { }
        
        /// <summary>
        /// Gets a given range of characters as bytes in a specified encoding.
        /// </summary>
        /// <param name="buffer">A buffer into which to store the bytes from the receiver. The returned bytes are not NULL-terminated.</param>
        /// <param name="maxLength">The maximum number of bytes to write to buffer.</param>
        /// <param name="usedLength">The number of bytes used from buffer. Pass NULL if you do not need this value.</param>
        /// <param name="encoding">The encoding to use for the returned bytes.</param>
        /// <param name="options">A mask to specify options to use for converting the receiver’s contents to encoding (if conversion is necessary).</param>
        /// <param name="range">The range of characters in the receiver to get.</param>
        /// <param name="remainingRange">The remaining range. Pass NULL If you do not need this value.</param>
        /// <returns>true if some characters were converted, otherwise false.</returns>
        [iOSVersion(2)]
        [Export("getBytes")]
        public bool GetBytes(CMutableVoidPointer buffer, int maxLength, CMutablePointer<int> usedLength, uint encoding, NSStringEncodingConversionOptions options, NSRange range, CMutablePointer<NSRange> remainingRange) { return false; }
        
        /// <summary>
        /// Returns a representation of the receiver as a C string using a given encoding.
        /// </summary>
        /// <param name="encoding">The encoding for the returned C string.</param>
        /// <returns>A C string representation of the receiver using the encoding specified by encoding. Returns NULL if the receiver cannot be losslessly converted to encoding.</returns>
        [iOSVersion(2)]
        [Export("cStringUsingEncoding")]
        public CString CStringUsingEncoding(uint encoding) { return null; }
        
        /// <summary>
        /// Converts the receiver’s content to a given encoding and stores them in a buffer.
        /// </summary>
        /// <param name="buffer">Upon return, contains the converted C-string plus the NULL termination byte. The buffer must include room for maxBufferCount bytes.</param>
        /// <param name="maxLength">The maximum number of bytes in the string to return in buffer (including the NULL termination byte).</param>
        /// <param name="encoding">The encoding for the returned C string.</param>
        /// <returns>true if the operation was successful, otherwise false. Returns false if conversion is not possible due to encoding errors or if buffer is too small.</returns>
        [iOSVersion(2)]
        [Export("getCString")]
        public bool GetCString(CMutablePointer<CChar> buffer, int maxLength, uint encoding) { return false; }
        
        /// <summary>
        /// Returns a null-terminated UTF8 representation of the receiver.
        /// </summary>
        /// <returns>A null-terminated UTF8 representation of the receiver.</returns>
        [iOSVersion(2)]
        [Export("UTF8String")]
        public CString UTF8String { get; private set; }
        
        /// <summary>
        /// Returns a representation of the receiver as a C string in the default C-string encoding.				 		  Deprecation Statement		  		 Use cStringUsingEncoding: or UTF8String instead.
        /// </summary>
        [Obsolete]
        [iOSVersion(2)]
        [Export("cString")]
        public CString CString() { return null; }
        
        /// <summary>
        /// Returns a representation of the receiver as a C string in the default C-string encoding, possibly losing information in converting to that encoding.				 		  Deprecation Statement		  		 Use cStringUsingEncoding: or dataUsingEncoding:allowLossyConversion: instead.
        /// </summary>
        [Obsolete]
        [iOSVersion(2)]
        [Export("lossyCString")]
        public CString LossyCString() { return null; }
        
        /// <summary>
        /// Returns the length in char-sized units of the receiver’s C-string representation in the default C-string encoding.				 		  Deprecation Statement		  		 Use lengthOfBytesUsingEncoding: or maximumLengthOfBytesUsingEncoding: instead.
        /// </summary>
        [Obsolete]
        [iOSVersion(2)]
        [Export("cStringLength")]
        public int CStringLength() { return 0; }
        
        /// <summary>
        /// Invokes getCString:maxLength:range:remainingRange: with NSMaximumStringLength as the maximum length, the receiver’s entire extent as the range, and NULL for the remaining range. 				 		  Deprecation Statement		  		 Use cStringUsingEncoding: or dataUsingEncoding:allowLossyConversion: instead.
        /// </summary>
        [Obsolete]
        [iOSVersion(2)]
        [Export("getCString")]
        public void GetCString(CMutablePointer<CChar> bytes) { }
        
        /// <summary>
        /// Invokes getCString:maxLength:range:remainingRange: with maxLength as the maximum length in char-sized units, the receiver’s entire extent as the range, and NULL for the remaining range. 				 		  Deprecation Statement		  		 Use getCString:maxLength:encoding: instead.
        /// </summary>
        [Obsolete]
        [iOSVersion(2)]
        [Export("getCString")]
        public void GetCString(CMutablePointer<CChar> bytes, int maxLength) { }
        
        /// <summary>
        /// Converts the receiver’s content to the default C-string encoding and stores them in a given buffer. 				 		  Deprecation Statement		  		 Use getCString:maxLength:encoding: instead.
        /// </summary>
        [Obsolete]
        [iOSVersion(2)]
        [Export("getCString")]
        public void GetCString(CMutablePointer<CChar> bytes, int maxLength, NSRange range, CMutablePointer<NSRange> remainingRange) { }
        
        /// <summary>
        /// Returns a new string made by appending a given string to the receiver.
        /// </summary>
        /// <param name="aString">The string to append to the receiver. This value must not be nil.       Important     Raises an NSInvalidArgumentException if aString is nil.</param>
        /// <returns>A new string made by appending aString to the receiver.</returns>
        [iOSVersion(2)]
        [Export("stringByAppendingString")]
        public string StringByAppendingString(string aString) { return ""; }
        
        /// <summary>
        /// Returns a new string formed from the receiver by either removing characters from the end, or by appending as many occurrences as necessary of a given pad string.
        /// </summary>
        /// <param name="newLength">The new length for the receiver.</param>
        /// <param name="withString">The string with which to extend the receiver.</param>
        /// <param name="startingAtIndex">The index in padString from which to start padding.</param>
        /// <returns>A new string formed from the receiver by either removing characters from the end, or by appending as many occurrences of padString as necessary.</returns>
        [iOSVersion(2)]
        [Export("stringByPaddingToLength")]
        public string StringByPaddingToLength(int newLength, string withString, int startingAtIndex) { return ""; }
        
        /// <summary>
        /// Returns an array containing substrings from the receiver that have been divided by a given separator.
        /// </summary>
        /// <param name="separator">The separator string.</param>
        /// <returns>An NSArray object containing substrings from the receiver that have been divided by separator.</returns>
        [iOSVersion(2)]
        [Export("componentsSeparatedByString")]
        public AnyObject[] ComponentsSeparatedByString(string separator) { return null; }
        
        /// <summary>
        /// Returns an array containing substrings from the receiver that have been divided by characters in a given set.
        /// </summary>
        /// <param name="separator">A character set containing the characters to to use to split the receiver. Must not be nil.</param>
        /// <returns>An NSArray object containing substrings from the receiver that have been divided by characters in separator.</returns>
        [iOSVersion(2)]
        [Export("componentsSeparatedByCharactersInSet")]
        public AnyObject[] ComponentsSeparatedByCharactersInSet(NSCharacterSet separator) { return null; }
        
        /// <summary>
        /// Returns a new string made by removing from both ends of the receiver characters contained in a given character set.
        /// </summary>
        /// <param name="set">A character set containing the characters to remove from the receiver. set must not be nil.</param>
        /// <returns>A new string made by removing from both ends of the receiver characters contained in set. If the receiver is composed entirely of characters from set, the empty string is returned.</returns>
        [iOSVersion(2)]
        [Export("stringByTrimmingCharactersInSet")]
        public string StringByTrimmingCharactersInSet(NSCharacterSet set) { return ""; }
        
        /// <summary>
        /// Returns a new string containing the characters of the receiver from the one at a given index to the end.
        /// </summary>
        /// <param name="anIndex">An index. The value must lie within the bounds of the receiver, or be equal to the length of the receiver.   Raises an NSRangeException if (anIndex - 1) lies beyond the end of the receiver.</param>
        /// <returns>A new string containing the characters of the receiver from the one at anIndex to the end. If anIndex is equal to the length of the string, returns an empty string.</returns>
        [iOSVersion(2)]
        [Export("substringFromIndex")]
        public string SubstringFromIndex(int anIndex) { return ""; }
        
        /// <summary>
        /// Returns a string object containing the characters of the receiver that lie within a given range.
        /// </summary>
        /// <param name="aRange">A range. The range must not exceed the bounds of the receiver.   Raises an NSRangeException if (aRange.location - 1) or (aRange.location + aRange.length - 1) lies beyond the end of the receiver.</param>
        /// <returns>A string object containing the characters of the receiver that lie within aRange.</returns>
        [iOSVersion(2)]
        [Export("substringWithRange")]
        public string SubstringWithRange(NSRange aRange) { return ""; }
        
        /// <summary>
        /// Returns a new string containing the characters of the receiver up to, but not including, the one at a given index.
        /// </summary>
        /// <param name="anIndex">An index. The value must lie within the bounds of the receiver, or be equal to the length of the receiver.   Raises an NSRangeException if (anIndex - 1) lies beyond the end of the receiver.</param>
        /// <returns>A new string containing the characters of the receiver up to, but not including, the one at anIndex. If anIndex is equal to the length of the string, returns a copy of the receiver.</returns>
        [iOSVersion(2)]
        [Export("substringToIndex")]
        public string SubstringToIndex(int anIndex) { return ""; }
        
        /// <summary>
        /// Finds and returns the range in the receiver of the first character from a given character set.
        /// </summary>
        /// <param name="aSet">A character set. This value must not be nil.   Raises an NSInvalidArgumentException if aSet is nil.</param>
        /// <returns>The range in the receiver of the first character found from aSet. Returns a range of {NSNotFound, 0} if none of the characters in aSet are found.</returns>
        [iOSVersion(2)]
        [Export("rangeOfCharacterFromSet")]
        public NSRange RangeOfCharacterFromSet(NSCharacterSet aSet) { return null; }
        
        /// <summary>
        /// Finds and returns the range in the receiver of the first character, using given options, from a given character set.
        /// </summary>
        /// <param name="aSet">A character set. This value must not be nil.   Raises an NSInvalidArgumentException if aSet is nil.</param>
        /// <param name="options">A mask specifying search options. The following options may be specified by combining them with the C bitwise OR operator: NSAnchoredSearch, NSBackwardsSearch.</param>
        /// <returns>The range in the receiver of the first character found from aSet. Returns a range of {NSNotFound, 0} if none of the characters in aSet are found.</returns>
        [iOSVersion(2)]
        [Export("rangeOfCharacterFromSet")]
        public NSRange RangeOfCharacterFromSet(NSCharacterSet aSet, NSStringCompareOptions options) { return null; }
        
        /// <summary>
        /// Finds and returns the range in the receiver of the first character from a given character set found in a given range with given options.
        /// </summary>
        /// <param name="aSet">A character set. This value must not be nil.   Raises an NSInvalidArgumentException if aSet is nil.</param>
        /// <param name="options">A mask specifying search options. The following options may be specified by combining them with the C bitwise OR operator: NSAnchoredSearch, NSBackwardsSearch.</param>
        /// <param name="range">The range in which to search. aRange must not exceed the bounds of the receiver.   Raises an NSRangeException if aRange is invalid.</param>
        /// <returns>The range in the receiver of the first character found from aSet within aRange. Returns a range of {NSNotFound, 0} if none of the characters in aSet are found.</returns>
        [iOSVersion(2)]
        [Export("rangeOfCharacterFromSet")]
        public NSRange RangeOfCharacterFromSet(NSCharacterSet aSet, NSStringCompareOptions options, NSRange range) { return null; }
        
        /// <summary>
        /// Finds and returns the range of the first occurrence of a given string within the receiver.
        /// </summary>
        /// <param name="aString">The string to search for. This value must not be nil.   Raises an NSInvalidArgumentException if aString is nil.</param>
        /// <returns>An NSRange structure giving the location and length in the receiver of the first occurrence of aString. Returns {NSNotFound, 0} if aString is not found or is empty (@&quot;&quot;).</returns>
        [iOSVersion(2)]
        [Export("rangeOfString")]
        public NSRange RangeOfString(string aString) { return null; }
        
        /// <summary>
        /// Finds and returns the range of the first occurrence of a given string within the receiver, subject to given options.
        /// </summary>
        /// <param name="aString">The string to search for. This value must not be nil.       Important     Raises an NSInvalidArgumentException if aString is nil.</param>
        /// <param name="options">A mask specifying search options. The following options may be specified by combining them with the C bitwise OR operator: NSCaseInsensitiveSearch, NSLiteralSearch, NSBackwardsSearch, NSAnchoredSearch. See String Programming Guide for details on these options.</param>
        /// <returns>An NSRange structure giving the location and length in the receiver of the first occurrence of aString, modulo the options in mask. Returns {NSNotFound, 0} if aString is not found or is empty (@&quot;&quot;).</returns>
        [iOSVersion(2)]
        [Export("rangeOfString")]
        public NSRange RangeOfString(string aString, NSStringCompareOptions options) { return null; }
        
        /// <summary>
        /// Finds and returns the range of the first occurrence of a given string, within the given range of the receiver, subject to given options.
        /// </summary>
        /// <param name="aString">The string for which to search. This value must not be nil.   Raises an NSInvalidArgumentException if aString is nil.</param>
        /// <param name="options">A mask specifying search options. The following options may be specified by combining them with the C bitwise OR operator: NSCaseInsensitiveSearch, NSLiteralSearch, NSBackwardsSearch, and NSAnchoredSearch. See String Programming Guide for details on these options.</param>
        /// <param name="range">The range within the receiver for which to search for aString.   Raises an NSRangeException if aRange is invalid.</param>
        /// <returns>An NSRange structure giving the location and length in the receiver of aString within aRange in the receiver, modulo the options in mask. The range returned is relative to the start of the string, not to the passed-in range. Returns {NSNotFound, 0} if aString is not found or is empty (@&quot;&quot;).</returns>
        [iOSVersion(2)]
        [Export("rangeOfString")]
        public NSRange RangeOfString(string aString, NSStringCompareOptions options, NSRange range) { return null; }
        
        /// <summary>
        /// Finds and returns the range of the first occurrence of a given string within a given range of the receiver, subject to given options, using the specified locale, if any.
        /// </summary>
        /// <param name="aString">The string for which to search. This value must not be nil.   Raises an NSInvalidArgumentException if aString is nil.</param>
        /// <param name="options">A mask specifying search options. The following options may be specified by combining them with the C bitwise OR operator: NSCaseInsensitiveSearch, NSLiteralSearch, NSBackwardsSearch, and NSAnchoredSearch. See String Programming Guide for details on these options.</param>
        /// <param name="range">The range within the receiver for which to search for aString.   Raises an NSRangeException if aRange is invalid.</param>
        /// <param name="locale">The locale to use when comparing the receiver with aString. If this value is nil, uses the system locale.   The locale argument affects the equality checking algorithm. For example, for the Turkish locale, case-insensitive compare matches “I” to “ı” (Unicode code point U+0131, Latin Small Dotless I), not the normal “i” character.</param>
        /// <returns>An NSRange structure giving the location and length in the receiver of aString within aRange in the receiver, modulo the options in mask. The range returned is relative to the start of the string, not to the passed-in range. Returns {NSNotFound, 0} if aString is not found or is empty (@&quot;&quot;).</returns>
        [iOSVersion(2)]
        [Export("rangeOfString")]
        public NSRange RangeOfString(string aString, NSStringCompareOptions options, NSRange range, NSLocale locale) { return null; }
        
        /// <summary>
        /// Enumerates all the lines in a string.
        /// </summary>
        /// <param name="block">The block executed for the enumeration.   The block takes two arguments:           line              The current line of the string being enumerated. The line contains just the contents of the line, without the line terminators. See getLineStart:end:contentsEnd:forRange: for a discussion of line terminators.                stop              A reference to a Boolean value that the block can use to stop the enumeration by setting *stop = YES; it should not touch *stop otherwise.</param>
        [iOSVersion(4)]
        [Export("enumerateLinesUsingBlock")]
        public void EnumerateLinesUsingBlock(Action<String, CMutablePointer<ObjCBool>> block) { }
        
        /// <summary>
        /// Enumerates the substrings of the specified type in the specified range of the string.
        /// </summary>
        /// <param name="range">The range within the string to enumerate substrings.</param>
        /// <param name="options">Options specifying types of substrings and enumeration styles.</param>
        /// <param name="usingBlock">The block executed for the enumeration.   The block takes four arguments:           substring              The enumerated string.                substringRange              The range of the enumerated string in the receiver.                enclosingRange              The range that includes the substring as well as any separator or filler characters that follow. For instance, for lines, enclosingRange contains the line terminators. The enclosingRange for the first string enumerated also contains any characters that occur before the string. Consecutive enclosing ranges are guaranteed not to overlap, and every single character in the enumerated range is included in one and only one enclosing range.                stop              A reference to a Boolean value that the block can use to stop the enumeration by setting *stop = YES; it should not touch *stop otherwise.</param>
        [iOSVersion(4)]
        [Export("enumerateSubstringsInRange")]
        public void EnumerateSubstringsInRange(NSRange range, NSStringEnumerationOptions options, Action<String, NSRange, NSRange, CMutablePointer<ObjCBool>> usingBlock) { }
        
        /// <summary>
        /// Returns a new string in which all occurrences of a target string in the receiver are replaced by another given string.
        /// </summary>
        /// <param name="target">The string to replace.</param>
        /// <param name="withString">The string with which to replace target.</param>
        /// <returns>A new string in which all occurrences of target in the receiver are replaced by replacement.</returns>
        [iOSVersion(2)]
        [Export("stringByReplacingOccurrencesOfString")]
        public string StringByReplacingOccurrencesOfString(string target, string withString) { return ""; }
        
        /// <summary>
        /// Returns a new string in which all occurrences of a target string in a specified range of the receiver are replaced by another given string.
        /// </summary>
        /// <param name="target">The string to replace.</param>
        /// <param name="withString">The string with which to replace target.</param>
        /// <param name="options">A mask of options to use when comparing target with the receiver. Pass 0 to specify no options.</param>
        /// <param name="range">The range in the receiver in which to search for target.</param>
        /// <returns>A new string in which all occurrences of target, matched using options, in searchRange of the receiver are replaced by replacement.</returns>
        [iOSVersion(2)]
        [Export("stringByReplacingOccurrencesOfString")]
        public string StringByReplacingOccurrencesOfString(string target, string withString, NSStringCompareOptions options, NSRange range) { return ""; }
        
        /// <summary>
        /// Returns a new string in which the characters in a specified range of the receiver are replaced by a given string.
        /// </summary>
        /// <param name="range">A range of characters in the receiver.</param>
        /// <param name="withString">The string with which to replace the characters in range.</param>
        /// <returns>A new string in which the characters in range of the receiver are replaced by replacement.</returns>
        [iOSVersion(2)]
        [Export("stringByReplacingCharactersInRange")]
        public string StringByReplacingCharactersInRange(NSRange range, string withString) { return ""; }
        
        /// <summary>
        /// Returns by reference the beginning of the first line and the end of the last line touched by the given range.
        /// </summary>
        /// <param name="startIndex">Upon return, contains the index of the first character of the line containing the beginning of aRange. Pass NULL if you do not need this value (in which case the work to compute the value isn’t performed).</param>
        /// <param name="end">Upon return, contains the index of the first character past the terminator of the line containing the end of aRange. Pass NULL if you do not need this value (in which case the work to compute the value isn’t performed).</param>
        /// <param name="contentsEnd">Upon return, contains the index of the first character of the terminator of the line containing the end of aRange. Pass NULL if you do not need this value (in which case the work to compute the value isn’t performed).</param>
        /// <param name="forRange">A range within the receiver. The value must not exceed the bounds of the receiver.   Raises an NSRangeException if aRange is invalid.</param>
        [iOSVersion(2)]
        [Export("getLineStart")]
        public void GetLineStart(CMutablePointer<int> startIndex, CMutablePointer<int> end, CMutablePointer<int> contentsEnd, NSRange forRange) { }
        
        /// <summary>
        /// Returns the range of characters representing the line or lines containing a given range.
        /// </summary>
        /// <param name="aRange">A range within the receiver. The value must not exceed the bounds of the receiver.</param>
        /// <returns>The range of characters representing the line or lines containing aRange, including the line termination characters. See getLineStart:end:contentsEnd:forRange: for a discussion of line terminators.</returns>
        [iOSVersion(2)]
        [Export("lineRangeForRange")]
        public NSRange LineRangeForRange(NSRange aRange) { return null; }
        
        /// <summary>
        /// Returns by reference the beginning of the first paragraph and the end of the last paragraph touched by the given range.
        /// </summary>
        /// <param name="startIndex">Upon return, contains the index of the first character of the paragraph containing the beginning of aRange. Pass NULL if you do not need this value (in which case the work to compute the value isn’t performed).</param>
        /// <param name="end">Upon return, contains the index of the first character past the terminator of the paragraph containing the end of aRange. Pass NULL if you do not need this value (in which case the work to compute the value isn’t performed).</param>
        /// <param name="contentsEnd">Upon return, contains the index of the first character of the terminator of the paragraph containing the end of aRange. Pass NULL if you do not need this value (in which case the work to compute the value isn’t performed).</param>
        /// <param name="forRange">A range within the receiver. The value must not exceed the bounds of the receiver.</param>
        [iOSVersion(2)]
        [Export("getParagraphStart")]
        public void GetParagraphStart(CMutablePointer<int> startIndex, CMutablePointer<int> end, CMutablePointer<int> contentsEnd, NSRange forRange) { }
        
        /// <summary>
        /// Returns the range of characters representing the paragraph or paragraphs containing a given range.
        /// </summary>
        /// <param name="aRange">A range within the receiver. The range must not exceed the bounds of the receiver.</param>
        /// <returns>The range of characters representing the paragraph or paragraphs containing aRange, including the paragraph termination characters.</returns>
        [iOSVersion(2)]
        [Export("paragraphRangeForRange")]
        public NSRange ParagraphRangeForRange(NSRange aRange) { return null; }
        
        /// <summary>
        /// Returns the range in the receiver of the composed character sequence located at a given index.
        /// </summary>
        /// <param name="anIndex">The index of a character in the receiver. The value must not exceed the bounds of the receiver.</param>
        /// <returns>The range in the receiver of the composed character sequence located at anIndex.</returns>
        [iOSVersion(2)]
        [Export("rangeOfComposedCharacterSequenceAtIndex")]
        public NSRange RangeOfComposedCharacterSequenceAtIndex(int anIndex) { return null; }
        
        /// <summary>
        /// Returns the range in the string of the composed character sequences for a given range.
        /// </summary>
        /// <param name="range">A range in the receiver. The range must not exceed the bounds of the receiver.</param>
        /// <returns>The range in the receiver that includes the composed character sequences in range.</returns>
        [iOSVersion(2)]
        [Export("rangeOfComposedCharacterSequencesForRange")]
        public NSRange RangeOfComposedCharacterSequencesForRange(NSRange range) { return null; }
        
        /// <summary>
        /// Parses the receiver as a text representation of a property list, returning an NSString, NSData, NSArray, or NSDictionary object, according to the topmost element.
        /// </summary>
        /// <returns>A property list representation of returning an NSString, NSData, NSArray, or NSDictionary object, according to the topmost element.</returns>
        [iOSVersion(2)]
        [Export("propertyList")]
        public AnyObject PropertyList() { return null; }
        
        /// <summary>
        /// Returns a dictionary object initialized with the keys and values found in the receiver.
        /// </summary>
        /// <returns>A dictionary object initialized with the keys and values found in the receiver</returns>
        [iOSVersion(2)]
        [Export("propertyListFromStringsFileFormat")]
        public NSDictionary PropertyListFromStringsFileFormat() { return null; }
        
        /// <summary>
        /// Returns the result of invoking compare:options: with NSCaseInsensitiveSearch as the only option.
        /// </summary>
        /// <param name="aString">The string with which to compare the receiver.   This value must not be nil. If this value is nil, the behavior is undefined and may change in future versions of OS X.</param>
        /// <returns>The result of invoking compare:options: with NSCaseInsensitiveSearch as the only option.</returns>
        [iOSVersion(2)]
        [Export("caseInsensitiveCompare")]
        public NSComparisonResult CaseInsensitiveCompare(string aString) { return null; }
        
        /// <summary>
        /// Compares the string with a given string using a case-insensitive, localized, comparison.
        /// </summary>
        /// <param name="aString">The string with which to compare the receiver.   This value must not be nil. If this value is nil, the behavior is undefined and may change in future versions of OS X.</param>
        /// <returns>Returns an NSComparisonResult value that indicates the lexical ordering. NSOrderedAscending the receiver precedes aString in lexical ordering, NSOrderedSame the receiver and aString are equivalent in lexical value, and NSOrderedDescending if the receiver follows aString.</returns>
        [iOSVersion(2)]
        [Export("localizedCaseInsensitiveCompare")]
        public NSComparisonResult LocalizedCaseInsensitiveCompare(string aString) { return null; }
        
        /// <summary>
        /// Returns the result of invoking compare:options:range: with no options and the receiver’s full extent as the range.
        /// </summary>
        /// <param name="aString">The string with which to compare the receiver.   This value must not be nil. If this value is nil, the behavior is undefined and may change in future versions of OS X.</param>
        /// <returns>The result of invoking compare:options:range: with no options and the receiver’s full extent as the range.</returns>
        [iOSVersion(2)]
        [Export("compare")]
        public NSComparisonResult Compare(string aString) { return null; }
        
        /// <summary>
        /// Compares the string and a given string using a localized comparison.
        /// </summary>
        /// <param name="aString">The string with which to compare the receiver.   This value must not be nil. If this value is nil, the behavior is undefined and may change in future versions of OS X.</param>
        /// <returns>Returns an NSComparisonResult. NSOrderedAscending the receiver precedes string in lexical ordering, NSOrderedSame the receiver and string are equivalent in lexical value, and NSOrderedDescending if the receiver follows string.</returns>
        [iOSVersion(2)]
        [Export("localizedCompare")]
        public NSComparisonResult LocalizedCompare(string aString) { return null; }
        
        /// <summary>
        /// Compares the string with the specified string using the given options.
        /// </summary>
        /// <param name="aString">The string with which to compare the receiver.   This value must not be nil. If this value is nil, the behavior is undefined and may change in future versions of OS X.</param>
        /// <param name="options">Options for the search—you can combine any of the following using a C bitwise OR operator: NSCaseInsensitiveSearch, NSLiteralSearch, NSNumericSearch. See String Programming Guide for details on these options.</param>
        /// <returns>The result of invoking compare:options:range: with a given mask as the options and the receiver’s full extent as the range.</returns>
        [iOSVersion(2)]
        [Export("compare")]
        public NSComparisonResult Compare(string aString, NSStringCompareOptions options) { return null; }
        
        /// <summary>
        /// Returns the result of invoking compare:options:range:locale: with a nil locale.
        /// </summary>
        /// <param name="aString">The string with which to compare the range of the receiver specified by range.   This value must not be nil. If this value is nil, the behavior is undefined and may change in future versions of OS X.</param>
        /// <param name="options">Options for the search—you can combine any of the following using a C bitwise OR operator: NSCaseInsensitiveSearch, NSLiteralSearch, NSNumericSearch.   See String Programming Guide for details on these options.</param>
        /// <param name="range">The range of the receiver over which to perform the comparison. The range must not exceed the bounds of the receiver.       Important     Raises an NSRangeException if range exceeds the bounds of the receiver.</param>
        /// <returns>The result of invoking compare:options:range:locale: with a nil locale.</returns>
        [iOSVersion(2)]
        [Export("compare")]
        public NSComparisonResult Compare(string aString, NSStringCompareOptions options, NSRange range) { return null; }
        
        /// <summary>
        /// Compares the string using the specified options and returns the lexical ordering for the range.
        /// </summary>
        /// <param name="aString">The string with which to compare the range of the receiver specified by range.   This value must not be nil. If this value is nil, the behavior is undefined and may change in future versions of OS X.</param>
        /// <param name="options">Options for the search—you can combine any of the following using a C bitwise OR operator: NSCaseInsensitiveSearch, NSLiteralSearch, NSNumericSearch.   See String Programming Guide for details on these options.</param>
        /// <param name="range">The range of the receiver over which to perform the comparison. The range must not exceed the bounds of the receiver.       Important     Raises an NSRangeException if range exceeds the bounds of the receiver.</param>
        /// <param name="locale">An instance of NSLocale. Passing nil causes the method to use the system locale. If you are comparing strings to present to the end-user, you should typically pass the user’s locale (-[NSLocale currentLocale]).</param>
        /// <returns>Returns an NSComparisonResult value that indicates the lexical ordering of a specified range within the receiver and a given string. NSOrderedAscending if the substring of the receiver given by range precedes aString in lexical ordering for the locale given in dict, NSOrderedSame if the substring of the receiver and aString are equivalent in lexical value, and NSOrderedDescending if the substring of the receiver follows aString.</returns>
        [iOSVersion(2)]
        [Export("compare")]
        public NSComparisonResult Compare(string aString, NSStringCompareOptions options, NSRange range, AnyObject locale) { return null; }
        
        /// <summary>
        /// Compares strings as sorted by the Finder.
        /// </summary>
        /// <param name="string">The string to compare with the receiver.</param>
        /// <returns>The result of the comparison.</returns>
        [iOSVersion(4)]
        [Export("localizedStandardCompare")]
        public NSComparisonResult LocalizedStandardCompare(string @string) { return null; }
        
        /// <summary>
        /// Returns a Boolean value that indicates whether a given string matches the beginning characters of the receiver.
        /// </summary>
        /// <param name="aString">A string.</param>
        /// <returns>true if aString matches the beginning characters of the receiver, otherwise false. Returns false if aString is empty.</returns>
        [iOSVersion(2)]
        [Export("hasPrefix")]
        public bool HasPrefix(string aString) { return false; }
        
        /// <summary>
        /// Returns a Boolean value that indicates whether a given string matches the ending characters of the receiver.
        /// </summary>
        /// <param name="aString">A string.</param>
        /// <returns>true if aString matches the ending characters of the receiver, otherwise false. Returns false if aString is empty.</returns>
        [iOSVersion(2)]
        [Export("hasSuffix")]
        public bool HasSuffix(string aString) { return false; }
        
        /// <summary>
        /// Returns a Boolean value that indicates whether a given string is equal to the receiver using a literal Unicode-based comparison.
        /// </summary>
        /// <param name="aString">The string with which to compare the receiver.</param>
        /// <returns>true if aString is equivalent to the receiver (if they have the same id or if they are NSOrderedSame in a literal comparison), otherwise false.</returns>
        [iOSVersion(2)]
        [Export("isEqualToString")]
        public bool IsEqualToString(string aString) { return false; }
        
        /// <summary>
        /// Returns an unsigned integer that can be used as a hash table address.
        /// </summary>
        /// <returns>An unsigned integer that can be used as a hash table address.</returns>
        [iOSVersion(2)]
        [Export("hash")]
        public int Hash { get; private set; }
        
        /// <summary>
        /// Returns a string with the given character folding options applied.
        /// </summary>
        /// <param name="options">A mask of compare flags with a suffix InsensitiveSearch.</param>
        /// <param name="locale">The locale to use for the folding. If this value is nil, uses the system locale.</param>
        /// <returns>A string with the character folding options applied.</returns>
        [iOSVersion(2)]
        [Export("stringByFoldingWithOptions")]
        public string StringByFoldingWithOptions(NSStringCompareOptions options, NSLocale locale) { return ""; }
        
        /// <summary>
        /// Returns a string containing characters the receiver and a given string have in common, starting from the beginning of each up to the first characters that aren’t equivalent.
        /// </summary>
        /// <param name="aString">The string with which to compare the receiver.</param>
        /// <param name="options">Options for the comparison. The following search options may be specified by combining them with the C bitwise OR operator: NSCaseInsensitiveSearch, NSLiteralSearch. See String Programming Guide for details on these options.</param>
        /// <returns>A string containing characters the receiver and aString have in common, starting from the beginning of each up to the first characters that aren’t equivalent.</returns>
        [iOSVersion(2)]
        [Export("commonPrefixWithString")]
        public string CommonPrefixWithString(string aString, NSStringCompareOptions options) { return ""; }
        
        /// <summary>
        /// Returns a capitalized representation of the receiver.
        /// </summary>
        /// <returns>A string with the first character from each word in the receiver changed to its corresponding uppercase value, and all remaining characters set to their corresponding lowercase values.</returns>
        [iOSVersion(2)]
        [Export("capitalizedString")]
        public string CapitalizedString { get; private set; }
        
        /// <summary>
        /// Returns a capitalized representation of the receiver using the specified locale.
        /// </summary>
        /// <param name="locale">The locale. Passing nil indicates the system locale. For strings presented to users, use currentLocale.</param>
        /// <returns>A string with the first character from each word in the receiver changed to its corresponding uppercase value, and all remaining characters set to their corresponding lowercase values.</returns>
        [iOSVersion(6)]
        [Export("capitalizedStringWithLocale")]
        public string CapitalizedStringWithLocale(NSLocale locale) { return ""; }
        
        /// <summary>
        /// Returns lowercased representation of the receiver.
        /// </summary>
        /// <returns>A string with each character from the receiver changed to its corresponding lowercase value.</returns>
        [iOSVersion(2)]
        [Export("lowercaseString")]
        public string LowercaseString { get; private set; }
        
        /// <summary>
        /// Returns a version of the string with all letters converted to lowercase, taking into account the specified locale.
        /// </summary>
        /// <param name="locale">The locale. Passing nil indicates the system locale. For strings presented to users, use currentLocale.</param>
        /// <returns>A lowercase string using the locale. Input of @&quot;ABcde&quot; would result in a return of @&quot;abcde&quot;.</returns>
        [iOSVersion(6)]
        [Export("lowercaseStringWithLocale")]
        public string LowercaseStringWithLocale(NSLocale locale) { return ""; }
        
        /// <summary>
        /// Returns a uppercased representation of the receiver.
        /// </summary>
        /// <returns>A string with each character from the receiver changed to its corresponding uppercase value.</returns>
        [iOSVersion(2)]
        [Export("uppercaseString")]
        public string UppercaseString { get; private set; }
        
        /// <summary>
        /// Returns a version of the string with all letters converted to uppercase, taking into account the specified locale.
        /// </summary>
        /// <param name="locale">The locale. Passing nil indicates the system locale. For strings presented to users, use currentLocale.</param>
        /// <returns>An uppercase string using the locale. Input of @&quot;ABcde&quot; would result in a return of @&quot;ABCDE&quot;.</returns>
        [iOSVersion(6)]
        [Export("uppercaseStringWithLocale")]
        public string UppercaseStringWithLocale(NSLocale locale) { return ""; }
        
        /// <summary>
        /// Returns a string made by normalizing the receiver’s contents using Form D.
        /// </summary>
        /// <returns>A string made by normalizing the receiver’s contents using the Unicode Normalization Form D.</returns>
        [iOSVersion(2)]
        [Export("decomposedStringWithCanonicalMapping")]
        public string DecomposedStringWithCanonicalMapping { get; private set; }
        
        /// <summary>
        /// Returns a string made by normalizing the receiver’s contents using Form KD.
        /// </summary>
        /// <returns>A string made by normalizing the receiver’s contents using the Unicode Normalization Form KD.</returns>
        [iOSVersion(2)]
        [Export("decomposedStringWithCompatibilityMapping")]
        public string DecomposedStringWithCompatibilityMapping { get; private set; }
        
        /// <summary>
        /// Returns a string made by normalizing the receiver’s contents using Form C.
        /// </summary>
        /// <returns>A string made by normalizing the receiver’s contents using the Unicode Normalization Form C.</returns>
        [iOSVersion(2)]
        [Export("precomposedStringWithCanonicalMapping")]
        public string PrecomposedStringWithCanonicalMapping { get; private set; }
        
        /// <summary>
        /// Returns a string made by normalizing the receiver’s contents using Form KC.
        /// </summary>
        /// <returns>A string made by normalizing the receiver’s contents using the Unicode Normalization Form KC.</returns>
        [iOSVersion(2)]
        [Export("precomposedStringWithCompatibilityMapping")]
        public string PrecomposedStringWithCompatibilityMapping { get; private set; }
        
        /// <summary>
        /// Returns the floating-point value of the receiver’s text as a double.
        /// </summary>
        /// <returns>The floating-point value of the receiver’s text as a double. Returns HUGE_VAL or –HUGE_VAL on overflow, 0.0 on underflow. Returns 0.0 if the receiver doesn’t begin with a valid text representation of a floating-point number.</returns>
        [iOSVersion(2)]
        [Export("doubleValue")]
        public CDouble DoubleValue { get; private set; }
        
        /// <summary>
        /// Returns the floating-point value of the receiver’s text as a float.
        /// </summary>
        /// <returns>The floating-point value of the receiver’s text as a float, skipping whitespace at the beginning of the string. Returns HUGE_VAL or –HUGE_VAL on overflow, 0.0 on underflow. Also returns 0.0 if the receiver doesn’t begin with a valid text representation of a floating-point number.</returns>
        [iOSVersion(2)]
        [Export("floatValue")]
        public CFloat FloatValue { get; private set; }
        
        /// <summary>
        /// Returns the integer value of the receiver’s text.
        /// </summary>
        /// <returns>The integer value of the receiver’s text, assuming a decimal representation and skipping whitespace at the beginning of the string. Returns INT_MAX or INT_MIN on overflow. Returns 0 if the receiver doesn’t begin with a valid decimal text representation of a number.</returns>
        [iOSVersion(2)]
        [Export("intValue")]
        public Cint intValue { get; private set; }
        
        /// <summary>
        /// Returns the NSinteger value of the receiver’s text.
        /// </summary>
        /// <returns>The NSinteger value of the receiver’s text, assuming a decimal representation and skipping whitespace at the beginning of the string. Returns 0 if the receiver doesn’t begin with a valid decimal text representation of a number.</returns>
        [iOSVersion(2)]
        [Export("integerValue")]
        public int integerValue { get; private set; }
        
        /// <summary>
        /// Returns the long long value of the receiver’s text.
        /// </summary>
        /// <returns>The long long value of the receiver’s text, assuming a decimal representation and skipping whitespace at the beginning of the string. Returns LLONG_MAX or LLONG_MIN on overflow. Returns 0 if the receiver doesn’t begin with a valid decimal text representation of a number.</returns>
        [iOSVersion(2)]
        [Export("longLongValue")]
        public CLongLong LongLongValue { get; private set; }
        
        /// <summary>
        /// Returns the Boolean value of the receiver’s text.
        /// </summary>
        /// <returns>The Boolean value of the receiver’s text. Returns true on encountering one of &quot;Y&quot;, &quot;y&quot;, &quot;T&quot;, &quot;t&quot;, or a digit 1-9—the method ignores any trailing characters. Returns false if the receiver doesn’t begin with a valid decimal text representation of a number.</returns>
        [iOSVersion(2)]
        [Export("boolValue")]
        public bool BoolValue { get; private set; }
        
        /// <summary>
        /// Returns a zero-terminated list of the encodings string objects support in the application’s environment.
        /// </summary>
        /// <returns>A zero-terminated list of the encodings string objects support in the application’s environment.</returns>
        [iOSVersion(2)]
        [Export("availableStringEncodings")]
        public static UnsafePointer<uint> AvailableStringEncodings() { return null; }
        
        /// <summary>
        /// Returns the C-string encoding assumed for any method accepting a C string as an argument.
        /// </summary>
        /// <returns>The C-string encoding assumed for any method accepting a C string as an argument.</returns>
        [iOSVersion(2)]
        [Export("defaultCStringEncoding")]
        public static uint DefaultCStringEncoding() { return 0; }
        
        /// <summary>
        /// Returns a human-readable string giving the name of a given encoding.
        /// </summary>
        /// <param name="encoding">A string encoding.</param>
        /// <returns>A human-readable string giving the name of encoding in the current locale’s language.</returns>
        [iOSVersion(2)]
        [Export("localizedNameOfStringEncoding")]
        public static string LocalizedNameOfStringEncoding(uint encoding) { return ""; }
        
        /// <summary>
        /// Returns a Boolean value that indicates whether the receiver can be converted to a given encoding without loss of information.
        /// </summary>
        /// <param name="encoding">A string encoding.</param>
        /// <returns>true if the receiver can be converted to encoding without loss of information. Returns false if characters would have to be changed or deleted in the process of changing encodings.</returns>
        [iOSVersion(2)]
        [Export("canBeConvertedToEncoding")]
        public bool CanBeConvertedToEncoding(uint encoding) { return false; }
        
        /// <summary>
        /// Returns an NSData object containing a representation of the receiver encoded using a given encoding.
        /// </summary>
        /// <param name="encoding">A string encoding.</param>
        /// <returns>The result of invoking dataUsingEncoding:allowLossyConversion: with false as the second argument (that is, requiring lossless conversion).</returns>
        [iOSVersion(2)]
        [Export("dataUsingEncoding")]
        public NSData DataUsingEncoding(uint encoding) { return null; }
        
        /// <summary>
        /// Returns an NSData object containing a representation of the receiver encoded using a given encoding.
        /// </summary>
        /// <param name="encoding">A string encoding.</param>
        /// <param name="allowLossyConversion">If true, then allows characters to be removed or altered in conversion.</param>
        /// <returns>An NSData object containing a representation of the receiver encoded using encoding. Returns nil if flag is false and the receiver can’t be converted without losing some information (such as accents or case).</returns>
        [iOSVersion(2)]
        [Export("dataUsingEncoding")]
        public NSData DataUsingEncoding(uint encoding, bool allowLossyConversion) { return null; }
        
        /// <summary>
        /// Returns the receiver.
        /// </summary>
        /// <returns>The receiver.</returns>
        [iOSVersion(2)]
        [Export("description")]
        public string Description { get; private set; }
        
        /// <summary>
        /// Returns the fastest encoding to which the receiver may be converted without loss of information.
        /// </summary>
        /// <returns>The fastest encoding to which the receiver may be converted without loss of information.</returns>
        [iOSVersion(2)]
        [Export("fastestEncoding")]
        public uint FastestEncoding { get; private set; }
        
        /// <summary>
        /// Returns the smallest encoding to which the receiver can be converted without loss of information.
        /// </summary>
        /// <returns>The smallest encoding to which the receiver can be converted without loss of information.</returns>
        [iOSVersion(2)]
        [Export("smallestEncoding")]
        public uint SmallestEncoding { get; private set; }
        
        /// <summary>
        /// Returns a string built from the strings in a given array by concatenating them with a path separator between each pair.
        /// </summary>
        /// <param name="components">An array of NSString objects representing a file path. To create an absolute path, use a slash mark (“/”) as the first component. To include a trailing path divider, use an empty string as the last component.</param>
        /// <returns>A string built from the strings in components by concatenating them (in the order they appear in the array) with a path separator between each pair.</returns>
        [iOSVersion(2)]
        [Export("pathWithComponents")]
        public static string PathWithComponents(AnyObject[] components) { return ""; }
        
        /// <summary>
        /// Returns an array of NSString objects containing, in order, each path component of the receiver.
        /// </summary>
        /// <returns>An array of NSString objects containing, in order, each path component of the receiver.</returns>
        [iOSVersion(2)]
        [Export("pathComponents")]
        public AnyObject[] PathComponents { get; private set; }
        
        /// <summary>
        /// interprets the receiver as a path in the file system and attempts to perform filename completion, returning a numeric value that indicates whether a match was possible, and by reference the longest path that matches the receiver.
        /// </summary>
        /// <param name="outputName">Upon return, contains the longest path that matches the receiver.</param>
        /// <param name="caseSensitive">If true, the methods considers case for possible completions.</param>
        /// <param name="matchesintoArray">Upon return, contains all matching filenames.</param>
        /// <param name="filterTypes">An array of NSString objects specifying path extensions to consider for completion. only paths whose extensions (not including the extension separator) match one of those strings.</param>
        /// <returns>0 if no matches are found and 1 if exactly one match is found. In the case of multiple matches, returns the actual number of matching paths if outputArray is provided, or simply a positive value if outputArray is NULL.</returns>
        [iOSVersion(2)]
        [Export("completePathintoString")]
        public int CompletePathintoString(AutoreleasingUnsafePointer<NSString> outputName, bool caseSensitive, AutoreleasingUnsafePointer<NSArray> matchesintoArray, AnyObject[] filterTypes) { return 0; }
        
        /// <summary>
        /// Returns a file system-specific representation of the receiver.
        /// </summary>
        /// <returns>A file system-specific representation of the receiver, as described for getFileSystemRepresentation:maxLength:.</returns>
        [iOSVersion(2)]
        [Export("fileSystemRepresentation")]
        public CString FileSystemRepresentation { get; private set; }
        
        /// <summary>
        /// interprets the receiver as a system-independent path and fills a buffer with a C-string in a format and encoding suitable for use with file-system calls.
        /// </summary>
        /// <param name="buffer">Upon return, contains a C-string that represent the receiver as as a system-independent path, plus the NULL termination byte. The size of buffer must be large enough to contain maxLength bytes.</param>
        /// <param name="maxLength">The maximum number of bytes in the string to return in buffer (including a terminating NULL character, which this method adds).</param>
        /// <returns>true if buffer is successfully filled with a file-system representation, otherwise false (for example, if maxLength would be exceeded or if the receiver can’t be represented in the file system’s encoding).</returns>
        [iOSVersion(2)]
        [Export("getFileSystemRepresentation")]
        public bool GetFileSystemRepresentation(CMutablePointer<CChar> buffer, int maxLength) { return false; }
        
        /// <summary>
        /// Returns the last path component of the receiver.
        /// </summary>
        /// <returns>The last path component of the receiver.</returns>
        [iOSVersion(2)]
        [Export("lastPathComponent")]
        public string LastPathComponent { get; private set; }
        
        /// <summary>
        /// interprets the receiver as a path and returns the receiver’s extension, if any.
        /// </summary>
        /// <returns>The receiver’s extension, if any (not including the extension divider).</returns>
        [iOSVersion(2)]
        [Export("pathExtension")]
        public string PathExtension { get; private set; }
        
        /// <summary>
        /// Returns a new string that replaces the current home directory portion of the current path with a tilde (~) character.
        /// </summary>
        /// <returns>A new string based on the current string object. If the new string specifies a file in the current home directory, the home directory portion of the path is replaced with a tilde (~) character. If the string does not specify a file in the current home directory, this method returns a new string object whose path is unchanged from the path in the current string.</returns>
        [iOSVersion(2)]
        [Export("stringByAbbreviatingWithTildeInPath")]
        public string StringByAbbreviatingWithTildeInPath { get; private set; }
        
        /// <summary>
        /// Returns a new string made by appending to the receiver a given string.
        /// </summary>
        /// <param name="aString">The path component to append to the receiver.</param>
        /// <returns>A new string made by appending aString to the receiver, preceded if necessary by a path separator.</returns>
        [iOSVersion(2)]
        [Export("stringByAppendingPathComponent")]
        public string StringByAppendingPathComponent(string aString) { return ""; }
        
        /// <summary>
        /// Returns a new string made by appending to the receiver an extension separator followed by a given extension.
        /// </summary>
        /// <param name="ext">The extension to append to the receiver.</param>
        /// <returns>A new string made by appending to the receiver an extension separator followed by ext.</returns>
        [iOSVersion(2)]
        [Export("stringByAppendingPathExtension")]
        public string StringByAppendingPathExtension(string ext) { return ""; }
        
        /// <summary>
        /// Returns a new string made by deleting the last path component from the receiver, along with any final path separator.
        /// </summary>
        /// <returns>A new string made by deleting the last path component from the receiver, along with any final path separator. If the receiver represents the root path it is returned unaltered.</returns>
        [iOSVersion(2)]
        [Export("stringByDeletingLastPathComponent")]
        public string StringByDeletingLastPathComponent { get; private set; }
        
        /// <summary>
        /// Returns a new string made by deleting the extension (if any, and only the last) from the receiver.
        /// </summary>
        /// <returns>a new string made by deleting the extension (if any, and only the last) from the receiver. Strips any trailing path separator before checking for an extension. If the receiver represents the root path, it is returned unaltered.</returns>
        [iOSVersion(2)]
        [Export("stringByDeletingPathExtension")]
        public string StringByDeletingPathExtension { get; private set; }
        
        /// <summary>
        /// Returns a new string made by expanding the initial component of the receiver to its full path value.
        /// </summary>
        /// <returns>A new string made by expanding the initial component of the receiver, if it begins with “~” or “~user”, to its full path value. Returns a new string matching the receiver if the receiver’s initial component can’t be expanded.</returns>
        [iOSVersion(2)]
        [Export("stringByExpandingTildeInPath")]
        public string StringByExpandingTildeInPath { get; private set; }
        
        /// <summary>
        /// Returns a new string made from the receiver by resolving all symbolic links and standardizing path.
        /// </summary>
        /// <returns>A new string made by expanding an initial tilde expression in the receiver, then resolving all symbolic links and references to current or parent directories if possible, to generate a standardized path. If the original path is absolute, all symbolic links are guaranteed to be removed; if it’s a relative path, symbolic links that can’t be resolved are left unresolved in the returned string. Returns self if an error occurs.</returns>
        [iOSVersion(2)]
        [Export("stringByResolvingSymlinksInPath")]
        public string StringByResolvingSymlinksInPath { get; private set; }
        
        /// <summary>
        /// Returns a new string made by removing extraneous path components from the receiver.
        /// </summary>
        /// <returns>A new string made by removing extraneous path components from the receiver.</returns>
        [iOSVersion(2)]
        [Export("stringByStandardizingPath")]
        public string StringByStandardizingPath { get; private set; }
        
        /// <summary>
        /// Returns an array of strings made by separately appending to the receiver each string in in a given array.
        /// </summary>
        /// <param name="paths">An array of NSString objects specifying paths to add to the receiver.</param>
        /// <returns>An array of NSString objects made by separately appending each string in paths to the receiver, preceded if necessary by a path separator.</returns>
        [iOSVersion(2)]
        [Export("stringsByAppendingPaths")]
        public AnyObject[] StringsByAppendingPaths(AnyObject[] paths) { return null; }
        
        /// <summary>
        /// Returns a representation of the receiver using a given encoding to determine the percent escapes necessary to convert the receiver into a legal URL string.
        /// </summary>
        /// <param name="encoding">The encoding to use for the returned string. If you are uncertain of the correct encoding you should use NSUTF8StringEncoding.</param>
        /// <returns>A representation of the receiver using encoding to determine the percent escapes necessary to convert the receiver into a legal URL string. Returns nil if encoding cannot encode a particular character.</returns>
        [iOSVersion(2)]
        [Export("stringByAddingPercentEscapesUsingEncoding")]
        public string StringByAddingPercentEscapesUsingEncoding(uint encoding) { return ""; }
        
        /// <summary>
        /// Returns a new string made by replacing in the receiver all percent escapes with the matching characters as determined by a given encoding.
        /// </summary>
        /// <param name="encoding">The encoding to use for the returned string.</param>
        /// <returns>A new string made by replacing in the receiver all percent escapes with the matching characters as determined by the given encoding encoding. Returns nil if the transformation is not possible, for example, the percent escapes give a byte sequence not legal in encoding.</returns>
        [iOSVersion(2)]
        [Export("stringByReplacingPercentEscapesUsingEncoding")]
        public string StringByReplacingPercentEscapesUsingEncoding(uint encoding) { return ""; }
        
        /// <summary>
        /// Returns a new string made from the receiver by replacing all characters not in the specified set with percent encoded characters.
        /// </summary>
        /// <param name="allowedCharacters">The characters not replaced in the string.</param>
        /// <returns>Returns the encoded string or nil if the transformation is not possible.</returns>
        [iOSVersion(7)]
        [Export("stringByAddingPercentEncodingWithAllowedCharacters")]
        public string StringByAddingPercentEncodingWithAllowedCharacters(NSCharacterSet allowedCharacters) { return ""; }
        
        /// <summary>
        /// Returns a new string made from the receiver by replacing all percent encoded sequences with the matching UTF-8 characters.
        /// </summary>
        /// <returns>A new string with the percent encoded sequences removed.</returns>
        [iOSVersion(7)]
        [Export("stringByRemovingPercentEncoding")]
        public string StringByRemovingPercentEncoding { get; private set; }
        
        /// <summary>
        /// Performs linguistic analysis on the specified string by enumerating the specific range of the string, providing the Block with the located tags.
        /// </summary>
        /// <param name="range">The range of the string to analyze.</param>
        /// <param name="scheme">The tag scheme to use. See Linguistic Tag Schemes for supported values.</param>
        /// <param name="options">The linguistic tagger options to use. See NSLinguisticTaggerOptionsfor the constants. These constants can be combined using the C-Bitwise OR operator.</param>
        /// <param name="orthography">The orthography of the string. If nil, the linguistic tagger will attempt to determine the orthography from the string content.</param>
        /// <param name="usingBlock">The Block to apply to the string.   The block takes four arguments:           tag              The tag scheme for the token. The opts parameter specifies the types of tagger options that are located.                tokenRange              The range of a string matching the tag scheme.                sentenceRange              The range of the sentence in which the token is found.                stop              A reference to a Boolean value. The block can set the value to true to stop further processing of the array. The stop argument is an out-only argument. You should only ever set this Boolean to true within the Block.</param>
        [iOSVersion(5)]
        [Export("enumerateLinguisticTagsInRange")]
        public void EnumerateLinguisticTagsInRange(NSRange range, string scheme, NSLinguisticTaggerOptions options, NSOrthography orthography, Action<String, NSRange, NSRange, CMutablePointer<ObjCBool>> usingBlock) { }
        
        /// <summary>
        /// Returns an array of linguistic tags for the specified range and requested tags within the receiving string.
        /// </summary>
        /// <param name="range">The range of the string to analyze.</param>
        /// <param name="scheme">The tag scheme to use. See Linguistic Tag Schemes for supported values.</param>
        /// <param name="options">The linguistic tagger options to use. See NSLinguisticTaggerOptions for the constants. These constants can be combined using the C-Bitwise OR operator.</param>
        /// <param name="orthography">The orthography of the string. If nil, the linguistic tagger will attempt to determine the orthography from the string content.</param>
        /// <param name="tokenRanges">An array returned by-reference containing the token ranges of the linguistic tags wrapped in NSValue objects.</param>
        /// <returns>Returns an array containing the linguistic tags for the tokenRanges within the receiving string.</returns>
        [iOSVersion(5)]
        [Export("linguisticTagsInRange")]
        public AnyObject[] LinguisticTagsInRange(NSRange range, string scheme, NSLinguisticTaggerOptions options, NSOrthography orthography, AutoreleasingUnsafePointer<NSArray> tokenRanges) { return null; }
        
        /// <summary>
        /// Type for Unicode characters.
        /// </summary>
        //[iOSVersion(2)]
        //public 
        //typealias char = CUnsignedShort
        
        //todo notifications
        /// <summary>
        /// These constants define the names of exceptions raised if NSString cannot represent a string in a given encoding, or parse a string as a property list.
        /// </summary>
        
        /// <summary>
        /// NSString raises an NSCharacterConversionException if a string cannot be represented in a file-system or string encoding.
        /// </summary>
        [iOSVersion(2)]
        public string NSCharacterConversionException { get; private set; }
        
        /// <summary>
        /// NSString raises an NSParseErrorException if a string cannot be parsed as a property list.
        /// </summary>
        [iOSVersion(2)]
        public string NSParseErrorException { get; private set; }
        
        /// <summary>
        /// The following constants are provided by NSString as possible string encodings.
        /// </summary>
        [Export("NSProprietaryStringEncoding")]
        public int NSProprietaryStringEncoding { get; private set; }
    }

    /// <summary>
    /// These values represent the options available to many of the string classes’ search and comparison methods.
    /// </summary>
    public enum NSStringCompareOptions
    {
        /// <summary>
        /// A case-insensitive search.
        /// </summary>
        [iOSVersion(2)]
        CaseInsensitiveSearch,

        /// <summary>
        /// Exact character-by-character equivalence.
        /// </summary>
        [iOSVersion(2)]
        LiteralSearch,

        /// <summary>
        /// Search from end of source string.
        /// </summary>
        [iOSVersion(2)]
        BackwardsSearch,

        /// <summary>
        /// Search is limited to start (or end, if NSBackwardsSearch) of source string.
        /// </summary>
        [iOSVersion(2)]
        AnchoredSearch,

        /// <summary>
        /// Numbers within strings are compared using numeric value, that is, Name2.txt &lt; Name7.txt &lt; Name25.txt.
        /// </summary>
        [iOSVersion(2)]
        NumericSearch,

        /// <summary>
        /// Search ignores diacritic marks.
        /// </summary>
        [iOSVersion(2)]
        DiacriticInsensitiveSearch,

        /// <summary>
        /// Search ignores width differences in characters that have full-width and half-width forms, as occurs in East Asian character sets.
        /// </summary>
        [iOSVersion(2)]
        WidthInsensitiveSearch,

        /// <summary>
        /// Comparisons are forced to return either NSOrderedAscending or NSOrderedDescending if the strings are equivalent but not strictly equal.
        /// </summary>
        [iOSVersion(2)]
        ForcedOrderingSearch,

        /// <summary>
        /// The search string is treated as an ICU-compatible regular expression. If set, no other options can apply except NSCaseInsensitiveSearch and NSAnchoredSearch. You can use this option only with the rangeOfString:... methods and stringByReplacingOccurrencesOfString:withString:options:range:.
        /// </summary>
        [iOSVersion(3.2)]
        RegularExpressionSearch,
    }
    /// <summary>
    /// Options for converting string encodings.
    /// </summary>
    public enum NSStringEncodingConversionOptions
    {
        /// <summary>
        /// Allows lossy conversion.
        /// </summary>
        [iOSVersion(2)]
        AllowLossy,

        /// <summary>
        /// Specifies an external representation (with a byte-order mark, if necessary, to indicate endianness).
        /// </summary>
        [iOSVersion(2)]
        ExternalRepresentation,
    }

    /// <summary>
    /// Constants to specify kinds of substrings and styles of enumeration.
    /// </summary>
    public enum NSStringEnumerationOptions
    {
        /// <summary>
        /// Enumerates by lines. Equivalent to lineRangeForRange:.
        /// </summary>
        [iOSVersion(4)]
        ByLines,

        /// <summary>
        /// Enumerates by paragraphs. Equivalent to paragraphRangeForRange:.
        /// </summary>
        [iOSVersion(4)]
        ByParagraphs,

        /// <summary>
        /// Enumerates by composed character sequences. Equivalent to rangeOfComposedCharacterSequencesForRange:.
        /// </summary>
        [iOSVersion(4)]
        ByComposedCharacterSequences,

        /// <summary>
        /// Enumerates by words.
        /// </summary>
        [iOSVersion(4)]
        ByWords,

        /// <summary>
        /// Enumerates by sentences.
        /// </summary>
        [iOSVersion(4)]
        BySentences,

        /// <summary>
        /// Causes enumeration to occur from the end of the specified range to the start.
        /// </summary>
        [iOSVersion(4)]
        Reverse,

        /// <summary>
        /// A way to indicate that the block does not need substring, in which case nil will be passed. This is simply a performance shortcut.
        /// </summary>
        [iOSVersion(4)]
        SubstringNotRequired,

        /// <summary>
        /// Causes the enumeration to occur using user's default locale. This does not make a difference in line, paragraph, or composed character sequence enumeration, but it may for words or sentences.
        /// </summary>
        [iOSVersion(4)]
        Localized,
    }
}