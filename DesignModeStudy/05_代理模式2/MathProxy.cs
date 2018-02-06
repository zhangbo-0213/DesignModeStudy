using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_代理模式2
{
    public class MathProxy : IMath
    {
        private Math math;
        public MathProxy() {
            math = new Math();
        }
        public double Add(double numA, double numB)
        {
            return math.Add(numA,numB);
        }

        public double Div(double numA, double numB)
        {
            return math.Div(numA,numB);
        }

        public double Mul(double numA, double numB)
        {
            return math.Mul(numA,numB);
        }

        public double Sub(double numA, double numB)
        {
            return math.Sub(numA,numB);
        }
    }
}
