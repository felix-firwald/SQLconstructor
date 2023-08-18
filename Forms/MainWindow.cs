using SQLconstructor.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLconstructor.Forms
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonCreateTable_Click(object sender, EventArgs e)
        {
            CreateTableWindow ctw = new CreateTableWindow();
            ctw.ShowDialog();
        }

        private void buttonGetTablesFromFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "SQL files (.SQL)|*.sql";
            ofd.FilterIndex = 0;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK )
            {
                ParseTables pt = new ParseTables(ofd.FileName);
                pt.Parse();
            }
            
        }

        private void buttonSaveCreates_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "SQL files (.SQL)|*.sql";
            sfd.FileName = $"{ListOfTables.Name}_CreateTables.sql";
            sfd.FilterIndex = 0;
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                File.WriteAllText(sfd.FileName, ListOfTables.GetRequestForTables());

            }
        }
    }
}
