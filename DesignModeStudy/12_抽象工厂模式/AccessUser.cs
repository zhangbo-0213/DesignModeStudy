using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_抽象工厂模式
{
    public class AccessUser : IUser
    {
        public User GetUser(int id)
        {
            Console.WriteLine("从Access数据库，根据id返回一条User记录");
            return null;
        }

        public void Insert(User user)
        {
            Console.WriteLine("从Access数据库，插入一条User记录");
        }
    }
}
