using ObjectiveC;
using System;
using SwiftSharp.Attributes;

namespace Foundation
{
    //https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Classes/NSBundle_Class/index.html#//apple_ref/occ/cl/NSBundle
    /// <summary>
    /// An NSBundle object represents a location in the file system that groups code and resources that can be used in a program. NSBundle objects locate program resources, dynamically load and unload executable code, and assist in localization. You build a bundle in Xcode using one of these project types: Application, Framework, plug-ins.
    /// </summary>
    [iOSVersion(2)]
    public class NSBundle : NSObject
    {
        /// <summary>
        /// Returns an NSBundle object initialized to correspond to the specified file URL.
        /// </summary>
        /// <param name="URL">The file URL to a directory. This must be a full URL for a directory; if it contains any symbolic links, they must be resolvable.</param>
        /// <returns>An NSBundle object initialized to correspond to url. This method initializes and returns a new instance only if there is no existing bundle associated with url, otherwise it deallocates self and returns the existing object. If url doesn’t exist or the user doesn’t have access to it, returns nil.</returns>
        [iOSVersion(4)]
        public NSBundle(NSURL URL) { }
        
        /// <summary>
        /// !! IMPORTANT !! Name the parameter you're using!
        /// 
        /// Returns an NSBundle object initialized to correspond to the specified directory or bundle identifier.
        /// </summary>
        /// <param name="path">The path to a directory. This must be a full pathname for a directory; if it contains any symbolic links, they must be resolvable.</param>
        /// <param name="identifier">The identifier for an existing NSBundle instance.</param>
        /// <returns>An NSBundle object initialized to correspond to fullPath. This method initializes and returns a new instance only if there is no existing bundle associated with fullPath, otherwise it deallocates self and returns the existing object. If fullPath doesn’t exist or the user doesn’t have access to it, returns nil.</returns>
        [iOSVersion(2)]
        public NSBundle(string path = "", string identifier = "") { }
        
        /// <summary>
        /// Returns the NSBundle object with which the specified class is associated.
        /// </summary>
        /// <param name="forClass">A class.</param>
        /// <returns>The NSBundle object that dynamically loaded aClass (a loadable bundle), the NSBundle object for the framework in which aClass is defined, or the main bundle object if aClass was not dynamically loaded or is not defined in a framework.</returns>
        [iOSVersion(2)]
        public NSBundle(AnyClass forClass) { }
        
        /// <summary>
        /// Returns the NSBundle object that corresponds to the directory where the current application executable is located.
        /// </summary>
        /// <returns>The NSBundle object that corresponds to the directory where the application executable is located, or nil if a bundle object could not be created.</returns>
        [iOSVersion(2)]
        [Export("mainBundle")]
        public static NSBundle MainBundle() { return null; }
        
        /// <summary>
        /// Returns an array of all the application’s non-framework bundles.
        /// </summary>
        /// <returns>An array of all the application’s non-framework bundles.</returns>
        [iOSVersion(2)]
        [Export("allBundles")]
        public static AnyObject[] AllBundles() { return null; }
        
        /// <summary>
        /// Returns an array of all of the application’s bundles that represent frameworks.
        /// </summary>
        /// <returns>An array of all of the application’s bundles that represent frameworks. Only frameworks with one or more Objective-C classes in them are included.</returns>
        [iOSVersion(2)]
        [Export("allFrameworks")]
        public static AnyObject[] AllFrameworks() { return null; }
        
        /// <summary>
        /// Returns the Class object for the specified name.
        /// </summary>
        /// <param name="className">The name of a class.</param>
        /// <returns>The Class object for className. Returns nil if className is not one of the classes associated with the receiver or if there is an error loading the executable code containing the class implementation.</returns>
        [iOSVersion(2)]
        [Export("classNamed")]
        public AnyClass ClassNamed(string className) { return null; }
        
        /// <summary>
        /// Returns the receiver’s principal class.
        /// </summary>
        /// <returns>The receiver’s principal class—after ensuring that the code containing the definition of that class is dynamically loaded. If the receiver encounters errors in loading or if it can’t find the executable code file in the bundle directory, returns nil.</returns>
        [iOSVersion(2)]
        [Export("principalClass")]
        public AnyClass PrincipalClass { get; private set; }
        
