using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_class_1
{
    internal class reqtangel
    {
        private double a;
        private double b; 
         public reqtangel() { }
        public reqtangel(double A, double B)
        {
            this.a = A;
            this.b = B;
 
       }
        public double periphery()
        {
            return (a + b)*2;   
        }
        public double area ()
        { return a * b; }
    }
}
