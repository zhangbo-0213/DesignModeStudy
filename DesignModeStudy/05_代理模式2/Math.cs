using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_代理模式2
{
    public class Math : IMath
    {
        public double Add(double numA, double numB)
        {
            return numA+numB;
        }

        public double Div(double numA, double numB)
        {
            return numA-numB;
        }

        public double Mul(double numA, double numB)
        {
            return numA*numB;
        }

        public double Sub(double numA, double numB)
        {
            return numA/numB;
        }
    }
}
