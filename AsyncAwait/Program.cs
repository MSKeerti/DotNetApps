// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/* Method3();
  Method4();
 void UseTraditionalThreading()
{
    Thread t1 = new Thread(new ThreadStart(Method1));
    Thread t2 = new Thread(new ThreadStart(Method2));

    t1.Start();
    t2.Start();
    Thread.Sleep(1000);  //Asking to delay an operation execution
}
void Method1() 
{
    for(int i=0; i<1000; i++)
    {
        Console.WriteLine($"METHOD 1: i={i}");
    }
}

void Method2()
{
    for (int i = 0; i < 100; i++)
    {
        Console.WriteLine($"METHOD 2: i={i}");
    }
}

async void Method3()
{
    for (int i = 0; i < 100; i++)
    {
        Console.WriteLine($"METHOD 3: i={i}");
    }
}

async void Method4()
{
    for (int i = 0; i < 100; i++)
    {
        Console.WriteLine($"METHOD 4: i={i}");
    }

}*/

await SimpleTask();

File.WriteAllText(@"SomeFile.txt", "blah blah blah");
string contents = await ReadFile();
Console.WriteLine(contents);
 
async Task SimpleTask()
{
    Console.WriteLine("Starting of the task");
    await Task.Delay(1000);  //force a delay
    Console.WriteLine("Task Complete");
}

async Task<string> ReadFile() 
{
    using (StreamReader r = new StreamReader(@"SomeFile.txt"))
    {
        return await r.ReadToEndAsync();
    }
}
