using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_建造者模式
{
    public class Product
    {
        private IList<string> parts = new List<string>();

        public void Add(string part) {
            parts.Add(part);
        }

        public void Show() {
            Console.WriteLine("---产品建造---");
            foreach (string part in parts) {
                Console.WriteLine(part);
            }
        }
    }
}
