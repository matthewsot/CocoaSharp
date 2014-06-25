using Foundation;
using SwiftSharp.Attributes;

namespace UIKit
{
    /// <summary>
    /// The amount of acceleration in a single linear direction.
    /// </summary>
    [iOSVersion(2)]
    public struct UIAccelerationValue
    {
        static public implicit operator UIAccelerationValue(CDouble value)
        {
            return new UIAccelerationValue();
        }
        static public implicit operator CDouble(UIAccelerationValue value)
        {
            return null;
        }
    }
}
