using ObjectiveC;
using System;
using SharpSwift.Attributes;
using System.Collections.Generic;
using Foundation;

namespace ObjectiveC
{
    /// <summary>
    /// NSObject is the root class of most Objective-C class hierarchies. Through NSObject, objects inherit a basic interface to the runtime system and the ability to behave as Objective-C objects.
    /// </summary>
    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Classes/NSObject_Class/index.html#//apple_ref/occ/cl/NSObject"/>
    [iOSVersion(2)]
    [Export("")]
    public class NSObject//: AnyObject, CVarArgType, Equatable, Hashable, NSObjectProtocol, Printable
    {
        /// <summary>
        /// Initializes the class before it receives its first message.
        /// </summary>
        [iOSVersion(2)]
        [Export("initialize")]
        public static void Initialize() {  }
        
        /// <summary>
        /// Invoked whenever a class or category is added to the Objective-C runtime; implement this method to perform class-specific behavior upon loading.
        /// </summary>
        [iOSVersion(2)]
        [Export("load")]
        public static void Load() {  }
        
        /// <summary>
        /// Returns a new instance of the receiving class.
        /// </summary>
        [iOSVersion(2)]
        [Export("alloc")]
        [return:Unwrapped]
        public static NSObject Alloc() { return default(NSObject); }
        
        /// <summary>
        /// Returns a new instance of the receiving class.
        /// </summary>
        /// <param name="zone">This parameter is ignored.</param>
        [iOSVersion(2)]
        [Export("allocWithZone")]
        [return:Unwrapped]
        public static NSObject AllocWithZone(NSZone zone) { return default(NSObject); }
        
        /// <summary>
        /// Implemented by subclasses to initialize a new object (the receiver) immediately after memory for it has been allocated.
        /// </summary>
        [iOSVersion(2)]
        public NSObject() { }
        
        /// <summary>
        /// Returns the object returned by copyWithZone:.
        /// </summary>
        [iOSVersion(2)]
        [Export("copy")]
        public virtual AnyObject Copy() { return default(AnyObject); }
        
        /// <summary>
        /// Returns the object returned by mutableCopyWithZone: where the zone is nil.
        /// </summary>
        [iOSVersion(2)]
        [Export("mutableCopy")]
        public virtual AnyObject MutableCopy() { return default(AnyObject); }
        
        /// <summary>
        /// Allocates a new instance of the receiving class, sends it an init message, and returns the initialized object.
        /// </summary>
        [iOSVersion(2)]
        [Export("new")]
        [return:Unwrapped]
        public static NSObject New() { return default(NSObject); }
        
        /// <summary>
        /// Returns the class object for the receiver’s superclass.
        /// </summary>
        [iOSVersion(2)]
        [Export("superclass")]
        [return:Optional]
        public static AnyClass Superclass() { return default(AnyClass); }
        
        /// <summary>
        /// Returns a Boolean value that indicates whether the receiving class is a subclass of, or identical to, a given class.
        /// </summary>
        /// <param name="aClass">A class object.</param>
        [iOSVersion(2)]
        [Export("isSubclassOfClass")]
        public static bool IsSubclassOfClass(AnyClass aClass) { return default(bool); }
        
        /// <summary>
        /// Returns a Boolean value that indicates whether instances of the receiver are capable of responding to a given selector.
        /// </summary>
        /// <param name="aSelector">A selector.</param>
        [iOSVersion(2)]
        [Export("instancesRespondToSelector")]
        public static bool InstancesRespondToSelector(Selector aSelector) { return default(bool); }
        
        /// <summary>
        /// Returns a Boolean value that indicates whether the receiver conforms to a given protocol.
        /// </summary>
        /// <param name="aProtocol"></param>
        [iOSVersion(2)]
        [Export("conformsToProtocol")]
        public static bool ConformsToProtocol(Protocol aProtocol) { return default(bool); }
        
        /// <summary>
        /// Locates and returns the address of the receiver’s implementation of a method so it can be called as a function.
        /// </summary>
        /// <param name="aSelector">A selector that identifies the method for which to return the implementation address. The selector must be a valid and non-NULL. If in doubt, use the respondsToSelector: method to check before passing the selector to methodForSelector:.</param>
        [iOSVersion(2)]
        [Export("methodForSelector")]
        public virtual IMP MethodForSelector(Selector aSelector) { return default(IMP); }
        
        /// <summary>
        /// Locates and returns the address of the implementation of the instance method identified by a given selector.
        /// </summary>
        /// <param name="aSelector">A selector that identifies the method for which to return the implementation address. The selector must be non-NULL and valid for the receiver. If in doubt, use the respondsToSelector: method to check before passing the selector to methodForSelector:.</param>
        [iOSVersion(2)]
        [Export("instanceMethodForSelector")]
        public static IMP InstanceMethodForSelector(Selector aSelector) { return default(IMP); }
        
        /// <summary>
        /// Returns a string that represents the contents of the receiving class.
        /// </summary>
        [iOSVersion(2)]
        [Export("description")]
        public static string Description() { return default(string); }
        
        /// <summary>
        /// Cancels perform requests previously registered with the performSelector:withObject:afterDelay: instance method.
        /// </summary>
        /// <param name="aTarget">The target for requests previously registered with the performSelector:withObject:afterDelay: instance method.</param>
        [iOSVersion(2)]
        [Export("cancelPreviousPerformRequestsWithTarget")]
        public static void CancelPreviousPerformRequestsWithTarget(AnyObject aTarget) {  }
        
