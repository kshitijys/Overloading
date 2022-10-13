using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
    public class Addition
    {

        public int add(int a, int b)
        {
            return a + b;   
        }

        public int add(int a, int b,int c)
        {
            return a + b+c;
        }

        public double add(double a, int b)
        {
            return a + b;
        }

        public double add(float a, double b)
        {
            return a + b;
        }
    }
}
