using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class ParticularCompany                          //stores the particular company details
    {
        public String company;
        public int WaPhr;
        public int max_workDays;
        public int max_workHrs;
        public int totalWage;
        public ParticularCompany(String company, int WaPhr, int max_workDays, int max_workHrs)
        {
            this.company = company;
            this.WaPhr = WaPhr;
            this.max_workDays = max_workDays;
            this.max_workHrs = max_workHrs;
        }
        public void TWage(int totalWage)                    //TWage stores the total wage of an employee in a company
        {
            this.totalWage = totalWage;
        }
    }
}
