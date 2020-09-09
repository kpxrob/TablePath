using System;
using System.Collections.Generic;
using System.Text;

namespace tablepath.Impl
{
    class StdInRectMapBuilder : IMapBuilder
    {
        /// <summary>
        /// Build map with args from std in. Also sets object start position.
        /// </summary>
        /// <param name="args">String containing init args separated by comma.(Width,Height,StartX,StartY). Ex: 4,4,2,2</param>
        /// <returns></returns>
        public Map2D BuildMap(object args)
        {
            string[] s_arg = (args as string).Split(',');
            int[] arguments = Array.ConvertAll(s_arg, a => int.Parse(a));
            Map2D map = new RectangularMap2D(arguments[0], arguments[1]);
            map.SetStartPosition(arguments[2], arguments[3]);
            return map;
        }
    }
}
