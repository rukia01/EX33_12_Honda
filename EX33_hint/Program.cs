using System;

namespace EX33_hint
{
    class Program
    {
        static void Main(string[] args)
        {
            RectAngle rectAngle1 = new RectAngle(10, 8);
            RectAngle rectAngle2 = new RectAngle(3, 2);
            var rectAngle3 = rectAngle1 + rectAngle2;
            if (rectAngle1 == rectAngle2)
            {
                Console.WriteLine("同じ四角形");
            }
            else
            {
                Console.WriteLine("違う四角形");
            }
            Console.WriteLine($"rectAngle1 + rectAngle2 = {rectAngle3.height} × {rectAngle3.width} = {rectAngle3.GetSurface()}");
        }
    }
}
