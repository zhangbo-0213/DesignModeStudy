using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_享元模式2
{
    public class WebsiteFactory
    {
        private Hashtable hashtable = new Hashtable();

        public Website GetWebsite(string key) {
            if (!hashtable.Contains(key)) {
                hashtable.Add(key, new ConcreteWebsite(key));
            }
            return (Website)hashtable[key];
        }

        //获得实例总数
        public int GetCounts() {
            return hashtable.Count;
        }
    }
}
