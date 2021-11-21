using System;
using System.Collections.Generic;
using System.Text;

namespace Lat5_2
{
    class Persegi
    {
        int x;

        public Persegi(int x)
        {
            this.x = x;
        }

        public virtual int luas()
        {
            return x * x;
        }
    }
}
