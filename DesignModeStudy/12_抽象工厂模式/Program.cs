using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_抽象工厂模式
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            Department department = new Department();

            IFactory factory = new SqlServerFactory();
            IUser iu = factory.CreateUser();
            iu.Insert(user);
            iu.GetUser(1);

            IDepartment id = factory.CreateDepartment();
            id.Insert(department);
            id.GetDepartment(1);

            Console.ReadKey();
        }
    }
}
