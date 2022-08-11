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
        private void FenetreDeProgression_Load(object sender, EventArgs e)
        {
            Timer1.Start(); // Lancement du timer dès au debut
        }

        int pdd = 0;
        private void Timer1_Tick_1(object sender, EventArgs e)
        {
            pdd++;
            BarDeProgression.Value = pdd;
            labelPourcentage.Text = pdd + "%";
            if (BarDeProgression.Value == 100)
            {
                BarDeProgression.Value = 0;
                Timer1.Stop();
                Connection MaFenetreCon = new Connection();
                MaFenetreCon.Show();
                this.Hide();
            }
        }
    }
}
