using ObjectiveC;using System;using SharpSwift.Attributes;using System.Collections.Generic;namespace Foundation{    /// <summary>    /// The NSOrthography class describes the linguistic content of a piece of text, typically used for the purposes of spelling and grammar checking.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/NSOrthography_Class/index.html#//apple_ref/occ/cl/NSOrthography"/>    [iOSVersion(4)]    public class NSOrthography : NSObject//, AnyObject, NSCoding, NSCopying, NSObjectProtocol    {        /// <summary>        /// Creates and returns an orthography instance with the specified dominant script and language map.        /// </summary>        /// <param name="dominantScript">The dominant script.</param>        /// <param name="languageMap">A dictionary containing the language map.</param>        [iOSVersion(4)]        public NSOrthography(string dominantScript, Dictionary<NSObject, AnyObject> languageMap) { }                /// <summary>        /// Returns the list of languages for the specified script.        /// </summary>        /// <param name="script">The script.</param>        [iOSVersion(4)]        [Export("languagesForScript")]        public AnyObject[] LanguagesForScript(string script) { return default(AnyObject[]); }                /// <summary>        /// Returns the dominant language for the specified script.        /// </summary>        /// <param name="script">The script.</param>        [iOSVersion(4)]        [Export("dominantLanguageForScript")]        public string DominantLanguageForScript(string script) { return default(string); }                /// <summary>        /// The dominant script for the text. (read-only)        /// </summary>        [iOSVersion(4)]        [Export("dominantScript")]        public string DominantScript { get; private set; }                /// <summary>        /// A dictionary that map script tags to arrays of language tags. (read-only)        /// </summary>        [iOSVersion(4)]        [Export("languageMap")]        public Dictionary<NSObject, AnyObject> LanguageMap { get; private set; }                /// <summary>        /// Returns an array containing all the languages appearing in the values of the language map. (read-only)        /// </summary>        [iOSVersion(4)]        [Export("allLanguages")]        public AnyObject[] AllLanguages { get; private set; }                /// <summary>        /// Returns an array containing all the scripts appearing as keys in the language map. (read-only)        /// </summary>        [iOSVersion(4)]        [Export("allScripts")]        public AnyObject[] AllScripts { get; private set; }                /// <summary>        /// Returns the first language in the list of languages for the dominant script. (read-only)        /// </summary>        [iOSVersion(4)]        [Export("dominantLanguage")]        public string DominantLanguage { get; private set; }    }}