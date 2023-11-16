using System.Text;

namespace Тумаков_10лаб.Classes
{
    public class BCipher : ICipher
    {
        public string Encode(string message)
        {
            StringBuilder encodedMessage = new StringBuilder();

            foreach (char c in message)
            {
                if (char.IsLetter(c))
                {
                    char encodedChar;
                    if (char.IsUpper(c))
                    {
                        encodedChar = (char)('A' + ('Z' - c));
                    }
                    else
                    {
                        encodedChar = (char)('a' + ('z' - c));
                    }
                    encodedMessage.Append(encodedChar);
                }
                else
                {
                    encodedMessage.Append(c);
                }
            }

            return encodedMessage.ToString();
        }

        public string Decode(string encodedMessage)
        {
            return Encode(encodedMessage);
        }
    }
}
