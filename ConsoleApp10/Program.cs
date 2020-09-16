using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Skriv 1 om det är en rektangel, 2 om det är en triangel och 3 om det är en cirkel: ");
            int form = int.Parse(Console.ReadLine());
            if (form == 1)
            {
                Console.Write("Höjd: ");
                double höjd = double.Parse(Console.ReadLine());
                Console.Write("Bredd: ");
                double bredd = double.Parse(Console.ReadLine());
                Console.WriteLine();
                IShape sh = new Rectangle(bredd, höjd);
                sh.Circumferance();
                sh.Area();
            }
            if (form == 2)
            {
                Console.Write("Höjd: ");
                double höjd = double.Parse(Console.ReadLine());
                Console.Write("Bredd: ");
                double bredd = double.Parse(Console.ReadLine());
                Console.WriteLine();
                IShape sh = new Triangle(bredd, höjd);
                sh.Circumferance();
                sh.Area();
            }
            if (form == 3)
            {
                Console.Write("Radie: ");
                double radie = double.Parse(Console.ReadLine());
                Console.WriteLine();
                IShape sh = new Circle(radie);
                sh.Circumferance();
                sh.Area();
            }
            Console.ReadLine();
        }
    }
}
