using SharpSwift.Attributes;

namespace Foundation
{
    /// <summary>
    /// An identifier for a background session.
    /// </summary>
    [iOSVersion(8)]
    public struct unichar
    {
        static public implicit operator unichar(char value)
        {
            return new unichar();
        }
        static public implicit operator char(unichar value)
        {
            return ' ';
        }
    }
}
