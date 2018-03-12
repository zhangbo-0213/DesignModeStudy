using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_备忘录模式2
{
    class Program
    {
        static void Main(string[] args)
        {
            Role role = new Role();
            role.Hea = 100;
            role.Atk = 100;
            role.Def = 100;
            role.ShowState();

            RoleMomentoTaker taker = new RoleMomentoTaker();
            taker.RoleMomento = role.CreateRoleMemento();

            role.Hea = 40;
            role.Atk = 50;
            role.Def = 80;
            role.ShowState();

            //恢复状态
            role.SetStateMemento(taker.RoleMomento);
            role.ShowState();

            Console.ReadKey();

        }
    }
}
