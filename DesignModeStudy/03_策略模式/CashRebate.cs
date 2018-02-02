using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_策略模式
{
    public class CashRebate : CashSuper
    {
        private double moneyRebate = 0.0d;

        public CashRebate(string moneyRebate) {
            this.moneyRebate = double.Parse(moneyRebate);
        }
        public override double acceptCash(double money)
        {
            return money * moneyRebate;
        }
    }
}
