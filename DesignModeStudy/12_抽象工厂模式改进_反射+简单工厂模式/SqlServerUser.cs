using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_抽象工厂模式改进_反射_简单工厂模式
{
    public class SqlServerUser : IUser
    {
        public User GetUser(int id)
        {
            Console.WriteLine("从SqlServer数据库，根据id获取一条User记录");
            return null;
        }

        public void Insert(User user)
        {
            Console.WriteLine("从SqlServer数据库,插入一条User记录");
        }
    }
}
