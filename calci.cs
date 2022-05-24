using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
 public partial class calculator
    {
        public int Addition(int a, int b)
        {
            return a + b; 
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        partial void Divide(int a, int b);
    }
}