        /// <summary>
        /// Returns the file URL for the resource file identified by the specified name and extension and residing in a given bundle directory.
        /// </summary>
        /// <param name="name">The name of a resource file contained in the directory specified by bundleURL.</param>
        /// <param name="withExtension">If extension is an empty string or nil, the extension is assumed not to exist and the file URL is the first file encountered that exactly matches name.</param>
        /// <param name="subdirectory">The path of a top-level bundle directory. This must be a valid path. For example, to specify the bundle directory for a Mac app, you might specify the path /Applications/MyApp.app.</param>
        /// <returns>The file URL for the resource file or nil if the file could not be located. This method also returns nil if the bundle specified by the bundlePath parameter does not exist or is not a readable directory.</returns>
        [iOSVersion(4)]
        [Export("URLForResource")]
        public NSURL URLForResource(string name, string withExtension, string subdirectory) { return null; }
        
        /// <summary>
        /// Returns the full pathname for the resource file identified by the specified name and extension and residing in a given bundle directory.
        /// </summary>
        /// <param name="name">The name of a resource file contained in the directory specified by bundlePath.</param>
        /// <param name="ofType">If extension is an empty string or nil, the extension is assumed not to exist and the file is the first file encountered that exactly matches name.</param>
        /// <param name="inDirectory">The path of a top-level bundle directory. This must be a valid path. For example, to specify the bundle directory for a Mac app, you might specify the path /Applications/MyApp.app.</param>
        /// <returns>The full pathname for the resource file or nil if the file could not be located. This method also returns nil if the bundle specified by the bundlePath parameter does not exist or is not a readable directory.</returns>
        [iOSVersion(2)]
        [Export("pathForResource")]
        public static string PathForResource(string name, string ofType, string inDirectory) { return ""; }
        
        /// <summary>
        /// Returns the file URL for the resource identified by the specified name and file extension.
        /// </summary>
        /// <param name="name">The name of the resource file.</param>
        /// <param name="withExtension">If extension is an empty string or nil, the extension is assumed not to exist and the file URL is the first file encountered that exactly matches name.</param>
        /// <returns>The file URL for the resource file or nil if the file could not be located.</returns>
        [iOSVersion(4)]
        [Export("URLForResource")]
        public NSURL URLForResource(string name, string withExtension) { return null; }
        
        /// <summary>
        /// Returns the full pathname for the resource identified by the specified name and file extension.
        /// </summary>
        /// <param name="name">The name of the resource file. If name is an empty string or nil, returns the first file encountered of the supplied type.</param>
        /// <param name="ofType">If extension is an empty string or nil, the extension is assumed not to exist and the file is the first file encountered that exactly matches name.</param>
        /// <returns>The full pathname for the resource file or nil if the file could not be located.</returns>
        [iOSVersion(2)]
        [Export("pathForResource")]
        public string PathForResource(string name, string ofType) { return ""; }
        
        /// <summary>
        /// Returns the file URL for the resource identified by the specified name and file extension and located in the specified bundle subdirectory.
        /// </summary>
        /// <param name="extension">If extension is an empty string or nil, the extension is assumed not to exist and the file URL is the first file encountered that exactly matches name.</param>
        /// <param name="subdirectory">The name of the bundle subdirectory.</param>
        /// <returns>The file URL for the resource file or nil if the file could not be located.</returns>
        [iOSVersion(4)]
        [Export("URLsForResourcesWithExtension")]
        public AnyObject[] URLsForResourcesWithExtension(string extension, string subdirectory) { return null; }
        
        /// <summary>
        /// You don't need to use this
        /// 
        /// Returns the full pathname for the resource identified by the specified name and file extension and located in the specified bundle subdirectory.
        /// </summary>
        /// <param name="name">The name of the resource file.</param>
        /// <param name="ofType">If extension is an empty string or nil, all the files in subpath and its subdirectories are returned. If an extension is provided the subdirectories are not searched.</param>
        /// <param name="inDirectory">The name of the bundle subdirectory. Can be nil.</param>
        /// <returns>An array of full pathnames for the subpath or nil if no files are located.</returns>
        [iOSVersion(2)]
        [Export("pathForResource")]
        public string PathForResourceInstance(string name, string ofType, string inDirectory) { return ""; }
        
