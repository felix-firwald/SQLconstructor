using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLconstructor.Classes
{
    internal class ColorCommand
    {
        private static string[] commands = {
            "CREATE TABLE",
            "DROP TABLE",
            "SELECT",
            "FROM",
            "INSERT INTO",
            "UPDATE",
            "SET",
            "WHERE" 
        };
        public string text { get; set; }
        public ColorCommand(string onText) 
        {
            this.text = onText;
        }
        public List<string> GetFoundCommands()
        {
            List<string> foundCommands = new List<string>();
            foreach (string command in commands)
            {
                int index = this.text.IndexOf(command);
                if (index >= 0 )
                {
                    foundCommands.Add(command);
                }
            }
            return foundCommands;
        }
    }
}
