using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_class_1
{
    internal class triangel
    {
        private double a;
        private double b;
        private double c;
        private double h;
        public triangel() { }
        public triangel(double A, double B, double C, double H)
        {
            this.a = A;
            this.b = B;
            this.c = C;
            this.h = H;
        }
        public double periphery ()
        {
            return a + b + c;
        }
        public double area()
        {
            return (a * h) / 2;
        }
    }
}

