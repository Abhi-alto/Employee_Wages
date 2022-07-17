using EmployeeWage;
Console.WriteLine("Welcome to Employee Wage Computation program");
Console.WriteLine("Enter 1 - Part time & 2- for full time employee");    //either part time or full time employee
int choice = Convert.ToInt16(Console.ReadLine());
if (choice < 1 || choice > 2)
{
    Console.WriteLine("Wrong input");
}
else
{
    Wages.compute(choice);
}