using SQLconstructor.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLconstructor.UserControls
{
    public partial class FinalCode : UserControl
    {
        public bool AutoUpdate = true;
        public FinalCode()
        {
            InitializeComponent();
            AutoUpdateThis();
        }
        public void UpdateText(string onText)
        {
            this.richTextBox.Text = onText;
        }

        private List<string> commands = new List<string>
        {
            "CREATE TABLE",
            "DROP TABLE",
            "INSERT INTO",
            "UPDATE",
            "DELETE",
            "SET",
            "SELECT",
            "FROM"
        };
        private List<string> constraints = new List<string> 
        {
            "NOT NULL",
            "UNIQUE",
            "CASCADE",
            "NO ACTION",
            "SET DEFAULT"
        };
        private List<string> fk = new List<string>
        {
            "FOREIGN KEY",
            "REFERENCES",
        };
        private List<string> misc = new List<string>
        {
            "--",
            "(",
            ")",
            ";",
            ",",
            "/*",
            "*/",
            "[",
            "]",
        };

        
        private void UpdateColors()
        {
            this.richTextBox.SelectAll();
            this.richTextBox.SelectionColor = Color.White;
            foreach (SQLDataType type in Enum.GetValues(typeof(SQLDataType)))
            {
                ColorizeAllSubstrings(type.ToString(), Color.DeepSkyBlue);
            }
            foreach (string command in commands)
            {
                ColorizeAllSubstrings(command, Color.LightGreen);
            }
            foreach (string constraint in constraints)
            {
                ColorizeAllSubstrings(constraint, Color.Red);
            }
            foreach (string v in fk)
            {
                ColorizeAllSubstrings(v, Color.BlueViolet);
            }
            foreach (string v in misc)
            {
                ColorizeAllSubstrings(v, Color.DarkGray);
            }

        }
        private void ColorizeAllSubstrings(string text, Color color) 
        {
            int startIndex = 0;
            while (startIndex < this.richTextBox.Text.Length)
            {
                Console.WriteLine($"Try to find from: {startIndex}");
                int start = this.richTextBox.Text.IndexOf(text, startIndex);
                
                if (start < 0)
                {
                    return;
                }
                else
                {
                    startIndex = start + text.Length + 1;
                    this.richTextBox.Select(start, text.Length);
                    this.richTextBox.SelectionColor = color;
                    this.richTextBox.DeselectAll();
                }
            }
        }
        private async void AutoUpdateThis()
        {
            while (this.AutoUpdate)
            {
                await Task.Delay(500);
                if (ListOfTables.IsNeedUpdateForCode())
                {
                    UpdateThis();
                }
            }
            
        }
        private void UpdateThis()
        {
            this.UpdateText(ListOfTables.GetRequestForTables());
            UpdateColors();
        }

        private void buttonUpdate_Click(object sender, System.EventArgs e)
        {
            UpdateThis();
        }
        private void buttonUpdateColorize_Click(object sender, System.EventArgs e)
        {
            UpdateColors();
        }
    }
}
