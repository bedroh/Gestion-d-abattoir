﻿using System;
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
    public partial class Modifier_Fournisseur : Form
    {
        public Modifier_Fournisseur(String id  , string nom , string adress , string num)
        {
            InitializeComponent();
            Idf.Text = id;
            bunifuTextBox1.Text = nom;
            bunifuTextBox2.Text = num;
            bunifuTextBox3.Text = adress;

        }

        private void bunifuPanel2_Click(object sender, EventArgs e)
        {

        }

        private void Modifier_Fournisseur_Load(object sender, EventArgs e)
        {

        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            if (bunifuTextBox1.Text == "" || bunifuTextBox2.Text == "" || bunifuTextBox3.Text == "")
            {
                MessageBox.Show("Esseyer remplir toutes les zones.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else
            {
                Datafournissuers.Modifier_fournissuer(bunifuTextBox1.Text, bunifuTextBox3.Text, bunifuTextBox2.Text , int.Parse(Idf.Text));
                MessageBox.Show("Fournisseurs modifier avec succes", "Modifier avec succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
