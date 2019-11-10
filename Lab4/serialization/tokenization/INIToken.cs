using System.Diagnostics;

namespace Lab4.serialization.tokenization
{
    [DebuggerDisplay("{TokenType} '{Value}'")]
    internal struct INIToken
    {
        public static readonly INIToken Empty = new INIToken(INITokenType.None);

        public readonly INITokenType TokenType;

        public readonly string Value;

        public INIToken(INITokenType tokenType, string value = null)
        {
            TokenType = tokenType;
            Value = value;
        }
    }
}