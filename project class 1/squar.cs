using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_class_1
{
    internal class squar
    {
        private double a;
        public squar() { }
        public squar (double A)
        { this.a = A; }
        public double periphery() 
        { return 4 * a; }
        public double area () 
        { return a * a; }
    }
}
