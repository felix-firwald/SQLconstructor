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
    public partial class TreeViewOfTables : UserControl
    {
        public TreeViewOfTables()
        {
            InitializeComponent();
        }

        public void UpdateView()
        {
            this.treeView.Nodes.Clear();
            this.treeView.Nodes.Add(new TreeNode("Database"));
            foreach (Table table in ListOfTables.tables)
            {
                AddTableToView(table);
                foreach (Field field in table.fields) 
                {
                    try
                    {
                        AddFieldToView(table, field);
                    }
                    catch (Exception ex) 
                    {
                        MessageBox.Show($"Возникла ошибка:\n{ex}", "Ошибка дерева");
                    }
                }
                
            }
        }

        private void AddTableToView(Table table)
        {
            this.treeView.Nodes[0].Nodes.Add(new TreeNode(table.Name));
        }

        private void AddFieldToView(Table table, Field field)
        {
            this.treeView.Nodes[0].Nodes[table.Name].Nodes.Add(new TreeNode(field.name));
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            UpdateView();
        }
    }
}
