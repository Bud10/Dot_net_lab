using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    internal class Class1
    {
        public int factorial(int n)
        {
            int fact = 1;
            while (n != 0)
            {
                fact *= n;
                n--;
            }
            return fact;

        }

        public bool prime(int n)
        {
            if (n <= 1) return false;
            int num = 0;
            int divisor = n;
            while(divisor != 0) {
                if (n % divisor== 0)
                {
                    num++;
                }
                divisor--; 
            }  
            return (num > 2)? false: true;
        }

    }
}
