using ObjectiveC;
using SwiftSharp.Attributes;

namespace Foundation
{
    //https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Classes/NSEnumerator_Class/index.html#//apple_ref/occ/cl/NSEnumerator
    /// <summary>
    /// NSEnumerator is an abstract class, instances of whose subclasses enumerate collections of other objects, such as arrays and dictionaries.
    /// </summary>
    [iOSVersion(2)]
    public class NSEnumerator
    {
        /// <summary>
        /// Returns an array of objects the receiver has yet to enumerate.
        /// </summary>
        /// <returns>An array of objects the receiver has yet to enumerate.</returns>
        [iOSVersion(2)]
        [Export("allObjects")]
        public static AnyObject[] AllObjects { get; private set; }

        /// <summary>
        /// Returns the next object from the collection being enumerated.
        /// </summary>
        /// <returns>The next object from the collection being enumerated, or nil when all objects have been enumerated.</returns>
        [iOSVersion(2)]
        [Export("nextObject")]
        public AnyObject NextObject() { return null; }
    }
}
