using System.Collections.Generic;
using System.Text;

namespace Lab4.serialization.tokenization
{
    internal sealed class INITokenizer : IEnumerator<INIToken>
    {
        public const string INI_TOKEN_FALSE = "false";
        public const string INI_TOKEN_NULL = "null";
        public const string INI_TOKEN_TRUE = "true";

        public INIToken Current { get; private set; }

        private StringBuilder _stringBuilder;
        private int _position;
        private string _serialized;

        private bool _disposed;

        public INITokenizer(string serialized, StringBuilder stringBuilder = null)
        {
            _serialized = serialized;
            _stringBuilder = stringBuilder ?? new StringBuilder();
        }

        public bool MoveNext()
        {
            //throw new System.NotImplementedException();

            var serialized = _serialized;
            for (; _position < serialized.Length; _position++)
            {
                var ch = serialized[_position];

                if (ch == ' ')
                {
                    continue;
                }
                
                
            }
        }
    }
}