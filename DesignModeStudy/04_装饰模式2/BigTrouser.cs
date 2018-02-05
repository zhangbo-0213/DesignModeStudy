using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_装饰模式2
{
    public class BigTrouser:Clothes
    {
        public override void Show()
        {
            base.Show();
            Console.WriteLine("Big-Trouser");     
        }
    }
}
