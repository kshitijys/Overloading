using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
    abstract public class shape2
    {
        public abstract void calculatearea();


    }

    public class Rectangle : shape2
    {
        public int length;
        public int breadth;
        public double result;


        public Rectangle(int length,int breadth)
        {
            this.length=length;
            this.breadth=breadth;
        }


        public override void calculatearea()
        {
          result=length*breadth;
        }

        public override string ToString()
        {
            return $"area of Rectangle is {result}";
        }
    }


}
