// See https://aka.ms/new-console-template for more information

using System;
using System.Net.Http.Headers;

partial class Program
{  
    //Declaration we create a new datatype
    delegate void Compute(int n1, int n2);
    delegate void Contractor(double budget);
    static void Main()
    {
        Action<string, bool> Work = new Action<string, bool>((b, a) => Console.WriteLine($"{b},{a}"));
        Func<string, string> Print = (Name) => $"My name is:{Name}";
        Predicate<string> Updatedb = (v) =>
        {
            if (v == null) return false;
            else return true;
        };

        Work("Coding in C#", true);
        Console.WriteLine(Print("Keerthi"));
        Console.WriteLine(Updatedb(null));
       
    }
     
    private static void UsingGenericDelegates()
    {
        Action<double> RockyRaniRegisterMarriage = new Action<double>(
                    (budget) =>
                    {
                        Console.WriteLine($"Registration fees & Arrangement: {budget * 95 / 100}");
                        Console.WriteLine($"Reception Charges: {budget * 5 / 100}");
                    }
                    );

        Func<int, int, string> modifiedCompute = (n1, n2) => $"Addition:{n1 + n2}";
        modifiedCompute = (n1, n2) => $"Subtraction:{n1 - n2}";

        Predicate<int> IsActive = (v) =>
        {
            if (v == 0) return false;
            else return true;
        };

        //Invoke all above delegate
        RockyRaniRegisterMarriage(50000d);
        Console.WriteLine(modifiedCompute(100, 200));
        Console.WriteLine($"Output of Predicate : {IsActive(1)}");
    }

    private static void RockyRaniMarriageDelegate()
    {
        Contractor RockyRaniMarriage = new Contractor((b) => Console.WriteLine($"Pandit charges: {b * 20 / 100}"));
        RockyRaniMarriage += (b) => Console.WriteLine($"Catering Charges: {b * 50 / 100}");
        RockyRaniMarriage += (b) => Console.WriteLine($"Mandap Decoration: {b * 5 / 100}");
        RockyRaniMarriage += (b) => Console.WriteLine($"Couple arrive in Porsche reserved for 2 days: {b * 15 / 100}");

        //Get Rocky and Rani married viz. Invoke the delegate like a function
        RockyRaniMarriage(500000);
    }

    private static void UsingLambda()
    {
        //Instantiation
        Compute objShortCompute = new Compute((a, b) => Console.WriteLine($"Addition: {a + b}"));
        objShortCompute += (s, t) => Console.WriteLine($"Subtraction:{s - t}");
        objShortCompute += (a, b) => Console.WriteLine($"Multiplication:{a * b}");
        objShortCompute += (s, t) => Console.WriteLine($"Division:{s / t}");

        //Invocation like calling a function
        objShortCompute(250, -50);
    }

    private static void DelegatesUsingLongCutTechnique()
    {
        //Instantiation
        Compute objCompute = new Compute(AddFn);
        objCompute += SubFn;
        objCompute += MulFn;
        objCompute += DivFn;

        //Invoke the delegate exactly like a function
        objCompute(100, 200);
    }

    static void AddFn(int n1, int n2)
    {
        Console.WriteLine($"Output of Addition:{n1+n2}");
    }

   static void SubFn(int n1, int n2)
    {
        Console.WriteLine($"Output of Subtraction:{n1-n2}");
    }

   static void MulFn(int n1, int n2)
    {
        Console.WriteLine($"Output of Multiplication:{n1*n2}");
    }

   static void DivFn(int n1, int n2)
    {
        Console.WriteLine($"Output of Divison: {n1/n2}");
    }
}
