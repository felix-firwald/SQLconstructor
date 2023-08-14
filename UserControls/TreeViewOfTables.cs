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
            TreeNode db = new TreeNode("Database");
            this.treeView.Nodes.Add(db);
            
            foreach (Table table in ListOfTables.tables)
            {
                TreeNode tn = AddTableToView(table);
                foreach (Field field in table.fields) 
                {
                    AddFieldToView(tn, field);
                }
            }
            db.ExpandAll();
        }

        private TreeNode AddTableToView(Table table)
        {
            TreeNode tn = new TreeNode(table.Name);
            this.treeView.Nodes[0].Nodes.Add(tn);
            return tn;
        }

        private void AddFieldToView(TreeNode table, Field field)
        {
            TreeNode tn = table.Nodes.Add(field.name);
            tn.ToolTipText = $"Тип: {field.type}, NULL: {field.isNull}, Уникальность: {field.isUnique}";
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            UpdateView();
        }
    }
}