        /// <summary>
        /// Returns the file URL for the resource identified by the specified name and file extension, located in the specified bundle subdirectory, and limited to global resources and those associated with the specified localization.
        /// </summary>
        /// <param name="name">The name of the resource file.</param>
        /// <param name="withExtension">If extension is an empty string or nil, the extension is assumed not to exist and the file URL is the first file encountered that exactly matches name.</param>
        /// <param name="subdirectory">The name of the bundle subdirectory to search.</param>
        /// <param name="localization">The language ID for the localization. This parameter should correspond to the name of one of the bundle's language-specific resource directories without the .lproj extension.</param>
        /// <returns>The file URL for the resource file or nil if the file could not be located.</returns>
        [iOSVersion(4)]
        [Export("URLForResource")]
        public NSURL URLForResource(string name, string withExtension, string subdirectory, string localization) { return null; }
        
        /// <summary>
        /// Returns the full pathname for the resource identified by the specified name and file extension, located in the specified bundle subdirectory, and limited to global resources and those associated with the specified localization.
        /// </summary>
        /// <param name="name">The name of the resource file.</param>
        /// <param name="ofType">If extension is an empty string or nil, the extension is assumed not to exist and the file is the first file encountered that exactly matches name.</param>
        /// <param name="inDirectory">The name of the bundle subdirectory to search.</param>
        /// <param name="forLocalization">The language ID for of the localization. This parameter should correspond to the name of one of the bundle's language-specific resource directories without the .lproj extension.</param>
        /// <returns>The full pathname for the resource file or nil if the file could not be located.</returns>
        [iOSVersion(2)]
        [Export("pathForResource")]
        public string PathForResource(string name, string ofType, string inDirectory, string forLocalization) { return ""; }
        
        /// <summary>
        /// Returns an array containing the pathnames for all bundle resources having the specified extension and residing in the bundle directory at the specified path.
        /// </summary>
        /// <param name="extension">The file extension. If extension is an empty string or nil, the extension is assumed not to exist, all the files in bundlePath are returned.</param>
        /// <param name="inDirectory">The top-level directory of a bundle. This must represent a valid path.</param>
        /// <returns>An array containing the full pathnames for all bundle resources with the specified extension. This method returns an empty array if no matching resource files are found. It also returns an empty array if the bundle specified by the bundlePath parameter does not exist or is not a readable directory.</returns>
        [iOSVersion(2)]
        [Export("pathsForResourcesOfType")]
        public static AnyObject[] PathsForResourcesOfType(string extension, string inDirectory) { return null; }
        
        /// <summary>
        /// You don't need to use this
        /// 
        /// Returns an array containing the pathnames for all bundle resources having the specified filename extension and residing in the resource subdirectory.
        /// </summary>
        /// <param name="extension">The file extension. If extension is an empty string or nil, the extension is assumed not to exist, all the files in subpath are returned.</param>
        /// <param name="inDirectory">The name of the bundle subdirectory to search.</param>
        /// <returns>An array containing the full pathnames for all bundle resources matching the specified criteria. This method returns an empty array if no matching resource files are found.</returns>
        [iOSVersion(2)]
        [Export("pathsForResourcesOfType")]
        public AnyObject[] PathsForResourcesOfTypeInstance(string extension, string inDirectory) { return null; }
        
        /// <summary>
        /// Returns an array containing the file URLs for all bundle resources having the specified filename extension, residing in the specified resource subdirectory, and limited to global resources and those associated with the specified localization.
        /// </summary>
        /// <param name="ext">The file extension of the files to retrieve.</param>
        /// <param name="subdirectory">The name of the bundle subdirectory to search.</param>
        /// <param name="localization">The language ID for the localization. This parameter should correspond to the name of one of the bundle's language-specific resource directories without the .lproj extension.</param>
        /// <returns>An array containing the file URLs for all bundle resources matching the specified criteria. This method returns an empty array if no matching resource files are found.</returns>
        [iOSVersion(4)]
        [Export("URLsForResourcesWithExtension")]
        public AnyObject[] URLsForResourcesWithExtension(string ext, string subdirectory, string localization) { return null; }
        
