using System;
using System.Security.Cryptography;
using tablepath.Impl;

namespace tablepath
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate map controller with correct parser and builder.
            MapController control = new MapController(new StdInCommandParser(), new StdInRectMapBuilder());
            //Read first line and load map builder
            string line1 = Console.ReadLine();
            control.LoadBuilderArgs(line1);
            //Read and run commands from stdin
            string line2 = Console.ReadLine();
            int[] pos = control.RunCommands(line2);
            //Print final object position
            Console.WriteLine("[{0},{1}]", pos[0], pos[1]);
            Console.Read(); 
        }

    }
}
