using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using math;

namespace GeometricMeasurement
{
    public class Calculation
    {
        //Properties
        public double V1;
        public double V2;
        public double V3;
        public double Circumference { get; set; }
        public double Volume { get; set; }
        public double Area { get; set; }

        //Parameterized construtors
        public Calculation(double sidea)
        {
            this.V1 = sidea;
        }
        public Calculation(double V1,double V2)
        {
            this.V1 = V1;
            this.V2 = V2;
        }
        public Calculation(double V1,double V2, double V3)
        {
            this.V1 = V1;
            this.V2 = V2;
            this.V3 = V3;
        }

        //Square
        public double SquareArea ()
        {
            return Area = V1 * V1;
        }
        public double SquareCircumference()
        {
            return Circumference= 4 * V1;
        }
       //Rectangle
        public double RectangleArea()
        {
            return Area = V1 * V2 ;
        }
        public double RectangleCircumference()
        {
            return Circumference = 2 * (V1 + V2);
        }
        //Cube
        public double CubeArea()
        {
            return Area = 6 * V1 * V1;
        }
        public double CubeVolume()
        {
            return Volume = V1 * V1 * V1;
        }
        //Circle
        public double CircleArea()
        {
            return Area = V1 *V1 * (Math.PI);
        }
        public double CircleCircumference()
        {
            return Circumference = 2 * (Math.PI) * V1;
        }
        //Triangle
        public double TriangleArea()
        {
            return Area = V1 * V2 / 2;
        }
        public double TriangleCircumference()
        {
            return Area = V1 + V2 + V3;
        }
    }
}
