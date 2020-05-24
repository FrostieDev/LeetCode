using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_May_2020
{
    class CFloodFill
    {
        //4-directionally means all 4 directions, not that it is limited to 4.
        // Had to check solution for this one. Converted from Java to C# syntax.
        public int[][] FloodFill(int[][] image, int sr, int sc, int newColor)
        {
            int oldColor = image[sr][sc];

            if(oldColor != newColor)
            {
                dfs(image, sr, sc, oldColor, newColor);
            }
            return image;
        }

        public void dfs(int[][] image, int r, int c, int oldColor,int newColor)
        {
            if (image[r][c] == oldColor)
            {
                image[r][c] = newColor;
                if (r >= 1) dfs(image, r - 1, c, oldColor, newColor);
                if (c >= 1) dfs(image, r, c - 1, oldColor, newColor);
                if (r + 1 < image.Length) dfs(image, r + 1, c, oldColor, newColor);
                if (c + 1 < image[0].Length) dfs(image, r, c + 1, oldColor, newColor);
            }
        }
    }
}
