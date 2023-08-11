using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLconstructor.Classes
{
    public class TableNotFound : Exception
    {
        public TableNotFound(string message) : base() { }
    }
    public static class ListOfTables
    {
        public static List<Table> tables { get; private set; }

        public static void AddTable(Table table)
        {
            tables.Add(table);
        }
        public static void RemoveTable(Table table)
        {
            tables.Remove(table);
        }
        public static Table GetTableByName(string name)
        {
            foreach (Table table in tables)
            {
                if (table.Name == name)
                {
                    return table;
                }
            }
            throw new TableNotFound($"A table with name \"{name}\" not found");
        }
    }
}
