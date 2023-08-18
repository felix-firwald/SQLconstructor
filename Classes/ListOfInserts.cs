using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLconstructor.Classes
{
    public static class ListOfInserts
    {
        private static List<string> commands = new List<string>();

        public static void AddCommand(string command)
        {
            commands.Add(command);
        }
        public static string GetCommands()
        {
            return string.Join("\n", commands.ToArray());
        }
    }
}
