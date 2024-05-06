namespace Kutuphane
{
    partial class AnaEkran
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
            this.araTxt = new System.Windows.Forms.TextBox();
            this.kategoriBox = new System.Windows.Forms.ComboBox();
            this.araBtn = new System.Windows.Forms.Button();
            this.girisBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.icerikPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // araTxt
            // 
            this.araTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            this.araTxt.Location = new System.Drawing.Point(43, 39);
            this.araTxt.Multiline = true;
            this.araTxt.Name = "araTxt";
            this.araTxt.Size = new System.Drawing.Size(236, 20);
            this.araTxt.TabIndex = 0;
            this.araTxt.Text = "Kitap Adı-Yazar Adı-ISBN";
            this.araTxt.TextChanged += new System.EventHandler(this.araTxt_TextChanged_1);
            // 
            // kategoriBox
            // 
            this.kategoriBox.FormattingEnabled = true;
            this.kategoriBox.Location = new System.Drawing.Point(319, 38);
            this.kategoriBox.Name = "kategoriBox";
            this.kategoriBox.Size = new System.Drawing.Size(121, 21);
            this.kategoriBox.Sorted = true;
            this.kategoriBox.TabIndex = 1;
            this.kategoriBox.SelectedIndexChanged += new System.EventHandler(this.kategoriBox_SelectedIndexChanged);
            // 
            // araBtn
            // 
            this.araBtn.Location = new System.Drawing.Point(493, 36);
            this.araBtn.Name = "araBtn";
            this.araBtn.Size = new System.Drawing.Size(75, 23);
            this.araBtn.TabIndex = 2;
            this.araBtn.Text = "Ara";
            this.araBtn.UseVisualStyleBackColor = true;
            this.araBtn.Click += new System.EventHandler(this.araBtn_Click);
            // 
            // girisBtn
            // 
            this.girisBtn.Location = new System.Drawing.Point(584, 37);
            this.girisBtn.Name = "girisBtn";
            this.girisBtn.Size = new System.Drawing.Size(75, 23);
            this.girisBtn.TabIndex = 3;
            this.girisBtn.Text = "Giriş Yap";
            this.girisBtn.UseVisualStyleBackColor = true;
            this.girisBtn.Click += new System.EventHandler(this.girisBtn_Click_1);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(57, 228);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(645, 145);
            this.panel1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(742, 309);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.araTxt);
            this.panel5.Controls.Add(this.kategoriBox);
            this.panel5.Controls.Add(this.araBtn);
            this.panel5.Controls.Add(this.girisBtn);
            this.panel5.Location = new System.Drawing.Point(14, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(742, 100);
            this.panel5.TabIndex = 0;
            // 
            // icerikPanel
            // 
            this.icerikPanel.Location = new System.Drawing.Point(13, 129);
            this.icerikPanel.Name = "icerikPanel";
            this.icerikPanel.Size = new System.Drawing.Size(754, 309);
            this.icerikPanel.TabIndex = 8;
            // 
            // AnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(772, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.icerikPanel);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "AnaEkran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Ekran";
            this.Load += new System.EventHandler(this.AnaEkran_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox araTxt;
        private System.Windows.Forms.ComboBox kategoriBox;
        private System.Windows.Forms.Button araBtn;
        private System.Windows.Forms.Button girisBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel icerikPanel;
    }
}