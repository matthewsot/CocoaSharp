using System;
using SharpSwift.Attributes;

namespace UIKit
{
    /// <summary>
    /// The completion block called at the end of an interactive transition for a collection view.
    /// </summary>
    [iOSVersion(7)]
    public struct UICollectionViewLayoutinteractiveTransitionCompletion
    {
        static public implicit operator UICollectionViewLayoutinteractiveTransitionCompletion(Action<bool, bool> value)
        {
            return new UICollectionViewLayoutinteractiveTransitionCompletion();
        }
        static public implicit operator Action<bool, bool>(UICollectionViewLayoutinteractiveTransitionCompletion value)
        {
            return null;
        }
    }
}