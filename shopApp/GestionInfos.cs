using Microsoft.Office.Interop.Excel;
using System;
using System.Data;
using System.Windows.Forms;


namespace shopApp
{
    public partial class GestionInfos : Form
    {
        BDConnexion bd;
        Dashboard dsh;

        public GestionInfos(Dashboard dsh)
        {
            InitializeComponent();
            this.dsh = dsh;
            bd = new BDConnexion();

            dtDateCreation.Enabled = false;
            if (dsh.lblUsername.Text.Equals("Username"))
            {
                btnCreateUser.Visible = true; 
            }
            else
                btnCreateUser.Visible = false;
        }

        #region Compte utilisateur
        // Mise à jour du compte utilisateur
        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtPrenom.Text == "" || txtAdresse.Text == ""|| txtPhone.Text == "" || txtUsername.Text == ""
                || txtPassword.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show("Veillez remplir les champs vides !!!");
            }
            else
            {
                bd.EnvoyerRequete("Update Utilisateur Set " +
                "nom = '" + txtName.Text + "'," +
                "prenom = '" + txtPrenom.Text + "', " +
                "adresse = '" + txtAdresse.Text + "', " +
                "phone = '" + txtPhone.Text + "', " +
                "username = '" + txtUsername.Text + "', " +
                "password = '" + txtPassword.Text + "', " +
                "email = '" + txtEmail.Text + "', " +
                "date_update = getDate() WHERE idUser = " + lblID.Text);
                MessageBox.Show("Mise à jour réussie !!");
            }
            
        }

        // Ajouter un nouveau compte utilisateur
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (txtAdresse.Text == "" || txtPassword.Text == ""
                || txtEmail.Text == "" || txtName.Text == "" || txtPrenom.Text == "" || !rdFemal.Checked && !rdMal.Checked
                || txtPhone.Text == "" || cbStatut.Text == "")
            {
                MessageBox.Show("Veuillez remplir les champs !!!");
            }
            else
            {
                bd.RecupererInformations("select email, username from Utilisateur where username = '" +
                    txtUsername.Text+"' and email = '"+txtEmail.Text+"'");

                    if (bd.table.Rows.Count > 0)
                    {
                        MessageBox.Show("Your Already Exists !!");
                    }
                    else
                    {
                        char sexe = char.Parse((rdFemal.Checked) && rdMal.Checked == false ? "F" : "M");
                        bd.EnvoyerRequete("Insert into Utilisateur(nom, prenom, sexe," +
                            "dateNaissance, adresse, phone, username, password, statut," +
                            "date_update, email) Values('" +
                            txtName.Text+"', '"+txtPrenom.Text+"', '"+sexe.ToString()+"', '"+
                            dtDateNaissance.Text+"', '"+txtAdresse.Text+"', '"+txtPhone.Text+"', '"+
                            txtUsername.Text+"', '"+txtPassword.Text+"', '"+cbStatut.Text+"','"+
                            DateTime.Now.ToString()+"', '"+txtEmail.Text+"')");

                        MessageBox.Show("Utilisateur Créé avec succès");
                        Dispose();
                        new Home().Show();
                    }
            }
            
        }

        // évènement lors d'un checked de rdMal
        private void rdMal_CheckedChanged(object sender, EventArgs e)
        {
            if (rdFemal.Checked)
            {
                rdFemal.Checked = false;
                rdMal.Checked = true;
            }
        }

        // évènement lors d'un checked de rdFemal
        private void rdFemal_CheckedChanged(object sender, EventArgs e)
        {
            if (rdMal.Checked)
            {
                rdMal.Checked = false;
                rdFemal.Checked = true;
            }
        }

        // Suppression du compte Utilisateur
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes-vous sur de votre choix ?", "Choix", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                bd.EnvoyerRequete("DELETE Utilisateur where idUser = " + dsh.lblId.Text + " and statut != '" + cbStatut.Text + "'");

                MessageBox.Show("Compte supprimeé avec success");

                Dispose();
                Home h = new Home();
                h.Show();
            }
               
            
        }
        #endregion

        #region Compte Bancaire

        // créer un numéro de compte aléatoire
        private void getNewNumero(object sender, EventArgs e)
        {
            Random rand = new Random();
            cbNumCompte.Items.Clear();
            this.cbNumCompte.Items.Add(rand.Next(100000000, 999999999).ToString());
        }

        // Création d'un compte Bancaire
        private void btnCreateAcBank_Click(object sender, EventArgs e)
        {
            if (cbNumCompte.Text == "" || txtAuteur.Text == "" || txtDevise.Text == "" || txtSoldeBank.Text == "")
                MessageBox.Show("Veuillez remplir les champs !!");
            else
            {
                bd.EnvoyerRequete("INSERT INTO CompteBancaire(numCompte, idUsr, solde, devise) VALUES (" + int.Parse(cbNumCompte.Text) + "," + int.Parse(IDUserAcc.Text) + "," + txtSoldeBank.Text + ",'" + txtDevise.Text + "')");
                btnCreateAcc.Enabled = false;
                MessageBox.Show("Compte Bancaire créé !!");
                ResetDatasBank();
            }
                
        }

        // mise à jour du compte bancaire
        private void btnUpdateAccountBank(object sender, EventArgs e)
        {
            if (cbNumCompte.Text == "" || txtAuteur.Text == "" || txtDevise.Text == "" || txtSoldeBank.Text == "")
                MessageBox.Show("Veuillez remplir les champs !!");
            else
            {
                bd.EnvoyerRequete("Update CompteBancaire Set " +
                    " numCompte = " + int.Parse(cbNumCompte.Text) + ", solde = " + txtSoldeBank.Text + "," +
                    "devise = '" + txtDevise.Text + "', date_update = getDate() where idCompte = " + int.Parse(lblIdBank.Text));

                MessageBox.Show("Mise à jour effectuée !!");
                ResetDatasBank();
            }
        }

        // Suppression d'un Compte Bancaire
        private void btnDeleteAccountBank_Click(object sender, EventArgs e)
        {
            if (cbNumCompte.Text == "" || txtAuteur.Text == "" || txtDevise.Text == "" || txtSoldeBank.Text == "")
                MessageBox.Show("Veuillez remplir les champs !!");
            else
            {
                if (MessageBox.Show("Voulez-vous vraiment supprimer ce compte Bancaire? ", "Suppression", 
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    bd.EnvoyerRequete("DELETE compteBancaire where idCompte = " + lblIdBank.Text);
                    MessageBox.Show("Votre compte bancaire vient d'être supprimé !!!");
                    ResetDatasBank();
                }
            }
        }

        private void cbNumCompte_SelectedIndexChanged(object sender, EventArgs e)
        {
            bd.RecupererInformations("select * from compteBancaire where numCompte = " + cbNumCompte.Text);

            if (bd.table.Rows.Count > 0)
            {
                DataTableReader dtr = new DataTableReader(bd.table);

                while (dtr.Read())
                {
                    lblIdBank.Text = dtr["idCompte"].ToString();
                    txtSoldeBank.Text = dtr["solde"].ToString();
                    txtDevise.Text = dtr["devise"].ToString();
                }
                btnCreateAcc.Enabled = false;
            }

        }

        public void ResetDatasBank()
        {
            cbNumCompte.Text = "";
            txtSoldeBank.Text = "";
            txtDevise.Text = "";
        }
        #endregion


        
    }
}
