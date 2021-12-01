using System;

namespace pr2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            Console.WriteLine("Задание I.\nТочка в области?\n");
            try
            {
                Console.Write("x: ");
                x = double.Parse(Console.ReadLine());
                Console.Write("y: ");
                y = double.Parse(Console.ReadLine());
                Console.WriteLine();
                if (x * x + y * y < 100 && y < (Math.Abs(x)))
                    Console.WriteLine("Да");
                else if (x * x + y * y == 625 || y == 0 || y == (Math.Abs(x)))
                    Console.WriteLine("На границе");
                else Console.WriteLine("Нет");
            }
            catch (Exception)
            {
                Console.WriteLine("Что-то не так");
            }

        }
    }
}
