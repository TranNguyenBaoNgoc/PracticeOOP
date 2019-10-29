using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    public class Rectangle
    {
        private float width;
        private float length;
        public Rectangle()
        {
            width = 1.0f;
            length = 1.0f;
        }

        public Rectangle(float l, float w)
        {
            width = w;
            length = l;
        }

        public double GetWidth()
        {
            return width;
        }

        public double GetLength()
        {
            return length;
        }
    }
}
