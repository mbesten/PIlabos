using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace lab3
{
    class Stoperica
    {
        static Stopwatch Mjerac = new Stopwatch();
        public static void ZapocniMjerenje()
        {
            Mjerac.Start();
        }

        public static TimeSpan VremenskiInterval()
        {
            TimeSpan vrijeme = Mjerac.Elapsed;

            return vrijeme;
        }
    }
}
