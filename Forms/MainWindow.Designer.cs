namespace SQLconstructor.Forms
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.tableMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableRight = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonGetTablesFromFile = new System.Windows.Forms.Button();
            this.buttonCreateTable = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonSaveAll = new System.Windows.Forms.Button();
            this.buttonSaveCreates = new System.Windows.Forms.Button();
            this.treeViewOfTables1 = new SQLconstructor.UserControls.TreeViewOfTables();
            this.finalCode1 = new SQLconstructor.UserControls.FinalCode();
            this.databasePanel1 = new SQLconstructor.UserControls.DatabasePanel();
            this.tableMain.SuspendLayout();
            this.tableRight.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableMain
            // 
            this.tableMain.ColumnCount = 3;
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 240F));
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 240F));
            this.tableMain.Controls.Add(this.tableRight, 2, 0);
            this.tableMain.Controls.Add(this.finalCode1, 1, 0);
            this.tableMain.Controls.Add(this.databasePanel1, 0, 0);
            this.tableMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableMain.Location = new System.Drawing.Point(0, 0);
            this.tableMain.Name = "tableMain";
            this.tableMain.RowCount = 1;
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableMain.Size = new System.Drawing.Size(1264, 561);
            this.tableMain.TabIndex = 0;
            // 
            // tableRight
            // 
            this.tableRight.ColumnCount = 1;
            this.tableRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableRight.Controls.Add(this.groupBox1, 0, 0);
            this.tableRight.Controls.Add(this.groupBox2, 0, 1);
            this.tableRight.Controls.Add(this.groupBox3, 0, 2);
            this.tableRight.Controls.Add(this.treeViewOfTables1, 0, 3);
            this.tableRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableRight.Location = new System.Drawing.Point(1027, 3);
            this.tableRight.Name = "tableRight";
            this.tableRight.RowCount = 4;
            this.tableRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableRight.Size = new System.Drawing.Size(234, 555);
            this.tableRight.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonGetTablesFromFile);
            this.groupBox1.Controls.Add(this.buttonCreateTable);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 84);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Создание таблицы";
            // 
            // buttonGetTablesFromFile
            // 
            this.buttonGetTablesFromFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGetTablesFromFile.Location = new System.Drawing.Point(6, 46);
            this.buttonGetTablesFromFile.Name = "buttonGetTablesFromFile";
            this.buttonGetTablesFromFile.Size = new System.Drawing.Size(216, 23);
            this.buttonGetTablesFromFile.TabIndex = 1;
            this.buttonGetTablesFromFile.Text = "Достать таблицу из файла";
            this.buttonGetTablesFromFile.UseVisualStyleBackColor = true;
            this.buttonGetTablesFromFile.Click += new System.EventHandler(this.buttonGetTablesFromFile_Click);
            // 
            // buttonCreateTable
            // 
            this.buttonCreateTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCreateTable.Location = new System.Drawing.Point(6, 20);
            this.buttonCreateTable.Name = "buttonCreateTable";
            this.buttonCreateTable.Size = new System.Drawing.Size(216, 23);
            this.buttonCreateTable.TabIndex = 0;
            this.buttonCreateTable.Text = "Создать таблицу";
            this.buttonCreateTable.UseVisualStyleBackColor = true;
            this.buttonCreateTable.Click += new System.EventHandler(this.buttonCreateTable_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 84);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Генерация данных";
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(7, 49);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(215, 23);
            this.button4.TabIndex = 1;
            this.button4.Text = "Сгенерировать данные";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(7, 20);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(215, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "Создать генератор";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonSaveAll);
            this.groupBox3.Controls.Add(this.buttonSaveCreates);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 183);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(228, 84);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Сохранение данных";
            // 
            // buttonSaveAll
            // 
            this.buttonSaveAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSaveAll.Enabled = false;
            this.buttonSaveAll.Location = new System.Drawing.Point(7, 49);
            this.buttonSaveAll.Name = "buttonSaveAll";
            this.buttonSaveAll.Size = new System.Drawing.Size(215, 23);
            this.buttonSaveAll.TabIndex = 1;
            this.buttonSaveAll.Text = "Сохранить все запросы";
            this.buttonSaveAll.UseVisualStyleBackColor = true;
            // 
            // buttonSaveCreates
            // 
            this.buttonSaveCreates.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSaveCreates.Location = new System.Drawing.Point(7, 20);
            this.buttonSaveCreates.Name = "buttonSaveCreates";
            this.buttonSaveCreates.Size = new System.Drawing.Size(215, 23);
            this.buttonSaveCreates.TabIndex = 0;
            this.buttonSaveCreates.Text = "Сохранить запросы на создание";
            this.buttonSaveCreates.UseVisualStyleBackColor = true;
            this.buttonSaveCreates.Click += new System.EventHandler(this.buttonSaveCreates_Click);
            // 
            // treeViewOfTables1
            // 
            this.treeViewOfTables1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewOfTables1.Location = new System.Drawing.Point(3, 273);
            this.treeViewOfTables1.Name = "treeViewOfTables1";
            this.treeViewOfTables1.Size = new System.Drawing.Size(228, 279);
            this.treeViewOfTables1.TabIndex = 3;
            // 
            // finalCode1
            // 
            this.finalCode1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(61)))));
            this.finalCode1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.finalCode1.Location = new System.Drawing.Point(243, 3);
            this.finalCode1.Name = "finalCode1";
            this.finalCode1.Padding = new System.Windows.Forms.Padding(5);
            this.finalCode1.Size = new System.Drawing.Size(778, 555);
            this.finalCode1.TabIndex = 1;
            // 
            // databasePanel1
            // 
            this.databasePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.databasePanel1.Location = new System.Drawing.Point(3, 3);
            this.databasePanel1.Name = "databasePanel1";
            this.databasePanel1.Size = new System.Drawing.Size(234, 500);
            this.databasePanel1.TabIndex = 2;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 561);
            this.Controls.Add(this.tableMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SQLConstructor";
            this.tableMain.ResumeLayout(false);
            this.tableRight.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableMain;
        private System.Windows.Forms.TableLayoutPanel tableRight;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonGetTablesFromFile;
        private System.Windows.Forms.Button buttonCreateTable;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonSaveAll;
        private System.Windows.Forms.Button buttonSaveCreates;
        private UserControls.FinalCode finalCode1;
        private UserControls.TreeViewOfTables treeViewOfTables1;
        private UserControls.DatabasePanel databasePanel1;
    }
}