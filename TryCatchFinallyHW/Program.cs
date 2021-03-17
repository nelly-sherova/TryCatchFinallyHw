using System;
using System.Linq;
namespace TryCatchFinallyHW
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Task 1");
            Console.ResetColor();
            Console.Write("Enter text: "); string text = Console.ReadLine();
            var answer = new string(text.Select(i => i == 'a' ? '1' : i == 'e' ? '2' :
                                                      i == 'i' ? '3' : i == 'o' ? '4' :
                                                      i == 'u' ? '5' : i).ToArray());
            Console.WriteLine(answer);
        }
    }
}