        /// <summary>
        /// Returns an array containing the file for all bundle resources having the specified filename extension, residing in the specified resource subdirectory, and limited to global resources and those associated with the specified localization.
        /// </summary>
        /// <param name="extension">The file extension of the files to retrieve.</param>
        /// <param name="inDirectory">The name of the bundle subdirectory to search.</param>
        /// <param name="forLocalization">The language ID for the localization. This parameter should correspond to the name of one of the bundle's language-specific resource directories without the .lproj extension.</param>
        /// <returns>An array containing the full pathnames for all bundle resources matching the specified criteria. This method returns an empty array if no matching resource files are found.</returns>
        [iOSVersion(2)]
        [Export("pathsForResourcesOfType")]
        public AnyObject[] PathsForResourcesOfType(string extension, string inDirectory, string forLocalization) { return null; }
        
        /// <summary>
        /// Creates and returns a file URL for the resource with the specified name and extension in the specified bundle.
        /// </summary>
        /// <param name="name">The name of the resource file.</param>
        /// <param name="withExtension">If extension is an empty string or nil, the extension is assumed not to exist and the file URL is the first file encountered that exactly matches name.</param>
        /// <param name="subdirectory">The name of the bundle subdirectory to search.</param>
        /// <param name="inBundleWithURL">The file URL of the bundle to search.</param>
        /// <returns>The file URL for the resource file or nil if the file could not be located.</returns>
        [iOSVersion(4)]
        [Export("URLForResource")]
        public static NSURL URLForResource(string name, string withExtension, string subdirectory, NSURL inBundleWithURL) { return null; }
        
        /// <summary>
        /// Returns an array containing the file URLs for all bundle resources having the specified filename extension, residing in the specified resource subdirectory, within the specified bundle.
        /// </summary>
        /// <param name="ext">The file extension of the files to retrieve.</param>
        /// <param name="subdirectory">The name of the bundle subdirectory to search.</param>
        /// <param name="inBundleWithURL">The file URL of the bundle to search.</param>
        /// <returns>The file URL for the resource file or nil if the file could not be located.</returns>
        [iOSVersion(4)]
        [Export("URLsForResourcesWithExtension")]
        public static AnyObject[] URLsForResourcesWithExtension(string ext, string subdirectory, NSURL inBundleWithURL) { return null; }
        
        /// <summary>
        /// Returns the full pathname of the receiving bundle’s subdirectory containing resources.
        /// </summary>
        /// <returns>The full pathname of the receiving bundle’s subdirectory containing resources.</returns>
        [iOSVersion(2)]
        [Export("resourcePath")]
        public string ResourcePath { get; private set; }
        
        /// <summary>
        /// Returns the file URL for the bundle’s App Store receipt.
        /// </summary>
        /// <returns>The file URL for the bundle’s App Store receipt.</returns>
        [iOSVersion(7)]
        [Export("appStoreReceiptURL")]
        public NSURL AppStoreReceiptURL { get; private set; }
        
        /// <summary>
        /// Returns the full URL of the receiver’s bundle directory.
        /// </summary>
        /// <returns>The full URL of the receiver’s bundle directory.</returns>
        [iOSVersion(4)]
        [Export("bundleURL")]
        public NSURL BundleURL { get; private set; }
        
        /// <summary>
        /// Returns the full pathname of the receiver’s bundle directory.
        /// </summary>
        /// <returns>The full pathname of the receiver’s bundle directory.</returns>
        [iOSVersion(2)]
        [Export("bundlePath")]
        public string BundlePath { get; private set; }
        
        /// <summary>
        /// Returns the receiver’s bundle identifier.
        /// </summary>
        /// <returns>The receiver’s bundle identifier, which is defined by the CFBundleIdentifier key in the bundle’s information property list.</returns>
        [iOSVersion(2)]
        [Export("bundleIdentifier")]
        public string BundleIdentifier { get; private set; }
        
        /// <summary>
        /// Returns a dictionary that contains information about the receiver.
        /// </summary>
        /// <returns>A dictionary, constructed from the bundle's Info.plist file, that contains information about the receiver. If the bundle does not contain an Info.plist file, a valid dictionary is returned but this dictionary contains only private keys that are used internally by the NSBundle class. The NSBundle class may add extra keys to this dictionary for its own use.</returns>
        [iOSVersion(2)]
        [Export("infoDictionary")]
        public NSDictionary InfoDictionary { get; private set; }
        
