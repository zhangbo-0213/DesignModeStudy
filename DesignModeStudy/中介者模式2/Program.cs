using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 中介者模式2
{
    class Program
    {
        static void Main(string[] args)
        {
            UnitedNationsSecurityCouncil unitedNationsSecurityCouncil = new UnitedNationsSecurityCouncil();

            USA usa = new USA(unitedNationsSecurityCouncil);
            Iraq iraq = new Iraq(unitedNationsSecurityCouncil);

            unitedNationsSecurityCouncil.USA = usa;
            unitedNationsSecurityCouncil.Iraq = iraq;

            usa.Send("不准研制核武器，否则开战！");
            iraq.Send("没有核武器，也不怕开战！");

            Console.ReadKey();
        }
    }
}
