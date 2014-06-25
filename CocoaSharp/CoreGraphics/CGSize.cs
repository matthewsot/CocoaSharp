using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SwiftSharp.Attributes;

namespace CoreGraphics
{
    /// <summary>
    /// A structure that contains width and height values.
    /// </summary>
    [iOSVersion(2)]
    public struct CGSize
    {
        /// <summary>
        /// A width value
        /// </summary>
        CGFloat width { get; set; }

        /// <summary>
        /// A height value
        /// </summary>
        CGFloat height { get; set; }
    } 
}
