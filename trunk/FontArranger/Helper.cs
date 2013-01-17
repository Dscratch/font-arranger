using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FontArranger
{
    static class Helper
    {
        public static uint roundUpToNextPowerOfTwo(uint x)
        {
            x--;
            x |= x >> 1;  // handle  2 bit numbers
            x |= x >> 2;  // handle  4 bit numbers
            x |= x >> 4;  // handle  8 bit numbers
            x |= x >> 8;  // handle 16 bit numbers
            x |= x >> 16; // handle 32 bit numbers
            x++;

            return x;
        }   
    }
    
}
