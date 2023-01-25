using System;
using System.Data;
using System.Media;
using System.Windows.Forms;

namespace shopApp
{
    public partial class Dashboard : Form
    {
        BDConnexion bd;

        public Dashboard()
        {
            InitializeComponent();
            bd = new BDConnexion();
        }


        #region Fonctions
        private Form activeForm = null; // Formulaire actif
        
        // ouvre un formulaire enfant
        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            lblTitle.Text = childForm.Text;
            panelContainer.Controls.Add(childForm);
            panelContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        // Affiche un sous Menu ou Menu
        private void showSubMenu(Panel subMenu) 
        {
            if (subMenu.Visible == false)
            {
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        // Toutes les commandes de l'utilisateur
        public void LoadCommandes()
        {
            bd.RecupererInformations("select * from Commande where idClient = " + lblId.Text);

            if (bd.table.Rows.Count > 0)
                lblQuantity.Text = bd.table.Rows.Count.ToString();
        }
        #endregion

        #region Evènements
        // évènement de click sur le bouton btnDashboard
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            DataTable tb = new DataTable();
            
            tb = bd.RecupererInformations("select * from utilisateur where idUser = " + lblId.Text);
           
            GestionInfos infos = new GestionInfos(this);
            DataTableReader dtr = new DataTableReader(tb);

            if (dtr.HasRows)
            {
                while (dtr.Read())
                {
                    infos.txtName.Text = dtr["nom"].ToString();
                    infos.txtEmail.Text = dtr["email"].ToString();
                    if (dtr["sexe"].ToString().Equals("F"))
                    {
                        infos.rdMal.Enabled = false;
                        infos.rdFemal.Checked = true;
                    }
                    else
                    {
                        infos.rdFemal.Enabled = false;
                        infos.rdMal.Checked = true;
                    }
                    infos.txtAdresse.Text = dtr["adresse"].ToString();
                    infos.txtPrenom.Text = dtr["prenom"].ToString();
                    infos.dtDateNaissance.Text = dtr["dateNaissance"].ToString();
                    infos.txtPhone.Text = dtr["phone"].ToString();
                    infos.lblID.Text = dtr["IdUser"].ToString();
                    infos.cbStatut.Items.Clear();
                    infos.cbStatut.Text = dtr["statut"].ToString();
                    infos.cbStatut.Items.Add(infos.cbStatut.Text);
                    infos.dtDateCreation.Text = dtr["date_creation"].ToString();
                    infos.dtDateUpdate.Text = dtr["date_update"].ToString();
                    infos.txtUsername.Text = dtr["username"].ToString();
                    infos.txtPassword.Text = dtr["password"].ToString();

                }

                DataTable tb1 = new DataTable();
                tb1 = bd.RecupererInformations("select * from CompteBancaire as cmpB INNER JOIN utilisateur as us ON cmpB.idUsr = us.idUser and us.idUser = " + lblId.Text);
                DataTableReader dtr1 = new DataTableReader(tb1);
                if (dtr1.HasRows)
                {
                    while (dtr1.Read())
                    {
                        infos.txtAuteur.Text = dtr1["nom"].ToString();
                        infos.cbNumCompte.Items.Add(dtr1["numCompte"]);
                        infos.txtSoldeBank.Text = dtr1["solde"].ToString();
                        infos.txtSoldeBank.Text = infos.txtSoldeBank.Text.Replace(',', '.');
                        infos.txtDevise.Text = dtr1["devise"].ToString();
                        infos.dateCreationAcccountBank.Value = DateTime.Parse(dtr1["date_creation"].ToString());
                        infos.dtUpdateAccountBank.Value = DateTime.Parse(dtr1["date_creation"].ToString());
                        infos.IDUserAcc.Text = lblId.Text;
                    }
                }
                else
                {
                    infos.IDUserAcc.Text = lblId.Text;
                    infos.txtAuteur.Text = infos.txtName.Text;
                }
                infos.btnCreateAcc.Enabled = true;
            }
            openChildForm(infos);
        }

        // évènement de click sur le bouton btnProduct
        private void btnProduct_Click(object sender, EventArgs e)
        {
            openChildForm(new GestionProduit());
        }

        // évènement de click sur le bouton btnUser
        private void btnUser_Click(object sender, EventArgs e)
        {
            openChildForm(new GestionUtilisateur());
        }

        // évènement de click sur le bouton btnMenu
        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (PanelMenu.Visible == true)
            {
                PanelMenu.Hide();
            }
            else
                PanelMenu.Show();
        }

        // évènement de click sur le bouton btnDeconnexion
        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment vous déconnectez ?", "Déconnexion", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Dispose();
                Home home = new Home();
                home.Show();
            }
        }

        // évènement de click sur le bouton btnDeconnexion
        private void btnAccount_Click(object sender, EventArgs e)
        {
            openChildForm(new GestionCompteBancaire());
        }

        // évènement de click sur le bouton btnShop
        private void btnShop_Click(object sender, EventArgs e)
        {
            openChildForm(new Boutique(this));
        }

        // évènement de click sur le bouton btnOrder
        private void btnOrder_Click(object sender, EventArgs e)
        {
            openChildForm(new GestionCommandes());
        }

        // évènement de click sur le bouton btnCategories
        private void btnCategories_Click(object sender, EventArgs e)
        {
            openChildForm(new GestionCategories());
        }

        // évènement de click sur le bouton btnBarCodes
        private void btnBarCodes_Click(object sender, EventArgs e)
        {
            openChildForm(new GestionCodeBares());
        }

        // Boutique
        private void cart_click(object sender, EventArgs e)
        {
            Cart c = new Cart(this);
            c.LoadCommandes();
            openChildForm(c);
        }
        #endregion


    }
}
