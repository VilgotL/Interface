using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Triangle : IShape
    {
        protected double width;
        protected double height;

        public void Area()
        {
            double a = width * height;
            a /= 2;
            Console.WriteLine("Area: " + a);
        }
        public void Circumferance()
        {
            double hypotenusa = Math.Sqrt(width * width + height * height);
            double o = width + height + hypotenusa;
            Console.WriteLine("Omkrets: " + o);
        }
    }
}
