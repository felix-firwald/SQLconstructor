namespace SQLconstructor.UserControls
{
    partial class FieldItemCreate
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableMain = new System.Windows.Forms.TableLayoutPanel();
            this.checkboxUnique = new System.Windows.Forms.CheckBox();
            this.inputName = new System.Windows.Forms.TextBox();
            this.inputType = new System.Windows.Forms.ComboBox();
            this.checkboxNull = new System.Windows.Forms.CheckBox();
            this.checkboxFK = new System.Windows.Forms.CheckBox();
            this.inputDefault = new System.Windows.Forms.TextBox();
            this.inputFKTable = new System.Windows.Forms.ComboBox();
            this.inputFKField = new System.Windows.Forms.ComboBox();
            this.inputSize = new System.Windows.Forms.NumericUpDown();
            this.buttonRemove = new FontAwesome.Sharp.IconButton();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableMain
            // 
            this.tableMain.ColumnCount = 10;
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableMain.Controls.Add(this.checkboxUnique, 5, 0);
            this.tableMain.Controls.Add(this.inputName, 1, 0);
            this.tableMain.Controls.Add(this.inputType, 2, 0);
            this.tableMain.Controls.Add(this.checkboxNull, 4, 0);
            this.tableMain.Controls.Add(this.checkboxFK, 7, 0);
            this.tableMain.Controls.Add(this.inputDefault, 6, 0);
            this.tableMain.Controls.Add(this.inputFKTable, 8, 0);
            this.tableMain.Controls.Add(this.inputFKField, 9, 0);
            this.tableMain.Controls.Add(this.inputSize, 3, 0);
            this.tableMain.Controls.Add(this.buttonRemove, 0, 0);
            this.tableMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableMain.Location = new System.Drawing.Point(0, 0);
            this.tableMain.Name = "tableMain";
            this.tableMain.RowCount = 1;
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableMain.Size = new System.Drawing.Size(1100, 25);
            this.tableMain.TabIndex = 0;
            // 
            // checkboxUnique
            // 
            this.checkboxUnique.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkboxUnique.AutoSize = true;
            this.checkboxUnique.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkboxUnique.Location = new System.Drawing.Point(455, 6);
            this.checkboxUnique.Margin = new System.Windows.Forms.Padding(35, 6, 6, 6);
            this.checkboxUnique.Name = "checkboxUnique";
            this.checkboxUnique.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkboxUnique.Size = new System.Drawing.Size(39, 13);
            this.checkboxUnique.TabIndex = 3;
            this.checkboxUnique.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkboxUnique.UseVisualStyleBackColor = true;
            // 
            // inputName
            // 
            this.inputName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputName.Location = new System.Drawing.Point(28, 3);
            this.inputName.MaxLength = 16;
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(119, 20);
            this.inputName.TabIndex = 0;
            this.inputName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inputType
            // 
            this.inputType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inputType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputType.FormattingEnabled = true;
            this.inputType.Location = new System.Drawing.Point(153, 3);
            this.inputType.Name = "inputType";
            this.inputType.Size = new System.Drawing.Size(114, 21);
            this.inputType.TabIndex = 1;
            // 
            // checkboxNull
            // 
            this.checkboxNull.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkboxNull.AutoSize = true;
            this.checkboxNull.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkboxNull.Location = new System.Drawing.Point(390, 6);
            this.checkboxNull.Margin = new System.Windows.Forms.Padding(20, 6, 6, 6);
            this.checkboxNull.Name = "checkboxNull";
            this.checkboxNull.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkboxNull.Size = new System.Drawing.Size(24, 13);
            this.checkboxNull.TabIndex = 2;
            this.checkboxNull.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkboxNull.UseVisualStyleBackColor = true;
            // 
            // checkboxFK
            // 
            this.checkboxFK.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkboxFK.AutoSize = true;
            this.checkboxFK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkboxFK.Enabled = false;
            this.checkboxFK.Location = new System.Drawing.Point(700, 6);
            this.checkboxFK.Margin = new System.Windows.Forms.Padding(40, 6, 6, 6);
            this.checkboxFK.Name = "checkboxFK";
            this.checkboxFK.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkboxFK.Size = new System.Drawing.Size(54, 13);
            this.checkboxFK.TabIndex = 4;
            this.checkboxFK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkboxFK.UseVisualStyleBackColor = true;
            this.checkboxFK.CheckedChanged += new System.EventHandler(this.checkboxFK_CheckedChanged);
            // 
            // inputDefault
            // 
            this.inputDefault.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputDefault.Location = new System.Drawing.Point(503, 3);
            this.inputDefault.Name = "inputDefault";
            this.inputDefault.Size = new System.Drawing.Size(154, 20);
            this.inputDefault.TabIndex = 5;
            this.inputDefault.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inputFKTable
            // 
            this.inputFKTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inputFKTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputFKTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputFKTable.Enabled = false;
            this.inputFKTable.FormattingEnabled = true;
            this.inputFKTable.Location = new System.Drawing.Point(763, 3);
            this.inputFKTable.Name = "inputFKTable";
            this.inputFKTable.Size = new System.Drawing.Size(164, 21);
            this.inputFKTable.TabIndex = 6;
            this.inputFKTable.SelectedIndexChanged += new System.EventHandler(this.inputFKTable_SelectedIndexChanged);
            // 
            // inputFKField
            // 
            this.inputFKField.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inputFKField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputFKField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputFKField.Enabled = false;
            this.inputFKField.FormattingEnabled = true;
            this.inputFKField.Location = new System.Drawing.Point(933, 3);
            this.inputFKField.Name = "inputFKField";
            this.inputFKField.Size = new System.Drawing.Size(164, 21);
            this.inputFKField.TabIndex = 7;
            this.inputFKField.SelectedIndexChanged += new System.EventHandler(this.inputFKField_SelectedIndexChanged);
            // 
            // inputSize
            // 
            this.inputSize.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.inputSize.Location = new System.Drawing.Point(273, 3);
            this.inputSize.Maximum = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.inputSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.inputSize.Name = "inputSize";
            this.inputSize.Size = new System.Drawing.Size(94, 20);
            this.inputSize.TabIndex = 8;
            this.inputSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // buttonRemove
            // 
            this.buttonRemove.BackColor = System.Drawing.Color.Red;
            this.buttonRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemove.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.buttonRemove.IconColor = System.Drawing.Color.White;
            this.buttonRemove.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonRemove.IconSize = 15;
            this.buttonRemove.Location = new System.Drawing.Point(3, 3);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(19, 19);
            this.buttonRemove.TabIndex = 9;
            this.buttonRemove.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonRemove.UseVisualStyleBackColor = false;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataSource = typeof(SQLconstructor.Classes.Table);
            // 
            // FieldItemCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableMain);
            this.Name = "FieldItemCreate";
            this.Size = new System.Drawing.Size(1100, 25);
            this.tableMain.ResumeLayout(false);
            this.tableMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableMain;
        private System.Windows.Forms.TextBox inputName;
        private System.Windows.Forms.ComboBox inputType;
        private System.Windows.Forms.CheckBox checkboxUnique;
        private System.Windows.Forms.CheckBox checkboxNull;
        private System.Windows.Forms.CheckBox checkboxFK;
        private System.Windows.Forms.TextBox inputDefault;
        private System.Windows.Forms.ComboBox inputFKTable;
        private System.Windows.Forms.ComboBox inputFKField;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private System.Windows.Forms.NumericUpDown inputSize;
        private FontAwesome.Sharp.IconButton buttonRemove;
    }
}
