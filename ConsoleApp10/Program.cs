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
            double höjd;
            double bredd;
            double radie;
            Console.Write("Skriv 1 om det är en rektangel, 2 om det är en triangel och 3 om det är en cirkel: ");
            int form = int.Parse(Console.ReadLine());
            if (form == 1)
            {
                Console.Write("Höjd: ");
                höjd = double.Parse(Console.ReadLine());
                Console.Write("Bredd: ");
                bredd = double.Parse(Console.ReadLine());
                Rectangle r = new Rectangle(bredd, höjd);
                IShape sh = r as IShape;
                sh.Circumferance();
                sh.Area();
            }
            if (form == 2)
            {
                Console.Write("Höjd: ");
                höjd = double.Parse(Console.ReadLine());
                Console.Write("Bredd: ");
                bredd = double.Parse(Console.ReadLine());
                Triangle t = new Triangle(bredd, höjd);
                IShape sh = t as IShape;
                sh.Circumferance();
                sh.Area();
            }
            if (form == 3)
            {
                Console.Write("Radie: ");
                radie = double.Parse(Console.ReadLine());
                Circle c = new Circle(radie);
                IShape sh = c as IShape;
                sh.Circumferance();
                sh.Area();
            }
            Console.ReadLine();
        }
    }
}
