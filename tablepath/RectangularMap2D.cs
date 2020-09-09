using System;
using System.Collections.Generic;
using System.Text;

namespace tablepath
{
    class RectangularMap2D : Map2D
    {
        public RectangularMap2D(int Width,int Height)
            : base(Width, Height, Positions: RenderMap(Width, Height))
        {

        }

        //Set map information. Valid positions should be set as 1.
        static int[,] RenderMap(int x, int y)
        {
            int[,] map = new int[x, y];
            for (int i = 0; i < x; i++)
                for (int j = 0; j < y; j++)
                    map[i, j] = 1;
            return map;
        }
    }
}
