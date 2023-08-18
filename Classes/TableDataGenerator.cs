using System;
using System.Collections.Generic;
using System.Security.RightsManagement;

namespace SQLconstructor.Classes
{
    public enum DataCategory
    {
        Integers,
        Fractionals,
        Strings,
        Times,
    }
    public class TableDataGenerator
    {
        protected class UncorrectDataType : Exception
        {
            protected UncorrectDataType(string message) : base() { }
        }
        readonly public Table table;
        public TableDataGenerator(Table table) 
        {
            this.table = table;
        }
        public void RunGeneration(int rows)
        {
            for (int row = 1; row <= rows; row++) 
            {
                ForEachField();
            }
        }
        private void ForEachField()
        {
            foreach (Field field in table.fields) 
            {
                field.generator.Generate();
            }
        }
        protected string Insert()
        {
            return $"INSERT INTO {this.table} VALUES ()";
        }
    }
}
