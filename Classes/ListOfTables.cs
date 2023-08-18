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
        public static string Name { get; private set; }
        public static List<Table> tables = new List<Table>();
        private static bool NeedUpdateForTree = false;
        private static bool NeedUpdateForCode = false;

        public static void SetName(string name)
        {
            Name = name;
            SetForNeedUpdate();
        }
        public static void SetForNeedUpdate()
        {
            NeedUpdateForTree = true; 
            NeedUpdateForCode = true;
        }
        public static bool IsNeedUpdateForCode()
        {
            bool result = NeedUpdateForCode;
            if (result)
            {
                NeedUpdateForCode = false;
            }
            return result;
        }
        public static bool IsNeedUpdateForTree()
        {
            bool result = NeedUpdateForTree;
            if (result)
            {
                NeedUpdateForTree = false;
            }
            return result;
        }
        public static void AddTable(Table table)
        {
            tables.Add(table);
            SetForNeedUpdate();
        }
        public static void RemoveTable(Table table)
        {
            tables.Remove(table);
            SetForNeedUpdate();
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
        public static bool NotEmpty()
        {
            if (tables.Count == 0)
            {
                return false;
            }
            return true;
        }
        public static string GetRequestForTables()
        {
            string result = "";
            foreach (Table table in tables)
            {
                result += table.GetCommandOfCreate();
                result += ";\n\n";
            }
            return result;
        }
    }
}
