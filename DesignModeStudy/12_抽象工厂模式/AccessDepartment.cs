using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_抽象工厂模式
{
    public class AccessDepartment : IDepartment
    {
        public Department GetDepartment(int id)
        {
            Console.WriteLine("从Accesss数据库，根据id获取一条Department记录");
            return null;
        }

        public void Insert(Department department)
        {
            Console.WriteLine("从Accesss数据库，插入一条Department记录");
        }
    }
}
