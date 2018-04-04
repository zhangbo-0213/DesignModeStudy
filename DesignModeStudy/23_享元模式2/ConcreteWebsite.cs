using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_享元模式2
{
    public class ConcreteWebsite : Website
    {
        private string name;

        public ConcreteWebsite(string name) {
            this.name = name;
        }
        public override void Use(User user)
        {
            Console.WriteLine("网站分类：{0}  用户:{1}",name,user.Use);
        }
    }
}
