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
    public partial class Liste_Des_Fournisseures : UserControl
    {
        public Liste_Des_Fournisseures()
        {
            InitializeComponent();
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            Ajouter_Fournisseur ajtF = new Ajouter_Fournisseur();
            ajtF.ShowDialog();
            bunifuButton22.PerformClick();
        }

        private void bunifuButton22_Click(object sender, EventArgs e)
        {
            Datafournissuers.List_des_fournissuer(bunifuDataGridView1 , bunifuTextBox1.Text);
        }

        private void Liste_Des_Fournisseures_Load(object sender, EventArgs e)
        {
            Datafournissuers.List_des_fournissuer(bunifuDataGridView1, bunifuTextBox1.Text);
        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {
            bunifuButton22.PerformClick();
        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = bunifuDataGridView1.Rows[e.RowIndex].Index;
                String colname = bunifuDataGridView1.Columns[e.ColumnIndex].Name;
                String id = bunifuDataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                String nom = bunifuDataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                String adress = bunifuDataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                String numtele = bunifuDataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
          


                if (colname == "mod")
                {


                    Modifier_Fournisseur modifier_Fournisseur = new Modifier_Fournisseur(id, nom, adress, numtele);
                    modifier_Fournisseur.ShowDialog();

                }
                if (colname == "supp")
                {
                    DialogResult dialog = MessageBox.Show("Vous etes sur ?", "Supprimer un client", MessageBoxButtons.YesNo);
                    if (dialog == DialogResult.Yes)
                    {
                        Datafournissuers.Supprimer_fournissuer(int.Parse(id));
                    }


                }
                bunifuButton22.PerformClick();
                bunifuDataGridView1.Rows[index].Selected = true;

            }
            catch
            {

            }
        }
    }
}
