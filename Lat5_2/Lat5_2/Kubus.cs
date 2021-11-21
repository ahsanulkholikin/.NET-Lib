using System;
using System.Collections.Generic;
using System.Text;

namespace Lat5_2
{
    class Kubus : Persegi
    {
        public Kubus(int x)
        : base(x)
        {
        }

        public override int luas()
        {
            return (6 * base.luas());
        }
    }
}
