using System;
using System.Data;
using System.Windows.Forms;

namespace shopApp
{
    public partial class Cart : Form
    {
        BDConnexion bd;
        public Dashboard dsh;
        public Cart(Dashboard dsh)
        {
            InitializeComponent();
            bd = new BDConnexion();
            NetToBy();
            this.dsh = dsh;
        }

        // Liste de tout les commandes
        public void LoadCommandes()
        {
            dgrCart.DataSource = bd.RecupererInformations("select idCmd as ID, us.nom AS Client, p.nomProduit as Produit, cmd.qty AS Quantité, (cmd.qty * p.prix) AS PRIXHT from commande AS cmd " +
                "INNER JOIN produit as p on p.idproduit = cmd.idproduit " +
                "INNER JOIN stock as st on st.idstock = p.idstock " +
                "INNER JOIN utilisateur as us on cmd.idclient = us.iduser and us.iduser = "+dsh.lblId.Text);
        }

        // Total à payer
        public void NetToBy()
        {
            double price = 0;

            if (dgrCart.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgrCart.Rows) price += double.Parse(row.Cells[4].Value.ToString());
                Tprix.Text = price.ToString() + " " + "";
            }
        }

        private void numCompte_TextChanged(object sender, EventArgs e)
        {
            try
            {
                bd.cn.Open();
                bd.cmd.CommandText = "select idCompte from CompteBancaire as cpB " +
                "INNER JOIN utilisateur as us on us.iduser = cpB.idusr where cpB.numCompte = " + numCompte.Text;
                bd.dr = bd.cmd.ExecuteReader();

                if (bd.dr.HasRows)
                    while (bd.dr.Read()) IDCompteB.Text = bd.dr["idCompte"].ToString();

                else IDCompteB.Text = "ID";
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                bd.cn.Close();
            }

            
        }
    }
}
