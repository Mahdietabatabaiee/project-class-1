using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_class_1
{
    internal class trapeze
    {
        private double a;
        private double b;
        private double c;
        private double d;
        private double h;
        public trapeze() { }
        public trapeze(double A, double B, double C, double D, double H)
        {
            this.a = A;
            this.b = B;
            this.c = C;
            this.d = D;
            this.h = H;
        }
        public double periphery()
        {
            return a + c + b + d; 
        }
        public double area ()
        {
            return ((c + d) / 2) * h;
        }
    }
}
