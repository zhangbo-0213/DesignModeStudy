using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_迭代器模式2
{
    public class IEnumerable2 
    {
        //yield return 可以返回可枚举类对象
        public IEnumerable<string> Color() {
            yield return "red";
            yield return "gren";
            yield return "blue";
        }
    }
}
