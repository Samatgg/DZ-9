using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тумаков_10лаб
{
    public interface ICipher
    {
        string Encode(string message);
        string Decode(string encodedMessage);
    }
}
