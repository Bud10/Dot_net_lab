using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    public class LeapYear
    {
        public bool Leap(int year)
            {
                if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
                {
                    return true;

                //Console.WriteLine(a % 4 == 0 && (year % 100 != 0 || year % 400 == 0) ? "Leap Year" : "Not Leap Year");
            }
            else { return false; }
            }
    }
}