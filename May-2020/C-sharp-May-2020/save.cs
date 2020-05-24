using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_May_2020
{
    class save
    {

        public int[][] FloodFill(int[][] image, int sr, int sc, int newColor)
        {
            int oldColor = image[sr][sc];


            for (int i = -1; i < 3; i++)
            {
                image = fillHorizontally(image, sr + i, sc, newColor, oldColor);
            }

            for (int i = -1; i < 3; i++)
            {
                image = fillVertically(image, sr, sc + i, newColor, oldColor);
            }

            return image;
        }

        public int[][] fillHorizontally(int[][] image, int sr, int sc, int newColor, int oldColor)
        {
            for (int i = -1; i < 3; i++)
            {
                Console.WriteLine("Filling horizontally at : " + (sr) + " , " + (sc + i));
                if (image[sr][sc + i] == oldColor)
                {
                    image[sr][sc + i] = newColor;
                }
                else if (image[sr][sc + i] == newColor)
                {
                    continue;
                }
                else
                {
                    break;
                }
            }
            return image;
        }

        public int[][] fillVertically(int[][] image, int sr, int sc, int newColor, int oldColor)
        {
            for (int i = -1; i < 3; i++)
            {
                Console.WriteLine("Filling vertically at : " + (sr + i) + " , " + (sc));
                if (image[sr + i][sc] == oldColor)
                {
                    image[sr + i][sc] = newColor;
                }
                else if (image[sr + i][sc] == newColor)
                {
                    continue;
                }
                else
                {
                    break;
                }
            }
            return image;
        }
    }
}
