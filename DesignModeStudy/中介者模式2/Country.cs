using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 中介者模式2
{
    public abstract class Country
    {
        protected UnitedNations unitedNations;
        public Country(UnitedNations unitedNations) {
            this.unitedNations = unitedNations;
        }
    }
}
