using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_外观模式2
{
    public class Bank
    {
        public bool HasSufficientSavings(Customer customer, int count) {
            Console.WriteLine("Check bank for {0}",customer.Name);
            return true;
        }
    }
}
