using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_装饰模式2
{
    public class Tshirts:Clothes
    {
        public override void Show()
        {
            base.Show();
            Console.WriteLine("T-shirts");     
        }
    }
}
