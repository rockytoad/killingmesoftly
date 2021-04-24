using System;

namespace ConsoleApp23
{
    class Program
    {
        static void Main(string[] args)
        {
            float x, y, dx, dy, step;
            float x1, y1, x2, y2;
            Console.WriteLine("input x1 : ");
            x1 = float.Parse(Console.ReadLine());
            Console.WriteLine("input y1 : ");
            y1 = float.Parse(Console.ReadLine());
            Console.WriteLine("input x2 : ");
             x2 = float.Parse(Console.ReadLine());
            Console.WriteLine("input y2 : ");
            y2 = float.Parse(Console.ReadLine());
            dx = x2 - x1;
            dy = y2 - y1;
            if(Math.Abs(dx) >=Math.Abs(dy))
            {
                step = Math.Abs(dx);
            }
            else
            {
                step = Math.Abs(dy);
            }
            dx /= step;
            dy /= step;
            x = x1;
            y = y1;
            int i = 1;
            if (i <= step)
            {
                Console.WriteLine("{0}", x, ",", y);
                x += dx;
                y += dy;
                i++;
                
            }
            else
            {
                Console.WriteLine("end");
            }
        }
    }
}
