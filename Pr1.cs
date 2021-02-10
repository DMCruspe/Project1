using System;

namespace ConsoleApp4
{ 
    public delegate int Operation(int x, int y, int z);

    class Program
    {
        private static int Sub(int x, int y, int z)
        {
            return x - y;
        }

        static void Main(string[] args)
        {
            Operation op = Sub;

            op += delegate (int x, int y, int z) { return (x + y + z) / 3; };

            Console.WriteLine(op(3, 9, 3));
        }
    }
}
