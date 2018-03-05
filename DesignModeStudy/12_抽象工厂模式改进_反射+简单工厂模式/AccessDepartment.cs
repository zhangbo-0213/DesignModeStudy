using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_抽象工厂模式改进_反射_简单工厂模式
{
    public class AccessDepartment : IDepartment
    {
        public Department GetDepartment(int id)
        {
            Console.WriteLine("从Access数据库，根据id返回一条Department记录");
            return null;
        }

        public void Insert(Department department)
        {
            Console.WriteLine("从Access数据库，插入一条Department记录");
        }
    }
}
