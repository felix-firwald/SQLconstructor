using SQLconstructor.Classes;
using SQLconstructor.UserControls;
using System;
using System.CodeDom;
using System.Windows.Forms;

namespace SQLconstructor.Forms
{
    public enum TableWindowType
    {
        Create,
        Edit
    }
    public partial class CreateTableWindow : Form
    {
        Table resultedTable;
        TableWindowType typeOfWindow;
        private readonly string initialTableName;
        public CreateTableWindow()
        {
            InitializeComponent();
            typeOfWindow = TableWindowType.Create;
        }
        public CreateTableWindow(Table table)
        {
            InitializeComponent();
            this.Text = $"Редактирование таблицы {table.Name}";
            this.inputName.Text = table.Name;
            this.initialTableName = table.Name;
            typeOfWindow = TableWindowType.Edit;
            // УДАЛИТЬ лишнее поле которое указано первым в форме!
            this.flowLayout.Controls.RemoveByKey("initialFieldItem");
            foreach (Field field in table.fields)
            {
                this.flowLayout.Controls.Add(new FieldItemCreate(field));
            }
        }

        #region Events
        private void buttonClose_Click(object sender, EventArgs e)
        {
            if (this.resultedTable != null || typeOfWindow == TableWindowType.Create)
            {
                ListOfTables.RemoveTable(this.resultedTable);
            }
            this.Close();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            try
            {
                CreateTable(this.inputName.Text);
                foreach (Control c in this.flowLayout.Controls) 
                {
                    if (c.GetType() == typeof(FieldItemCreate))
                    {
                        FieldItemCreate field = (FieldItemCreate)c;
                        CreateField(field);
                    }
                }
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Возникла ошибка!\n{ex}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonAddField_Click(object sender, EventArgs e)
        {
            AddFieldItem();
        }
        #endregion

        #region Private
        private void CreateTable(string name)
        {
            if (typeOfWindow == TableWindowType.Create)
            {
                this.resultedTable = new Table(name);
            }
            else
            {
                this.resultedTable = ListOfTables.GetTableByName(this.initialTableName);
                this.resultedTable.ClearFields();
            }
        }
        private void CreateField(FieldItemCreate fieldItem)
        {
            Field field = fieldItem.GetField();
            if (field != null)
            {
                this.resultedTable.AddField(fieldItem.GetField());
            }
        }
        private void AddFieldItem()
        {
            this.flowLayout.Controls.Add(new FieldItemCreate());
        }

        #endregion

    }
}
