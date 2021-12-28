
namespace Parser
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MembersGread = new System.Windows.Forms.DataGridView();
            this.ParserButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxMiddleName = new System.Windows.Forms.TextBox();
            this.textBoxBirthDay = new System.Windows.Forms.TextBox();
            this.TeamsGread = new System.Windows.Forms.DataGridView();
            this.CreateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MembersGread)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeamsGread)).BeginInit();
            this.SuspendLayout();
            // 
            // MembersGread
            // 
            this.MembersGread.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MembersGread.DefaultCellStyle = dataGridViewCellStyle1;
            this.MembersGread.Location = new System.Drawing.Point(1037, 183);
            this.MembersGread.Name = "MembersGread";
            this.MembersGread.RowTemplate.Height = 25;
            this.MembersGread.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MembersGread.Size = new System.Drawing.Size(463, 422);
            this.MembersGread.TabIndex = 1;
            this.MembersGread.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MembersGread_CellContentClick);
            // 
            // ParserButton
            // 
            this.ParserButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ParserButton.Location = new System.Drawing.Point(695, 614);
            this.ParserButton.Name = "ParserButton";
            this.ParserButton.Size = new System.Drawing.Size(220, 119);
            this.ParserButton.TabIndex = 2;
            this.ParserButton.Text = "Parse";
            this.ParserButton.UseVisualStyleBackColor = true;
            this.ParserButton.Click += new System.EventHandler(this.ParserButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1037, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "FirstName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1167, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "LastName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1303, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "MiddleName";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1458, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Birthday";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(1015, 72);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(100, 23);
            this.textBoxFirstName.TabIndex = 7;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(1154, 72);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(100, 23);
            this.textBoxLastName.TabIndex = 8;
            // 
            // textBoxMiddleName
            // 
            this.textBoxMiddleName.Location = new System.Drawing.Point(1292, 72);
            this.textBoxMiddleName.Name = "textBoxMiddleName";
            this.textBoxMiddleName.Size = new System.Drawing.Size(100, 23);
            this.textBoxMiddleName.TabIndex = 9;
            // 
            // textBoxBirthDay
            // 
            this.textBoxBirthDay.Location = new System.Drawing.Point(1437, 72);
            this.textBoxBirthDay.Name = "textBoxBirthDay";
            this.textBoxBirthDay.Size = new System.Drawing.Size(100, 23);
            this.textBoxBirthDay.TabIndex = 10;
            // 
            // TeamsGread
            // 
            this.TeamsGread.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TeamsGread.DefaultCellStyle = dataGridViewCellStyle2;
            this.TeamsGread.Location = new System.Drawing.Point(119, 183);
            this.TeamsGread.Name = "TeamsGread";
            this.TeamsGread.RowTemplate.Height = 25;
            this.TeamsGread.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TeamsGread.Size = new System.Drawing.Size(463, 422);
            this.TeamsGread.TabIndex = 11;
            this.TeamsGread.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TeamsGread_CellContentClick_1);
            // 
            // CreateButton
            // 
            this.CreateButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreateButton.Location = new System.Drawing.Point(1467, 649);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(158, 84);
            this.CreateButton.TabIndex = 12;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1677, 761);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.TeamsGread);
            this.Controls.Add(this.textBoxBirthDay);
            this.Controls.Add(this.textBoxMiddleName);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ParserButton);
            this.Controls.Add(this.MembersGread);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.MembersGread)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeamsGread)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView MembersGread;
        private System.Windows.Forms.Button ParserButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxMiddleName;
        private System.Windows.Forms.TextBox textBoxBirthDay;
        private System.Windows.Forms.DataGridView TeamsGread;
        private System.Windows.Forms.Button CreateButton;
    }
}

