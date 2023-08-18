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

namespace SQLconstructor.UserControls
{
    public partial class DatabasePanel : UserControl
    {
        public DatabasePanel()
        {
            InitializeComponent();
        }

        private void inputName_TextChanged(object sender, EventArgs e)
        {
            ListOfTables.SetName(this.inputName.Text);
        }
    }
}
