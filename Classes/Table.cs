using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SQLconstructor.Classes
{
    static public class CommonFunctools
    {
        public static string GetWithSpace(string text, int length=20)
        {
            int count = (length - text.Length);
            if (count < 4)
            {
                count = 4;
            }
            string space = String.Concat(Enumerable.Repeat(" ", count));
            return text + space;
        }
    }
    public class TableException : Exception
    {
        public TableException(string message) : base()
        {

        }
    }
    public class Table
    {
        public string Name { get; set; }
        public List<Field> fields { get; private set; }
        public Table(string name) 
        {
            this.Name = name;
            ListOfTables.AddTable(this);
        }
        ~Table()
        {
            ListOfTables.RemoveTable(this);
        }
        #region Public
        public string GetCommandOfCreate()
        {
            if (this.fields == null)
            {
                throw new TableException($"No fields detected in the table {this.Name}");
            }
            return createCommand();
        }
        public void WriteToFile(string path)
        {
            if (this.fields == null)
            {
                return;
            }
            File.AppendAllText(path, createCommand());
        }
        public override string ToString()
        {
            return Name;
        }
        #endregion

        #region Private
        private string createCommand()
        {
            string start = $"CREATE TABLE {Name} (\n";
            string definition = "";
            string end = "\n)";
            int len = fields.Count;
            int counter = 1;
            foreach (Field field in fields)
            {
                string last_char = ",\n";
                if (counter == len) {
                    last_char = "\n";
                }
                counter++;
                definition += field.GetText();
                definition += last_char;
            }
            string result = start + definition + end;
            return result;
        }
        #endregion
    }
}
