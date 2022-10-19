using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int x1 = rnd.Next(-100, 100);
            int y1 = rnd.Next(-100, 100);
            int x2 = rnd.Next(-100, 100);
            int y2 = rnd.Next(-100, 100);
            Console.WriteLine($"X1:{x1}");
            Console.WriteLine($"Y1:{y1}");
            Console.WriteLine($"X2:{x2}");
            Console.WriteLine($"Y2:{y2}");
            double distance = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
            string distance1 = distance.ToString();
            Console.WriteLine($"Расстояние между точками: {distance1}");
        }
    }
}
