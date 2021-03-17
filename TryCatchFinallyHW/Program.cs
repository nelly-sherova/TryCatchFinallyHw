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
            var selectedText = new string(text.Select(t => t == 'a' ? '1' : t == 'e' ? '2' :
                                                      t == 'i' ? '3' : t == 'o' ? '4' :
                                                      t == 'u' ? '5' : t).ToArray());
            Console.WriteLine(selectedText);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Task 2");
            Console.ResetColor();
            Console.Write("Enter text: "); string text2 = Console.ReadLine();
            var selectedText2 = new string(text2.Select(t => t == '1' ? 'a' : t == '2' ? 'e' :
                                                      t == '3' ? 'i' : t == '4' ? 'o' :
                                                      t == '5' ? 'u' : t).ToArray());
            Console.WriteLine(selectedText2);
        }
    }
}
