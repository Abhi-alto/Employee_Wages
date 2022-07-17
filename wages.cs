using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EmployeeWage
{
    public interface IEmployeeWageForCompany
    {
        public int rndm();
        public int wage();
        public void compute();
    }
    internal class Wages : IEmployeeWageForCompany
    {
        static int day_hr;
        //static int WaPhr = 20;
        public String company;
        public int WaPhr;
        public int max_workDays;
        public int max_workHrs;
        public int ToMonWag = 0;                  //total Monthly working wage
        public Wages(String company, int WaPhr, int max_workDays, int max_workHrs)
        {
            this.company = company;
            this.WaPhr = WaPhr;
            this.max_workDays = max_workDays;
            this.max_workHrs = max_workHrs;
        }
        public int rndm()               //for geting a random number
        {
            Random ran = new Random();
            return (ran.Next(0, 2));               //randomly checking present or absent
        }
        public int wage()                //for calculating the daily wage through switch case
        {
            int ch = new Random().Next(0, 3);
            day_hr = 0;
            switch (ch)
            {
                case 1:
                    day_hr = 4;
                    // Console.WriteLine("Employee is working Part Time");
                    break;
                case 2:
                    day_hr = 8;
                    // Console.WriteLine("Employee is working Full Time");
                    break;
                default:
                    day_hr = 0;
                    // Console.WriteLine("Absent");
                    break;
            }
            return (WaPhr * day_hr);
        }
        public void compute()                //for calculating the monthly wage for each company
        {
            Console.WriteLine(company);
            int days = 0;
            int totHrs = 0;                     //total hrs present or absent

            while (days < max_workDays && totHrs < max_workHrs)
            {
                //Wages obj = new Wages();
                ToMonWag = ToMonWag + (wage());
                days++;
                totHrs = totHrs + day_hr;
                if (totHrs > max_workHrs)                           //If day <20 &  total hrs > max_workHrs
                {
                    ToMonWag = ToMonWag - ((totHrs - max_workHrs) * WaPhr);
                }
            }
            Console.WriteLine("Total wage of the employee for the month is = Rs." + ToMonWag);  //total monthly wage of the employee
        }
    }
}