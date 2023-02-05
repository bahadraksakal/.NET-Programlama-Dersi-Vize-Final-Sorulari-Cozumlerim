using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Ahmet_Bahadir_Aksakal_GorselProgramlamaFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panelCalisan.Visible = false;
            panelOgrenci.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonOgrenciPanelOpen_Click(object sender, EventArgs e)
        {
            panelCalisan.Visible = false;
            panelOgrenci.Visible = true;
            textBoxOgrenciAd.Text = "";
            textBoxOgrenciSoyAd.Text = "";
            textBoxOgrenciTel.Text = "";
            textBoxOgrenciSinif.Text = "";
            buttonOgrenciEkle.Visible = true;
            buttonOgrenciGuncelle.Visible = false;
        }

        private void buttonCalisanPanelOpen_Click(object sender, EventArgs e)
        {
            panelOgrenci.Visible = false;
            panelCalisan.Visible= true;
            textBoxCalisanAd.Text = "";
            textBoxCalisanSoyAd.Text = "";
            textBoxCalisanTel.Text = "";
            textBoxCalisanKurum.Text = "";
            buttonCalisanEkle.Visible= true;
            buttonCalisanGuncelle.Visible= false;
        }

        private void buttonCalisanEkle_Click(object sender, EventArgs e)
        {
            string ad = textBoxCalisanAd.Text;
            string soyAd = textBoxCalisanSoyAd.Text;
            string tel = textBoxCalisanTel.Text;
            string kurum = textBoxCalisanKurum.Text;
            //Calisan yeniCalisan=new Calisan(ad,soyAd,tel,kurum);
            try
            {
                mySqlConnection1.Open();
                MySqlCommand command = mySqlConnection1.CreateCommand();
                command.CommandText = "INSERT INTO `kisi` (`ad_kisi`, `soy_ad_kisi`, `tel_kisi`, `unvan_kisi`,`kurum_kisi`) VALUES (@ad, @soyAd, @tel, @unvan, @kurum);";
                command.Parameters.AddWithValue("@ad",ad);
                command.Parameters.AddWithValue("@soyAd", soyAd);
                command.Parameters.AddWithValue("@tel", tel);
                command.Parameters.AddWithValue("@unvan", "Çalışan");
                command.Parameters.AddWithValue("@kurum", kurum);
                command.ExecuteNonQuery();
                mySqlConnection1.Close();
                buttonCalisanlariListele.PerformClick();
                MessageBox.Show("Çalışan Başarıyla Eklendi");
            }
            catch
            {
                Console.WriteLine("Calisan Ekle Hata");
                MessageBox.Show("Çalışan Eklenirken Bir Hata Oluştu");
            }
        }

        private void buttonOgrenciEkle_Click(object sender, EventArgs e)
        {
            string ad = textBoxOgrenciAd.Text;
            string soyAd = textBoxOgrenciSoyAd.Text;
            string tel = textBoxOgrenciTel.Text;
            string sinif = textBoxOgrenciSinif.Text;
            try
            {
                mySqlConnection1.Open();
                MySqlCommand command = mySqlConnection1.CreateCommand();
                command.CommandText = "INSERT INTO `kisi` (`ad_kisi`, `soy_ad_kisi`, `tel_kisi`, `unvan_kisi`,`sinif_kisi`) VALUES (@ad, @soyAd, @tel, @unvan, @sinif);";
                command.Parameters.AddWithValue("@ad", ad);
                command.Parameters.AddWithValue("@soyAd", soyAd);
                command.Parameters.AddWithValue("@tel", tel);
                command.Parameters.AddWithValue("@unvan", "Öğrenci");
                command.Parameters.AddWithValue("@sinif", sinif);
                command.ExecuteNonQuery();
                mySqlConnection1.Close();
                buttonOgrenciListele.PerformClick();
                MessageBox.Show("Öğrenci Başarıyla Eklendi");
            }
            catch
            {
                Console.WriteLine("Öğrenci Ekle Hata");
                MessageBox.Show("Öğrenci Eklenirken Bir Hata Oluştu");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonDataBaseTest_Click(object sender, EventArgs e)
        {
            labelDataBaseTest.Visible = true;
            try
            {
                mySqlConnection1.Open();
                mySqlConnection1.Close();
                labelDataBaseTest.Text = "Database Bağlantısı Başarılı";
            }
            catch
            {
                Console.WriteLine("Data Base Bağlantısı Testi Başarısız Oldu !");
                MessageBox.Show("Data Base ile bağlantı kurulumadı");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void Listele(string ListedenDislanicakUnvan)
        {
            try
            {
                mySqlConnection1.Open();
                MySqlCommand command = mySqlConnection1.CreateCommand();
                command.CommandText = "SELECT * FROM kisi;";
                MySqlDataReader reader = command.ExecuteReader();
                int i = 0;
                dataGridViewListe.Rows.Clear();
                dataGridViewListe.Refresh();
                while (reader.Read())
                {
                    if (reader.GetString(4) == ListedenDislanicakUnvan)
                    {
                        continue;
                    }
                    dataGridViewListe.Rows.Add();
                    dataGridViewListe.Rows[i].Cells[0].Value = reader.GetInt32(0);
                    if (!reader.IsDBNull(1))
                    {
                        dataGridViewListe.Rows[i].Cells[1].Value = reader.GetString(1);
                    }
                    if (!reader.IsDBNull(2))
                    {
                        dataGridViewListe.Rows[i].Cells[2].Value = reader.GetString(2);
                    }
                    if (!reader.IsDBNull(3))
                    {
                        dataGridViewListe.Rows[i].Cells[3].Value = reader.GetString(3);
                    }
                    if (!reader.IsDBNull(4))
                    {
                        dataGridViewListe.Rows[i].Cells[4].Value = reader.GetString(4);
                    }
                    if (!reader.IsDBNull(5))
                    {
                        dataGridViewListe.Rows[i].Cells[5].Value = reader.GetString(5);
                    }
                    if (!reader.IsDBNull(6))
                    {
                        dataGridViewListe.Rows[i].Cells[6].Value = reader.GetString(6);
                    }
                    i++;
                }
                reader.Close();
                mySqlConnection1.Close();
            }
            catch
            {
                Console.WriteLine("Listeleme Esnasında Hata !");
                MessageBox.Show("Listeleme Esnasında Hata !");
            }
        }
        private void buttonKisiListele_Click(object sender, EventArgs e)
        {
            dataGridViewListe.Columns[4].Visible = true;
            dataGridViewListe.Columns[6].Visible = true;
            dataGridViewListe.Columns[5].Visible = true;
            Listele("Hepsi");
        }

        private void buttonOgrenciListele_Click(object sender, EventArgs e)
        {
            dataGridViewListe.Columns[4].Visible = false;
            dataGridViewListe.Columns[5].Visible = true;
            dataGridViewListe.Columns[6].Visible = false;
            Listele("Çalışan");
        }

        private void buttonCalisanlariListele_Click(object sender, EventArgs e)
        {
            dataGridViewListe.Columns[4].Visible = false;
            dataGridViewListe.Columns[5].Visible = false;
            dataGridViewListe.Columns[6].Visible = true;
            Listele("Öğrenci");
        }

        private void dataGridViewListe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int lastRow = dataGridViewListe.Rows.Count - 1;
            if (e.ColumnIndex == 7 && e.RowIndex != lastRow)
            {
                //update işlemi
                string unvan = dataGridViewListe.CurrentRow.Cells[4].Value.ToString();
                if (unvan == "Çalışan")
                {
                    buttonCalisanPanelOpen.PerformClick();
                    labelidKisiStr.Text = dataGridViewListe.CurrentRow.Cells[0].Value.ToString();
                    textBoxCalisanAd.Text = dataGridViewListe.CurrentRow.Cells[1].Value.ToString();
                    textBoxCalisanSoyAd.Text = dataGridViewListe.CurrentRow.Cells[2].Value.ToString();
                    textBoxCalisanTel.Text = dataGridViewListe.CurrentRow.Cells[3].Value.ToString();
                    textBoxCalisanKurum.Text = dataGridViewListe.CurrentRow.Cells[6].Value.ToString();
                    buttonCalisanEkle.Visible = false;
                    buttonCalisanGuncelle.Visible = true;

                }
                if (unvan == "Öğrenci")
                {
                    buttonOgrenciPanelOpen.PerformClick();
                    labelidKisiStr.Text = dataGridViewListe.CurrentRow.Cells[0].Value.ToString();
                    textBoxOgrenciAd.Text = dataGridViewListe.CurrentRow.Cells[1].Value.ToString();
                    textBoxOgrenciSoyAd.Text = dataGridViewListe.CurrentRow.Cells[2].Value.ToString();
                    textBoxOgrenciTel.Text = dataGridViewListe.CurrentRow.Cells[3].Value.ToString();
                    textBoxOgrenciSinif.Text = dataGridViewListe.CurrentRow.Cells[5].Value.ToString();
                    buttonOgrenciEkle.Visible = false;
                    buttonOgrenciGuncelle.Visible = true;
                }
                MessageBox.Show("Kişi Ekle Paneli üzerinden güncelleme yapabilirsiniz");
            }
            if (e.ColumnIndex == 8 && e.RowIndex != lastRow)
            {
                // delete işlemi
                string ad= dataGridViewListe.CurrentRow.Cells[1].Value.ToString();
                DialogResult dialogResult= MessageBox.Show(ad+" kişini silmek isteniğinizden eminmisiniz?","Onay", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    //update ekranı açık, bug olmaması için update ekranını kapatıyoruz.
                    buttonOgrenciPanelOpen.PerformClick();
                    int id = Int32.Parse(dataGridViewListe.CurrentRow.Cells[0].Value.ToString());
                    deleteKisi(id);
                    if (dataGridViewListe.CurrentRow.Cells[4].Visible == true)
                    {
                        //kullanıcı kişiler ekranınıdadır ve o ekranı yenile
                        buttonKisiListele.PerformClick();
                    }
                    else
                    {
                        if (dataGridViewListe.CurrentRow.Cells[4].Value.ToString() == "Öğrenci")
                        {
                            buttonOgrenciListele.PerformClick();
                        }
                        if (dataGridViewListe.CurrentRow.Cells[4].Value.ToString() == "Çalışan")
                        {
                            buttonCalisanlariListele.PerformClick();
                        }
                    }
                }
                else
                {
                    return;
                }             

            }


        }

        private void buttonCalisanGuncelle_Click(object sender, EventArgs e)
        {
            string ad = textBoxCalisanAd.Text;
            string soyAd = textBoxCalisanSoyAd.Text;
            string tel = textBoxCalisanTel.Text;
            string kurum = textBoxCalisanKurum.Text;
            int id = Int32.Parse(labelidKisiStr.Text.ToString());
            try
            {
                mySqlConnection1.Open();
                MySqlCommand command = mySqlConnection1.CreateCommand();
                command.CommandText = "UPDATE `kisi` SET `ad_kisi` = @ad, `soy_ad_kisi` = @soyAd, `tel_kisi` = @tel, `kurum_kisi` = @kurum WHERE (`id_kisi` = @id);";
                command.Parameters.AddWithValue("@ad", ad);
                command.Parameters.AddWithValue("@soyAd", soyAd);
                command.Parameters.AddWithValue("@tel", tel);
                command.Parameters.AddWithValue("@kurum", kurum);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
                mySqlConnection1.Close();
                buttonCalisanlariListele.PerformClick();
                MessageBox.Show("Çalışan Başarıyla Güncellendi");
            }
            catch
            {
                Console.WriteLine("Calisan Güncelle Hata");
                MessageBox.Show("Çalışan Güncellenirken Bir Hata Oluştu");
            }
        }

        private void buttonOgrenciGuncelle_Click(object sender, EventArgs e)
        {
            string ad = textBoxOgrenciAd.Text;
            string soyAd = textBoxOgrenciSoyAd.Text;
            string tel = textBoxOgrenciTel.Text;
            string sinif = textBoxOgrenciSinif.Text;
            int id = Int32.Parse(labelidKisiStr.Text.ToString());
            try
            {
                mySqlConnection1.Open();
                MySqlCommand command = mySqlConnection1.CreateCommand();
                command.CommandText = "UPDATE `kisi` SET `ad_kisi` = @ad, `soy_ad_kisi` = @soyAd, `tel_kisi` = @tel, `sinif_kisi` = @sinif WHERE (`id_kisi` = @id);";
                command.Parameters.AddWithValue("@ad", ad);
                command.Parameters.AddWithValue("@soyAd", soyAd);
                command.Parameters.AddWithValue("@tel", tel);
                command.Parameters.AddWithValue("@sinif", sinif);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
                mySqlConnection1.Close();
                buttonOgrenciListele.PerformClick();
                MessageBox.Show("Öğrenci Başarıyla Güncellendi");
            }
            catch
            {
                Console.WriteLine("Öğrenci Güncelle Hata");
                MessageBox.Show("Öğrenci Güncellenirken Bir Hata Oluştu");
            }
        }
        private void deleteKisi(int id)
        {
            try
            {
                mySqlConnection1.Open();
                MySqlCommand command = mySqlConnection1.CreateCommand();
                command.CommandText = "DELETE FROM `kisi` WHERE (`id_kisi` = @id);";
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
                mySqlConnection1.Close();
            }
            catch
            {
                Console.WriteLine("Kişi Silinirken Hata");
                MessageBox.Show("Kişi Silinirken Bir Hata Oluştu");
            }
        }
    }
}
