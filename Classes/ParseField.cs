using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLconstructor.Classes
{
    public class ParseField
    {
        #region Common
        private Table table;
        private string input;
        private int logline = 1;
        #endregion
        #region Properties
        private string name;
        private SQLDataType type;
        private bool isNull;
        private bool isUnique;
        private string defaultValue;
        private Table fkTable;
        private Field fkField;
        private int size = -1;
        #endregion
        public ParseField(Table table, string text) 
        {
            this.table = table;
            this.input = text.Trim();
            Parse();
            Field f = new Field(
                name, type,
                isNull, isUnique,
                defaultValue,
                fkTable, fkField,
                size
            );
            table.AddField(f);
        }
        private void Parse()
        {
            try
            {
                GetName();
                GetSQLType();
                GetNull();
                GetUnique();
                // GetDefault();
                // GetFKTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }


        }
        private void GetName()
        {
            Log();
            this.name = this.input.Split(' ')[0];
            this.input = this.input.Replace(this.name, "").Trim();
            Console.WriteLine(this.name);
        }
        private void GetSQLType()
        {
            Log();
            bool first = true;
            SQLDataType tempType = SQLDataType.BIT;
            foreach (SQLDataType t in Enum.GetValues(typeof(SQLDataType))) 
            {

                if (this.input.Contains(t.ToString()))
                {
                    if (first && tempType.ToString().Length < t.ToString().Length)
                    {
                        tempType = t;
                        first = false;
                    }
                }
            }
            this.type = tempType;
            //throw new Exception($"Unsuccess parsing SQLType!");
        }
        private void GetNull()
        {
            Log();
            string keyword = "NOT NULL";
            if (IsContains(keyword))
            {
                this.isNull = false;
                this.input.Replace(keyword, "").Trim();
            }
            else
            {
                this.isNull = true;
            }
        }
        private void GetUnique()
        {
            Log();
            string keyword = "UNIQUE";
            if (IsContains(keyword))
            {
                this.isUnique = true;
                this.input.Replace(keyword, "").Trim();
            }
            else
            {
                this.isUnique = false;
            }
        }
        //private void GetDefault()
        //{
        //    string keyword = "DEFAULT";
        //    if (IsContains(keyword))
        //    {
        //        int len = this.input.IndexOf(keyword) + keyword.Length;
                
        //    }
        //}
        //private void GetFKTable()
        //{
        //    string keyword = "FOREIGN KEY REFERENCES";
        //    if (IsContains(keyword))
        //    {
        //        int len = this.input.IndexOf(keyword) + keyword.Length;
        //    }
        //}
        private bool IsContains(string text)
        {
            return this.input.Contains(text);
        }
        private void Log()
        {
            Console.WriteLine($"[{this.GetHashCode()}] - {this.logline}. {this.input.Trim()}");
            logline++;
        }
    }
}
