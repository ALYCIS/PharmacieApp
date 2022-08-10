using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacieApp
{
    public partial class FenetreDeProgression : Form
    {
        public FenetreDeProgression()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        int pdd = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            pdd++;
            BarDeProgression.Value = pdd;
            labelPourcentage.Text = pdd + "%";
            if(BarDeProgression.Value ==100)
            {
                BarDeProgression.Value = 0;
                timer1.Stop();
                Connection MaFenetreCon = new Connection();
                MaFenetreCon.Show();
                this.Hide();
            }
        }

        private void FenetreDeProgression_Load(object sender, EventArgs e)
        {
            timer1.Start(); // Lancement du timer dès au debut
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
