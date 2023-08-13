
using SQLconstructor.Classes;
using System.Collections.Generic;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SQLconstructor.UserControls
{
    public partial class FieldItemCreate : UserControl
    {
        public FieldItemCreate()
        {
            InitializeComponent();
            GetTypes();
            if (ListOfTables.NotEmpty())
            {
                this.checkboxFK.Enabled = true;
            }
        }
        public Field GetField()
        {
            string name = this.inputName.Text;
            SQLDataType type = (SQLDataType)Enum.Parse(typeof(SQLDataType), this.inputType.Text);
            bool isNull = this.checkboxNull.Checked;
            bool isUniq = this.checkboxUnique.Checked;
            string defaultValue = null;
            if (!string.IsNullOrEmpty(this.inputDefault.Text))
            {
                defaultValue = this.inputDefault.Text;
            }
            Table fkTable = null;
            Field fkField = null;
            if (this.checkboxFK.Checked)
            {
                fkTable = ListOfTables.GetTableByName(this.inputFKTable.SelectedItem.ToString());
                fkField = fkTable.GetFieldByName(this.inputFKField.SelectedItem.ToString());
            }
            return new Field(name, type, isNull, isUniq, defaultValue, fkTable, fkField);
        }
        private void GetTypes()
        {
            foreach (var enumerator in Enum.GetValues(typeof(SQLDataType)))
            {
                this.inputType.Items.Add(enumerator.ToString());
            }
            this.inputType.SelectedIndex = 0;
        }
        private void GetTablesForFK()
        {
            foreach (Table table in ListOfTables.tables)
            {
                this.inputFKTable.Items.Add(table.Name);
            }
            this.inputFKTable.SelectedIndex = 0;
        }
        private void GetFieldsOfTableForFK()
        {
            Table table = ListOfTables.GetTableByName(this.inputFKTable.SelectedItem.ToString());
            foreach (Field field in table.fields)
            {
                this.inputFKField.Items.Add(field.name);
            }
            this.inputFKField.SelectedIndex = 0;
        }

        private void checkboxFK_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkboxFK.Checked)
            {
                this.inputFKTable.Enabled = true;
                this.inputFKField.Enabled = true;
                GetTablesForFK();
            }
            else
            {
                this.inputFKTable.Enabled = false;
                this.inputFKField.Enabled = false;
                this.inputFKTable.Text = "";
                this.inputFKField.Text = "";
                this.inputFKTable.Items.Clear();
                this.inputFKField.Items.Clear();
            }
        }

        private void inputFKTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.inputFKField.Items.Clear();
            GetFieldsOfTableForFK();
        }
    }
}
