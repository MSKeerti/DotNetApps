// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");*/
//Working with datatypes
/*int num1 = 100;
int num2 = 100;
Console.WriteLine("Sum = " + (num1 + num2));

//Declaration-alternate way
var num3 = 200;
var formattedFloat = 200f;
var formattedDouble = 200d;
var formattedDecimal = 200m;

Console.WriteLine(num3.GetType().Name);
Console.WriteLine(formattedFloat.GetType().Name);
Console.WriteLine(formattedDouble.GetType().Name);
Console.WriteLine(formattedDecimal.GetType().Name);

//Concatenation using String Interpolation
Console.WriteLine($"The datatype of num is {num3.GetType().Name}");
Console.WriteLine($"The datatype of num is {formattedFloat.GetType().Name}");
Console.WriteLine($"The datatype of num is {formattedDouble.GetType().Name}");
Console.WriteLine($"The datatype of num is {formattedDecimal.GetType().Name}");

//other types
bool isEverythingOk = true;
string greetMessage = "Hello welcome to C# training session";
char iamSingle = 'S';

Console.WriteLine($"Value of {nameof(isEverythingOk)} is {isEverythingOk}");

//Function
void WorkingWithDatatypes()
{
    //Working with datatypes
    int num1 = 100;
    int num2 = 100;
    Console.WriteLine("Sum = " + (num1 + num2));

    //Declaration-alternate way
    var num3 = 200;
    var formattedFloat = 200f;
    var formattedDouble = 200d;
    var formattedDecimal = 200m;

    Console.WriteLine(num3.GetType().Name);
    Console.WriteLine(formattedFloat.GetType().Name);
    Console.WriteLine(formattedDouble.GetType().Name);
    Console.WriteLine(formattedDecimal.GetType().Name);

    //Concatenation using String Interpolation
    Console.WriteLine($"The datatype of num is {num3.GetType().Name}");
    Console.WriteLine($"The datatype of num is {formattedFloat.GetType().Name}");
    Console.WriteLine($"The datatype of num is {formattedDouble.GetType().Name}");
    Console.WriteLine($"The datatype of num is {formattedDecimal.GetType().Name}");

    //other types
    bool isEverythingOk = true;
    string greetMessage = "Hello welcome to C# training session";
    char iamSingle = 'S';

    Console.WriteLine($"Value of {nameof(isEverythingOk)} is {isEverythingOk}");

}
WorkingWithDatatypes();
ConversionOfTypes();

void ConversionOfTypes()
{
    int num1 = 100;
    double num2 = 100;
    bool isEverythingOk = true;
    string str = "Hello";
    string strNum = "100";

    var result1 = (double)num1;
    var result2 = (int)num2;
    //var result3 = (string)isEverythingOk; //string on heap & bool on stack.Hence error in casting

    var convert1 = Convert.ToString(null);
    var convert2 = Convert.ToInt32(str);
    //var convert3 = Convert.ToInt32(str); //Error at runtime


    Console.WriteLine(convert1);
    Console.WriteLine(convert2);
    //Console.WriteLine(convert3);

}*/

/*void WorkingWithArrays()
{
    int[] arr = new int[3];
    arr[0] = 10;
    arr[1] = 20;
    arr[2] = 30;

    string[] greetings = { "Namaste", "Hello", "Hola" };
    int[] evens = { 2, 4, 6, 8, 10 };
    object[] objArray = { 100, "Ok", new int[] { 1, 2, 3 } };

    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"Value of item: {arr[i]}");
    }

    int counter = 0;
    while (counter < greetings.Length)
    {
        Console.WriteLine($"A new way to Greet: {greetings[counter]}");
        counter++;
    }
    do
    {
        Console.WriteLine($"The next even number is: {evens[counter]}");
        counter++;
    } while (counter < evens.Length);

    foreach (var singleitem in objArray)
    {
        if (singleitem.GetType().Name == "Int32[]")
        {

            foreach (var item in (Int32[])objArray[2])
            {
                Console.WriteLine(item); //item: corresponds to the value at a position
            }
        }
        else
        {
            Console.WriteLine($"Single item in {nameof(objArray)}: {singleitem}");
        }
    }

}
WorkingWithArrays();*/


using System.Data;
using System.Diagnostics;

void WorkingWithCollections()
{
    List<string> shoppingList = new List<string>();
    Console.WriteLine($"Total items in shopping bag:{shoppingList.Count()}");
    shoppingList.Add("Bags");
    Log(new object[] { " Item added:", shoppingList[0] });
    shoppingList.Add("Dresses");
    Log(new object[] { " Item added:", shoppingList[1]});
    shoppingList.Add("Shoes");
    Log(new object[] { " Item added:", shoppingList[2] });
    //Print
    PrintValues(shoppingList); 
    Console.WriteLine($"Total items in shopping bag:{shoppingList.Count()}");
    shoppingList.Remove("Shoes");
    Log(new object[] { " Item removed:", "shoes" });
    //Print
    PrintValues(shoppingList);
    Console.WriteLine($"Total items in shopping bag:{shoppingList.Count()}");
    ////////
    ///
    Print(new object[] {"Comma-separated values of the shoping list",
                 shoppingList[0],
    shoppingList[1],
    "\n The total count of item is:",
    shoppingList.Count() });

}
WorkingWithCollections();

void PrintValues<T>(List<T> pCollection)
{
    //use code snippet: foreach
    foreach(var item in pCollection)
    {
        Console.WriteLine(item);
    }
}

void Print(object[] pValues)
{
    string result = " ";
    foreach (var item in pValues)
    {
        result = $"{result},{item}";
    }
    result = result.TrimStart(',');
    Console.WriteLine(result);
}


void Log(object[] pValues)
{
    string result = " ";
    foreach (var item in pValues)
    {
        result = $"{result} {item}";
    }

    var finalResult = $"[ {DateTime.Now.ToString()}]: {result}";
    //Console Logging
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("----------");
    Console.WriteLine(finalResult);

    //Output Window
    Debug.WriteLine("-----LOG------");
    Debug.WriteLine(finalResult);
}

//create variable
Utils objutils = new Utils();
class Utils
{

}
