using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_装饰模式2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("MajorTom");
            Tshirts tshirts = new Tshirts();
            BigTrouser bigTrouser = new BigTrouser();
            Shoes shoes = new Shoes();

            tshirts.WearClothes(person);
            bigTrouser.WearClothes(tshirts);
            shoes.WearClothes(bigTrouser);

            shoes.Show();

            Console.ReadKey();
        }
    }
}
