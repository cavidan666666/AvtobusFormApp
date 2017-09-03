using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvtobusForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Avtobus avtobusum;

        private void button1_Click(object sender, EventArgs e)
        {
            //kodlarimizi try ctch icinde yaziriqki hemin kodda error varsa gostersin
            try
            {
                //Butona klik olanda avtobus istfide olunacaqi ucun bir obyekt yaradiriq xetkodunu ve umumi yerlerin sayini icine yaziriq
                avtobusum = new Avtobus(textBox1.Text, Convert.ToInt16(textBox2.Text));
                label3.Text = "Avtobu dayandi get Min";
                panel2.Enabled = true;

               
            }
            catch 
            {
                MessageBox.Show("Burda sef var Qaqa1!!");
                label3.Text = "Avtobus Heleki Hazir Deyil";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label3.Text = "Tam Bilet Kesildi";
            avtobusum.sernisinMindir(true);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            avtobusum.sernisinMindir(false);
            label3.Text = "Telebe Bileti Kesildi";

          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            avtobusum.sernisinDusurd();
            label3.Text = "Bir Sernisin Dusdu";

        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Text = "Sizin Balans = " + avtobusum.balansiGoster().ToString() + "AZN";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = "Bos Yerleirn Sayi = " + avtobusum.bosYerlerinSayiniGoster().ToString();



            if (avtobusum.bosYerlerinSayiniGoster() < 0)
            {
                label3.Text = "Bos Yer Qalmadi Qaqa";
            }
            else
            {
                label3.Text = avtobusum.bosYerlerinSayiniGoster() +  "Bos Yer Var";
            }
        }
    }
}
