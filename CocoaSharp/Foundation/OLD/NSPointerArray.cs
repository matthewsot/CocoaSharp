using ObjectiveC;
using System;
using SwiftSharp.Attributes;

namespace Foundation
{
    //https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Classes/NSPointerArray_Class/index.html#//apple_ref/occ/cl/NSPointerArray
    /// <summary>
    /// NSPointerArray is a mutable collection modeled after NSArray but it can also hold NULL values, which can be inserted or extracted (and which contribute to the object’s count). Moreover, unlike traditional arrays, you can set the count of the array directly. In a garbage collected environment, if you specify a zeroing weak memory configuration, if an element is collected it is replaced by a NULL value.
    /// </summary>
    [iOSVersion(6)]
    public class NSPointerArray : NSObject
    {
        /// <summary>
        /// Initializes the receiver to use the given options.
        /// </summary>
        /// <param name="options">The pointer functions options for the new instance.</param>
        /// <returns>The receiver, initialized to use the given options.</returns>
        [iOSVersion(6)]
        public NSPointerArray(NSPointerFunctionsOptions options) { }
        
        /// <summary>
        /// Initializes the receiver to use the given functions.
        /// </summary>
        /// <param name="pointerFunctions">The pointer functions for the new instance.</param>
        /// <returns>The receiver, initialized to use the given functions.</returns>
        [iOSVersion(6)]
        public NSPointerArray(NSPointerFunctions pointerFunctions) { }
        
        /// <summary>
        /// Returns a new pointer array initialized to use the given options.
        /// </summary>
        /// <param name="options">The pointer functions options for the new instance.</param>
        /// <returns>A new pointer array initialized to use the given options.</returns>
        [iOSVersion(6)]
        [Export("pointerArrayWithOptions")]
        public static NSPointerArray PointerArrayWithOptions(NSPointerFunctionsOptions options) { return null; }
        
        /// <summary>
        /// A new pointer array initialized to use the given functions.
        /// </summary>
        /// <param name="functions">The pointer functions for the new instance.</param>
        /// <returns>A new pointer array initialized to use the given pointer functions.</returns>
        [iOSVersion(6)]
        [Export("pointerArrayWithPointerFunctions")]
        public static NSPointerArray PointerArrayWithPointerFunctions(NSPointerFunctions functions) { return null; }
        
        /// <summary>
        /// Returns a new pointer array that maintains strong references to its elements.
        /// </summary>
        /// <returns>A new pointer array that maintains strong references to its elements.</returns>
        [iOSVersion(6)]
        [Export("strongObjectsPointerArray")]
        public static NSPointerArray StrongObjectsPointerArray() { return null; }
        
        /// <summary>
        /// Returns a new pointer array that maintains weak references to its elements.
        /// </summary>
        /// <returns>A new pointer array that maintains weak references to its elements.</returns>
        [iOSVersion(6)]
        [Export("weakObjectsPointerArray")]
        public static NSPointerArray WeakObjectsPointerArray() { return null; }
        
        /// <summary>
        /// Returns the number of elements in the receiver.
        /// </summary>
        /// <returns>The number of elements in the receiver.</returns>
        [iOSVersion(6)]
        [Export("count")]
        public int Count { get; set; }
        
        /// <summary>
        /// Returns an array containing all the objects in the receiver.
        /// </summary>
        /// <returns>An array containing all the objects in the receiver.</returns>
        [iOSVersion(6)]
        [Export("allObjects")]
        public AnyObject[] AllObjects { get; private set; }
        
        /// <summary>
        /// Returns the pointer at a given index.
        /// </summary>
        /// <param name="index">The index of an element in the receiver. This value must be less than the count of the receiver.</param>
        /// <returns>The pointer at index.</returns>
        [iOSVersion(6)]
        [Export("pointerAtIndex")]
        public COpaquePointer PointerAtIndex(int index) { return null; }
        
        /// <summary>
        /// Adds a given pointer to the receiver.
        /// </summary>
        /// <param name="pointer">The pointer to add. This value may be NULL.</param>
        [iOSVersion(6)]
        [Export("addPointer")]
        public void AddPointer(CMutableVoidPointer pointer) { }
        
        /// <summary>
        /// Removes the pointer at a given index.
        /// </summary>
        /// <param name="index">The index of an element in the receiver. This value must be less than the count of the receiver.</param>
        [iOSVersion(6)]
        [Export("removePointerAtIndex")]
        public void RemovePointerAtIndex(int index) { }
        
        /// <summary>
        /// Inserts a pointer at a given index.
        /// </summary>
        /// <param name="item">The pointer to add.</param>
        /// <param name="atIndex">The index of an element in the receiver. This value must be less than the count of the receiver.</param>
        [iOSVersion(6)]
        [Export("insertPointer")]
        public void InsertPointer(CMutableVoidPointer item, int atIndex) { }
        
        /// <summary>
        /// Replaces the pointer at a given index.
        /// </summary>
        /// <param name="index">The index of an element in the receiver. This value must be less than the count of the receiver.</param>
        /// <param name="withPointer">The item with which to replace the element at index. This value may be NULL.</param>
        [iOSVersion(6)]
        [Export("replacePointerAtIndex")]
        public void ReplacePointerAtIndex(int index, CMutableVoidPointer withPointer) { }
        
        /// <summary>
        /// Removes NULL values from the receiver.
        /// </summary>
        [iOSVersion(6)]
        [Export("compact")]
        public void Compact() { }
        
        /// <summary>
        /// Returns a new NSPointerFunctions object reflecting the functions in use by the receiver.
        /// </summary>
        /// <returns>A new NSPointerFunctions object reflecting the functions in use by the receiver.</returns>
        [iOSVersion(6)]
        [Export("pointerFunctions")]
        public NSPointerFunctions PointerFunctions { get; private set; }
    }
}