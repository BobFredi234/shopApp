using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace shopApp
{
    public class BDConnexion
    {
        public SqlConnection cn;
        public SqlCommand cmd;
        public DataTable table;
        public SqlDataAdapter adapter;
        public SqlDataReader dr;
        private readonly String cnString;

        /// <summary>
        ///     Constructeur
        /// </summary>
        public BDConnexion()
        { 
            cnString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Bobi\\OneDrive\\Documents\\DBMarket.mdf;Integrated Security=True;Connect Timeout=30";
            cn = new SqlConnection(cnString); // connection à la base de données
            cmd = new SqlCommand(); // nouvelle instance pour une commande sql
            cmd.Connection = cn; // affection de con à l'attribut Connection de SqlCommand
            table = new DataTable();
        }

        // fonction pour requête
        public int EnvoyerRequete(string query)
        {
            int test = -1;
            try
            {
                cn.Open(); //Ouverture d'une nouvelle connexion
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                test = 0;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error Sql", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
            finally
            {
                cn.Close();
            }

            return test;
        }

        // fonction pour recuperer une table
        public DataTable RecupererInformations(string query)
        {
            try
            {
                if (cn.State.ToString() == "Close")
                {
                    cn.Open();
                }
                adapter = new SqlDataAdapter(query, cnString);
                table.Clear();
                adapter.Fill(table);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error Sql", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
            finally
            {
                cn.Close();
            }

            return table;
        }
    }
}
