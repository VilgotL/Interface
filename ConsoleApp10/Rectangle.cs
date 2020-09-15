﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Rectangle : IShape
    {
        protected double width;
        protected double height;

        public void Area()
        {
            double a = width * height;
            Console.WriteLine("Area: " + a);
        }
        public void Circumferance()
        {
            double o = width + width + height + height;
            Console.WriteLine("Omkrets: " + o);
        }

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        } 
    }
}
