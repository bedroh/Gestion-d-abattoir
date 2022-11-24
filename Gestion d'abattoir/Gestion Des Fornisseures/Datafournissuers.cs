﻿using Bunifu.UI.WinForms;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_d_abattoir.Gestion_Des_Fornisseures
{
    class Datafournissuers
    {
        public static void Ajouter_Fournisseur(String nomfournisseur, string adress, string numtele )
        {
            try
            {
                Connexion.conn.Open();
                SqlCommand sql = new SqlCommand("insert into Fournisseurs ( nomfournisseur , adress , numtele  ) values ('" + nomfournisseur + "' ,  '" + adress + "' , '" + numtele + "' );", Connexion.conn);
                sql.ExecuteNonQuery();
                Connexion.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connexion.conn.Close();
            }
        }
        public static void Modifier_fournissuer(String nomfournisseur, string adress, string numtele, int id)
        {
            try
            {
                Connexion.conn.Open();
                SqlCommand sql = new SqlCommand("update  Fournisseurs Set nomfournisseur='" + nomfournisseur + "' , adress ='" + adress + "' , numtele ='" + numtele + "' where idfournisseur='" + id + "' ;", Connexion.conn);
                sql.ExecuteNonQuery();
                Connexion.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connexion.conn.Close();
            }
        }
        public static void List_des_fournissuer(BunifuDataGridView bunifuDataGridView, String txt)
        {
            try
            {
                Connexion.conn.Open();
                SqlCommand sql = new SqlCommand("Select * from Fournisseurs  ;", Connexion.conn);
                SqlDataReader dr = sql.ExecuteReader();
                bunifuDataGridView.Rows.Clear();
                while (dr.Read())
                {
                    bunifuDataGridView.Rows.Add(dr[0], dr[1], dr[2] , dr[3]);

                }
                Connexion.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connexion.conn.Close();
            }
        }
        public static void Supprimer_fournissuer(int id)
        {
            try
            {
                Connexion.conn.Open();
                SqlCommand sql = new SqlCommand("delete from Fournisseurs where idfournisseur ='" + id + "' ;", Connexion.conn);
                sql.ExecuteNonQuery();
                Connexion.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connexion.conn.Close();
            }
        }
    }
}
