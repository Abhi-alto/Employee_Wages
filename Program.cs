using EmployeeWage;
Console.WriteLine("Welcome to Employee Wage Computation program");
IEmployeeWageForCompany IBM = new Wages("IBM", 30, 18, 80);
IBM.compute();
IEmployeeWageForCompany TATA = new Wages("TATA", 35, 25, 115);
TATA.compute();