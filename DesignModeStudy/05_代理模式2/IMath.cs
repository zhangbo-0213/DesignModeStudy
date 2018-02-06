using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_代理模式2
{
    public interface IMath
    {
        double Add(double numA, double numB);
        double Sub(double numA,double numB);
        double Mul(double numA,double numB);
        double Div(double numA,double numB);
    }
}
