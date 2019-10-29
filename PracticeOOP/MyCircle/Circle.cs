using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCircle
{
    public class Circle
    {
        private double radius;
        public Circle()
        {
            radius = 1.0;
        }
       
        public Circle(double r)
        {
            radius = r;
        }

        public double GetRadius()
        {
            return radius;
        }

        public double GetArea()
        {
            return radius * radius * Math.PI;
        }

        public double Circumference()
        {
            return radius * 2 * Math.PI;
        }
        public void SetRadius(double newRadius)
        {
            radius = newRadius;
        }

        public override string ToString()
        {
            return String.Format("Circle[Radius={0}]",radius);
        }
    }
}
