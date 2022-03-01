using System;

namespace EX33_hint
{
    class Program
    {
        static void Main(string[] args)
        {
            RectAngle rectAngle1 = new RectAngle(5, 4);
            RectAngle rectAngle2 = new RectAngle(6, 2);
            if (rectAngle1 == rectAngle2)
            {
                Console.WriteLine("同じ四角形");
            }
            else
            {
                Console.WriteLine("違う四角形");
            }
            Console.WriteLine($"rectAngle1とrectAngle2の二つの四角形が入る四角形の面積は{rectAngle1 + rectAngle2}");
        }
    }
}
