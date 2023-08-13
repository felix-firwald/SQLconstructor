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
            this.inputName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.flowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonAddField = new System.Windows.Forms.Button();
            this.fieldLabelCreate1 = new SQLconstructor.UserControls.FieldLabelCreate();
            this.fieldItemCreate1 = new SQLconstructor.UserControls.FieldItemCreate();
            this.tableMain.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayout.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableMain
            // 
            this.tableMain.ColumnCount = 1;
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableMain.Controls.Add(this.groupBox1, 0, 0);
            this.tableMain.Controls.Add(this.panel1, 0, 3);
            this.tableMain.Controls.Add(this.flowLayout, 0, 2);
            this.tableMain.Controls.Add(this.panel2, 0, 1);
            this.tableMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableMain.Location = new System.Drawing.Point(0, 0);
            this.tableMain.Name = "tableMain";
            this.tableMain.RowCount = 4;
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableMain.Size = new System.Drawing.Size(684, 461);
            this.tableMain.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.inputName);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(678, 54);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Введите имя таблицы";
            // 
            // inputName
            // 
            this.inputName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputName.Font = new System.Drawing.Font("SF UI Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputName.Location = new System.Drawing.Point(6, 19);
            this.inputName.Margin = new System.Windows.Forms.Padding(12);
            this.inputName.MaxLength = 16;
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(666, 21);
            this.inputName.TabIndex = 0;
            this.inputName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Controls.Add(this.buttonOk);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(14, 425);
            this.panel1.Margin = new System.Windows.Forms.Padding(14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(656, 22);
            this.panel1.TabIndex = 1;
            // 
            // buttonClose
            // 
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonClose.Location = new System.Drawing.Point(482, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(174, 22);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "Закрыть";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOk.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonOk.Location = new System.Drawing.Point(0, 0);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(174, 22);
            this.buttonOk.TabIndex = 0;
            this.buttonOk.Text = "Создать таблицу";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // flowLayout
            // 
            this.flowLayout.AutoScroll = true;
            this.flowLayout.Controls.Add(this.fieldLabelCreate1);
            this.flowLayout.Controls.Add(this.fieldItemCreate1);
            this.flowLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayout.Location = new System.Drawing.Point(3, 103);
            this.flowLayout.Name = "flowLayout";
            this.flowLayout.Size = new System.Drawing.Size(678, 305);
            this.flowLayout.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonAddField);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(9, 69);
            this.panel2.Margin = new System.Windows.Forms.Padding(9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(666, 22);
            this.panel2.TabIndex = 3;
            // 
            // buttonAddField
            // 
            this.buttonAddField.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonAddField.Location = new System.Drawing.Point(0, 0);
            this.buttonAddField.Name = "buttonAddField";
            this.buttonAddField.Size = new System.Drawing.Size(142, 22);
            this.buttonAddField.TabIndex = 0;
            this.buttonAddField.Text = "Добавить поле";
            this.buttonAddField.UseVisualStyleBackColor = true;
            this.buttonAddField.Click += new System.EventHandler(this.buttonAddField_Click);
            // 
            // fieldLabelCreate1
            // 
            this.fieldLabelCreate1.Dock = System.Windows.Forms.DockStyle.Top;
            this.fieldLabelCreate1.Location = new System.Drawing.Point(3, 3);
            this.fieldLabelCreate1.Name = "fieldLabelCreate1";
            this.fieldLabelCreate1.Size = new System.Drawing.Size(1100, 30);
            this.fieldLabelCreate1.TabIndex = 0;
            // 
            // fieldItemCreate1
            // 
            this.fieldItemCreate1.Location = new System.Drawing.Point(3, 39);
            this.fieldItemCreate1.Name = "fieldItemCreate1";
            this.fieldItemCreate1.Size = new System.Drawing.Size(1100, 25);
            this.fieldItemCreate1.TabIndex = 1;
            // 
            // CreateTableWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.ControlBox = false;
            this.Controls.Add(this.tableMain);
            this.MaximumSize = new System.Drawing.Size(1100, 600);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "CreateTableWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создание таблицы";
            this.tableMain.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.flowLayout.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableMain;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox inputName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.FlowLayoutPanel flowLayout;
        private UserControls.FieldLabelCreate fieldLabelCreate1;
        private UserControls.FieldItemCreate fieldItemCreate1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonAddField;
    }
}