using System;
using System.Collections.Generic;
using System.Text;

namespace tablepath
{
    
    public class MapController
    {
        Map2D _map;
        ICommandParser _cmdParser;
        IMapBuilder _mapBuilder;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="parser">Parser used when RunCommands is called</param>
        /// <param name="builder">Builder used when LoadBuilderArgs is called</param>
        public MapController(ICommandParser parser, IMapBuilder builder)
        {
            _cmdParser = parser;
            _mapBuilder = builder;
        }
        /// <summary>
        /// Builds map using initialization arguments.
        /// </summary>
        /// <param name="args">Arguments containing map properties and object start position. Parsed by IMapBuilder implementation</param>
        public void LoadBuilderArgs(object args)
        {
            _map = _mapBuilder.BuildMap(args);
        }
        /// <summary>
        /// Runs list of commands.
        /// </summary>
        /// <param name="commands">List of commands parsed by ICommandParser implementation.</param>
        /// <returns>Returns last position of the object {x,y}.</returns>
        public int[] RunCommands(object commands)
        {
            return ProcessCommandQueue(_cmdParser.ParseCommands(commands));
        }
        private int[] ProcessCommandQueue(Command[] commands)
        {
            foreach(var cmd in commands)
            {
                if (cmd == Command.QUIT)
                    break;
                else
                {
                    //break when object goes out of bounds
                    if (!_map.HandleCommand(cmd))
                        break;
                }
            }
            return new int[] { _map.Object.X, _map.Object.Y };
        }

    }
}
