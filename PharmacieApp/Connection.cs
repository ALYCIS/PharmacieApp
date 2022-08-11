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
    public partial class Connection : Form
    {
        public Connection()
        {
            InitializeComponent();
        }

        private void LienVendeurlabelC_Click(object sender, EventArgs e)
        {
            Employers E = new Employers();
            E.Show();
            this.Hide();
        }
    }
}
