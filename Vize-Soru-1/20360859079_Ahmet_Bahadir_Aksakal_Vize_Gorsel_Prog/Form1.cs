using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20360859079_Ahmet_Bahadir_Aksakal_Vize_Gorsel_Prog
{
    public partial class Form1 : Form
    {
        private int setSaat=0;
        private int setDk=0;
        private bool setPmAm=true;
        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            Thread saatTH = new Thread(saat);
            saatTH.Start();
            //not alarm 1 dk süresince caliyor
            


        }
        private void saat()
        {
            
            int saniye=00;
            int dk=00;
            int saat=12;
            bool setPmAmCheck=true;
            int flagX = 0;
            if (dk >= 10)
            {
                label3.Text = Convert.ToString(dk);
            }
            if (dk < 10)
            {
                label3.Text = "0" + Convert.ToString(dk);
            }
            if (saat >= 10)
            {
                label1.Text = Convert.ToString(saat);
            }
            if (saat < 10)
            {
                label1.Text = "0" + Convert.ToString(saat);
            }
            label5.Text=Convert.ToString(saniye);
            while (true)
            {
                //Console.WriteLine("saat:"+setSaat+" --- "+saat);
                //Console.WriteLine("dk:" + setDk + " --- " + dk);
                //Console.WriteLine("pm-true:" + setPmAm + " --- " + setPmAmCheck);
                //Console.WriteLine("mod 0:" + (saniye%2) + " --- 0" );
                if (setPmAm == setPmAmCheck && setSaat == saat && setDk == dk && saniye % 2 == 0)
                {
                    groupBox1.BackColor = Color.White;
                    groupBox1.ForeColor = Color.Red;
                }
                else
                {
                    groupBox1.BackColor = Color.Gray;
                    groupBox1.ForeColor = Color.White;
                }

                Thread.Sleep(1000);    

                saniye++;
                if (saniye >= 10)
                {
                    label5.Text =Convert.ToString(saniye);
                }
                if(saniye < 10)
                {
                    label5.Text ="0"+Convert.ToString(saniye);
                }               
                if (saniye == 60)
                {
                    saniye = 0;
                    label5.Text = "0" + Convert.ToString(saniye);
                    dk++;
                    if (dk >= 10)
                    {
                        label3.Text = Convert.ToString(dk);
                    }
                    if (dk < 10)
                    {
                        label3.Text = "0" + Convert.ToString(dk);
                    }

                }
                if (dk == 60)
                {
                    dk = 0;
                    label3.Text = "0" + Convert.ToString(dk);
                    saat++;
                    if (saat >= 10)
                    {
                        label1.Text = Convert.ToString(saat);
                    }
                    if (saat < 10)
                    {
                        label1.Text = "0" + Convert.ToString(saat);
                    }

                }
                if (saat > 12)
                {
                    saat = 1;
                    label1.Text = "0" + Convert.ToString(saat);
                    //Console.WriteLine("pm-true:" + label6.Text + " --- " + setPmAmCheck);
                    if (setPmAmCheck == false &&flagX==0)
                    {
                        //Console.WriteLine("girdi2");
                        label6.Text = "pm";
                        setPmAmCheck = true;
                        flagX = 1;
                    }
                    if (setPmAmCheck==true && flagX == 0)
                    {
                      //  Console.WriteLine("girdi1");
                        label6.Text = "am";
                        setPmAmCheck = false;
                        flagX = 1;
                    }
                    
                    //Console.WriteLine("pm-true:" + label6.Text + " --- " +setPmAmCheck);
                }
                flagX = 0;


            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            setSaat=Int32.Parse(textBox1.Text);
            setDk=Int32.Parse(textBox2.Text);
            setPmAm = radioButton1.Checked;            
            
        }
    }
}
