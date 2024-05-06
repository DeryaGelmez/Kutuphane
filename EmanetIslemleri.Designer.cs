namespace Kutuphane
{
    partial class EmanetIslemleri
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.geriBtn = new System.Windows.Forms.Button();
            this.verBtn = new System.Windows.Forms.Button();
            this.temizleBtn = new System.Windows.Forms.Button();
            this.alBtn = new System.Windows.Forms.Button();
            this.kitapAraTxt = new System.Windows.Forms.TextBox();
            this.islemAraTxt = new System.Windows.Forms.TextBox();
            this.durumTxt = new System.Windows.Forms.TextBox();
            this.islemAraBtn = new System.Windows.Forms.Button();
            this.kitapAraBtn = new System.Windows.Forms.Button();
            this.uyeAraBtn = new System.Windows.Forms.Button();
            this.uyeAraTxt = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.kitapIDTxt = new System.Windows.Forms.TextBox();
            this.uyeIDTxt = new System.Windows.Forms.TextBox();
            this.yetkiliIDTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.teslimIdTxt = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel1.Controls.Add(this.teslimIdTxt);
            this.panel1.Controls.Add(this.geriBtn);
            this.panel1.Controls.Add(this.verBtn);
            this.panel1.Controls.Add(this.temizleBtn);
            this.panel1.Controls.Add(this.alBtn);
            this.panel1.Controls.Add(this.kitapAraTxt);
            this.panel1.Controls.Add(this.islemAraTxt);
            this.panel1.Controls.Add(this.durumTxt);
            this.panel1.Controls.Add(this.islemAraBtn);
            this.panel1.Controls.Add(this.kitapAraBtn);
            this.panel1.Controls.Add(this.uyeAraBtn);
            this.panel1.Controls.Add(this.uyeAraTxt);
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.dataGridView3);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.kitapIDTxt);
            this.panel1.Controls.Add(this.uyeIDTxt);
            this.panel1.Controls.Add(this.yetkiliIDTxt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.label24);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 449);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // geriBtn
            // 
            this.geriBtn.Location = new System.Drawing.Point(8, 7);
            this.geriBtn.Name = "geriBtn";
            this.geriBtn.Size = new System.Drawing.Size(75, 23);
            this.geriBtn.TabIndex = 25;
            this.geriBtn.Text = "Geri";
            this.geriBtn.UseVisualStyleBackColor = true;
            this.geriBtn.Click += new System.EventHandler(this.geriBtn_Click);
            // 
            // verBtn
            // 
            this.verBtn.Location = new System.Drawing.Point(146, 243);
            this.verBtn.Name = "verBtn";
            this.verBtn.Size = new System.Drawing.Size(89, 39);
            this.verBtn.TabIndex = 24;
            this.verBtn.Text = "Kitap Ver";
            this.verBtn.UseVisualStyleBackColor = true;
            this.verBtn.Click += new System.EventHandler(this.verBtn_Click);
            // 
            // temizleBtn
            // 
            this.temizleBtn.Location = new System.Drawing.Point(41, 243);
            this.temizleBtn.Name = "temizleBtn";
            this.temizleBtn.Size = new System.Drawing.Size(89, 39);
            this.temizleBtn.TabIndex = 23;
            this.temizleBtn.Text = "Temizle";
            this.temizleBtn.UseVisualStyleBackColor = true;
            this.temizleBtn.Click += new System.EventHandler(this.temizleBtn_Click);
            // 
            // alBtn
            // 
            this.alBtn.Location = new System.Drawing.Point(25, 309);
            this.alBtn.Name = "alBtn";
            this.alBtn.Size = new System.Drawing.Size(218, 23);
            this.alBtn.TabIndex = 22;
            this.alBtn.Text = "Teslim Al";
            this.alBtn.UseVisualStyleBackColor = true;
            this.alBtn.Click += new System.EventHandler(this.alBtn_Click);
            // 
            // kitapAraTxt
            // 
            this.kitapAraTxt.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.kitapAraTxt.Location = new System.Drawing.Point(268, 158);
            this.kitapAraTxt.Name = "kitapAraTxt";
            this.kitapAraTxt.Size = new System.Drawing.Size(425, 20);
            this.kitapAraTxt.TabIndex = 21;
            this.kitapAraTxt.Text = "Kitap Adı-Yazar Adı-ISBN-Kategori Adı";
            this.kitapAraTxt.TextChanged += new System.EventHandler(this.kitapAraTxt_TextChanged);
            // 
            // islemAraTxt
            // 
            this.islemAraTxt.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.islemAraTxt.Location = new System.Drawing.Point(268, 309);
            this.islemAraTxt.Name = "islemAraTxt";
            this.islemAraTxt.Size = new System.Drawing.Size(425, 20);
            this.islemAraTxt.TabIndex = 20;
            this.islemAraTxt.Text = "İşlem ID, Üye Adı, Kitap Adı, ISBN";
            // 
            // durumTxt
            // 
            this.durumTxt.Location = new System.Drawing.Point(207, 92);
            this.durumTxt.Name = "durumTxt";
            this.durumTxt.Size = new System.Drawing.Size(24, 20);
            this.durumTxt.TabIndex = 19;
            // 
            // islemAraBtn
            // 
            this.islemAraBtn.Location = new System.Drawing.Point(712, 306);
            this.islemAraBtn.Name = "islemAraBtn";
            this.islemAraBtn.Size = new System.Drawing.Size(75, 23);
            this.islemAraBtn.TabIndex = 18;
            this.islemAraBtn.Text = "Ara";
            this.islemAraBtn.UseVisualStyleBackColor = true;
            this.islemAraBtn.Click += new System.EventHandler(this.islemAraBtn_Click);
            // 
            // kitapAraBtn
            // 
            this.kitapAraBtn.Location = new System.Drawing.Point(712, 158);
            this.kitapAraBtn.Name = "kitapAraBtn";
            this.kitapAraBtn.Size = new System.Drawing.Size(75, 23);
            this.kitapAraBtn.TabIndex = 17;
            this.kitapAraBtn.Text = "Ara";
            this.kitapAraBtn.UseVisualStyleBackColor = true;
            this.kitapAraBtn.Click += new System.EventHandler(this.kitapAraBtn_Click);
            // 
            // uyeAraBtn
            // 
            this.uyeAraBtn.Location = new System.Drawing.Point(712, 7);
            this.uyeAraBtn.Name = "uyeAraBtn";
            this.uyeAraBtn.Size = new System.Drawing.Size(75, 23);
            this.uyeAraBtn.TabIndex = 16;
            this.uyeAraBtn.Text = "Ara";
            this.uyeAraBtn.UseVisualStyleBackColor = true;
            this.uyeAraBtn.Click += new System.EventHandler(this.uyeAraBtn_Click);
            // 
            // uyeAraTxt
            // 
            this.uyeAraTxt.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.uyeAraTxt.Location = new System.Drawing.Point(268, 7);
            this.uyeAraTxt.Name = "uyeAraTxt";
            this.uyeAraTxt.Size = new System.Drawing.Size(425, 20);
            this.uyeAraTxt.TabIndex = 15;
            this.uyeAraTxt.Text = "Ad, Soyad, E-Mail";
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(268, 187);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(519, 113);
            this.dataGridView2.TabIndex = 13;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // dataGridView3
            // 
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(8, 335);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(779, 111);
            this.dataGridView3.TabIndex = 12;
            this.dataGridView3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellClick);
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(268, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(519, 112);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(117, 192);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(118, 20);
            this.dateTimePicker2.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(117, 160);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(118, 20);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // kitapIDTxt
            // 
            this.kitapIDTxt.Location = new System.Drawing.Point(131, 123);
            this.kitapIDTxt.Name = "kitapIDTxt";
            this.kitapIDTxt.Size = new System.Drawing.Size(100, 20);
            this.kitapIDTxt.TabIndex = 7;
            // 
            // uyeIDTxt
            // 
            this.uyeIDTxt.Location = new System.Drawing.Point(131, 92);
            this.uyeIDTxt.Name = "uyeIDTxt";
            this.uyeIDTxt.Size = new System.Drawing.Size(73, 20);
            this.uyeIDTxt.TabIndex = 6;
            // 
            // yetkiliIDTxt
            // 
            this.yetkiliIDTxt.Location = new System.Drawing.Point(131, 60);
            this.yetkiliIDTxt.Name = "yetkiliIDTxt";
            this.yetkiliIDTxt.Size = new System.Drawing.Size(100, 20);
            this.yetkiliIDTxt.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Teslim Tarihi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "İşlem Tarihi:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(38, 130);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(48, 13);
            this.label22.TabIndex = 2;
            this.label22.Text = "Kitap ID:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(38, 99);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(43, 13);
            this.label23.TabIndex = 1;
            this.label23.Text = "Üye ID:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(38, 67);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(52, 13);
            this.label24.TabIndex = 0;
            this.label24.Text = "Yetkili ID:";
            // 
            // teslimIdTxt
            // 
            this.teslimIdTxt.Enabled = false;
            this.teslimIdTxt.Location = new System.Drawing.Point(108, 288);
            this.teslimIdTxt.Name = "teslimIdTxt";
            this.teslimIdTxt.Size = new System.Drawing.Size(56, 20);
            this.teslimIdTxt.TabIndex = 26;
            // 
            // EmanetIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "EmanetIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emanet İşlemleri";
            this.Load += new System.EventHandler(this.EmanetIslemleri_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox kitapIDTxt;
        private System.Windows.Forms.TextBox uyeIDTxt;
        private System.Windows.Forms.TextBox yetkiliIDTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button islemAraBtn;
        private System.Windows.Forms.Button kitapAraBtn;
        private System.Windows.Forms.Button uyeAraBtn;
        private System.Windows.Forms.TextBox uyeAraTxt;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TextBox durumTxt;
        private System.Windows.Forms.Button verBtn;
        private System.Windows.Forms.Button temizleBtn;
        private System.Windows.Forms.Button alBtn;
        private System.Windows.Forms.TextBox kitapAraTxt;
        private System.Windows.Forms.TextBox islemAraTxt;
        private System.Windows.Forms.Button geriBtn;
        private System.Windows.Forms.TextBox teslimIdTxt;
    }
}