using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_抽象工厂模式改进_反射_简单工厂模式
{
    public interface IDepartment
    {
        void Insert(Department department);
        Department GetDepartment(int id);
    }
}
