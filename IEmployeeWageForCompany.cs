using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EmployeeWage
{
    public interface IEmployeeWageForCompany
    {
        public void AddDetails(String company, int WaPhr, int max_workDays, int max_workHrs);
        public void perCompany();
        public int wage(int wage);
        public int compute(ParticularCompany company);
        public void QuerrySolved(String CheckCompany);
    }
}
