using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 中介者模式2
{
    public class UnitedNationsSecurityCouncil : UnitedNations
    {
        private USA usa;
        private Iraq iraq;

        public USA USA {
            set { this.usa = value; }
        }

        public Iraq Iraq {
            set { this.iraq = value; }
        }
        public override void Declare(string message, Country country)
        {
            if (country == usa)
                iraq.GetMessage(message);
            else
                usa.GetMessage(message);
        }
    }
}