        /// <summary>
        /// Returns the value associated with the specified key in the receiver's information property list.
        /// </summary>
        /// <param name="key">A key in the receiver's property list.</param>
        /// <returns>The value associated with key in the receiver's property list (Info.plist). The localized value of a key is returned when one is available.</returns>
        [iOSVersion(2)]
        [Export("objectForInfoDictionaryKey")]
        public AnyObject ObjectForInfoDictionaryKey(string key) { return null; }
        
        /// <summary>
        /// Returns the file URL of the receiver's subdirectory containing plug-ins.
        /// </summary>
        /// <returns>The file URL of the receiving bundle’s subdirectory containing plug-ins.</returns>
        [iOSVersion(4)]
        [Export("builtInPlugInsURL")]
        public NSURL BuiltInPlugInsURL { get; private set; }
        
        /// <summary>
        /// Returns the full pathname of the receiver's subdirectory containing plug-ins.
        /// </summary>
        /// <returns>The full pathname of the receiving bundle’s subdirectory containing plug-ins.</returns>
        [iOSVersion(2)]
        [Export("builtInPlugInsPath")]
        public string BuiltInPlugInsPath { get; private set; }
        
        /// <summary>
        /// Returns the file URL of the receiver's executable file.
        /// </summary>
        /// <returns>The file URL of the receiving bundle’s executable file.</returns>
        [iOSVersion(4)]
        [Export("executableURL")]
        public NSURL ExecutableURL { get; private set; }
        
        /// <summary>
        /// Returns the full pathname of the receiver's executable file.
        /// </summary>
        /// <returns>The full pathname of the receiving bundle’s executable file.</returns>
        [iOSVersion(2)]
        [Export("executablePath")]
        public string ExecutablePath { get; private set; }
        
        /// <summary>
        /// Returns the file URL of the executable with the specified name in the receiver’s bundle.
        /// </summary>
        /// <param name="executableName">The name of an executable file.</param>
        /// <returns>The file URL of the executable executableName in the receiver’s bundle.</returns>
        [iOSVersion(4)]
        [Export("URLForAuxiliaryExecutable")]
        public NSURL URLForAuxiliaryExecutable(string executableName) { return null; }
        
        /// <summary>
        /// Returns the full pathname of the executable with the specified name in the receiver’s bundle.
        /// </summary>
        /// <param name="executableName">The name of an executable file.</param>
        /// <returns>The full pathname of the executable executableName in the receiver’s bundle.</returns>
        [iOSVersion(2)]
        [Export("pathForAuxiliaryExecutable")]
        public string PathForAuxiliaryExecutable(string executableName) { return ""; }
        
        /// <summary>
        /// Returns the file URL of the receiver's subdirectory containing private frameworks.
        /// </summary>
        /// <returns>The file URL of the receiver's subdirectory containing private frameworks.</returns>
        [iOSVersion(4)]
        [Export("privateFrameworksURL")]
        public NSURL PrivateFrameworksURL { get; private set; }
        
        /// <summary>
        /// Returns the full pathname of the receiver's subdirectory containing private frameworks.
        /// </summary>
        /// <returns>The full pathname of the receiver's subdirectory containing private frameworks.</returns>
        [iOSVersion(2)]
        [Export("privateFrameworksPath")]
        public string PrivateFrameworksPath { get; private set; }
        
        /// <summary>
        /// Returns the file URL of the receiver's subdirectory containing shared frameworks.
        /// </summary>
        /// <returns>The file URL of the receiver's subdirectory containing shared frameworks.</returns>
        [iOSVersion(4)]
        [Export("sharedFrameworksURL")]
        public NSURL SharedFrameworksURL { get; private set; }
        
        /// <summary>
        /// Returns the full pathname of the receiver's subdirectory containing shared frameworks.
        /// </summary>
        /// <returns>The full pathname of the receiver's subdirectory containing shared frameworks.</returns>
        [iOSVersion(2)]
        [Export("sharedFrameworksPath")]
        public string SharedFrameworksPath { get; private set; }
        
        /// <summary>
        /// Returns the file URL of the receiver's subdirectory containing shared support files.
        /// </summary>
        /// <returns>The file URL of the receiver's subdirectory containing shared support files.</returns>
        [iOSVersion(4)]
        [Export("sharedSupportURL")]
        public NSURL SharedSupportURL { get; private set; }
        
