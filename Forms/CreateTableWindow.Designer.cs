namespace SQLconstructor.Forms
{
    partial class CreateTableWindow
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
            this.tableMain = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridFields = new System.Windows.Forms.DataGridView();
            this.FieldName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataTypeOfField = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.isNull = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isUnique = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isFK = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.fkTable = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.fkField = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.defaultValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableMain.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFields)).BeginInit();
            this.SuspendLayout();
            // 
            // tableMain
            // 
            this.tableMain.ColumnCount = 1;
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableMain.Controls.Add(this.groupBox1, 0, 0);
            this.tableMain.Controls.Add(this.panel1, 0, 2);
            this.tableMain.Controls.Add(this.dataGridFields, 0, 1);
            this.tableMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableMain.Location = new System.Drawing.Point(0, 0);
            this.tableMain.Name = "tableMain";
            this.tableMain.RowCount = 3;
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableMain.Size = new System.Drawing.Size(597, 461);
            this.tableMain.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(591, 54);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Введите имя таблицы";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("SF UI Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(6, 19);
            this.textBox1.MaxLength = 16;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(576, 21);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 414);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(591, 44);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Создать таблицу";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(408, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Закрыть";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dataGridFields
            // 
            this.dataGridFields.AllowUserToOrderColumns = true;
            this.dataGridFields.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridFields.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridFields.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridFields.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFields.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FieldName,
            this.DataTypeOfField,
            this.isNull,
            this.isUnique,
            this.isFK,
            this.fkTable,
            this.fkField,
            this.defaultValue});
            this.dataGridFields.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridFields.Location = new System.Drawing.Point(3, 63);
            this.dataGridFields.Name = "dataGridFields";
            this.dataGridFields.Size = new System.Drawing.Size(591, 345);
            this.dataGridFields.TabIndex = 2;
            // 
            // FieldName
            // 
            this.FieldName.HeaderText = "Имя поля";
            this.FieldName.Name = "FieldName";
            // 
            // DataTypeOfField
            // 
            this.DataTypeOfField.DataPropertyName = "DataTypesEnumeration";
            this.DataTypeOfField.HeaderText = "Тип данных";
            this.DataTypeOfField.Name = "DataTypeOfField";
            // 
            // isNull
            // 
            this.isNull.HeaderText = "NULL";
            this.isNull.Name = "isNull";
            // 
            // isUnique
            // 
            this.isUnique.HeaderText = "Уникальный";
            this.isUnique.Name = "isUnique";
            // 
            // isFK
            // 
            this.isFK.HeaderText = "Внешний ключ";
            this.isFK.Name = "isFK";
            // 
            // fkTable
            // 
            this.fkTable.HeaderText = "Внешний ключ (таблица)";
            this.fkTable.Name = "fkTable";
            // 
            // fkField
            // 
            this.fkField.HeaderText = "Внешний ключ (поле)";
            this.fkField.Name = "fkField";
            // 
            // defaultValue
            // 
            this.defaultValue.HeaderText = "Значение по умолчанию";
            this.defaultValue.Name = "defaultValue";
            // 
            // CreateTableWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 461);
            this.ControlBox = false;
            this.Controls.Add(this.tableMain);
            this.Name = "CreateTableWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создание таблицы";
            this.tableMain.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFields)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableMain;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridFields;
        private System.Windows.Forms.DataGridViewTextBoxColumn FieldName;
        private System.Windows.Forms.DataGridViewComboBoxColumn DataTypeOfField;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isNull;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isUnique;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isFK;
        private System.Windows.Forms.DataGridViewComboBoxColumn fkTable;
        private System.Windows.Forms.DataGridViewComboBoxColumn fkField;
        private System.Windows.Forms.DataGridViewTextBoxColumn defaultValue;
    }
}