using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_外观模式2
{
    public class Loans
    {
        public bool HasNotBadLoans(Customer customer) {
            Console.WriteLine("Check Loans for {0}",customer.Name);
            return true;
        }
    }
}
