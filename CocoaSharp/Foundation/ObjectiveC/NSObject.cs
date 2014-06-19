using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Foundation;

namespace ObjectiveC
{
    //https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Classes/NSObject_Class/index.html#//apple_ref/occ/clm/NSObject/load
    public class NSObject
    {
        /// <summary>
        /// Initializes the class before it receives its first message.
        /// </summary>
        [Export("initialize")]
        public static void Initialise() { }

        /// <summary>
        /// Invoked whenever a class or category is added to the Objective-C runtime; implement this method to perform class-specific behavior upon loading. 
        /// </summary>
        [Export("load")]
        public static void load() { }

        /// <summary>
        /// Returns a new instance of the receiving class.
        /// </summary>
        /// <returns>A new instance of the receiver. </returns>
        [Export("alloc")]
        public static NSObject Allocate() { return new NSObject(); }

        /// <summary>
        /// Returns a new instance of the receiving class. 
        /// </summary>
        /// <param name="zone">This parameter is ignored. </param>
        /// <returns>A new instance of the receiver. </returns>
        [Export("allocWithZone")]
        public static NSObject AllocateWithZone(COpaquePointer zone) { return new NSObject(); }

        //initializer, not sure how this should be represented
        /// <summary>
        /// Implemented by subclasses to initialize a new object (the receiver) immediately after memory for it has been allocated. 
        /// </summary>
        [Export("init")]
        public NSObject() { }

        //convenience for NSCopying
        /// <summary>
        /// Returns the object returned by copyWithZone:. 
        /// </summary>
        /// <returns>The object returned by the NSCopying protocol method copyWithZone:,. </returns>
        [Export("copy")]
        public AnyObject Copy() { return null;  }

        /// <summary>
        /// Returns the object returned by mutableCopyWithZone: where the zone is nil. 
        /// </summary>
        /// <returns>The object returned by the NSMutableCopying protocol method mutableCopyWithZone:, where the zone is nil. </returns>
        [Export("mutableCopy")]
        public AnyObject MutableCopy() { return null; }

        /// <summary>
        /// Allocates a new instance of the receiving class, sends it an init message, and returns the initialized object. 
        /// </summary>
        /// <returns>A new instance of the receiver. </returns>
        [Export("new")]
        public static NSObject New() { return null;  }

        /// <summary>
        /// Returns the class object for the receiver’s superclass. 
        /// </summary>
        /// <returns>The class object for the receiver’s superclass. </returns>
        [Export("superclass")]
        public static AnyClass Superclass() { return null;  }

        /// <summary>
        /// Returns a Boolean value that indicates whether the receiving class is a subclass of, or identical to, a given class. 
        /// </summary>
        /// <param name="aClass">A class object.</param>
        /// <returns>true if the receiving class is a subclass of—or identical to—aClass, otherwise false.</returns>
        [Export("isSubclassOfClass")]
        public static bool IsSubclassOfClass(AnyClass aClass) { return false; }

        /// <summary>
        /// Returns a Boolean value that indicates whether instances of the receiver are capable of responding to a given selector. 
        /// </summary>
        /// <param name="aSelector">A selector.</param>
        /// <returns>true if instances of the receiver are capable of responding to aSelector messages, otherwise false.</returns>
        [Export("instancesRespondToSelector")]
        public static bool InstancesRespondToSelector(Selector aSelector) { return false; }

        /// <summary>
        /// Returns a Boolean value that indicates whether the receiver conforms to a given protocol. 
        /// </summary>
        /// <param name="aProtocol">A protocol.</param>
        /// <returns>true if the receiver conforms to aProtocol, otherwise false.</returns>
        [Export("conformsToProtocol")]
        public static bool conformsToProtocol(Protocol aProtocol) { return false; }

        /// <summary>
        /// Returns an NSMethodSignature object that contains a description of the instance method identified by a given selector. 
        /// </summary>
        /// <param name="aSelector">A selector that identifies the method for which to return the implementation address.</param>
        /// <returns>An NSMethodSignature object that contains a description of the instance method identified by aSelector, or nil if the method can’t be found.</returns>
        [Export("instanceMethodSignatureForSelector")]
        public static NSMessageSignature InstanceMethodSignatureForSelector(Selector aSelector) { return null;  }

        /// <summary>
        /// Returns an NSMethodSignature object that contains a description of the method identified by a given selector.
        /// </summary>
        /// <param name="aSelector">A selector that identifies the method for which to return the implementation address. When the receiver is an instance, aSelector should identify an instance method; when the receiver is a class, it should identify a class method.</param>
        /// <returns>An NSMethodSignature object that contains a description of the method identified by aSelector, or nil if the method can’t be found.</returns>
        [Export("methodSignatureForSelector")]
        public static NSMessageSignature MethodSignatureForSelector(Selector aSelector) { return null; }

        /// <summary>
        /// Returns a string that represents the contents of the receiving class.
        /// </summary>
        /// <returns>A string that represents the contents of the receiving class.</returns>
        [Export("description")]
        public static string ToString() { return ""; }

        /// <summary>
        /// Creates and returns a proxy for the receiving object
        /// </summary>
        [Export("autoContentAccessingProxy")]
        public AnyObject AutoContentAccessingProxy { get; private set; }

        /// <summary>
        /// Cancels perform requests previously registered with the performSelector:withObject:afterDelay: instance method.
        /// </summary>
        /// <param name="aTarget">The target for requests previously registered with the performSelector:withObject:afterDelay: instance method.</param>
        [Export("cancelPreviousPerformRequestsWithTarget")]
        public static void CancelPreviousPerformRequestsWithTarget(AnyObject aTarget) { return; }

