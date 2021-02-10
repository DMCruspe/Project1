using System;

namespace ConsoleApp5
{
    class Program
    {
        delegate int Operation(int x, int y);

        static void Main(string[] args)
        {
            Console.Write("Укажите первое число: ");
                int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Укажите второе число: ");
                int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Выберите действие: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" 1 - сумма");
            Console.WriteLine(" 2 - вычитание");
            Console.WriteLine(" 3 - умножение");
            Console.WriteLine(" 4 - деление");
            Console.ResetColor();


            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    Operation add = (x, y) => x + y;
                    Console.WriteLine("Результат: " + add(x, y)); break;
                case 2:

                    Operation sub = (x, y) => x - y;
                    Console.WriteLine("Результат: " + sub(x, y)); break;
                case 3:
                    Operation mul = (x, y) => x * y;
                    Console.WriteLine("Результат: " + mul(x, y)); break;
                case 4:
                    if (y > 0)
                    {
                        Operation div = (x, y) => x / y;
                        Console.WriteLine("Результат: " + div(x, y));
                    }
                    else
                    {
                        Console.WriteLine("На ноль делить нельзя!!!");
                    }
                    break;
                    default:
                        Console.WriteLine("Введите другое число!"); break;
                }
            
            
        }
    }
}
