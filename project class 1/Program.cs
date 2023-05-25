using System.ComponentModel.Design;

namespace project_class_1 // mahdie tabatabaee 
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number for each geometric shape : traingel 1 , reqtangel 2 , elipes 3 , circle 4, squar 5, trapeze 6 ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num == 1)
            {
                Console.WriteLine("enter a: ");
                double a1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("enter b:");
                double b1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("enter c: ");
                double c1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("enter h :");
                double h1 = Convert.ToDouble(Console.ReadLine());

                var tr = new triangel(a1, b1, c1, h1);
                Console.WriteLine("periphery of triangle is: " + tr.periphery());
                Console.WriteLine("area of triangle is : " + tr.area());

            }
            else if (num == 2)
            {
                Console.WriteLine("enter a:");
                double a2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("enter b:");
                double b2 = Convert.ToDouble(Console.ReadLine());

                var rec = new reqtangel(a2, b2);
                Console.WriteLine("the prephiry of rectangle is : " + rec.periphery());
                Console.WriteLine("the area of rectangle is : " + rec.area());
            }
            else if (num == 3)
            {
                Console.WriteLine("enter the long r :");
                double longr = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("enter the short r :");
                double shortr = Convert.ToDouble(Console.ReadLine());
                var eli = new ellipes(longr, shortr);
                Console.WriteLine("the prephiry of elipes : " + eli.priphery());
                Console.WriteLine("the area of the elipe is: " + eli.area());
            }
            else if (num == 4)
            {
                Console.WriteLine("enter r : ");
                double rc = Convert.ToDouble(Console.ReadLine());
                var cir = new circle(rc);
                Console.WriteLine("the periphery of circle is: " + cir.periphery());
                Console.WriteLine("the area of circle is : " + cir.area());
            }
            else if (num == 5)
            {
                Console.WriteLine("enter a : ");
                double as1 = Convert.ToDouble(Console.ReadLine());
                var sq = new squar(as1);
                Console.WriteLine("the periphery of squar: " + sq.periphery());
                Console.WriteLine("the area of squar is :" + sq.area());
            }
            else if (num == 6)
            {
                Console.WriteLine("enter the longest edge");
                double le = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("enter the shortest edge :");
                double se = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("enter a , c:");
                double at = Convert.ToDouble(Console.ReadLine());
                double ct = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("enter the height :");
                double ht= Convert.ToDouble(Console.ReadLine());
                var tr = new trapeze(at,se,ct,le,ht);
                Console.WriteLine("the periphery is :"+ tr.periphery());
                Console.WriteLine("the area is :"+tr.area());
            } 
        }
    }
}