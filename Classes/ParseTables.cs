using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SQLconstructor.Classes
{
    public class ParseTables
    {
        private string inputString;
        private List<string> tablesDefinitions = new List<string>();
        public ParseTables(string pathFile, char sepTab=';', char sepField=',') 
        {
            this.inputString = File.ReadAllText(pathFile);
            Console.WriteLine(pathFile);
            tablesDefinitions.AddRange(this.inputString.Split(sepTab));
        }
        public void Parse() 
        {
            foreach (string def in tablesDefinitions)
            {
                ParseTable(def);
            }
        }
        private void ParseTable(string text) 
        {
            if (!text.Trim().StartsWith("CREATE TABLE"))
            {
                Console.WriteLine($"CANCELED!");
                return;
            }
            string tablename = text.Split(' ')[2];
            Table table = new Table(tablename);
            string fieldsDefinition = text.Replace($"CREATE TABLE {tablename} (", "").TrimEnd(')');
            foreach (string fieldDef in Regex.Split(fieldsDefinition, ",")) 
            {
                ParseField pf = new ParseField(table, fieldDef);
            }
            Console.WriteLine(tablename);
            Console.WriteLine(fieldsDefinition);
        }
    }
}
