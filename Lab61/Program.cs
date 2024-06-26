using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab61
{
    interface ISolid
    {
        double GetVolume();
    }

    class Pyramid : ISolid
    {
        public int A { get; set; }
        public int B { get; set; }
        public int H { get; set; }

        public Pyramid(int a, int b, int h)
        {
            A = a;
            B = b;
            H = h;
        }

        public double GetVolume()
        {
            return (1.0 / 3) * A * B * H;
        }
    }

    class Cone : ISolid
    {
        public int R { get; set; }
        public int H { get; set; }

        public Cone(int r, int h)
        {
            R = r;
            H = h;
        }

        public double GetVolume()
        {
            return (1.0 / 3) * Math.PI * Math.Pow(R, 2) * H;
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the base length (A) of the pyramid:");
            int pyramidA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the base width (B) of the pyramid:");
            int pyramidB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the height (H) of the pyramid:");
            int pyramidH = Convert.ToInt32(Console.ReadLine());

            ISolid pyramid = new Pyramid(pyramidA, pyramidB, pyramidH);
            Console.WriteLine($"Volume of the pyramid: {pyramid.GetVolume()}");

            Console.WriteLine("Enter the radius (R) of the cone:");
            int coneR = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the height (H) of the cone:");
            int coneH = Convert.ToInt32(Console.ReadLine());

            ISolid cone = new Cone(coneR, coneH);
            Console.WriteLine($"Volume of the cone: {cone.GetVolume()}");

            Console.ReadLine();
        }
    }

}
