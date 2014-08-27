using SharpSwift.Attributes;

namespace Foundation
{
    public struct NSURLFileScheme
    {
        static public implicit operator NSURLFileScheme(string value)
        {
            return new NSURLFileScheme();
        }
        static public implicit operator string(NSURLFileScheme value)
        {
            return "";
        }
    }
}
