using SwiftSharp.Attributes;

namespace Foundation
{
    /// <summary>
    /// Specifies a bitfield used to configure the behavior of elements in an instance of NSHashTable.
    /// </summary>
    [iOSVersion(6)]
    //using NSHashTableOptions = Int32;
    public struct NSHashTableOptions
    {
        static public implicit operator NSHashTableOptions(int value)
        {
            return new NSHashTableOptions();
        }
        static public implicit operator int(NSHashTableOptions value)
        {
            return 0;
        }
    }
}
