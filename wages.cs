using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EmployeeWage
{
    internal class Wages
    {
        static int day_hr;
        public int rndm()               //for geting a random number
        {
            Random ran = new Random();
            return (ran.Next(0, 2));               //randomly checking present or absent
        }
        public static int wage(int ch)                //for calculating the daily wage through switch case
        {
            int WaPhr = 20;
            day_hr = 0;
            switch (ch)
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
            return (WaPhr * day_hr);
        }
        public static void compute(int ch)                //for calculating the monthly wage 
        {
            int days = 0;
            int totHrs = 4;                     //B/c time limit will only come if person is full time , then at the day 12th total hrs =96 , one more day and hrs=104 therefore to satisfy the condition of 100 hrs
            int ToMonWag = 0;                  //Monthly working days
            int wa = Wages.wage(ch);                                 //called static method wage
            while (days < 20 && totHrs < 100)    //loop for checking no. of hrs<101 and total daysless than 21
            {
                Wages random = new Wages();         //creating object for class wage for non-static functions
                int r = random.rndm();            //Calling a non-static function
                if (r == 1)
                {
                    Console.WriteLine("Employee is Present today ");
                    ToMonWag = ToMonWag + wa;
                    days++;                //when employee is present increment the day number
                    totHrs = totHrs + day_hr;
                }
                else
                {
                    Console.WriteLine("Employee is Absent today ");
                    days++;                //when employee is absent increment the day number and day_hr but wage not calculated
                    totHrs = totHrs + day_hr;
                }
            }

            Console.WriteLine("Total wage of the employee for the month is = Rs." + ToMonWag);  //total monthly wage of the employee
        }
    }
}
