using System.Text;

namespace Тумаков_10лаб.Classes
{
    public class ACipher : ICipher
    {
        public string Encode(string message)
        {
            StringBuilder encodedMessage = new StringBuilder();

            foreach (char c in message)
            {
                if (char.IsLetter(c))
                {
                    if (c == 'Z')
                    {
                        encodedMessage.Append('A');
                    }
                    else if (c == 'z')
                    {
                        encodedMessage.Append('a');
                    }
                    else
                    {
                        encodedMessage.Append((char)(c + 1));
                    }
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
            StringBuilder decodedMessage = new StringBuilder();

            foreach (char c in encodedMessage)
            {
                if (char.IsLetter(c))
                {
                    if (c == 'A')
                    {
                        decodedMessage.Append('Z');
                    }
                    else if (c == 'a')
                    {
                        decodedMessage.Append('z');
                    }
                    else
                    {
                        decodedMessage.Append((char)(c - 1));
                    }
                }
                else
                {
                    decodedMessage.Append(c);
                }
            }

            return decodedMessage.ToString();
        }
    }
}
