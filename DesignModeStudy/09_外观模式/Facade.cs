using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_外观模式
{
    public class Facade
    {
        private SubSystemOne subSystemOne;
        private SubSystemTwo subSystemTwo;
        private SubSystemThree subSystemThree;
        private SubSystemFour subSystemFour;

        public Facade() {
            subSystemOne = new SubSystemOne();
            subSystemTwo = new SubSystemTwo();
            subSystemThree = new SubSystemThree();
            subSystemFour = new SubSystemFour();
        }

        public void MethodA() {
            Console.WriteLine("\n方法组A()");
            subSystemOne.MethodOne();
            subSystemTwo.MethodTwo();
            subSystemFour.MethonFour();
        }

        public void MethodB() {
            Console.WriteLine("\n方法组B()");
            subSystemThree.MethodThree();
            subSystemFour.MethonFour();
        }
    }
}
