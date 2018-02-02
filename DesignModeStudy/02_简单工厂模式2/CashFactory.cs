using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_简单工厂模式2
{
    public class CashFactory
    {
        public static CashSuper CreatCashAccept(string type) {
            CashSuper cash=null;
            switch (type) {
                case "正常收费":
                    cash = new CashNormal();
                    break;
                case "满300减50":
                    cash = new CashReturn("300","50");
                    break;
                case "打8折":
                    cash = new CashRebate("0.8");
                    break;
            }
            return cash;
        }
    }
}
