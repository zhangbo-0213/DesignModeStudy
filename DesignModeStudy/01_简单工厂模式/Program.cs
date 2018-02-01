using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_简单工厂模式
    //简单工厂模式：通过一个专门的类来管理类的实例的生成，这个类充当“工厂”角色，生产产品
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("请输入第一个数字：");
                double numA = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("请输入第二个数字：");
                double numB = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("请输入运算符：");
                string str = Console.ReadLine();
                Operation oper = OperationFactory.CreatOperation(str);
                oper.NumA = numA;
                oper.NumB = numB;
                Console.WriteLine("运算结果是{0}", oper.GetResult());
            }
            catch (Exception ex){
                Console.WriteLine("您的输入有误："+ex.Message);
            }

            Console.ReadKey();
        }
    }
}
