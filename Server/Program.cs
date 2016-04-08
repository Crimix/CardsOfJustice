using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Program
    {
        static int Main(string[] args)
        {
            ServerListener.startListener();
            return 0;
        }
    }
}
