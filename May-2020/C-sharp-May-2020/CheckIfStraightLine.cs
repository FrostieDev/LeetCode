using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_May_2020
{
    //https://www.mathsisfun.com/algebra/line-equation-2points.html
    public class CheckIfStraightLine
    {
        public bool CheckStraightLine(int[][] coordinates)
        {
            double firstM = 0; // Slope of first pair.

            for(int i = 1; i < coordinates.Length; i++)
            {
                Console.WriteLine(i + "run");
                int[] previousCoordinate = coordinates[i - 1];
                int[] currentCoordinate = coordinates[i];

                double previousSubstraction = currentCoordinate[1] - previousCoordinate[1];
                double currentSubstraction = currentCoordinate[0] -  previousCoordinate[0];

                double m; // Current slope

                try
                {
                    m = previousSubstraction / currentSubstraction;
                } catch (Exception)
                {
                    return false;
                }

                //if(previousSubstraction != 0 && currentSubstraction != 0)
                //{
                //    m = previousSubstraction / currentSubstraction;
                //} else
                //{
                //    m = 0;
                //}

                if(i == 1)
                {
                    Console.WriteLine("First m = " + m);
                    firstM = m;
                }

                Console.WriteLine(previousCoordinate[0] + "," + previousCoordinate[1] + " and " + currentCoordinate[0] + "," + currentCoordinate[1] + " has M = " + m);

                if (m != firstM)
                {
                    if (double.IsInfinity(m) && double.IsInfinity(firstM))
                    {
                        return true;
                    }
                    return false;
                }

            }
            return true;
        }
    }
}
