using SwiftSharp.Attributes;

namespace Foundation
{
    //https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Classes/NSDirectoryEnumerator_Class/index.html#//apple_ref/occ/cl/NSDirectoryEnumerator
    /// <summary>
    /// An NSDirectoryEnumerator object enumerates the contents of a directory, returning the pathnames of all files and directories contained within that directory. These pathnames are relative to the directory.
    /// </summary>
    [iOSVersion(2)]
    class NSDirectoryEnumerator
    {
        /// <summary>
        /// Returns an NSDictionary object that contains the attributes of the directory at which enumeration started.
        /// </summary>
        /// <returns>An NSDictionary object that contains the attributes of the directory at which enumeration started.</returns>
        [iOSVersion(2)]
        [Export("directoryAttributes")]
        public static NSDictionary DirectoryAttributes { get; private set; }

        /// <summary>
        /// Returns an object that contains the attributes of the most recently returned file or subdirectory (as referenced by the pathname).
        /// </summary>
        /// <returns>A dictionary that contains the attributes of the most recently returned file or subdirectory (as referenced by the pathname).</returns>
        [iOSVersion(2)]
        [Export("fileAttributes")]
        public static NSDictionary FileAttributes { get; private set; }

        /// <summary>
        /// Returns the number of levels deep the current object is in the directory hierarchy being enumerated.
        /// </summary>
        /// <returns>The number of levels, with the directory passed to enumeratorAtURL:includingPropertiesForKeys:options:errorHandler: (NSFileManager) considered to be level 0.</returns>
        [iOSVersion(4)]
        [Export("level")]
        public static int Level { get; private set; }

        /// <summary>
        /// Causes the receiver to skip recursion into the most recently obtained subdirectory.
        /// </summary>
        [iOSVersion(2)]
        [Export("skipDescendents")]
        public void SkipDescendents() { }

        /// <summary>
        /// Causes the receiver to skip recursion into the most recently obtained subdirectory.
        /// </summary>
        [iOSVersion(4)]
        [Export("skipDescendants")]
        public void SkipDescendants() { }
    }
}
