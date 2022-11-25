using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_d_abattoir.Gestion_Des_Fornisseures
{
    public partial class Ajouter_Fournisseur : Form
    {
        public Ajouter_Fournisseur()
        {
            InitializeComponent();
        }

        private void Ajouter_Fournisseur_Load(object sender, EventArgs e)
        {

        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            if (bunifuTextBox1.Text == "" || bunifuTextBox2.Text == "" || bunifuTextBox3.Text =="")
            {
                MessageBox.Show("Esseyer remplir toutes les zones.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else
            {
                Datafournissuers.Ajouter_Fournisseur(bunifuTextBox1.Text , bunifuTextBox3.Text, bunifuTextBox2.Text);
                MessageBox.Show("Fournisseurs ajouter avec succes", "Ajouter avec succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
        }
    }
}
