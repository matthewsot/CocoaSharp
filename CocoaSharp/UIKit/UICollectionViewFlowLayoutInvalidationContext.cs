using ObjectiveC;using System;using SwiftSharp.Attributes;using System.Collections.Generic;using Foundation;using CoreGraphics;namespace UIKit{    /// <summary>    /// A UICollectionViewFlowLayoutInvalidationContext object specifies properties for determining whether to recompute the size of items or their position in the layout. The flow layout object creates instances of this class when it needs to invalidate its contents in response to changes. You can also create instances when invalidating the flow layout manually.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UICollectionViewFlowLayoutInvalidationContext_class/index.html#//apple_ref/occ/cl/UICollectionViewFlowLayoutInvalidationContext"/>    [iOSVersion(7)]    public class UICollectionViewFlowLayoutInvalidationContext : UICollectionViewLayoutInvalidationContext//, AnyObject, NSObjectProtocol    {        /// <summary>        /// A Boolean indicating whether to recompute the size of items and views in the layout.        /// </summary>        [iOSVersion(7)]        [Export("invalidateFlowLayoutDelegateMetrics")]        public bool InvalidateFlowLayoutDelegateMetrics { get; set; }                /// <summary>        /// A Boolean indicating whether to recompute the layout attributes for items and views in the layout.        /// </summary>        [iOSVersion(7)]        [Export("invalidateFlowLayoutAttributes")]        public bool InvalidateFlowLayoutAttributes { get; set; }    }}