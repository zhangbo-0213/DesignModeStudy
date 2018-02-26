using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_外观模式2
{
    public class Mortgage
    {
        private Bank bank;
        private Credit credit;
        private Loans loans;

        public Mortgage() {
            bank = new Bank();
            credit = new Credit();
            loans = new Loans();
        }

        public bool IsEigible(Customer customer, int amount) {
            Console.WriteLine("{0} applies for {1} loan",customer.Name,amount);

            bool eigible = true;

            if (!bank.HasSufficientSavings(customer, amount))
                eigible = false;
            else if (!credit.HasGoodCredit(customer))
                eigible = false;
            else if (!loans.HasNotBadLoans(customer))
                eigible = false;

            return eigible;
        }
    }
}
