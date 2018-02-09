using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_工厂方法模式2
{
    class Program
    {
        //产品的打包生产
        static void Main(string[] args)
        {
            Creator[] creators = new Creator[2];
            creators[0] = new Resume();
            creators[1] = new Result();

            foreach (Creator creator in creators) {
                Console.WriteLine("The information of {0}:",creator.GetType().Name);
                foreach (Page page in creator.Pages) {
                    Console.WriteLine(page.GetType().Name);
                }
            }

            Console.ReadKey();
        }
    }
}
