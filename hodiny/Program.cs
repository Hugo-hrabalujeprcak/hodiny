// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
while (1 + 1 == 2)
{
    DateTime cas = DateTime.Now;
    if (cas.Hour == 12)
        Console.WriteLine("cas na pivco");
    Console.WriteLine(cas);
    Console.WriteLine(DateTime.Now.DayOfWeek);
    Thread.Sleep(1000);
    Console.Clear();
}
