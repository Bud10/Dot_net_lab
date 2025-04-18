using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    public class SumOfArray
    {
        int total = 0;
        public int sum(int[] arr)
        {
            foreach (int i in arr)
            {
                total = total + i;
            }
            return total;
        }
    }
}