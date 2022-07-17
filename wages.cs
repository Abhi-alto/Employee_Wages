using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EmployeeWage
{
    internal class Wages
    {
        public int rndm()               //for geting a random number
        {
            Random ran = new Random();
            return (ran.Next(0, 2));               //randomly checking present or absent
        }
        public static int wage()                //for calculating the wage through switch case
        {
            int WaPhr = 20;
            Console.WriteLine("Enter 1 - Part time & 2- for full time employee");    //either part time or full time employee
            int choice = Convert.ToInt16(Console.ReadLine());
            int day_hr = 0;
            switch (choice)
            {
                case 1:
                    day_hr = 4;
                    break;
                case 2:
                    day_hr = 8;
                    break;
                default:
                    day_hr = 0;
                    break;
            }
            if (day_hr == 0)
            {
                Console.WriteLine("Wrong input");
                return 0;
            }
            else
            {
                return (WaPhr * day_hr);
            }
        }
    }
}
