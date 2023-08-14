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
    public class FieldNotFound : Exception
    {
        public FieldNotFound(string message) : base()
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
        NVARCHAR,
        VARCHAR,
        CHAR,
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
        public string name { get; private set; }
        public SQLDataType type { get; private set; }
        public bool isNull { get; private set; }
        public bool isUnique { get; private set; }
        public string defaultValue { get; private set; }
        public Table fkTable { get; private set; }
        public Field fkField { get; private set; }
        public int lengthOf { get; private set; }

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
        public void ChangeProperties(
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
        public override string ToString()
        {
            return this.name;
        }
        public string GetText()
        {
            if (!this.validated)
            {
                return $"-- {this.name} will not be constructed as long as there are errors in its config";
            }
            string result = "";
            result += ws_get_name();
            result += ws_get_type();
            result += ws_get_null();
            result += ws_get_uniq();
            result += ws_get_default();
            result += ws_get_foreign();
            return result.Trim();
        }
        
        #region Configuration
        private string ws_get_name()
        {
            return CommonFunctools.GetWithSpace(this.name);
        }
        private string ws_get_type()
        {
            string result = this.type.ToString();
            if (this.lengthOf > -1)
            {
                result += $"({this.lengthOf})";
            }
            return CommonFunctools.GetWithSpace(result);
        }
        private string ws_get_null()
        {
            if (!this.isNull)
            {
                return CommonFunctools.GetWithSpace("NOT NULL");
            }
            return "";
        }
        private string ws_get_uniq()
        {
            if (this.isUnique)
            {
                return CommonFunctools.GetWithSpace("UNIQUE");
            }
            return "";
        }
        private string ws_get_default()
        {
            if (this.defaultValue != null)
            {
                string c = "'";
                switch (this.type)
                {
                    case SQLDataType.BOOL:
                    case SQLDataType.BIT:
                    case SQLDataType.TINYINT:
                    case SQLDataType.SMALLINT:
                    case SQLDataType.BIGINT:
                    case SQLDataType.INT:
                    case SQLDataType.FLOAT: 
                    case SQLDataType.DOUBLE:
                    case SQLDataType.DECIMAL:
                        c = "";
                        break;
                    default: break;
                }
                return CommonFunctools.GetWithSpace($"DEFAULT {c}{this.defaultValue}{c}");
            }
            return "";
        }
        private string ws_get_foreign()
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
            if (this.isUnique)
            {
                if (this.isNull)
                {
                    throw new FieldException($"Wrong configuration: UNIQUE={this.isUnique}, NULL={this.isNull}");
                }
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
            if (this.defaultValue != null && this.defaultValue != "")
            {
                
                string val = this.defaultValue;
                string exceptMessage = $"Неверное значение по умолчанию {this.name}={val}:\n";
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
                    MessageBox.Show($"{exceptMessage}{ex}");
                    //throw new FieldException($"{exceptMessage}{ex}");
                }
            }
            return;
        }
        #endregion
    }
}
