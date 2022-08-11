using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PharmacieApp
{
    public partial class Employers : Form
    {
        private readonly SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\CISSE\Documents\MaPharmacie.mdf;Integrated Security=True;Connect Timeout=30");
        public Employers()
        {
            InitializeComponent();
        }
        
        private void AjouterbuttonE_MouseHover(object sender, EventArgs e)
        {
            AjouterbuttonE.BackColor = Color.Blue;
        }

        private void AjouterbuttonE_MouseLeave(object sender, EventArgs e)
        {
            AjouterbuttonE.BackColor = Color.Crimson;
        }

        private void ImageCloseCheckBoxE_CheckedChanged(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AjouterbuttonE_Click(object sender, EventArgs e)
        {

        }
    }
}
