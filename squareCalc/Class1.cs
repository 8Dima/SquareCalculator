using System;

namespace squareCalc
{
    public class Calc
    {
        public double radius;
        public double side1;
        public double side2;
        public double side3;
        
        public Calc(double r)
        {
            radius = r;
        }

        public Calc(double s1, double s2, double s3)
        {
            side1 = s1;
            side2 = s2;
            side3 = s3;
        }

        public void Triangle()
        {
            double p = (side1 + side2 + side3) / 2.0;
            double res = Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3));
            Console.WriteLine(p);
            Console.WriteLine(res);
        }

        public void Circle()
        {
            double res = Math.Pow(radius, 2) * Math.PI;
            Console.WriteLine(res);
        }
    }
}