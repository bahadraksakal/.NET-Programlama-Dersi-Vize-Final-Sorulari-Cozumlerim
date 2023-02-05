namespace Ahmet_Bahadir_Aksakal_GorselProgramlamaFinal
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelidKisiStr = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonCalisanPanelOpen = new System.Windows.Forms.Button();
            this.buttonOgrenciPanelOpen = new System.Windows.Forms.Button();
            this.panelCalisan = new System.Windows.Forms.Panel();
            this.buttonCalisanEkle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxCalisanKurum = new System.Windows.Forms.TextBox();
            this.textBoxCalisanTel = new System.Windows.Forms.TextBox();
            this.textBoxCalisanSoyAd = new System.Windows.Forms.TextBox();
            this.textBoxCalisanAd = new System.Windows.Forms.TextBox();
            this.panelOgrenci = new System.Windows.Forms.Panel();
            this.buttonOgrenciEkle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxOgrenciSinif = new System.Windows.Forms.TextBox();
            this.textBoxOgrenciTel = new System.Windows.Forms.TextBox();
            this.textBoxOgrenciSoyAd = new System.Windows.Forms.TextBox();
            this.textBoxOgrenciAd = new System.Windows.Forms.TextBox();
            this.mySqlConnection1 = new MySql.Data.MySqlClient.MySqlConnection();
            this.buttonDataBaseTest = new System.Windows.Forms.Button();
            this.labelDataBaseTest = new System.Windows.Forms.Label();
            this.dataGridViewListe = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonOgrenciListele = new System.Windows.Forms.Button();
            this.buttonKisiListele = new System.Windows.Forms.Button();
            this.buttonCalisanlariListele = new System.Windows.Forms.Button();
            this.buttonCalisanGuncelle = new System.Windows.Forms.Button();
            this.buttonOgrenciGuncelle = new System.Windows.Forms.Button();
            this.id_kisi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ad_kisi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soy_ad_kisi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel_kisi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unvan_kisi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinif_kisi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kurum_kisi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guncelle = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Sil = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelCalisan.SuspendLayout();
            this.panelOgrenci.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListe)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelidKisiStr);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.buttonCalisanPanelOpen);
            this.panel1.Controls.Add(this.buttonOgrenciPanelOpen);
            this.panel1.Controls.Add(this.panelOgrenci);
            this.panel1.Controls.Add(this.panelCalisan);
            this.panel1.Location = new System.Drawing.Point(12, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 414);
            this.panel1.TabIndex = 0;
            // 
            // labelidKisiStr
            // 
            this.labelidKisiStr.AutoSize = true;
            this.labelidKisiStr.Location = new System.Drawing.Point(18, 12);
            this.labelidKisiStr.Name = "labelidKisiStr";
            this.labelidKisiStr.Size = new System.Drawing.Size(18, 16);
            this.labelidKisiStr.TabIndex = 4;
            this.labelidKisiStr.Text = "-1";
            this.labelidKisiStr.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(102, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 18);
            this.label9.TabIndex = 3;
            this.label9.Text = "KİŞİ EKLE";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonCalisanPanelOpen
            // 
            this.buttonCalisanPanelOpen.Location = new System.Drawing.Point(169, 49);
            this.buttonCalisanPanelOpen.Name = "buttonCalisanPanelOpen";
            this.buttonCalisanPanelOpen.Size = new System.Drawing.Size(99, 32);
            this.buttonCalisanPanelOpen.TabIndex = 2;
            this.buttonCalisanPanelOpen.Text = "Çalışan";
            this.buttonCalisanPanelOpen.UseVisualStyleBackColor = true;
            this.buttonCalisanPanelOpen.Click += new System.EventHandler(this.buttonCalisanPanelOpen_Click);
            // 
            // buttonOgrenciPanelOpen
            // 
            this.buttonOgrenciPanelOpen.Location = new System.Drawing.Point(13, 49);
            this.buttonOgrenciPanelOpen.Name = "buttonOgrenciPanelOpen";
            this.buttonOgrenciPanelOpen.Size = new System.Drawing.Size(99, 32);
            this.buttonOgrenciPanelOpen.TabIndex = 1;
            this.buttonOgrenciPanelOpen.Text = "Öğrenci";
            this.buttonOgrenciPanelOpen.UseVisualStyleBackColor = true;
            this.buttonOgrenciPanelOpen.Click += new System.EventHandler(this.buttonOgrenciPanelOpen_Click);
            // 
            // panelCalisan
            // 
            this.panelCalisan.Controls.Add(this.label5);
            this.panelCalisan.Controls.Add(this.label6);
            this.panelCalisan.Controls.Add(this.label7);
            this.panelCalisan.Controls.Add(this.label8);
            this.panelCalisan.Controls.Add(this.textBoxCalisanKurum);
            this.panelCalisan.Controls.Add(this.textBoxCalisanTel);
            this.panelCalisan.Controls.Add(this.textBoxCalisanSoyAd);
            this.panelCalisan.Controls.Add(this.textBoxCalisanAd);
            this.panelCalisan.Controls.Add(this.buttonCalisanEkle);
            this.panelCalisan.Controls.Add(this.buttonCalisanGuncelle);
            this.panelCalisan.Location = new System.Drawing.Point(13, 100);
            this.panelCalisan.Name = "panelCalisan";
            this.panelCalisan.Size = new System.Drawing.Size(255, 311);
            this.panelCalisan.TabIndex = 1;
            // 
            // buttonCalisanEkle
            // 
            this.buttonCalisanEkle.Location = new System.Drawing.Point(64, 226);
            this.buttonCalisanEkle.Name = "buttonCalisanEkle";
            this.buttonCalisanEkle.Size = new System.Drawing.Size(110, 32);
            this.buttonCalisanEkle.TabIndex = 8;
            this.buttonCalisanEkle.Text = "Çalışan Ekle";
            this.buttonCalisanEkle.UseVisualStyleBackColor = true;
            this.buttonCalisanEkle.Click += new System.EventHandler(this.buttonCalisanEkle_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Kurum:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Telefon:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Soyad:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "Ad:";
            // 
            // textBoxCalisanKurum
            // 
            this.textBoxCalisanKurum.Location = new System.Drawing.Point(64, 144);
            this.textBoxCalisanKurum.Name = "textBoxCalisanKurum";
            this.textBoxCalisanKurum.Size = new System.Drawing.Size(169, 22);
            this.textBoxCalisanKurum.TabIndex = 3;
            // 
            // textBoxCalisanTel
            // 
            this.textBoxCalisanTel.Location = new System.Drawing.Point(64, 96);
            this.textBoxCalisanTel.Name = "textBoxCalisanTel";
            this.textBoxCalisanTel.Size = new System.Drawing.Size(169, 22);
            this.textBoxCalisanTel.TabIndex = 2;
            // 
            // textBoxCalisanSoyAd
            // 
            this.textBoxCalisanSoyAd.Location = new System.Drawing.Point(64, 54);
            this.textBoxCalisanSoyAd.Name = "textBoxCalisanSoyAd";
            this.textBoxCalisanSoyAd.Size = new System.Drawing.Size(170, 22);
            this.textBoxCalisanSoyAd.TabIndex = 1;
            // 
            // textBoxCalisanAd
            // 
            this.textBoxCalisanAd.Location = new System.Drawing.Point(64, 19);
            this.textBoxCalisanAd.Name = "textBoxCalisanAd";
            this.textBoxCalisanAd.Size = new System.Drawing.Size(169, 22);
            this.textBoxCalisanAd.TabIndex = 0;
            // 
            // panelOgrenci
            // 
            this.panelOgrenci.Controls.Add(this.buttonOgrenciEkle);
            this.panelOgrenci.Controls.Add(this.label4);
            this.panelOgrenci.Controls.Add(this.label3);
            this.panelOgrenci.Controls.Add(this.label2);
            this.panelOgrenci.Controls.Add(this.label1);
            this.panelOgrenci.Controls.Add(this.textBoxOgrenciSinif);
            this.panelOgrenci.Controls.Add(this.textBoxOgrenciTel);
            this.panelOgrenci.Controls.Add(this.textBoxOgrenciSoyAd);
            this.panelOgrenci.Controls.Add(this.textBoxOgrenciAd);
            this.panelOgrenci.Controls.Add(this.buttonOgrenciGuncelle);
            this.panelOgrenci.Location = new System.Drawing.Point(13, 100);
            this.panelOgrenci.Name = "panelOgrenci";
            this.panelOgrenci.Size = new System.Drawing.Size(255, 311);
            this.panelOgrenci.TabIndex = 1;
            // 
            // buttonOgrenciEkle
            // 
            this.buttonOgrenciEkle.Location = new System.Drawing.Point(64, 226);
            this.buttonOgrenciEkle.Name = "buttonOgrenciEkle";
            this.buttonOgrenciEkle.Size = new System.Drawing.Size(110, 32);
            this.buttonOgrenciEkle.TabIndex = 8;
            this.buttonOgrenciEkle.Text = "Öğrenci Ekle";
            this.buttonOgrenciEkle.UseVisualStyleBackColor = true;
            this.buttonOgrenciEkle.Click += new System.EventHandler(this.buttonOgrenciEkle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sınıf:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Telefon:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ad:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxOgrenciSinif
            // 
            this.textBoxOgrenciSinif.Location = new System.Drawing.Point(64, 144);
            this.textBoxOgrenciSinif.Name = "textBoxOgrenciSinif";
            this.textBoxOgrenciSinif.Size = new System.Drawing.Size(169, 22);
            this.textBoxOgrenciSinif.TabIndex = 3;
            // 
            // textBoxOgrenciTel
            // 
            this.textBoxOgrenciTel.Location = new System.Drawing.Point(64, 96);
            this.textBoxOgrenciTel.Name = "textBoxOgrenciTel";
            this.textBoxOgrenciTel.Size = new System.Drawing.Size(169, 22);
            this.textBoxOgrenciTel.TabIndex = 2;
            // 
            // textBoxOgrenciSoyAd
            // 
            this.textBoxOgrenciSoyAd.Location = new System.Drawing.Point(64, 54);
            this.textBoxOgrenciSoyAd.Name = "textBoxOgrenciSoyAd";
            this.textBoxOgrenciSoyAd.Size = new System.Drawing.Size(170, 22);
            this.textBoxOgrenciSoyAd.TabIndex = 1;
            // 
            // textBoxOgrenciAd
            // 
            this.textBoxOgrenciAd.Location = new System.Drawing.Point(64, 19);
            this.textBoxOgrenciAd.Name = "textBoxOgrenciAd";
            this.textBoxOgrenciAd.Size = new System.Drawing.Size(169, 22);
            this.textBoxOgrenciAd.TabIndex = 0;
            // 
            // mySqlConnection1
            // 
            this.mySqlConnection1.ConnectionString = "server=localhost;port=3306;database=database_ahmetbahadiraksakal_gorselprogramlam" +
    "afinal;user id=root";
            // 
            // buttonDataBaseTest
            // 
            this.buttonDataBaseTest.Location = new System.Drawing.Point(12, 21);
            this.buttonDataBaseTest.Name = "buttonDataBaseTest";
            this.buttonDataBaseTest.Size = new System.Drawing.Size(113, 39);
            this.buttonDataBaseTest.TabIndex = 1;
            this.buttonDataBaseTest.Text = "Database Test";
            this.buttonDataBaseTest.UseVisualStyleBackColor = true;
            this.buttonDataBaseTest.Click += new System.EventHandler(this.buttonDataBaseTest_Click);
            // 
            // labelDataBaseTest
            // 
            this.labelDataBaseTest.AutoSize = true;
            this.labelDataBaseTest.Location = new System.Drawing.Point(131, 32);
            this.labelDataBaseTest.Name = "labelDataBaseTest";
            this.labelDataBaseTest.Size = new System.Drawing.Size(105, 16);
            this.labelDataBaseTest.TabIndex = 2;
            this.labelDataBaseTest.Text = "Bağlantı Durumu";
            this.labelDataBaseTest.Visible = false;
            // 
            // dataGridViewListe
            // 
            this.dataGridViewListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_kisi,
            this.ad_kisi,
            this.soy_ad_kisi,
            this.tel_kisi,
            this.unvan_kisi,
            this.sinif_kisi,
            this.kurum_kisi,
            this.guncelle,
            this.Sil});
            this.dataGridViewListe.Location = new System.Drawing.Point(22, 65);
            this.dataGridViewListe.Name = "dataGridViewListe";
            this.dataGridViewListe.RowHeadersWidth = 51;
            this.dataGridViewListe.RowTemplate.Height = 24;
            this.dataGridViewListe.Size = new System.Drawing.Size(1172, 389);
            this.dataGridViewListe.TabIndex = 3;
            this.dataGridViewListe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewListe_CellClick);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.buttonCalisanlariListele);
            this.panel2.Controls.Add(this.buttonKisiListele);
            this.panel2.Controls.Add(this.buttonOgrenciListele);
            this.panel2.Controls.Add(this.dataGridViewListe);
            this.panel2.Location = new System.Drawing.Point(316, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1216, 467);
            this.panel2.TabIndex = 4;
            // 
            // buttonOgrenciListele
            // 
            this.buttonOgrenciListele.Location = new System.Drawing.Point(22, 10);
            this.buttonOgrenciListele.Name = "buttonOgrenciListele";
            this.buttonOgrenciListele.Size = new System.Drawing.Size(149, 37);
            this.buttonOgrenciListele.TabIndex = 4;
            this.buttonOgrenciListele.Text = "Ogrencileri Listele";
            this.buttonOgrenciListele.UseVisualStyleBackColor = true;
            this.buttonOgrenciListele.Click += new System.EventHandler(this.buttonOgrenciListele_Click);
            // 
            // buttonKisiListele
            // 
            this.buttonKisiListele.Location = new System.Drawing.Point(545, 10);
            this.buttonKisiListele.Name = "buttonKisiListele";
            this.buttonKisiListele.Size = new System.Drawing.Size(149, 37);
            this.buttonKisiListele.TabIndex = 5;
            this.buttonKisiListele.Text = "Kişileri Listele";
            this.buttonKisiListele.UseVisualStyleBackColor = true;
            this.buttonKisiListele.Click += new System.EventHandler(this.buttonKisiListele_Click);
            // 
            // buttonCalisanlariListele
            // 
            this.buttonCalisanlariListele.Location = new System.Drawing.Point(1045, 10);
            this.buttonCalisanlariListele.Name = "buttonCalisanlariListele";
            this.buttonCalisanlariListele.Size = new System.Drawing.Size(149, 37);
            this.buttonCalisanlariListele.TabIndex = 6;
            this.buttonCalisanlariListele.Text = "Çalışanları Listele";
            this.buttonCalisanlariListele.UseVisualStyleBackColor = true;
            this.buttonCalisanlariListele.Click += new System.EventHandler(this.buttonCalisanlariListele_Click);
            // 
            // buttonCalisanGuncelle
            // 
            this.buttonCalisanGuncelle.Location = new System.Drawing.Point(47, 226);
            this.buttonCalisanGuncelle.Name = "buttonCalisanGuncelle";
            this.buttonCalisanGuncelle.Size = new System.Drawing.Size(146, 32);
            this.buttonCalisanGuncelle.TabIndex = 8;
            this.buttonCalisanGuncelle.Text = "Çalışan Güncelle";
            this.buttonCalisanGuncelle.UseVisualStyleBackColor = true;
            this.buttonCalisanGuncelle.Visible = false;
            this.buttonCalisanGuncelle.Click += new System.EventHandler(this.buttonCalisanGuncelle_Click);
            // 
            // buttonOgrenciGuncelle
            // 
            this.buttonOgrenciGuncelle.Location = new System.Drawing.Point(47, 226);
            this.buttonOgrenciGuncelle.Name = "buttonOgrenciGuncelle";
            this.buttonOgrenciGuncelle.Size = new System.Drawing.Size(146, 32);
            this.buttonOgrenciGuncelle.TabIndex = 8;
            this.buttonOgrenciGuncelle.Text = "Öğrenci Güncelle";
            this.buttonOgrenciGuncelle.UseVisualStyleBackColor = true;
            this.buttonOgrenciGuncelle.Visible = false;
            this.buttonOgrenciGuncelle.Click += new System.EventHandler(this.buttonOgrenciGuncelle_Click);
            // 
            // id_kisi
            // 
            this.id_kisi.HeaderText = "id_kisi";
            this.id_kisi.MinimumWidth = 6;
            this.id_kisi.Name = "id_kisi";
            this.id_kisi.ReadOnly = true;
            this.id_kisi.Visible = false;
            this.id_kisi.Width = 125;
            // 
            // ad_kisi
            // 
            this.ad_kisi.HeaderText = "Ad";
            this.ad_kisi.MinimumWidth = 6;
            this.ad_kisi.Name = "ad_kisi";
            this.ad_kisi.ReadOnly = true;
            this.ad_kisi.Width = 125;
            // 
            // soy_ad_kisi
            // 
            this.soy_ad_kisi.HeaderText = "Soy Ad";
            this.soy_ad_kisi.MinimumWidth = 6;
            this.soy_ad_kisi.Name = "soy_ad_kisi";
            this.soy_ad_kisi.ReadOnly = true;
            this.soy_ad_kisi.Width = 125;
            // 
            // tel_kisi
            // 
            this.tel_kisi.HeaderText = "Telefon";
            this.tel_kisi.MinimumWidth = 6;
            this.tel_kisi.Name = "tel_kisi";
            this.tel_kisi.ReadOnly = true;
            this.tel_kisi.Width = 125;
            // 
            // unvan_kisi
            // 
            this.unvan_kisi.HeaderText = "Ünvan";
            this.unvan_kisi.MinimumWidth = 6;
            this.unvan_kisi.Name = "unvan_kisi";
            this.unvan_kisi.ReadOnly = true;
            this.unvan_kisi.Width = 125;
            // 
            // sinif_kisi
            // 
            this.sinif_kisi.HeaderText = "Sınıf";
            this.sinif_kisi.MinimumWidth = 6;
            this.sinif_kisi.Name = "sinif_kisi";
            this.sinif_kisi.ReadOnly = true;
            this.sinif_kisi.Width = 125;
            // 
            // kurum_kisi
            // 
            this.kurum_kisi.HeaderText = "Kurum";
            this.kurum_kisi.MinimumWidth = 6;
            this.kurum_kisi.Name = "kurum_kisi";
            this.kurum_kisi.ReadOnly = true;
            this.kurum_kisi.Width = 125;
            // 
            // guncelle
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle7.NullValue = "Güncelle";
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Blue;
            this.guncelle.DefaultCellStyle = dataGridViewCellStyle7;
            this.guncelle.HeaderText = "Güncelle";
            this.guncelle.MinimumWidth = 6;
            this.guncelle.Name = "guncelle";
            this.guncelle.Text = "Güncelle";
            this.guncelle.Width = 125;
            // 
            // Sil
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle8.NullValue = "Sil";
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DarkRed;
            this.Sil.DefaultCellStyle = dataGridViewCellStyle8;
            this.Sil.HeaderText = "Sil";
            this.Sil.MinimumWidth = 6;
            this.Sil.Name = "Sil";
            this.Sil.Text = "Sil";
            this.Sil.Width = 125;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(13, 524);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(858, 25);
            this.label10.TabIndex = 5;
            this.label10.Text = "Ahmet Bahadır Aksakal - 20360859079 / 3. Sınıf Görsel Programlama Dersi Final Pro" +
    "jesi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1535, 595);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.labelDataBaseTest);
            this.Controls.Add(this.buttonDataBaseTest);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelCalisan.ResumeLayout(false);
            this.panelCalisan.PerformLayout();
            this.panelOgrenci.ResumeLayout(false);
            this.panelOgrenci.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListe)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelOgrenci;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxOgrenciSinif;
        private System.Windows.Forms.TextBox textBoxOgrenciTel;
        private System.Windows.Forms.TextBox textBoxOgrenciSoyAd;
        private System.Windows.Forms.TextBox textBoxOgrenciAd;
        private System.Windows.Forms.Button buttonOgrenciEkle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelCalisan;
        private System.Windows.Forms.Button buttonCalisanEkle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxCalisanKurum;
        private System.Windows.Forms.TextBox textBoxCalisanTel;
        private System.Windows.Forms.TextBox textBoxCalisanSoyAd;
        private System.Windows.Forms.TextBox textBoxCalisanAd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonCalisanPanelOpen;
        private System.Windows.Forms.Button buttonOgrenciPanelOpen;
        private System.Windows.Forms.Label labelidKisiStr;
        private MySql.Data.MySqlClient.MySqlConnection mySqlConnection1;
        private System.Windows.Forms.Button buttonDataBaseTest;
        private System.Windows.Forms.Label labelDataBaseTest;
        private System.Windows.Forms.DataGridView dataGridViewListe;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonCalisanlariListele;
        private System.Windows.Forms.Button buttonKisiListele;
        private System.Windows.Forms.Button buttonOgrenciListele;
        private System.Windows.Forms.Button buttonCalisanGuncelle;
        private System.Windows.Forms.Button buttonOgrenciGuncelle;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_kisi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ad_kisi;
        private System.Windows.Forms.DataGridViewTextBoxColumn soy_ad_kisi;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel_kisi;
        private System.Windows.Forms.DataGridViewTextBoxColumn unvan_kisi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinif_kisi;
        private System.Windows.Forms.DataGridViewTextBoxColumn kurum_kisi;
        private System.Windows.Forms.DataGridViewButtonColumn guncelle;
        private System.Windows.Forms.DataGridViewButtonColumn Sil;
        private System.Windows.Forms.Label label10;
    }
}

