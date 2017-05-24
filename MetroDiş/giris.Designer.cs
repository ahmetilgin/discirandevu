namespace MetroDiş
{
    partial class giris
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
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.isim = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.doktorlariListele = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.kaydet = new MetroFramework.Controls.MetroButton();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroButton2
            // 
            this.metroButton2.Highlight = true;
            this.metroButton2.Location = new System.Drawing.Point(486, 305);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(122, 23);
            this.metroButton2.TabIndex = 2;
            this.metroButton2.Text = "Çıkış";
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // isim
            // 
            this.isim.AutoSize = true;
            this.isim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.isim.Location = new System.Drawing.Point(24, 82);
            this.isim.Name = "isim";
            this.isim.Size = new System.Drawing.Size(128, 24);
            this.isim.TabIndex = 3;
            this.isim.Text = "Kullanıcı ADİ";
            this.isim.Click += new System.EventHandler(this.isim_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "",
            "POLİKLİNİK 1",
            "POLİKLİNİK 2",
            "POLİKLİNİK 3"});
            this.comboBox1.Location = new System.Drawing.Point(158, 120);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(156, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // doktorlariListele
            // 
            this.doktorlariListele.Location = new System.Drawing.Point(45, 305);
            this.doktorlariListele.Name = "doktorlariListele";
            this.doktorlariListele.Size = new System.Drawing.Size(129, 23);
            this.doktorlariListele.TabIndex = 8;
            this.doktorlariListele.Text = "Doktorlari Listele";
            this.doktorlariListele.Click += new System.EventHandler(this.metroButton1_Click_1);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(45, 122);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(104, 19);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "Poliklinik Seçiniz:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(158, 147);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(156, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(45, 147);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(39, 19);
            this.metroLabel2.TabIndex = 11;
            this.metroLabel2.Text = "Tarih:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(45, 182);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(269, 95);
            this.listBox1.TabIndex = 21;
            // 
            // kaydet
            // 
            this.kaydet.Highlight = true;
            this.kaydet.Location = new System.Drawing.Point(342, 305);
            this.kaydet.Name = "kaydet";
            this.kaydet.Size = new System.Drawing.Size(121, 23);
            this.kaydet.Style = MetroFramework.MetroColorStyle.Brown;
            this.kaydet.TabIndex = 22;
            this.kaydet.Text = "Kaydet";
            this.kaydet.Click += new System.EventHandler(this.kaydet_Click);
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(342, 128);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(121, 154);
            this.listBox2.TabIndex = 23;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(181, 305);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(133, 23);
            this.metroButton1.TabIndex = 24;
            this.metroButton1.Text = "Boş Saatleri";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click_2);
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Items.AddRange(new object[] {
            "Diş Ağrısı",
            "Çürük",
            "Protez",
            "Aft",
            "Pamukçuk",
            "Çene kayması",
            "Diş teli",
            "Diğer"});
            this.listBox3.Location = new System.Drawing.Point(486, 122);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(122, 160);
            this.listBox3.TabIndex = 25;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(342, 92);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(49, 19);
            this.metroLabel3.TabIndex = 26;
            this.metroLabel3.Text = "Saatler";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(486, 86);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(49, 19);
            this.metroLabel4.TabIndex = 27;
            this.metroLabel4.Text = "Şikayet";
            // 
            // giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 391);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.kaydet);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.doktorlariListele);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.isim);
            this.Controls.Add(this.metroButton2);
            this.Name = "giris";
            this.Text = "Randevu Ara";
            this.Load += new System.EventHandler(this.giris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton2;
        private System.Windows.Forms.Label isim;
        private System.Windows.Forms.ComboBox comboBox1;
        private MetroFramework.Controls.MetroButton doktorlariListele;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.ListBox listBox1;
        private MetroFramework.Controls.MetroButton kaydet;
        private System.Windows.Forms.ListBox listBox2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.ListBox listBox3;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;

    }
}