using SwiftSharp.Attributes;

namespace Foundation
{
    /// <summary>
    /// Defines the memory and personality options for an NSPointerFunctions object.
    /// </summary>
    [iOSVersion(6)]
    public struct NSPointerFunctionsOptions
    {
        static public implicit operator NSPointerFunctionsOptions(int value)
        {
            return new NSPointerFunctionsOptions();
        }
        static public implicit operator int(NSPointerFunctionsOptions value)
        {
            return 0;
        }
    }
}
