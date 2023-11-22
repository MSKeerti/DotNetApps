// See https://aka.ms/new-console-template for more information
using TestDal;
using TestDbConsole;

Console.WriteLine("Hello, World!");

CrudEF<Parent>.Add("Seema", true);
CrudEF<Parent>.Add("Master Varun", true);
CrudEF<Parent>.Add("Master Varun", false);

CrudEF<Parent> .Update("Imposter Hacker","Baby Barbie");

CrudEF<Parent>.Add("Imposter Hacker", false);

CrudEF<Parent>.Delete("Imposter Hacker");

var result = CrudEF<Parent>.SearchOne("Baby Barbie");
Console.WriteLine($"Search matches:{result.Name}");

//Get records
CrudEF<Parent>.Get()
    .ForEach((p) =>
    {
        if (p.IsActive == true)
            Console.WriteLine($"{p.Name} is an {p.IsActive} parent");
        else
            Console.WriteLine($"{p.Name} is child");
    });


    