using SharpSwift.Attributes;

namespace Foundation
{
    /// <summary>
    /// Used to describe an integer.
    /// </summary>
    //using NSinteger = Int32;
    //using NSInteger = Int32;
    [iOSVersion(2)]
    public struct NSinteger
    {
        static public implicit operator NSinteger(int value)
        {
            return new NSinteger();
        }
        static public implicit operator int(NSinteger value)
        {
            return 0;
        }
    }
    public struct NSInteger
    {
        static public implicit operator NSInteger(int value)
        {
            return new NSInteger();
        }
        static public implicit operator int(NSInteger value)
        {
            return 0;
        }
    }
}
