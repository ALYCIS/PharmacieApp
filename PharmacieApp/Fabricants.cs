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
        private SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\CISSE\Documents\MaPharmacie.mdf;Integrated Security=True;Connect Timeout=30");
        private int  Cle = 0;
        public Fabricants()
        {
            InitializeComponent();
            AfficherBD();
        }
        private void buttonAjouterF_Click(object sender, EventArgs e)
        {
            if(NomTextBoxF.Text == "" || AdresseTextBox.Text =="" || DescriptionTextBoxF.Text=="" || TelTextBoxF.Text =="")
            {
                MessageBox.Show("Completez les informations s'il vous plaît!");
            }
            else
            {
                try
                {
                    Con.Open();
                    string actionReq = '\''+NomTextBoxF.Text+ '\''+ ',' + '\''+AdresseTextBox.Text + '\''+',' + '\''+DescriptionTextBoxF.Text+ '\''+',' + '\''+ TelTextBoxF.Text+ '\'';
                    /*string Req = "insert into FabricantTbl values('" + NomTextBox.Text +
                        "','" + AdresseTextBox.Text + "','" + DescriptionTextBoxF.Text + "','" + TelTextBoxF.Text + "')";*/
                    string Req = $"insert into FabricantTbl values({actionReq})";
                    MessageBox.Show(Req);
                    SqlCommand cmd = new SqlCommand(Req, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Fabricant Ajouté avec Succès!");
                    Con.Close();
                    AfficherBD();
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
            Reinitialisation();
        }

        private void Reinitialisation()
        {
            NomTextBoxF.Clear();
            AdresseTextBox.Clear();
            DescriptionTextBoxF.Clear();
            TelTextBoxF.Clear();
            Cle = 0;
        }

        private void AfficherBD()
        {
            Con.Open();
            string Req = $"select * from FabricantTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Req, Con);
            SqlCommandBuilder build = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ListeFabricantDataGridViewF.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void ListeFabricantDataGridViewF_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NomTextBoxF.Text = ListeFabricantDataGridViewF.SelectedRows[0].Cells[1].Value.ToString();
            AdresseTextBox.Text = ListeFabricantDataGridViewF.SelectedRows[0].Cells[2].Value.ToString();
            DescriptionTextBoxF.Text = ListeFabricantDataGridViewF.SelectedRows[0].Cells[3].Value.ToString();
            TelTextBoxF.Text = ListeFabricantDataGridViewF.SelectedRows[0].Cells[4].Value.ToString();

            if (NomTextBoxF.Text == "")
                Cle = 0;
            else
                Cle = Convert.ToInt32(ListeFabricantDataGridViewF.SelectedRows[0].Cells[0].Value.ToString());
        }

        private void buttonSupprimerF_Click(object sender, EventArgs e)
        {

        }

        private void buttonModifierF_Click(object sender, EventArgs e)
        {

        }
    }
}
