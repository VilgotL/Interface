using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Circle : IShape
    {
        protected double radie;

        public void Area()
        {
            double a = radie*radie*Math.PI;
            Console.WriteLine("Area: " + a);
        }
        public void Circumferance()
        {
            double o = (radie + radie) * Math.PI;
            Console.WriteLine("Omkrets: " + o);
        }

        public Circle(double radie)
        {
            this.radie = radie;
        }
    }
}