        /// <summary>
        /// Returns the full pathname of the receiver's subdirectory containing shared support files.
        /// </summary>
        /// <returns>The full pathname of the receiver's subdirectory containing shared support files.</returns>
        [iOSVersion(2)]
        [Export("sharedSupportPath")]
        public string SharedSupportPath { get; private set; }
        
        /// <summary>
        /// Returns the file URL of the receiver's subdirectory containing resource files.
        /// </summary>
        /// <returns>The file URL of the receiver's subdirectory containing resource files.</returns>
        [iOSVersion(4)]
        [Export("resourceURL")]
        public NSURL ResourceURL { get; private set; }
        
        /// <summary>
        /// Returns a localized version of the string designated by the specified key and residing in the specified table.
        /// </summary>
        /// <param name="key">The key for a string in the table identified by tableName.</param>
        /// <param name="value">The value to return if key is nil or if a localized string for key can’t be found in the table.</param>
        /// <param name="table">The receiver’s string table to search. If tableName is nil or is an empty string, the method attempts to use the table in Localizable.strings.</param>
        /// <returns>A localized version of the string designated by key in table tableName. If value is nil or an empty string, and a localized string is not found in the table, returns key. If key and value are both nil, returns the empty string.</returns>
        [iOSVersion(2)]
        [Export("localizedStringForKey")]
        public string LocalizedStringForKey(string key, string value, string table) { return ""; }
        
        /// <summary>
        /// Returns an array of numbers indicating the architecture types supported by the bundle’s executable.
        /// </summary>
        /// <returns>An array of NSNumber objects, each of which contains an integer value corresponding to a supported processor architecture. For a list of common architecture types, see the constants in Mach-O Architecture. If the bundle does not contain a Mach-O executable, this method returns nil.</returns>
        [iOSVersion(2)]
        [Export("executableArchitectures")]
        public AnyObject[] ExecutableArchitectures { get; private set; }
        
        /// <summary>
        /// Returns a Boolean value indicating whether the bundle’s executable code could be loaded successfully.
        /// </summary>
        /// <param name="error">On input, a pointer to an error object variable. On output, this variable may contain an error object indicating why the bundle’s executable could not be loaded. If no error would occur, this parameter is left unmodified. You may specify nil for this parameter if you are not interested in the error information.</param>
        /// <returns>true if the bundle’s executable code could be loaded successfully or is already loaded; otherwise, false if the code could not be loaded.</returns>
        [iOSVersion(2)]
        [Export("preflightAndReturnError")]
        public bool PreflightAndReturnError(NSErrorPointer error) { return false; }
        
        /// <summary>
        /// Dynamically loads the bundle’s executable code into a running program, if the code has not already been loaded.
        /// </summary>
        /// <returns>true if the method successfully loads the bundle’s code or if the code has already been loaded, otherwise false.</returns>
        [iOSVersion(2)]
        [Export("load")]
        public bool Load() { return false; }
        
        /// <summary>
        /// Loads the bundle’s executable code and returns any errors.
        /// </summary>
        /// <param name="error">On input, a pointer to an error object variable. On output, this variable may contain an error object indicating why the bundle’s executable could not be loaded. If no error occurred, this parameter is left unmodified. You may specify nil for this parameter if you are not interested in the error information.</param>
        /// <returns>true if the bundle’s executable code was loaded successfully or was already loaded; otherwise, false if the code could not be loaded.</returns>
        [iOSVersion(2)]
        [Export("loadAndReturnError")]
        public bool LoadAndReturnError(NSErrorPointer error) { return false; }
        
        /// <summary>
        /// Unloads the code associated with the receiver.
        /// </summary>
        /// <returns>true if the bundle was successfully unloaded or was not already loaded; otherwise, false if the bundle could not be unloaded.</returns>
        [iOSVersion(2)]
        [Export("unload")]
        public bool Unload() { return false; }
        
        /// <summary>
        /// Returns one or more localizations from the specified list that a bundle object would use to locate resources for the current user.
        /// </summary>
        /// <param name="localizationsArray">An array of NSString objects, each of which specifies the language ID for a localization that the bundle supports.</param>
        /// <returns>An array of NSString objects containing the preferred localizations. These strings are ordered in the array according to the user's language preferences and are taken from the strings in the localizationsArray parameter.</returns>
        [iOSVersion(2)]
        [Export("preferredLocalizationsFromArray")]
        public static AnyObject[] PreferredLocalizationsFromArray(AnyObject[] localizationsArray) { return null; }
        
