using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacieApp
{
    public partial class Fabricants : Form
    {
        public Fabricants()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\CISSE\Documents\MaPharmacie.mdf;Integrated Security=True;Connect Timeout=30");
        private void buttonAjouterF_Click(object sender, EventArgs e)
        {
            if(NomTextBox.Text == "" || AdresseTextBox.Text =="" || DescriptionTextBoxF.Text=="" || TelTextBoxF.Text =="")
            {
                MessageBox.Show("Completez les informations s'il vous plaît!");
            }
            else
            {
                try
                {
                    Con.Open();
                    string actionReq = '\''+NomTextBox.Text+ '\''+ ',' + '\''+AdresseTextBox.Text + '\''+',' + '\''+DescriptionTextBoxF.Text+ '\''+',' + '\''+ TelTextBoxF.Text+ '\'';
                    /*string Req = "insert into FabricantTbl values('" + NomTextBox.Text +
                        "','" + AdresseTextBox.Text + "','" + DescriptionTextBoxF.Text + "','" + TelTextBoxF.Text + "')";*/
                    string Req = $"insert into FabricantTbl values({actionReq})";
                    MessageBox.Show(Req);
                    SqlCommand cmd = new SqlCommand(Req, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Fabricant Ajouté avec Succès!");
                    Con.Close();
                    Reinitialisation();
                     

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }       
            }
        }

        private void FermerCheckBoxF_CheckedChanged(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonReinitF_Click(object s, EventArgs e)
        {
            NomTextBox.Text = "";
                
            AdresseTextBox.Text= "";
            DescriptionTextBoxF.Text="";
            TelTextBoxF.Text="";
        }

        private void Reinitialisation()
        {
            NomTextBox.Clear();
            AdresseTextBox.Clear();
            DescriptionTextBoxF.Clear();
            TelTextBoxF.Clear();
        }

        private void ListeFabricantDataGridViewF_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
