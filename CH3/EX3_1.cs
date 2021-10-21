using System;

namespace EX3_1
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Width of Rect :");
            string width = Console.ReadLine();

            Console.WriteLine("Height of Rect :");
            string height = Console.ReadLine();

            int widthI = Convert.ToInt32(width);
            int heightI = Convert.ToInt32(height);

            Console.WriteLine("Area of Rect : {0}", widthI * heightI);
        }
    }
}