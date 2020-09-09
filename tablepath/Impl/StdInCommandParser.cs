using System;
using System.Collections.Generic;
using System.Text;

namespace tablepath.Impl
{
    class StdInCommandParser : ICommandParser
    {
        /// <summary>
        /// Parse commands from std in
        /// </summary>
        /// <param name="args">String containing commands separated by comma. Ex: 1,3,3,1,3,1,0</param>
        /// <returns></returns>
        public Command[] ParseCommands(object args)
        {
            string[] s_arg = (args as string).Split(',');
            return Array.ConvertAll(s_arg, s => (Command)int.Parse(s));
        }
    }
}
