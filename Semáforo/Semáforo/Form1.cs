using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semáforo
{
    public partial class Form1 : Form
    {

        private Semáforo sema;
        public Form1()
        {
            InitializeComponent();
            sema = new Semáforo();
            atualizarInterface();
        }


        private void atualizarInterface()
        {
            txb_Dados.Text = sema.getestado().ToString();
            txb_Dado_2.Text = Convert.ToString(sema.getestado(), 2);

            

            if (sema.getled(1))
            {
                pic_rua1.Image = Semáforo.Properties.Resources.verde; // Verde R1
            }
            else if (sema.getled(2))
            {
                pic_rua1.Image = Semáforo.Properties.Resources.amarelo; // Amarelo R1
            }
            else if (sema.getled(3))
            {
                pic_rua1.Image = Semáforo.Properties.Resources.vermelho; // Vermelho R1
            }
            else
            {
                pic_rua1.Image = Semáforo.Properties.Resources.desligado; // Nenhum LED aceso
            }
            
            if (sema.getled(6))
            {
                pic_rua2.Image = Semáforo.Properties.Resources.verde; // Verde R2
            }
            else if (sema.getled(7))
            {
                pic_rua2.Image = Semáforo.Properties.Resources.amarelo; // Amarelo R2
            }
            else if (sema.getled(8))
            {
                pic_rua2.Image = Semáforo.Properties.Resources.vermelho; // Vermelho R2
            }
            else
            {
                pic_rua2.Image = Semáforo.Properties.Resources.desligado; // Nenhum LED aceso
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Rua2Verm_Click(object sender, EventArgs e)
        {
            sema.apagar(6);
            sema.apagar(7);
            sema.ligar(8);
            atualizarInterface();
        }

        private void btn_Rua2Amar_Click(object sender, EventArgs e)
        {
            sema.apagar(6);
            sema.apagar(8);
            sema.ligar(7);
            atualizarInterface();
        }

        private void Lbl_rua2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Rua1Verd_Click(object sender, EventArgs e)
        {
            sema.apagar(3);
            sema.apagar(2);
            sema.ligar(1);
            atualizarInterface();
        }

        private void btn_Rua1Amar_Click(object sender, EventArgs e)
        {
            sema.apagar(1);
            sema.apagar(3);
            sema.ligar(2);
            atualizarInterface();
        }

        private void btn_Rua1Verm_Click(object sender, EventArgs e)
        {
            sema.apagar(2);
            sema.apagar(1);
            sema.ligar(3);
            atualizarInterface();
        }

        private void btn_Rua2Verd_Click(object sender, EventArgs e)
        {
            sema.apagar(6);
            sema.ligar(6);
            atualizarInterface();
        }
    }
}
