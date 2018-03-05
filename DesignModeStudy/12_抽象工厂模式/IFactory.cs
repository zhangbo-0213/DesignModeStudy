using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_抽象工厂模式
{
    public interface IFactory
    {
        IUser CreateUser();
        IDepartment CreateDepartment();
    }
}