        /// <summary>
        /// Cancels perform requests previously registered with performSelector:withObject:afterDelay:.
        /// </summary>
        /// <param name="aTarget">The target for requests previously registered with the performSelector:withObject:afterDelay: instance method</param>
        /// <param name="aSelector">The selector for requests previously registered with the performSelector:withObject:afterDelay: instance method.</param>
        /// <param name="anArgument">The argument for requests previously registered with the performSelector:withObject:afterDelay: instance method. Argument equality is determined using isEqual:, so the value need not be the same object that was passed originally. Pass nil to match a request for nil that was originally passed as the argument.</param>
        [Export("cancelPreviousPerformRequestsWithTarget")]
        public static void CancelPreviousPerformRequestsWithTarget(AnyObject aTarget, Selector aSelector, AnyObject anArgument) { return; }

        /// <summary>
        /// Returns the object to which unrecognized messages should first be directed. 
        /// </summary>
        /// <param name="aSelector">A selector for a method that the receiver does not implement.</param>
        /// <returns>The object to which unrecognized messages should first be directed.</returns>
        [Export("forwardingTargetForSelector")]
        public AnyObject ForwardingTargetForSelector(Selector aSelector) { return null; }

        /// <summary>
        /// Overridden by subclasses to forward messages to other objects.
        /// </summary>
        /// <param name="anInvocation">The invocation to forward.</param>
        [Export("forwardInvocation")]
        public void ForwardInvocation(NSInvocation anInvocation) { return; }

        /// <summary>
        /// Dynamically provides an implementation for a given selector for a class method.
        /// </summary>
        /// <param name="name">The name of a selector to resolve.</param>
        /// <returns>true if the method was found and added to the receiver, otherwise false.</returns>
        [Export("resolveClassMethod")]
        public static bool ResolveClassMethod(Selector name) { return false; }

        /// <summary>
        /// Dynamically provides an implementation for a given selector for an instance method.
        /// </summary>
        /// <param name="name">The name of a selector to resolve.</param>
        /// <returns>true if the method was found and added to the receiver, otherwise false.</returns>
        [Export("resolveInstanceMethod")]
        public static bool ResolveInstanceMethod(Selector name) { return false; }

        /// <summary>
        /// Handles messages the receiver doesn’t recognize.
        /// </summary>
        /// <param name="aSelector">A selector that identifies a method not implemented or recognized by the receiver.</param>
        [Export("doesNotRecognizeSelector")]
        public void DoesNotRecognizeSelector(Selector aSelector) { return; }

        /// <summary>
        /// Overridden by subclasses to substitute another object in place of the object that was decoded and subsequently received this message.
        /// </summary>
        /// <param name="aDecoder">The decoder used to decode the receiver.</param>
        /// <returns>The receiver, or another object to take the place of the object that was decoded and subsequently received this message.</returns>
        [Export("awakeAfterUsingCoder")]
        public AnyObject AwakeAfterUsingCoder(NSCoder aDecoder) { return null; }

        /// <summary>
        /// Overridden by subclasses to substitute a class other than its own during coding.
        /// </summary>
        [Export("classForCoder")]
        public AnyClass ClassForCoder { get; private set; }

        /// <summary>
        /// Overridden by subclasses to substitute a new class for instances during keyed archiving.
        /// </summary>
        [Export("classForKeyedArchiver")]
        public AnyClass ClassForKeyedArchiver { get; private set; }

        /// <summary>
        /// Overridden to return the names of classes that can be used to decode objects if their class is unavailable.
        /// </summary>
        /// <returns>An array of NSString objects that specify the names of classes in preferred order for unarchiving</returns>
        [Export("classFallbacksForKeyedArchiver")]
        public static AnyObject[] ClassFallbacksForKeyedArchiver() { return null; }

        /// <summary>
        /// Overridden by subclasses to substitute a new class during keyed unarchiving.
        /// </summary>
        /// <returns>The class to substitute for the receiver during keyed unarchiving.</returns>
        [Export("classForKeyedUnarchiver")]
        public static AnyClass ClassForKeyedUnarchiver() { return null; }

        /// <summary>
        /// Overridden by subclasses to substitute another object for itself during encoding.
        /// </summary>
        /// <param name="aCoder">The coder encoding the receiver.</param>
        /// <returns>The object encode instead of the receiver (if different).</returns>
        [Export("replacementObjectForCoder")]
        public AnyObject ReplacementObjectForCoder(NSCoder aCoder) { return null; }

        /// <summary>
        /// Overridden by subclasses to substitute another object for itself during keyed archiving.
        /// </summary>
        /// <param name="archiver">A keyed archiver creating an archive.</param>
        /// <returns>The object encode instead of the receiver (if different).</returns>
        [Export("replacementObjectForKeyedArchiver")]
        public AnyObject ReplacementObjectForKeyedArchiver(NSKeyedArchiver archiver) { return null; }

        /// <summary>
        /// Sets the receiver's version number.
        /// </summary>
        /// <param name="aVersion">The version number for the receiver.</param>
        [Export("setVersion")]
        public static void SetVersion(int aVersion) { return; }

        /// <summary>
        /// Returns the version number assigned to the class.
        /// </summary>
        /// <returns>The version number assigned to the class.</returns>
        [Export("version")]
        public static int Version() { return 0; }

        /// <summary>
        /// The garbage collector invokes this method on the receiver before disposing of the memory it uses.
        /// Garbage collection is deprecated in OS X v10.8; instead, you should use Automatic Reference Counting — see Transitioning to ARC Release Notes.
        /// </summary>
        [Obsolete]
        [Export("finalize")]
        public void Finalize() { return; }
    }
}