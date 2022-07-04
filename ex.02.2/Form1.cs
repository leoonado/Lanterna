using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex._02._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                this.BackgroundImage = Image.FromFile("desligada.png");
                btnLigarDesligar.Text = "Desligada";
                btnLigarDesligar.ForeColor = Color.White;
                btnLigarDesligar.BackColor = Color.Red;
        }



        private void btnLigarDesligar_Click_1(object sender, EventArgs e)
        {
            String LigaDesliga = btnLigarDesligar.Text;
            Lanterna l = new Lanterna(LigaDesliga);

            if (l.getLigar() == "Desligada" & this.duration > 0)
            {
                l.setLigar("Ligada");
                this.BackgroundImage = Image.FromFile("acessa.png");
                btnLigarDesligar.BackColor = Color.Green;
                btnLigarDesligar.ForeColor = Color.White;
                timer1 = new System.Windows.Forms.Timer();
                timer1.Tick += new EventHandler(count_down);
                timer1.Interval = 1000;
                timer1.Start();


            }
            else
            {
                l.setLigar("Desligada");
                this.BackgroundImage = Image.FromFile("desligada.png");
                btnLigarDesligar.ForeColor = Color.White;
                btnLigarDesligar.BackColor = Color.Red;
                timer1.Stop();
                if (this.duration == 0)
                {
                    MessageBox.Show("Por favor trocar a bateria!");
                }

            }

            
            btnLigarDesligar.Text = l.getLigar();
       

        }
        private int duration = 10;
        private void btnTrocarBateria_Click(object sender, EventArgs e)
        {
            Bateria B = new Bateria(100);
            this.duration = B.getCarga();
            label1.Text = duration.ToString() + "%";
        }



        private void count_down(object sender, EventArgs e)
        {
        

            if (duration == 0)
            {
                String LigaDesliga = btnLigarDesligar.Text;
                Lanterna l = new Lanterna(LigaDesliga);
                l.setLigar("Desligada");
                this.BackgroundImage = Image.FromFile("desligada.png");
                btnLigarDesligar.ForeColor = Color.White;
                btnLigarDesligar.BackColor = Color.Red;
                btnLigarDesligar.Text = l.getLigar();
                timer1.Stop();
            }
            else if (duration > 0)
            {
                duration--;
                label1.Text = duration.ToString() + "%";
            }
        }


    }
}