using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ahmet_Bahadir_Aksakal_GorselProgramlamaFinalSoru2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //dosya yolu seçme
            string dosyaYolu = "";

            //açılan streamlerin oto kapanmasi için using kullandım
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                DialogResult secim = folderBrowserDialog.ShowDialog();
                if (secim == DialogResult.OK)
                {
                    dosyaYolu = folderBrowserDialog.SelectedPath;
                }
                else
                {
                    MessageBox.Show("Aranacak Klasörü Seçmediniz !");
                    return;
                }
            }

            // Dosya adı arama
            bool bulundu = false;
            string aranacakDosyaAdi = textBox1.Text;
            string[] dosyalar = Directory.GetFiles(dosyaYolu);
            foreach (string dosya in dosyalar)
            {
                if (dosya.Contains(aranacakDosyaAdi))
                {
                    MessageBox.Show("Dosya bulundu: " + dosya);
                    bulundu = true;
                }
            }
            if (bulundu == false)
            {
                MessageBox.Show("Dosya Bulunmadı, aradığınız dizini veya aranan dosya adını kontrol ediniz");
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
