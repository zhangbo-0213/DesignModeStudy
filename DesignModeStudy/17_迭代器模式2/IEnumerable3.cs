using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_迭代器模式2
{
    public class IEnumerable3
    {
        public IEnumerator<string> GetEnumerator() {
            return Color();
        }

        //yield return 可以返回枚举器对象
         IEnumerator<string> Color() {
            yield return "red";
            yield return "green";
            yield return "blue";
        }
    }
}
