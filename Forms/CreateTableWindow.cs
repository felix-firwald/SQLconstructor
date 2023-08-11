using SQLconstructor.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLconstructor.Forms
{
    public partial class CreateTableWindow : Form
    {
        public CreateTableWindow()
        {
            InitializeComponent();
            GetListOfTypes();
        }
        private void GetListOfTypes()
        {
            var cb = (DataGridViewComboBoxColumn)this.dataGridFields.Columns["DataTypeOfField"];
            cb.DataSource = Enum.GetValues(typeof(SQLDataType));
        }
    }
}
