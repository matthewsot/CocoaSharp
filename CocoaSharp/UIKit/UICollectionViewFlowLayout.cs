using CoreGraphics;
using ObjectiveC;using System;using SwiftSharp.Attributes;using Foundation;namespace UIKit{    //https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UICollectionViewFlowLayout_class/index.html#//apple_ref/occ/cl/UICollectionViewFlowLayout    /// <summary>    /// The UICollectionViewFlowLayout class is a concrete layout object that organizes items into a grid with optional header and footer views for each section. The items in the collection view flow from one row or column (depending on the scrolling direction) to the next, with each row comprising as many cells as will fit. Cells can be the same sizes or different sizes.    /// </summary>    [iOSVersion(6)]    public class UICollectionViewFlowLayout : UICollectionViewLayout    {        /// <summary>        /// The scroll direction of the grid.        /// </summary>        [iOSVersion(6)]        [Export("scrollDirection")]        public UICollectionViewScrollDirection ScrollDirection { get; set; }                /// <summary>        /// The minimum spacing to use between lines of items in the grid.        /// </summary>        [iOSVersion(6)]        [Export("minimumLineSpacing")]        public CGFloat MinimumLineSpacing { get; set; }                /// <summary>        /// The minimum spacing to use between items in the same row.        /// </summary>        [iOSVersion(6)]        [Export("minimuminteritemSpacing")]        public CGFloat MinimuminteritemSpacing { get; set; }                /// <summary>        /// The default size to use for cells.        /// </summary>        [iOSVersion(6)]        [Export("itemSize")]        public CGSize ItemSize { get; set; }                /// <summary>        /// The estimated size of cells in the collection view.        /// </summary>        [iOSVersion(8)]        [Export("estimatedItemSize")]        public CGSize EstimatedItemSize { get; set; }                /// <summary>        /// The margins used to lay out content in a section        /// </summary>        [iOSVersion(6)]        [Export("sectionInset")]        public UIEdgeInsets SectionInset { get; set; }                /// <summary>        /// The default sizes to use for section headers.        /// </summary>        [iOSVersion(6)]        [Export("headerReferenceSize")]        public CGSize HeaderReferenceSize { get; set; }                /// <summary>        /// The default sizes to use for section footers.        /// </summary>        [iOSVersion(6)]        [Export("footerReferenceSize")]        public CGSize FooterReferenceSize { get; set; }        /// <summary>        /// Constants that specify the types of supplementary views that can be presented using a flow layout.        /// </summary>                /// <summary>        /// A supplementary view that identifies the header for a given section.        /// </summary>        [iOSVersion(6)]        public string UICollectionElementKindSectionHeader { get; private set; }                /// <summary>        /// A supplementary view that identifies the footer for a given section.        /// </summary>        [iOSVersion(6)]        public string UICollectionElementKindSectionFooter { get; private set; }    }

    /// <summary>
    /// Constants indicating the direction of scrolling for the layout.
    /// </summary>
    public enum UICollectionViewScrollDirection
    {
        /// <summary>
        /// The layout scrolls content vertically.
        /// </summary>
        [iOSVersion(6)]
        Vertical,

        /// <summary>
        /// The layout scrolls content horizontally.
        /// </summary>
        [iOSVersion(6)]
        Horizontal,
    }}