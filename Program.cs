using EmployeeWage;
Console.WriteLine("Welcome to Employee Wage Computation program");
int r = Wages.Rndm();            //Calling a static function
if (r == 1)
{
    Console.WriteLine("Employee is Present");
    Console.WriteLine("Daily wage of the employee is = " + (Wages.wagee()));
}
else
{
    Console.WriteLine("Employee is Absent");
}