        /// <summary>
        /// Cancels perform requests previously registered with performSelector:withObject:afterDelay:.
        /// </summary>
        /// <param name="aTarget">The target for requests previously registered with the performSelector:withObject:afterDelay: instance method</param>
        /// <param name="selector">The selector for requests previously registered with the performSelector:withObject:afterDelay: instance method.</param>
        /// <param name="@object">The argument for requests previously registered with the performSelector:withObject:afterDelay: instance method. Argument equality is determined using isEqual:, so the value need not be the same object that was passed originally. Pass nil to match a request for nil that was originally passed as the argument.</param>
        [iOSVersion(2)]
        [Export("cancelPreviousPerformRequestsWithTarget")]
        public static void CancelPreviousPerformRequestsWithTarget(AnyObject aTarget, Selector selector, [Optional] AnyObject @object) {  }
        
        /// <summary>
        /// Returns the object to which unrecognized messages should first be directed.
        /// </summary>
        /// <param name="aSelector">A selector for a method that the receiver does not implement.</param>
        [iOSVersion(2)]
        [Export("forwardingTargetForSelector")]
        [return:Optional]
        public virtual AnyObject ForwardingTargetForSelector(Selector aSelector) { return default(AnyObject); }
        
        /// <summary>
        /// Dynamically provides an implementation for a given selector for a class method.
        /// </summary>
        /// <param name="name">The name of a selector to resolve.</param>
        [iOSVersion(2)]
        [Export("resolveClassMethod")]
        public static bool ResolveClassMethod(Selector name) { return default(bool); }
        
        /// <summary>
        /// Dynamically provides an implementation for a given selector for an instance method.
        /// </summary>
        /// <param name="name">The name of a selector to resolve.</param>
        [iOSVersion(2)]
        [Export("resolveInstanceMethod")]
        public static bool ResolveInstanceMethod(Selector name) { return default(bool); }
        
        /// <summary>
        /// Handles messages the receiver doesn’t recognize.
        /// </summary>
        /// <param name="aSelector">A selector that identifies a method not implemented or recognized by the receiver.</param>
        [iOSVersion(2)]
        [Export("doesNotRecognizeSelector")]
        public virtual void DoesNotRecognizeSelector(Selector aSelector) {  }
        
        /// <summary>
        /// Overridden by subclasses to substitute another object in place of the object that was decoded and subsequently received this message.
        /// </summary>
        /// <param name="aDecoder">The decoder used to decode the receiver.</param>
        [iOSVersion(2)]
        [Export("awakeAfterUsingCoder")]
        [return:Optional]
        public virtual AnyObject AwakeAfterUsingCoder(NSCoder aDecoder) { return default(AnyObject); }
        
        /// <summary>
        /// Overridden to return the names of classes that can be used to decode objects if their class is unavailable.
        /// </summary>
        [iOSVersion(2)]
        [Export("classFallbacksForKeyedArchiver")]
        public static AnyObject[] ClassFallbacksForKeyedArchiver() { return default(AnyObject[]); }
        
        /// <summary>
        /// Overridden by subclasses to substitute a new class during keyed unarchiving.
        /// </summary>
        [iOSVersion(2)]
        [Export("classForKeyedUnarchiver")]
        public static AnyClass ClassForKeyedUnarchiver() { return default(AnyClass); }
        
        /// <summary>
        /// Overridden by subclasses to substitute another object for itself during encoding.
        /// </summary>
        /// <param name="aCoder">The coder encoding the receiver.</param>
        [iOSVersion(2)]
        [Export("replacementObjectForCoder")]
        [return:Optional]
        public virtual AnyObject ReplacementObjectForCoder(NSCoder aCoder) { return default(AnyObject); }
        
        /// <summary>
        /// Overridden by subclasses to substitute another object for itself during keyed archiving.
        /// </summary>
        /// <param name="archiver">A keyed archiver creating an archive.</param>
        [iOSVersion(2)]
        [Export("replacementObjectForKeyedArchiver")]
        [return:Optional]
        public virtual AnyObject ReplacementObjectForKeyedArchiver(NSKeyedArchiver archiver) { return default(AnyObject); }
        
        /// <summary>
        /// Sets the receiver&#39;s version number.
        /// </summary>
        /// <param name="aVersion">The version number for the receiver.</param>
        [iOSVersion(2)]
        [Export("setVersion")]
        public static void SetVersion(int aVersion) {  }
        
        /// <summary>
        /// Returns the version number assigned to the class.
        /// </summary>
        [iOSVersion(2)]
        [Export("version")]
        public static int Version() { return default(int); }
        
        /// <summary>
        /// The garbage collector invokes this method on the receiver before disposing of the memory it uses.
        /// </summary>
        [iOSVersion(2)]
        [Export("finalize")]
        public virtual void Finalize() {  }
        
        /// <summary>
        /// A proxy for the receiving object (read-only)
        /// </summary>
        [iOSVersion(4)]
        [Export("autoContentAccessingProxy")]
        public AnyObject AutoContentAccessingProxy { get; private set; }
        
        /// <summary>
        /// Overridden by subclasses to substitute a class other than its own during coding. (read-only)
        /// </summary>
        [iOSVersion(2)]
        [Export("classForCoder")]
        public AnyClass ClassForCoder { get; private set; }
        
        /// <summary>
        /// Overridden by subclasses to substitute a new class for instances during keyed archiving.
        /// </summary>
        [iOSVersion(2)]
        [Export("classForKeyedArchiver")]
        [Optional]
        public AnyClass ClassForKeyedArchiver { get; private set; }
    }
}
