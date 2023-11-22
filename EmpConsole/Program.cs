// See https://aka.ms/new-console-template for more information

using EmpConsole;
using EmpDal;
using EmpLib;
using System.Xml.Linq;


Person Rohit = new Person();
Rohit.Name = "Rohit";
Console.WriteLine(Rohit.Eat());

Person Lekha = new Person();
Lekha.Name = "Lekha";
Console.WriteLine(Lekha.Work());

//Base=Derived()
Person Rushabh = new EmpLib.Employee() { Designation = "Intern", DOJ = DateTime.Now.AddMonths(-1) };
Rushabh.Name = "Rushabh";
((EmpLib.Employee)Rushabh).Designation = "Analyst";
Console.WriteLine(Rushabh.Work());
Console.WriteLine($"EmpId for {Rushabh.Name} is {((EmpLib.Employee)Rushabh).EmpId}");

Console.WriteLine(((EmpLib.Employee)Rushabh).AttendTraining("C2C"));

//Polymorphism
Father SharmajisFather = new Father();
Father SharmajiFather = new Father();
Console.WriteLine($"sharmaji's Father :{SharmajiFather.settle()}");
Console.WriteLine($"sharmaji's father get married:{SharmajiFather.settle()}");
Console.WriteLine($"Sharmaji's father's concept of drawing (Using abstract): {SharmajisFather.Drawing()}");
Console.WriteLine($"Sharmaji's father's concept of drawing (Using abstract): {SharmajisFather.WhatIsDating()}");


//using virtual, modifications are allowed using override. Overridden behaviour is executed as below
Father Sharmaji = new Child();
Console.WriteLine($"sharmaji :{Sharmaji.settle()}");
Console.WriteLine($"sharmaji get married :{Sharmaji.getmarried()}");
Console.WriteLine($"Sharmaji's concept of drawing (using abstract): {Sharmaji.Drawing()}");
Console.WriteLine($"Sharmaji's concept of drawing (using abstract): {Sharmaji.WhatIsDating()}");




//No virtual, modification disallowed by base class, forced modify using 'new' keyword.Forced execution of derived class using 
//typecasting((Child)SharmajiV2).GetMarried()
Father SharmajiV2 = new Child();
Console.WriteLine($"SharmajiV2 get married: {((Child)SharmajiV2).getmarried()}");

//See Overloading-Compile-time polymorphism below
EmpLib.Employee Vidyasagar = new EmpLib.Employee();
Vidyasagar.Name = "Vidyasagar";
Vidyasagar.Designation = "Security Systems Analyst";
Console.WriteLine(Vidyasagar.Work());
Console.WriteLine(Vidyasagar.Work("Solving bugs"));

//Exposing non-public information through public methods
EmpLib.Employee Srikar = new EmpLib.Employee();
Srikar.SetTaxInfo("I'm eligible in the 20% tax payer category");
Console.WriteLine(Srikar.GetTaxinfo());

//Test calling one constructor from another
Person Sricharan = new Person("768490874567", "+91 9342567231");
//This constructor should call the constructor that sets the aadhar number
Console.WriteLine($"Aadhar:{Sricharan:Aadhar}|Mobile Number:{Sricharan.MobileNumber}");

Console.WriteLine($"Total Employee Count:{EmpUtils.EmpCount}");

//Adding employees to a temporary db-using static List<Employee>
EmpUtils.EmpDb.Add(Srikar);
EmpUtils.EmpDb.Add(Vidyasagar);
EmpUtils.EmpDb.Add(new EmpLib.Employee("456789045667", "+91 94536789067") { Name = "Nidha", Designation = "Analyst", Salary = 500000 });
EmpUtils.EmpDb.Add(new EmpLib.Employee("567890765467", "+91 97896789068") { Name = "Keerthi", Designation = "Analyst", Salary = 60000});
EmpUtils.EmpDb.Add(new EmpLib.Employee("890745667906", "+91 94532167897") { Name = "Mahesh", Designation = "Sr Analyst", Salary =90000});

//Get all employees whose aadhar card starts with AA

var resultList= EmpUtils.EmpDb.Where((emp) => emp.Aadhar!= null && emp.Aadhar.StartsWith("AA"));
resultList.ToList().ForEach((emp) => Console.WriteLine($"{emp.Name} | {emp.Aadhar} | {emp.Designation}"));
Console.WriteLine(resultList);

//Get all employees with salary greater than 6L
var res = EmpUtils.EmpDb.Where((emp) => emp.Salary > 6000000);
res.ToList().ForEach((emp)=> Console.WriteLine($"{emp.Name}|{emp.Salary}"));
Console.WriteLine(res);


EmpDbContext dbContext = new EmpDbContext();

CrudEFEmp<EmpDal.Employee>.insertemp("seema", true);



CrudEFEmp<EmpDal.Employee>.update("Master Varun", "Baby Barbie");

CrudEFEmp<EmpDal.Employee>.delete("Imposter Hacker");








