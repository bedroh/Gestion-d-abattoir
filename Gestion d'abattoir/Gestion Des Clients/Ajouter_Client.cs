using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_d_abattoir.Gestion_Des_Clients
{
    public partial class Ajouter_Client : Form
    {
        public Ajouter_Client()
        {
            InitializeComponent();
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            if (bunifuTextBox1.Text == "" || bunifuTextBox2.Text == "" || bunifuTextBox5.Text == "" || bunifuTextBox6.Text == "")
            {
                MessageBox.Show("Esseyer remplir toutes les zones.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else
            {
                Dataclients.Ajouter_Client(bunifuTextBox1.Text ,bunifuTextBox4.Text , bunifuTextBox3.Text ,bunifuTextBox6.Text , bunifuTextBox2.Text , bunifuTextBox5.Text );      
                MessageBox.Show("Client ajouter avec succes", "Ajouter avec succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
        }
    }
}
