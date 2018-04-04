using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_享元模式
{
    public class FlyweightFactory
    {
        private Hashtable flyweights = new Hashtable();

        public Flyweight GetFlyweight(string key) {
            if (!flyweights.Contains(key))
            {
                Console.WriteLine("不存在该实例，创建新的实例");
                flyweights.Add(key, new ConcreteFlyweight());
            }
            else {
                Console.WriteLine("存在该实例，返回已存在实例");
            }
            return (Flyweight)flyweights[key];
        }
    }
}
