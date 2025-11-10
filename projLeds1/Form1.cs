using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projLeds1
{
    public partial class Form1 : Form
    {
        private Leds leds;
        public Form1()
        {
            InitializeComponent();
            leds = new Leds();
            atualizaInterface();
        }



        private void atualizaInterface()
        {
            txtDadoDec.Text = leds.getDado().ToString();
            txtDadoBin.Text = Convert.ToString(leds.getDado(), 2);
            txtDadoHex.Text = Convert.ToString(leds.getDado(), 16).ToUpper();
            btn_1.Text = (leds.getLed(1) ? "Off" : "On");
            btn_2.Text = (leds.getLed(2) ? "Off" : "On");
            btn_3.Text = (leds.getLed(3) ? "Off" : "On");
            btn_4.Text = (leds.getLed(4) ? "Off" : "On");
            btn_5.Text = (leds.getLed(5) ? "Off" : "On");
            btn_6.Text = (leds.getLed(6) ? "Off" : "On");
            btn_7.Text = (leds.getLed(7) ? "Off" : "On");
            btn_8.Text = (leds.getLed(8) ? "Off" : "On");
            pictureBox1.Image = (leds.getLed(1) ? Properties.Resources.acesa : Properties.Resources.apagada);
            pictureBox2.Image = (leds.getLed(2) ? Properties.Resources.acesa : Properties.Resources.apagada);
            pictureBox3.Image = (leds.getLed(3) ? Properties.Resources.acesa : Properties.Resources.apagada);
            pictureBox4.Image = (leds.getLed(4) ? Properties.Resources.acesa : Properties.Resources.apagada);
            pictureBox5.Image = (leds.getLed(5) ? Properties.Resources.acesa : Properties.Resources.apagada);
            pictureBox6.Image = (leds.getLed(6) ? Properties.Resources.acesa : Properties.Resources.apagada);
            pictureBox7.Image = (leds.getLed(7) ? Properties.Resources.acesa : Properties.Resources.apagada);
            pictureBox8.Image = (leds.getLed(8) ? Properties.Resources.acesa : Properties.Resources.apagada);




        }


        private void btn_1_Click(object sender, EventArgs e)
        {
            if (leds.getLed(1))
            {
                leds.apagar(1);
                pictureBox1.Image = Properties.Resources.WhatsApp_Image_2025_10_19_at_10_14_03; 
            }
            else
            {
                leds.acender(1);
                pictureBox1.Image = Properties.Resources.WhatsApp_Image_2025_10_19_at_10_14_03__1_;
            }
            atualizaInterface();
        }
        private void btn_2_Click(object sender, EventArgs e)
        {
            if (leds.getLed(2))
            {
                leds.apagar(2);
               
            }
            else
            {
                leds.acender(2);
                
            }
            atualizaInterface();
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            if (leds.getLed(3))
            {
                leds.apagar(3);
                
            }
            else
            {
                leds.acender(3);
                
            }
            atualizaInterface();
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            if (leds.getLed(4))
            {
                leds.apagar(4);
                
            }
            else
            {
                leds.acender(4);
                
            }
            atualizaInterface();
        }
        private void btn_5_Click(object sender, EventArgs e)
        {
            if (leds.getLed(5))
            {
                leds.apagar(5);
               
            }
            else
            {
                leds.acender(5);
                
            }
            atualizaInterface();
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            if (leds.getLed(6))
            {
                leds.apagar(6);
                
            }
            else
            {
                leds.acender(6);
                
            }
            atualizaInterface();
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            if (leds.getLed(7))
            {
                leds.apagar(7);
                
            }
            else
            {
                leds.acender(7);
                
            }
            atualizaInterface();
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            if (leds.getLed(8))
            {
                leds.apagar(8);
                
            }
            else
            {
                leds.acender(8);
                
            }
            atualizaInterface();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

       












    }









}
