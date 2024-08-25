using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SampleLibrary
{
    public class Class1
    {
        public Class1()
        {
        }

        public double Method1(double val)
        {
            Console.WriteLine($"Method1 called with {val}");
            var res = qwerty(val);
            Console.WriteLine($"qwerty {val}");
            return res;
        }

        public double Method2(double val)
        {
            return qazxsw(val);
        }

        internal double qwerty(double val)
        {
            Console.WriteLine($"qwerty called with {val}");
            var res = val * val;
            Console.WriteLine($"qwerty returning {res}");
            return res;
        }

        private double qazxsw(double val)
        {
            return 2 * val;
        }
    }
}