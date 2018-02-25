using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_原型模式2
{
    //原型模式的深复制实现，将类成员中的引用类型成员继承并实现ICloneable接口，并在类中提供该类的克隆方法，克隆方法内实现对引用类型成员的复制
    class Program
    {
        static void Main(string[] args)
        {
            Resume r1 = new Resume("Major");
            r1.SetInfo("male",20);
            r1.SetWorkExperience("1990-2004", "CompanyA");
            r1.DisPlay();

            Resume r2 = r1.Clone() as Resume;
            r2.SetWorkExperience("2005-2014","ConpanyB");
            r2.DisPlay();

            Console.ReadKey();
        }
    }
}
