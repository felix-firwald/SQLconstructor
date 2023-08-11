using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static SQLconstructor.Classes.CommonFunctools;

namespace SQLconstructor.Classes
{
    public class FieldException : Exception
    {
        public FieldException(string message) : base()
        {

        }
    }

    public enum SQLDataType
    {
        // целочисленные
        BOOL,
        BIT,
        TINYINT,
        SMALLINT,
        BIGINT,
        INT,
        // дробные
        FLOAT,
        DOUBLE,
        DECIMAL,
        // строковые
        CHAR,
        VARCHAR,
        NVARCHAR,
        TEXT,
        // дата и время
        SMALLDATETIME,
        DATETIME,
        DATE,
        TIME
    }
    public class Field
    {
        #region Procedural
        private bool validated;
        #endregion
        private string name;
        private SQLDataType type;
        private bool isNull;
        private bool isUnique;
        private string defaultValue;
        private Table fkTable;
        private Field fkField;
        private int lengthOf;

        public Field(
            string name, SQLDataType dataType,
            bool isNull = false, bool isUnique = false,
            string defaultValue = null,
            Table foreignKeyTable = null, Field foreignKeyField = null,
            int length = -1
        )
        {
            this.name = name;
            this.type = dataType;
            this.isNull = isNull;
            this.isUnique = isUnique;
            this.defaultValue = defaultValue;
            this.fkTable = foreignKeyTable;
            this.fkField = foreignKeyField;
            this.lengthOf = length;
            Validate();
        }
        public string GetText()
        {
            if (!this.validated)
            {
                return $"-- {this.name} will not be constructed as long as there are errors in its config";
            }
            string result = "";
            result += get_name();
            result += get_type();
            result += get_null();
            result += get_uniq();
            result += get_default();
            result += get_foreign();
            return result.Trim();
        }
        
        #region Configuration
        private string get_name()
        {
            return CommonFunctools.GetWithSpace(this.name);
        }
        private string get_type()
        {
            string result = this.type.ToString();
            if (this.lengthOf > -1)
            {
                result += $"({this.lengthOf})";
            }
            return CommonFunctools.GetWithSpace(result);
        }
        private string get_null()
        {
            if (!this.isNull)
            {
                return CommonFunctools.GetWithSpace("NOT NULL");
            }
            return "";
        }
        private string get_uniq()
        {
            if (this.isUnique)
            {
                return CommonFunctools.GetWithSpace("UNIQUE");
            }
            return "";
        }
        private string get_default()
        {
            if (this.defaultValue != null)
            {
                return CommonFunctools.GetWithSpace(this.name);
            }
            return "";
        }
        private string get_foreign()
        {
            if (this.fkTable != null)
            {
                string cmd = "FOREIGN KEY REFERENCES";
                return CommonFunctools.GetWithSpace($"{cmd} {this.fkTable}({this.fkField})");
            }
            return "";
        }
        #endregion

        #region Validation
        private void Validate()
        {
            try
            {
                checkUniqAndNull();
                checkForeign();
                checkDefault();
                this.validated = true;
            }
            catch (FieldException ex)
            {
                this.validated = false;
                MessageBox.Show(
                    $"Обнаружены ошибки в конфигурации поля {this.name}\n{ex}",
                    "Ошибка конфигурации поля",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
        private void checkUniqAndNull()
        {
            if (this.isUnique == true || this.isNull == true)
            {
                throw new FieldException($"Wrong configuration: UNIQUE={this.isUnique}, NULL={this.isNull}");
            }
        }
        private void checkForeign() 
        {
            bool ftable = this.fkTable == null;
            bool ffield = this.fkField == null;
            if (ftable != ffield)
            {
                throw new FieldException($"One of FK_arguments wrong: table {this.fkTable} field {this.fkField}");
            }
        }

        private void checkDefault()
        {
            if (this.defaultValue != null)
            {
                string exceptMessage = $"Invalid default value for {this.name}:\n";
                string val = this.defaultValue;
                try
                {
                    switch (type)
                    {
                        case SQLDataType.BIT:
                        case SQLDataType.BOOL:
                        case SQLDataType.TINYINT:
                        case SQLDataType.SMALLINT:
                        case SQLDataType.INT:
                        case SQLDataType.BIGINT:
                            int.Parse(val);
                            return;
                        case SQLDataType.FLOAT:
                            float.Parse(val);
                            return;
                        case SQLDataType.DOUBLE:
                            double.Parse(val);
                            return;
                        case SQLDataType.DECIMAL:
                            decimal.Parse(val);
                            return;
                        case SQLDataType.SMALLDATETIME:
                        case SQLDataType.DATETIME:
                        case SQLDataType.DATE:
                        case SQLDataType.TIME:
                            DateTime.Parse(val);
                            return;
                    }
                }
                catch (Exception ex)
                {
                    throw new FieldException($"{exceptMessage}{ex}");
                }
            }
            return;
        }
        #endregion
    }
}
