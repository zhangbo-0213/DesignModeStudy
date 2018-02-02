using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_策略模式
{
    public class CashContext
    {
        private CashSuper cash = null;
        //基本的策略模式中，选择所用算法的具体实现的职责由客户端承担，并转给Context对象，
        //public CashContext(CashSuper cs) {
        //    cash = cs;
        //}   

        //将策略模式与简单工厂模式相结合后，选择的具体实现职责可以由Context对象来承担，减轻客户端的职责。
        public CashContext(string str) {
            switch (str) {
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
        }

        public double GetResult(double money) {
            return cash.acceptCash(money);
        }
    }
}
