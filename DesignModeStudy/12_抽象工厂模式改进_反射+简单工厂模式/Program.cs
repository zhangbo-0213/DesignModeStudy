using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_抽象工厂模式改进_反射_简单工厂模式
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            Department department = new Department();

            IUser iuser= DataAccess.CreateUser();
            iuser.Insert(user);
            iuser.GetUser(1);

            IDepartment idepartment = DataAccess.CreateDepartment();
            idepartment.Insert(department);
            idepartment.GetDepartment(1);

            Console.ReadKey();
        }
    }
}
