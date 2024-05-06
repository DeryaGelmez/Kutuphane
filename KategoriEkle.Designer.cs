namespace Kutuphane
{
    partial class KategoriEkle
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.kategoriEkleTxt = new System.Windows.Forms.TextBox();
            this.araCombobox = new System.Windows.Forms.ComboBox();
            this.kaydetBtn = new System.Windows.Forms.Button();
            this.duzenleBtn = new System.Windows.Forms.Button();
            this.silBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori Giriniz:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(333, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kategori:";
            // 
            // kategoriEkleTxt
            // 
            this.kategoriEkleTxt.Location = new System.Drawing.Point(60, 90);
            this.kategoriEkleTxt.Name = "kategoriEkleTxt";
            this.kategoriEkleTxt.Size = new System.Drawing.Size(142, 20);
            this.kategoriEkleTxt.TabIndex = 2;
            // 
            // araCombobox
            // 
            this.araCombobox.FormattingEnabled = true;
            this.araCombobox.Location = new System.Drawing.Point(292, 89);
            this.araCombobox.Name = "araCombobox";
            this.araCombobox.Size = new System.Drawing.Size(156, 21);
            this.araCombobox.TabIndex = 3;
            // 
            // kaydetBtn
            // 
            this.kaydetBtn.Location = new System.Drawing.Point(92, 128);
            this.kaydetBtn.Name = "kaydetBtn";
            this.kaydetBtn.Size = new System.Drawing.Size(75, 23);
            this.kaydetBtn.TabIndex = 4;
            this.kaydetBtn.Text = "Kaydet";
            this.kaydetBtn.UseVisualStyleBackColor = true;
            this.kaydetBtn.Click += new System.EventHandler(this.kaydetBtn_Click_1);
            // 
            // duzenleBtn
            // 
            this.duzenleBtn.Location = new System.Drawing.Point(292, 128);
            this.duzenleBtn.Name = "duzenleBtn";
            this.duzenleBtn.Size = new System.Drawing.Size(75, 23);
            this.duzenleBtn.TabIndex = 5;
            this.duzenleBtn.Text = "Düzenle";
            this.duzenleBtn.UseVisualStyleBackColor = true;
            // 
            // silBtn
            // 
            this.silBtn.Location = new System.Drawing.Point(373, 128);
            this.silBtn.Name = "silBtn";
            this.silBtn.Size = new System.Drawing.Size(75, 23);
            this.silBtn.TabIndex = 6;
            this.silBtn.Text = "Sil";
            this.silBtn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(292, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            // 
            // KategoriEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(514, 213);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.silBtn);
            this.Controls.Add(this.duzenleBtn);
            this.Controls.Add(this.kaydetBtn);
            this.Controls.Add(this.araCombobox);
            this.Controls.Add(this.kategoriEkleTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "KategoriEkle";
            this.Text = "Kategori Ekle";
            this.Load += new System.EventHandler(this.KategoriEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox kategoriEkleTxt;
        private System.Windows.Forms.ComboBox araCombobox;
        private System.Windows.Forms.Button kaydetBtn;
        private System.Windows.Forms.Button duzenleBtn;
        private System.Windows.Forms.Button silBtn;
        private System.Windows.Forms.Label label3;
    }
}