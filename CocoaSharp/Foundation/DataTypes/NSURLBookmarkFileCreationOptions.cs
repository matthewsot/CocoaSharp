using SwiftSharp.Attributes;

namespace Foundation
{
    //using NSURLBookmarkFileCreationOptions = Int32;
    /// <summary>
    /// Options used when creating file bookmark data
    /// </summary>
    [iOSVersion(4)]
    public struct NSURLBookmarkFileCreationOptions
    {
        static public implicit operator NSURLBookmarkFileCreationOptions(int value)
        {
            return new NSURLBookmarkFileCreationOptions();
        }
        static public implicit operator int(NSURLBookmarkFileCreationOptions value)
        {
            return 0;
        }
    }
}
