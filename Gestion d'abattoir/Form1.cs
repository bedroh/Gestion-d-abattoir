using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_d_abattoir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuButton23_Click(object sender, EventArgs e)
        {
            liste_Des_Fournisseures1.Show();
            liste_Des_Fournisseures1.BringToFront();
        }

        private void bunifuButton24_Click(object sender, EventArgs e)
        {
            liste_Des_Clients1.Show();
            liste_Des_Clients1.BringToFront();
        }
    }
}
