
namespace ChampionShipParser
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TeamDataGread = new System.Windows.Forms.DataGridView();
            this.ParseFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeamDataGread)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(886, 164);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(532, 313);
            this.dataGridView1.TabIndex = 0;
            // 
            // TeamDataGread
            // 
            this.TeamDataGread.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TeamDataGread.Location = new System.Drawing.Point(67, 164);
            this.TeamDataGread.Name = "TeamDataGread";
            this.TeamDataGread.Size = new System.Drawing.Size(557, 300);
            this.TeamDataGread.TabIndex = 1;
            // 
            // ParseFile
            // 
            this.ParseFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.ParseFile.Location = new System.Drawing.Point(629, 492);
            this.ParseFile.Name = "ParseFile";
            this.ParseFile.Size = new System.Drawing.Size(270, 96);
            this.ParseFile.TabIndex = 2;
            this.ParseFile.Text = "ParseFile";
            this.ParseFile.UseVisualStyleBackColor = true;
            this.ParseFile.Click += new System.EventHandler(this.ParseFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(28, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1778, 831);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ParseFile);
            this.Controls.Add(this.TeamDataGread);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeamDataGread)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView TeamDataGread;
        private System.Windows.Forms.Button ParseFile;
        private System.Windows.Forms.Label label1;
    }
}

