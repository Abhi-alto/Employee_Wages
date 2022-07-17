using EmployeeWage;
Console.WriteLine("Welcome to Employee Wage Computation program");

IEmployeeWageForCompany comp = new Wages();
comp.AddDetails("TATA", 200, 20, 100);
comp.AddDetails("IBM", 300, 25, 100);
comp.AddDetails("TCS", 200, 25, 100);
comp.AddDetails("Mahindra", 280, 20, 100);
comp.AddDetails("L&T", 150, 27, 100);
comp.perCompany();
comp.QuerrySolved("IBM");