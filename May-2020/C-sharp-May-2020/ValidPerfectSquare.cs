using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_May_2020
{
    /// <summary>
    /// Binary search to determine perfect square without use of sqrt.
    /// </summary>
    class ValidPerfectSquare
    {
        public bool IsPerfectSquare(int num)
        {
            if (num < 2) return true;
            long left = 1;
            long right = num;

            while (left <= right)
            {
                long mid = left + (right - left) / 2; // To find mid - if 16 it would be 8.
                long square = mid * mid; // This would be 8*8 = 64, which is bigger than 16.
                if (square == num) return true;
                if (square > num)
                {
                    right = mid - 1; // Its not in the right part, so cut that of. Here it would be right = 7;
                }
                else if (square < num)
                {
                    left = mid + 1; // Its not in the left part, so cut that of.
                }
            }
            return false;
        }
    }
}
