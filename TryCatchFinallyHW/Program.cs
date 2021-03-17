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

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Task 3");
            Console.ResetColor();
            Console.Write("Enter text:  "); string text3 = Console.ReadLine();
            var number1 = new string(text3.TakeWhile(t => t != '+' && t != '-' && t != '*' && t != '/').
                                      Where(t => t >= '0' && t <= '9').ToArray());
            var number2 = new string(text3.SkipWhile(t => t != '+' && t != '-' && t != '*' && t != '/').
                                     Where(t => t >= '0' && t <= '9').ToArray());

            var num1 = new string(text3.TakeWhile(i => i != '+' && i != '-' && i != '*' && i != '/').
                                      Where(i => i >= '0' && i <= '9').ToArray());

            var Operator = text3.First(t => t == '+' || t == '-' || t == '*' || t == '/');
            var  mathOperation = MathOperation(number1, Operator, number2);
            Console.WriteLine($"Result : {Operator}");
            Console.WriteLine($"Because {int.Parse(number1)} {Operator} {int.Parse(number2)} = {mathOperation}");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Task 4");
            Console.ResetColor();
            Console.Write("Enter text: "); string text4 = Console.ReadLine();
            char[] space = new string(' ', text4.Length).ToCharArray();
            var ans = string.Join("", text4.Zip(space, (ltr, spc) => (ltr >= 'A' && ltr <= 'Z') ? spc.ToString() + ltr.ToString() : ltr.ToString()));
            Console.WriteLine(ans);
        }
        public static string MathOperation(string number1, char oper, string number2)
        {
            decimal ans = 0;
            switch (oper)
            {
                case '+':
                    ans = int.Parse(number1) + int.Parse(number2);
                    break;
                case '-':
                    ans = int.Parse(number1) - int.Parse(number2);
                    break;
                case '*':
                    ans = int.Parse(number1) * int.Parse(number2);
                    break;
                case '/':
                    ans = int.Parse(number1) / int.Parse(number2);
                    break;
                default:
                    break;
            }
            return Math.Round(ans).ToString();
        }
    }
}
