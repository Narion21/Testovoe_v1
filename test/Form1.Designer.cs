namespace test
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.connectionBtn = new System.Windows.Forms.Button();
            this.ipTb = new System.Windows.Forms.TextBox();
            this.portTb = new System.Windows.Forms.TextBox();
            this.usernameTb = new System.Windows.Forms.TextBox();
            this.passwordTb = new System.Windows.Forms.TextBox();
            this.databaseTb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableCars = new System.Windows.Forms.DataGridView();
            this.tableMarks = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableOwners = new System.Windows.Forms.DataGridView();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableCars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableMarks)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableOwners)).BeginInit();
            this.SuspendLayout();
            // 
            // connectionBtn
            // 
            this.connectionBtn.Location = new System.Drawing.Point(12, 25);
            this.connectionBtn.Name = "connectionBtn";
            this.connectionBtn.Size = new System.Drawing.Size(220, 115);
            this.connectionBtn.TabIndex = 0;
            this.connectionBtn.Text = "button1";
            this.connectionBtn.UseVisualStyleBackColor = true;
            this.connectionBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // ipTb
            // 
            this.ipTb.Location = new System.Drawing.Point(251, 11);
            this.ipTb.Name = "ipTb";
            this.ipTb.Size = new System.Drawing.Size(100, 31);
            this.ipTb.TabIndex = 1;
            // 
            // portTb
            // 
            this.portTb.Location = new System.Drawing.Point(251, 48);
            this.portTb.Name = "portTb";
            this.portTb.Size = new System.Drawing.Size(100, 31);
            this.portTb.TabIndex = 2;
            // 
            // usernameTb
            // 
            this.usernameTb.Location = new System.Drawing.Point(251, 85);
            this.usernameTb.Name = "usernameTb";
            this.usernameTb.Size = new System.Drawing.Size(100, 31);
            this.usernameTb.TabIndex = 3;
            // 
            // passwordTb
            // 
            this.passwordTb.Location = new System.Drawing.Point(251, 122);
            this.passwordTb.Name = "passwordTb";
            this.passwordTb.Size = new System.Drawing.Size(100, 31);
            this.passwordTb.TabIndex = 4;
            // 
            // databaseTb
            // 
            this.databaseTb.Location = new System.Drawing.Point(251, 166);
            this.databaseTb.Name = "databaseTb";
            this.databaseTb.Size = new System.Drawing.Size(100, 31);
            this.databaseTb.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 125);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Location = new System.Drawing.Point(426, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1109, 988);
            this.tabControl.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableCars);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1093, 941);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cars";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableMarks);
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1093, 941);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Marks";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableCars
            // 
            this.tableCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableCars.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableCars.Location = new System.Drawing.Point(3, 3);
            this.tableCars.Name = "tableCars";
            this.tableCars.RowHeadersWidth = 82;
            this.tableCars.RowTemplate.Height = 33;
            this.tableCars.Size = new System.Drawing.Size(1087, 935);
            this.tableCars.TabIndex = 10;
            // 
            // tableMarks
            // 
            this.tableMarks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableMarks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableMarks.Location = new System.Drawing.Point(3, 3);
            this.tableMarks.Name = "tableMarks";
            this.tableMarks.RowHeadersWidth = 82;
            this.tableMarks.RowTemplate.Height = 33;
            this.tableMarks.Size = new System.Drawing.Size(1087, 935);
            this.tableMarks.TabIndex = 11;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tableOwners);
            this.tabPage3.Location = new System.Drawing.Point(8, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1093, 941);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Owners";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableOwners
            // 
            this.tableOwners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableOwners.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableOwners.Location = new System.Drawing.Point(3, 3);
            this.tableOwners.Name = "tableOwners";
            this.tableOwners.RowHeadersWidth = 82;
            this.tableOwners.RowTemplate.Height = 33;
            this.tableOwners.Size = new System.Drawing.Size(1087, 935);
            this.tableOwners.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1560, 1034);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.databaseTb);
            this.Controls.Add(this.passwordTb);
            this.Controls.Add(this.usernameTb);
            this.Controls.Add(this.portTb);
            this.Controls.Add(this.ipTb);
            this.Controls.Add(this.connectionBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableCars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableMarks)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableOwners)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connectionBtn;
        private System.Windows.Forms.TextBox ipTb;
        private System.Windows.Forms.TextBox portTb;
        private System.Windows.Forms.TextBox usernameTb;
        private System.Windows.Forms.TextBox passwordTb;
        private System.Windows.Forms.TextBox databaseTb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView tableCars;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView tableMarks;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView tableOwners;
    }
}

