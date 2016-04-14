using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public interface IIPEncoder
    {
        string Encode(string ip);
        string Decode(string input);
    }
}
