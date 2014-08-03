using ObjectiveC;using System;using SwiftSharp.Attributes;using System.Collections.Generic;namespace Foundation{	/// <summary>	/// An NSValue object is a simple container for a single C or Objective-C data item. It can hold any of the scalar types such as int, float, and char, as well as pointers, structures, and object id references. Use this class to work with such data types in collections (such as NSArray and NSSet), key-value coding, and other APIs that require Objective-C objects. NSValue objects are always immutable.	/// </summary>	/// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Classes/NSValue_Class/index.html#//apple_ref/occ/cl/NSValue"/>	[iOSVersion(2)]	public class NSValue : NSObject//, AnyObject, NSCoding, NSCopying, NSObjectProtocol, NSSecureCoding	{		/// <summary>		/// Initializes a value object to contain the specified value, interpreted with the specified Objective-C type.		/// </summary>		/// <param name="bytes">A pointer to data to be stored in the new value object.</param>		/// <param name="objCType">The Objective-C type of value, as provided by the @encode() compiler directive. Do not hard-code this parameter as a C string.</param>		[iOSVersion(2)]		public NSValue(ConstUnsafePointer<Action> bytes, ConstUnsafePointer<Int8> objCType) { }				/// <summary>		/// Creates a value object containing the specified value, interpreted with the specified Objective-C type.		/// </summary>		/// <param name="value">A pointer to data to be stored in the new value object.</param>		/// <param name="objCType">The Objective-C type of value, as provided by the @encode() compiler directive. Do not hard-code this parameter as a C string.</param>		[iOSVersion(2)]		[Export("valueWithBytes")]		public static NSValue ValueWithBytes(ConstUnsafePointer<Action> value, ConstUnsafePointer<Int8> objCType) { return default(NSValue); }				/// <summary>		/// Creates a value object containing the specified value, interpreted with the specified Objective-C type.		/// </summary>		/// <param name="value">A pointer to data to be stored in the new value object.</param>		/// <param name="withObjCType">The Objective-C type of value, as provided by the @encode() compiler directive. Do not hard-code this parameter as a C string.</param>		/// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>		[iOSVersion(2)]		[IgnoreParameters("NAME_YOUR_PARAMS")]		public NSValue(ConstUnsafePointer<Action> value, ConstUnsafePointer<Int8> withObjCType, bool NAME_YOUR_PARAMS = false) { }				/// <summary>		/// Copies the value into the specified buffer.		/// </summary>		/// <param name="buffer">A buffer into which to copy the value. The buffer must be large enough to hold the value.</param>		[iOSVersion(2)]		[Export("getValue")]		public void GetValue(UnsafePointer<Action> buffer) {  }				/// <summary>		/// Creates a value object containing the specified pointer.		/// </summary>		/// <param name="pointer">The value for the new object.</param>		[iOSVersion(2)]		public NSValue(ConstUnsafePointer<Action> pointer) { }				/// <summary>		/// Creates a value object containing the specified object.		/// </summary>		/// <param name="nonretainedObject">The value for the new object.</param>		[iOSVersion(2)]		public NSValue(AnyObject nonretainedObject) { }				/// <summary>		/// Returns the value as an untyped pointer.		/// </summary>		/// <param name=")"></param>		[iOSVersion(2)]		[Export("pointerValue")]		public UnsafePointer<Action> PointerValue() -> UnsafePointer<> )) { return default(UnsafePointer<Action>); }				/// <summary>		/// Creates a new value object containing the specified Foundation range structure.		/// </summary>		/// <param name="range">The value for the new object.</param>		[iOSVersion(2)]		public NSValue(NSRange range) { }				/// <summary>		/// Returns a Boolean value that indicates whether the value object and another value object are equal.		/// </summary>		/// <param name="aValue">The other value object with which to compare the value object.</param>		[iOSVersion(2)]		[Export("isEqualToValue")]		public bool IsEqualToValue(NSValue aValue) { return default(bool); }				/// <summary>		/// A C string containing the Objective-C type of the data contained in the value object.		/// </summary>		[iOSVersion(2)]		[Export("objCType")]		public ConstUnsafePointer<Int8> ObjCType { get; private set; }				/// <summary>		/// The value as a non-retained pointer to an object. (read-only)		/// </summary>		[iOSVersion(2)]		[Export("nonretainedObjectValue")]		public AnyObject NonretainedObjectValue { get; private set; }				/// <summary>		/// The Foundation range structure representation of the value. (read-only)		/// </summary>		[iOSVersion(2)]		[Export("rangeValue")]		public NSRange RangeValue { get; private set; }	}}