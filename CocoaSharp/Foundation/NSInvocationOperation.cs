using ObjectiveC;using System;using SharpSwift.Attributes;using System.Collections.Generic;namespace Foundation{    /// <summary>    /// The NSInvocationOperation class is a concrete subclass of NSOperation that manages the execution of a single encapsulated task specified as an invocation. You can use this class to initiate an operation that consists of invoking a selector on a specified object. This class implements a non-concurrent operation.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/NSInvocationOperation_Class/index.html#//apple_ref/occ/cl/NSInvocationOperation"/>    [iOSVersion(2)]    public class NSInvocationOperation : NSOperation//, AnyObject, NSObjectProtocol    {        /// <summary>        /// Returns an NSInvocationOperation object initialized with the specified target and selector.        /// </summary>        /// <param name="target">The object defining the specified selector.</param>        /// <param name="selector">The selector to invoke when running the operation. The selector may take 0 or 1 parameters; if it accepts a parameter, the type of that parameter must be id. The return type of the method may be void, a scalar value, or an object that can be returned as an id type.</param>        /// <param name="@object">The parameter object to pass to the selector. If the selector does not take an argument, specify nil.</param>        [iOSVersion(2)]        [Export("convenience init")]        public NSInvocationOperation(AnyObject target, Selector selector, AnyObject @object) { }                /// <summary>        /// Returns an NSInvocationOperation object initialized with the specified invocation object.        /// </summary>        /// <param name="invocation">The invocation object identifying the target object, selector, and parameter objects.</param>        [iOSVersion(2)]        public NSInvocationOperation(NSInvocation invocation) { }                /// <summary>        /// The receiver’s invocation object. (read-only)        /// </summary>        [iOSVersion(2)]        [Export("invocation")]        public NSInvocation Invocation { get; private set; }                /// <summary>        /// The result of the invocation or method. (read-only)        /// </summary>        [iOSVersion(2)]        [Export("result")]        public AnyObject Result { get; private set; }    }}