using SQLconstructor.Classes;
using SQLconstructor.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SQLconstructor.Forms
{
    public partial class CreateTableWindow : Form
    {
        Table resultedTable;
        public CreateTableWindow()
        {
            InitializeComponent();
        }
        #region Events
        private void buttonClose_Click(object sender, EventArgs e)
        {
            if (this.resultedTable != null)
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
        #endregion
        #region Private
        private void CreateTable(string name)
        {
            this.resultedTable = new Table(name);
        }
        private void CreateField(FieldItemCreate fieldItem)
        {
            this.resultedTable.AddField(fieldItem.GetField());
        }
        #endregion

        private void buttonAddField_Click(object sender, EventArgs e)
        {
            this.flowLayout.Controls.Add(new FieldItemCreate());
        }
    }
}
