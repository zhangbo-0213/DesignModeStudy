using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_组合模式
{
    public class Leaf : Component
    {
        public Leaf(string name):base(name) {

        }
        
        //由于叶结点没有再增加分支和树叶，所以add和remove方法没有实现意义，
        //但一致的接口可以消除叶结点和枝节结点在抽象层次的区别
        public override void Add(Component c)
        {
            Console.WriteLine("Cannot add to a leaf");
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-',depth)+name);
        }

        public override void Remove(Component c)
        {
            Console.WriteLine("Cannot remove from a leaf");
        }
    }
}
