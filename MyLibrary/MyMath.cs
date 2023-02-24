using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public static class MyMath
    {
        public static double Add(double num1 , double num2)
        {
            return num1 + num2;
        }

        public static double Average(this List<int> list)
        {
            double sum = 0;

            foreach (int item in list)
            {
                sum += item;
            }

            return sum / list.Count;
        }

    }
}
