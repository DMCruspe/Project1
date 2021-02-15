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


            Switch();

            switch (Convert.ToChar(Console.ReadLine()))
            {
                case '+' :
                    Operation add = (x, y) => x + y;
                    Console.WriteLine("Результат: " + add(x, y)); break;
                case '-':

                    Operation sub = (x, y) => x - y;
                    Console.WriteLine("Результат: " + sub(x, y)); break;
                case '*':
                    Operation mul = (x, y) => x * y;
                    Console.WriteLine("Результат: " + mul(x, y)); break;
                case '/':
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

        static void Switch()
        {
            Console.WriteLine("Выберите действие: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("+, -, *, /");
            Console.ResetColor();
            
        }
    }
}
