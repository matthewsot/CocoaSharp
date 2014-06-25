using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SwiftSharp.Attributes;

namespace CoreGraphics
{
    /// <summary>
    /// A structure that contains the location and dimensions of a rectangle.
    /// 
    /// In the default Quartz coordinate space, the origin is located in the lower-left corner of the rectangle and the rectangle extends towards the upper-right corner. If the context has a flipped-coordinate space—often the case on iOS—the origin is in the upper-left corner and the rectangle extends towards the lower-right corner.
    /// </summary>
    [iOSVersion(2)]
    public struct CGRect
    {
        /// <summary>
        /// A point that specifies the coordinates of the rectangle’s origin.
        /// </summary>
        public CGPoint origin { get; set; }
        
        /// <summary>
        /// A size that specifies the height and width of the rectangle.
        /// </summary>
        public CGSize size { get; set; }
    }
}
