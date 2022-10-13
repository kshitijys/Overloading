using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
    abstract public class shape
    {
        public abstract void calculatearea();
    }
    public class Circle : shape
    {
        public int radius;
        public double result;


        public Circle(int radius)
        {
            this.radius = radius;
        }


        public override void calculatearea()
        {
            result = (double)radius * radius * 3.14;
        }

        public override string ToString()
        {
            return $"area of circle is {result}";     
        }
    }

}
