using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_抽象工厂模式
{
    public class SqlServerDepartment : IDepartment
    {
        public Department GetDepartment(int id)
        {
            Console.WriteLine("从SqlServer数据库，根据id返回一条Department记录");
            return null;
        }

        public void Insert(Department department)
        {
            Console.WriteLine("从SqlServer数据库，插入一条Department记录");
        }
    }
}
