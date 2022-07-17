using EmployeeWage;
Console.WriteLine("Welcome to Employee Wage Computation program");

IEmployeeWageForCompany comp = new Wages();
comp.AddDetails("TATA", 200, 20, 8);
comp.AddDetails("IBM", 300, 25, 9);
comp.AddDetails("TCS", 200, 25, 9);
comp.AddDetails("Mahindra", 280, 20, 8);
comp.AddDetails("L&T", 150, 27, 9);
comp.perCompany();