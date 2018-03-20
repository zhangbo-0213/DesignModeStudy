using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_单例模式
{
    public class Singleton
    {
        private static Singleton instance;

        //创建静态只读的进程辅助对象
        private static readonly object syncRoot = new object();

        private Singleton() {

        }

        public static Singleton GetInstace() {
            //对进程加锁，确保同一时刻只有一个进程进行对象实例的创建
            //lock:确保当一个线程位于代码的临界区时，另一个线程不进入临时区。如果其他线程试图进入锁定的代码
            //将会一直等待（即被阻止）直到该对象被释放
            if (instance == null) {
                //由于在加锁时instance对象实例还没有被创建，因此需要使用进程辅助对象syncRoot作为参数传入
                lock (syncRoot) {
                    //这里进行二次判断，是由于当实力没有被创建时，多个线程仍然可以进入第一层判断，被lock后
                    //第一个进程进入lock内，创建了实例后，为了防止在等待完成后进入lock内后续线程继续创建实例
                    //需要再次进行实例是否生成的判断
                    if (instance == null) {
                        instance = new Singleton();
                    }
                }
            }
            return instance;
        }
    }
}
