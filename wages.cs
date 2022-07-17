using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EmployeeWage
{
    internal class Wages
    {
        public static int Rndm()
        {
            Random ran = new Random();
            return (ran.Next(0, 2));
        }
        public static int wagee()
        {
            int WaPhr = 20;
            int F_DaHr = 8;
            return (WaPhr * F_DaHr);

        }
    }
}
