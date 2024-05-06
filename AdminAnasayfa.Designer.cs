namespace Kutuphane
{
    partial class AdminAnasayfa
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cikisBtn = new System.Windows.Forms.Button();
            this.profilBtn = new System.Windows.Forms.Button();
            this.btnEmanetIslem = new System.Windows.Forms.Button();
            this.btnUyeIslem = new System.Windows.Forms.Button();
            this.btnKitapIslem = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel1.Location = new System.Drawing.Point(180, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(620, 453);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel2.Controls.Add(this.cikisBtn);
            this.panel2.Controls.Add(this.profilBtn);
            this.panel2.Controls.Add(this.btnEmanetIslem);
            this.panel2.Controls.Add(this.btnUyeIslem);
            this.panel2.Controls.Add(this.btnKitapIslem);
            this.panel2.Location = new System.Drawing.Point(2, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(172, 450);
            this.panel2.TabIndex = 0;
            // 
            // cikisBtn
            // 
            this.cikisBtn.Location = new System.Drawing.Point(31, 397);
            this.cikisBtn.Name = "cikisBtn";
            this.cikisBtn.Size = new System.Drawing.Size(110, 40);
            this.cikisBtn.TabIndex = 5;
            this.cikisBtn.Text = "Çıkış Yap";
            this.cikisBtn.UseVisualStyleBackColor = true;
            this.cikisBtn.Click += new System.EventHandler(this.cikisBtn_Click);
            // 
            // profilBtn
            // 
            this.profilBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profilBtn.Location = new System.Drawing.Point(3, 271);
            this.profilBtn.Name = "profilBtn";
            this.profilBtn.Size = new System.Drawing.Size(166, 64);
            this.profilBtn.TabIndex = 4;
            this.profilBtn.Text = "Profil İşlemleri";
            this.profilBtn.UseVisualStyleBackColor = true;
            this.profilBtn.Click += new System.EventHandler(this.profilBtn_Click_1);
            // 
            // btnEmanetIslem
            // 
            this.btnEmanetIslem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmanetIslem.Location = new System.Drawing.Point(3, 201);
            this.btnEmanetIslem.Name = "btnEmanetIslem";
            this.btnEmanetIslem.Size = new System.Drawing.Size(166, 64);
            this.btnEmanetIslem.TabIndex = 2;
            this.btnEmanetIslem.Text = "Emanet İşlemleri";
            this.btnEmanetIslem.UseVisualStyleBackColor = true;
            this.btnEmanetIslem.Click += new System.EventHandler(this.btnEmanetIslem_Click_1);
            // 
            // btnUyeIslem
            // 
            this.btnUyeIslem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUyeIslem.Location = new System.Drawing.Point(3, 131);
            this.btnUyeIslem.Name = "btnUyeIslem";
            this.btnUyeIslem.Size = new System.Drawing.Size(166, 64);
            this.btnUyeIslem.TabIndex = 1;
            this.btnUyeIslem.Text = "Üye İşlemleri";
            this.btnUyeIslem.UseVisualStyleBackColor = true;
            this.btnUyeIslem.Click += new System.EventHandler(this.btnUyeIslem_Click_1);
            // 
            // btnKitapIslem
            // 
            this.btnKitapIslem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKitapIslem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnKitapIslem.Location = new System.Drawing.Point(3, 61);
            this.btnKitapIslem.Name = "btnKitapIslem";
            this.btnKitapIslem.Size = new System.Drawing.Size(166, 64);
            this.btnKitapIslem.TabIndex = 0;
            this.btnKitapIslem.Text = "Kitap İşlemleri";
            this.btnKitapIslem.UseVisualStyleBackColor = true;
            this.btnKitapIslem.Click += new System.EventHandler(this.btnKitapIslem_Click_1);
            // 
            // AdminAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AdminAnasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Anasayfa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminAnasayfa_FormClosing);
            this.Load += new System.EventHandler(this.AdminAnasayfa_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button profilBtn;
        private System.Windows.Forms.Button btnEmanetIslem;
        private System.Windows.Forms.Button btnUyeIslem;
        private System.Windows.Forms.Button btnKitapIslem;
        private System.Windows.Forms.Button cikisBtn;
    }
}