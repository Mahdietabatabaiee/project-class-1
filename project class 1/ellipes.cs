using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_class_1
{
    internal class ellipes
    {
        private double rlong;
        private double rshort;
        public ellipes() { }
        public ellipes(double Rlong, double Rshort) 
        {   this.rlong = Rlong;
            this.rshort = Rshort;
        }
        public double priphery()
        {
            const double p = 3.14;
            return ((rlong + rshort) / 2) * p*2 ;
        }
        public double area()
        {
            const double p1 = 3.14;
            return (rlong * rshort) * p1;
        }
    }
}
