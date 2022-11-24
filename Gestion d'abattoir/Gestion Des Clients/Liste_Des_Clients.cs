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
    public partial class Liste_Des_Clients : UserControl
    {
        public Liste_Des_Clients()
        {
            InitializeComponent();
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            Ajouter_Client ajtc = new Ajouter_Client();
            ajtc.ShowDialog();
        }
            
    }
}
