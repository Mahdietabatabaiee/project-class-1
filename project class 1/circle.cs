using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace project_class_1
{
    internal class circle
    {
        private double r;
      
        public circle() { }
        public circle(double R) { this.r = R;}
        public double periphery()
        {
            const double p = 3.14;
            return 2 * p * r;
        }
        public double area() 
        {
            const double p1 = 3.14;
            return p1* Math.Pow(r,2);
        }
    }
}
