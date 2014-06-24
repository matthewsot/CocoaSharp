using SwiftSharp.Attributes;

namespace Foundation
{
    /// <summary>
    /// Specifies a bitfield used to configure the behavior of elements in an instance of NSMapTable.
    /// </summary>
    //using NSMapTableOptions = Int32;
    [iOSVersion(6)]
    public struct NSMapTableOptions
    {
        static public implicit operator NSMapTableOptions(int value)
        {
            return new NSMapTableOptions();
        }
        static public implicit operator int(NSMapTableOptions value)
        {
            return 0;
        }
    }
}
