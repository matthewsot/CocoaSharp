using Foundation;
using SwiftSharp.Attributes;

namespace UIKit
{
    /// <summary>
    /// The layout priority is used to indicate to the constraint-based layout system which constraints are more important, allowing the system to make appropriate tradeoffs when satisfying the constraints of the system as a whole.
    /// </summary>
    [iOSVersion(6)]
    public struct UILayoutPriority
    {
        static public implicit operator UILayoutPriority(CFloat value)
        {
            return new UILayoutPriority();
        }
        static public implicit operator CFloat(UILayoutPriority value)
        {
            return null;
        }
    }
}
