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
        [Export("initialize")]
        public static void Initialise() { }

        [Export("load")]
        public static void load() { }

        [Export("alloc")]
        public static NSObject Allocate() { return new NSObject(); }

        //zone is ignored
        [Export("allocWithZone")]
        public static NSObject AllocateWithZone(COpaquePointer zone) { return new NSObject(); }

        //initializer, not sure how this should be represented
        [Export("init")]
        public NSObject() { }

        //convenience for NSCopying
        [Export("copy")]
        public AnyObject Copy() { return null;  }

        [Export("mutableCopy")]
        public AnyObject MutableCopy() { return null; }

        [Export("new")]
        public static NSObject New() { return null;  }

        [Export("superclass")]
        public static AnyClass Superclass() { return null;  }

        [Export("isSubclassOfClass")]
        public static bool IsSubclassOfClass(AnyClass aClass) { return false; }

        [Export("instancesRespondToSelector")]
        public static bool InstancesRespondToSelector(Selector aSelector) { return false; }

        [Export("conformsToProtocol")]
        public static bool conformsToProtocol(Protocol aProtocol) { return false; }

        [Export("instanceMethodSignatureForSelector")]
        public static NSMessageSignature InstanceMethodSignatureForSelector(Selector aSelector) { return null;  }

        [Export("methodSignatureForSelector")]
        public static NSMessageSignature MethodSignatureForSelector(Selector aSelector) { return null; }

        [Export("description")]
        public static string ToString() { return ""; }

        [Export("autoContentAccessingProxy")]
        public AnyObject AutoContentAccessingProxy { get; private set; }

        [Export("cancelPreviousPerformRequestsWithTarget")]
        public static void CancelPreviousPerformRequestsWithTarget(AnyObject aTarget) { return; }

        [Export("cancelPreviousPerformRequestsWithTarget")]
        public static void CancelPreviousPerformRequestsWithTarget(AnyObject aTarget, Selector aSelector, AnyObject anArgument) { return; }

        [Export("forwardingTargetForSelector")]
        public AnyObject ForwardingTargetForSelector(Selector aSelector) { return null; }

        [Export("forwardInvocation")]
        public void ForwardInvocation(NSInvocation anInvocation) { return; }

        [Export("resolveClassMethod")]
        public static bool ResolveClassMethod(Selector name) { return false; }

        [Export("resolveInstanceMethod")]
        public static bool ResolveInstanceMethod(Selector name) { return false; }

        [Export("doesNotRecognizeSelector")]
        public void DoesNotRecognizeSelector(Selector aSelector) { return; }

        [Export("awakeAfterUsingCoder")]
        public AnyObject AwakeAfterUsingCoder(NSCoder aDecoder) { return null; }

        [Export("classForCoder")]
        public AnyClass ClassForCoder { get; private set; }

        [Export("classForKeyedArchiver")]
        public AnyClass ClassForKeyedArchiver { get; private set; }

        [Export("classFallbacksForKeyedArchiver")]
        public static AnyObject[] ClassFallbacksForKeyedArchiver() { return null; }

        [Export("classForKeyedUnarchiver")]
        public static AnyClass ClassForKeyedUnarchiver() { return null; }

        [Export("replacementObjectForCoder")]
        public AnyObject ReplacementObjectForCoder(NSCoder aCoder) { return null; }

        [Export("replacementObjectForKeyedArchiver")]
        public AnyObject ReplacementObjectForKeyedArchiver(NSKeyedArchiver archiver) { return null; }

        [Export("setVersion")]
        public static void SetVersion(int aVersion) { return; }

        [Export("version")]
        public static int Version() { return 0; }

        [Obsolete] //GC is depreciated, should use the ARC
        [Export("finalize")]
        public void Finalize() { return; }
    }
}