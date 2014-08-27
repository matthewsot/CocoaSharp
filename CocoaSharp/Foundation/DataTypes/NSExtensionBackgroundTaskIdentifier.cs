using SharpSwift.Attributes;

namespace Foundation
{
    /// <summary>
    /// An identifier for a background session.
    /// </summary>
    [iOSVersion(8)]
    public struct NSExtensionBackgroundTaskIdentifier
    {
        static public implicit operator NSExtensionBackgroundTaskIdentifier(int value)
        {
            return new NSExtensionBackgroundTaskIdentifier();
        }
        static public implicit operator int(NSExtensionBackgroundTaskIdentifier value)
        {
            return 0;
        }
    }
}
