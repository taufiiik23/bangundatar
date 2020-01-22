using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangunDatar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Square");
            Console.WriteLine("2. Rectangle");
            Console.WriteLine("3. Circle");
            Console.WriteLine("4. Triangle");
            Console.WriteLine("5. Random Triangle");
            Console.Write("Choose one: ");
            int choose = Convert.ToInt32(Console.ReadLine());

            switch(choose)
            {
                case 1:
                    Console.WriteLine("Input sides: ");
                    int side = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Area: " + (side * side));
                    Console.WriteLine("Around " + (4 * side));
                    break;

                case 2:
                    Console.WriteLine("Input Length: ");
                    int length = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Input Width: ");
                    int width = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Area: " + (length * width));
                    Console.WriteLine("Around: " + 2 * (length + width));
                    break;

                case 3:
                    Console.WriteLine("Input Radius: ");
                    int radius = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Area: " + 3.14 * radius * radius);
                    Console.WriteLine("Around: " + 3.14 * 2 * radius);
                    break;

                case 4:
                    Console.WriteLine("Input High :");
                    int sideA = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Input Base : ");
                    int Base = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Area: " + 0.5 * Base * sideA);
                    Console.WriteLine("Around: " + (sideA * 2) * Base);
                    break;

                case 5:
                    Console.WriteLine("Input SideA :");
                    int sideA1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Input SideB : ");
                    int sideB = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Input SideC : ");
                    int sideC = Convert.ToInt32(Console.ReadLine());
                    double s = 0.5*(sideA1 + sideB + sideC);
                    double Luas = s * ((s - sideA1) * (s - sideB) * (s - sideC));

                    Console.WriteLine("Area: " + Math.Sqrt(Luas));
                    Console.WriteLine("Around: " + (sideA1 + sideB + sideC));
                    break;


            }
        }
    }
}
