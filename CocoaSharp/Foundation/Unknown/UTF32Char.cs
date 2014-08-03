using SwiftSharp.Attributes;

namespace Foundation
{
    /// <summary>
    /// An identifier for a background session.
    /// </summary>
    [iOSVersion(8)]
    public struct UTF32Char
    {
        static public implicit operator UTF32Char(char value)
        {
            return new UTF32Char();
        }
        static public implicit operator char(UTF32Char value)
        {
            return ' ';
        }
    }
}
