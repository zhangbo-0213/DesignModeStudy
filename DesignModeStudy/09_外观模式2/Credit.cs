using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_外观模式2
{
    public class Credit
    {
        public bool HasGoodCredit(Customer customer) {
            Console.WriteLine("Check credit for {0}", customer.Name);
            return true;
        }
    }
}
