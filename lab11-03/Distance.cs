using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11_03
{
    class Distance
    {
        public int foot { get; set; }
        public double inch { get; set; }

        public Distance()
        {
            foot = 0;
            inch = 0;
        }

        public Distance(int foot, double inch)
        {
            this.foot = foot + ((int)inch / 12);
            this.inch = inch % 12;
        }

        public static Distance operator +(Distance d1, Distance d2) =>
            new Distance(d1.foot + d2.foot + ((int)((d1.inch + d2.inch) / 12)), (d1.inch + d2.inch) % 12);
        public static Distance operator -(Distance d1, Distance d2) =>
            new Distance(((12 * d1.foot + (int)d1.inch) - (12 * d2.foot + (int)d2.inch)) / 12, ((12 * d1.foot + (int)d1.inch) - (12 * d2.foot + (int)d2.inch)) % 12);

        public static bool operator > (Distance d1, Distance d2)
        {
            if ((12 * d1.foot + (int)d1.inch) > (12 * d2.foot + (int)d2.inch))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator <(Distance d1, Distance d2)
        {
            if ((12 * d1.foot + (int)d1.inch) < (12 * d2.foot + (int)d2.inch))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString() => (foot + "\'-" + inch + "\"");
    }
}
