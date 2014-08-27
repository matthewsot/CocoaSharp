using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpSwift.Attributes;

namespace CoreGraphics
{
    /// <summary>
    /// A structure that contains a point in a two-dimensional coordinate system. 
    /// </summary>
    [iOSVersion(2)]
    public struct CGPoint
    {
        /// <summary>
        /// The x-coordinate of the point.
        /// </summary>
        CGFloat x { get; set; }

        /// <summary>
        /// The y-coordinate of the point.
        /// </summary>
        CGFloat y { get; set; }
    }
}
