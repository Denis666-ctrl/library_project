using System;
using git_library;
namespace git_library_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 func = new Class1();
            func.HelloWorld();

            func.AddAndPrint(3, 4);

            string greeting = func.GetGreeting("Денис");
            Console.WriteLine(greeting);

            int sum = func.AddNumbers(5, 20);
            Console.WriteLine($"Сумма: {sum}");

            bool isEven = func.IsEven(14);
            Console.WriteLine($"Число 14 четное? {isEven}");
        }
    }
}