using System;

namespace EX33_hint
{
    class Program
    {
        static void Main(string[] args)
        {
            RectAngle rectAngle1 = new RectAngle(5, 4);
            RectAngle rectAngle2 = new RectAngle(6, 2);
            Console.WriteLine($"{rectAngle1 + rectAngle2}");
        }
    }
}