        /// <summary>
        /// Returns the localizations that a bundle object would prefer, given the specified bundle and user’s language preferences.
        /// </summary>
        /// <param name="localizationsArray">An array of NSString objects, each of which specifies the language ID for a localization that the bundle supports.</param>
        /// <param name="forPreferences">An array of NSString objects containing the user's preferred localizations. If this parameter is nil, the method uses the user's localization preferences.</param>
        /// <returns>An array of NSString objects, each of which identifies a localization in the receiver’s bundle. These strings are ordered in the array according to the specified preferences and are taken from the strings in the localizationsArray parameter. If none of the user-preferred localizations are available in the bundle, this method returns one of the bundle localizations.</returns>
        [iOSVersion(2)]
        [Export("preferredLocalizationsFromArray")]
        public static AnyObject[] PreferredLocalizationsFromArray(AnyObject[] localizationsArray, AnyObject[] forPreferences) { return null; }
        
        /// <summary>
        /// Returns an ordered list of preferred localizations contained in the receiver’s bundle.
        /// </summary>
        /// <returns>An array of NSString objects containing language IDs for localizations in the receiver’s bundle. The strings are ordered according to the user's language preferences and available localizations.</returns>
        [iOSVersion(2)]
        [Export("preferredLocalizations")]
        public AnyObject[] PreferredLocalizations { get; private set; }
        
        /// <summary>
        /// Returns the localization for the development language.
        /// </summary>
        /// <returns>The language ID for the development language.</returns>
        [iOSVersion(2)]
        [Export("developmentLocalization")]
        public string DevelopmentLocalization { get; private set; }
        
        /// <summary>
        /// Returns a list of all the localizations contained in the receiver’s bundle.
        /// </summary>
        /// <returns>An array of NSString objects containing language IDs for all the localizations contained within the receiver’s bundle.</returns>
        [iOSVersion(2)]
        [Export("localizations")]
        public AnyObject[] Localizations { get; private set; }
        
        /// <summary>
        /// Returns a dictionary with the keys from the bundle’s localized property list.
        /// </summary>
        /// <returns>A dictionary with the keys from the bundle’s localized property list (InfoPlist.strings).</returns>
        [iOSVersion(2)]
        [Export("localizedInfoDictionary")]
        public NSDictionary LocalizedInfoDictionary { get; private set; }
        
        /// <summary>
        /// These constants describe the CPU types that a bundle’s executable code may support.
        /// </summary>
        
        /// <summary>
        /// Specifies the 32-bit intel architecture.
        /// </summary>
        [iOSVersion(2)]
        public int NSBundleExecutableArchitectureI386 { get; private set; }
        
        /// <summary>
        /// Specifies the 32-bit PowerPC architecture.
        /// </summary>
        [iOSVersion(2)]
        public int NSBundleExecutableArchitecturePPC { get; private set; }
        
        /// <summary>
        /// Specifies the 64-bit intel architecture.
        /// </summary>
        [iOSVersion(2)]
        public int NSBundleExecutableArchitectureX86_64 { get; private set; }
        
        /// <summary>
        /// Specifies the 64-bit PowerPC architecture.
        /// </summary>
        [iOSVersion(2)]
        public int NSBundleExecutableArchitecturePPC64 { get; private set; }
        
        /// <summary>
        /// This constant is provided in the userInfo dictionary of the NSBundleDidLoadNotification notification.
        /// </summary>
        [Export("NSLoadedClasses")]
        public string NSLoadedClasses { get; private set; }

        /// <summary>
        /// posts NSBundleclassNamed:principalClassNSBundleDidLoadNotification
        /// The notification object is the NSBundle instance that dynamically loads classes. The userInfo dictionary contains an NSLoadedClasses key.
        /// In a typical use of this notification, an object might want to enumerate the userInfo array to check if each loaded class conformed to a certain protocol (say, an protocol for a plug-and-play tool set); if a class does conform, the object would create an instance of that class and add the instance to another NSArray object.
        /// </summary>
        [iOSVersion(2)]
        public class NSBundleDidLoadNotification : NSNotification
        {
            public NSBundleDidLoadNotification() : base("", null) { }
        }
    }
}