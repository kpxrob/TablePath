using System;
using System.Collections.Generic;
using System.Text;

namespace tablepath
{
    public interface ICommandParser
    {
        Command[] ParseCommands(object args);
    }
}
