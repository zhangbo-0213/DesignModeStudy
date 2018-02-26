using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_外观模式2
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer("MajorTom");
            Mortgage mortgage = new Mortgage();

            bool eigible=mortgage.IsEigible(customer,12000);

            Console.WriteLine(customer.Name+" has ben "+(eigible?"Approved":"Rejected"));

            Console.ReadKey();
        }
    }
}
