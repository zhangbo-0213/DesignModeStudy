using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Configuration;

namespace _12_抽象工厂模式改进_反射_简单工厂模式
{
    public class DataAccess
    {
        private static readonly string AssemblyName = "12_抽象工厂模式改进_反射+简单工厂模式";
        private static readonly string namespaceName = "_12_抽象工厂模式改进_反射_简单工厂模式";
        //使用配置文件的方式存储字符串的值，在发生变化时，避免源码修改再编译
        private static readonly string db =ConfigurationSettings.AppSettings["DB"];

        public static IUser CreateUser() {
            string className = namespaceName + "." + db + "User";
            //使用反射创建实例
            return (IUser)Assembly.Load(AssemblyName).CreateInstance(className);
        }

        public static IDepartment CreateDepartment() {
            string className = namespaceName + "." + db + "Department";
            return (IDepartment)Assembly.Load(AssemblyName).CreateInstance(className);
        }
    }
}
