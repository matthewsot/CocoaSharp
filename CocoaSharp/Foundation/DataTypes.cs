using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ObjectiveC;
using SwiftSharp.Attributes;

namespace Foundation
{
    /// <summary>
    /// Defines the signature for a block object used for comparison operations.
    /// </summary>
    //[iOSVersion(4)]
    using NSComparator = Func<AnyObject, AnyObject, NSComparisonResult>;
        
    /// <summary>
    /// Specifies a bitfield used to configure the behavior of elements in an instance of NSHashTable.
    /// </summary>
    //[iOSVersion(6)]  
    using NSHashTableOptions = Int32;
        
    /// <summary>
    /// Used to describe an integer.
    /// </summary>
    //[iOSVersion(2)]
    using NSinteger = Int32;
    using NSInteger = Int32;
        
    /// <summary>
    /// Specifies a bitfield used to configure the behavior of elements in an instance of NSMapTable.
    /// </summary>
    //[iOSVersion(6)]
    using NSMapTableOptions = Int32;

    using NSUInteger = Int32; //TODO: figure out what NSUInteger really is
    
    using NSRange = _NSRange;
        
    /// <summary>
    /// Type indicating a parameter is a pointer to an NSRange structure.
    /// </summary>
    //[iOSVersion(2)]
    using NSRangePointer = UnsafePointer<NSRange>;
        
    /// <summary>
    /// Type for the platform-specific native socket handle.
    /// </summary>
    //[iOSVersion(2)]
    using NSSocketNativeHandle = Cint;
    
    //StringEncoding is ObjC only

    /// <summary>
    /// Used to specify a time interval, in seconds.
    /// </summary>
    //[iOSVersion(2)]  
    using NSTimeinterval = CDouble;

    using NSURLBookmarkFileCreationOptions = Int32;
    using NSURLFileScheme = String;

    /// <summary>
    /// A structure used to describe a portion of a series—such as characters in a string or objects in an NSArray object.
    /// </summary>
    [iOSVersion(2)]
    public struct _NSRange
    {
        public NSUInteger location;
        public NSUInteger length;
    }

    ///Opaque structure containing endian-independent double value. 
    [iOSVersion(2)]
    struct NSSwappedDouble
    {
        private CUnsignedLongLong v;
    }

    //Opaque type containing an endian-independent float value. 
    [iOSVersion(2)]
    struct NSSwappedFloat
    {
        private CUnsignedInt v;
    }
}
