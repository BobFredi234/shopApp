using System;
using System.Data.SqlClient;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace shopApp
{
    public class Personne : BDConnexion
    {
        public int idPersonne = 0;
        public string nom, prenom, adresse;
        public char sexe;
        public DateTime dateNaissance;
        public CompteBancaire account;


        public Personne(string nom, string prenom, char sexe, DateTime dateNaissance, CompteBancaire account, string adresse)
        {
            this.idPersonne++;
            this.nom = nom;
            this.prenom = prenom;
            this.sexe = sexe;
            this.dateNaissance = dateNaissance;
            this.account = account;
            this.adresse = adresse;
        }

        public void ConsulterListeProduit()
        {

        }
        public void PassCommand(int idAccountBank, int idUser, int idProduct)
        {
            try
            {
                if (idAccountBank != 0 && idUser != 0 && idProduct != 0)
                {
                }else
                    MessageBox.Show("Veuillez vérifiez les informations saisies !!", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
            catch (SqlException exc)
            {
                MessageBox.Show(exc.Message, exc.Source, MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }
        public void createAccountBank(int numCompte, string auteur, double solde)
        {
            try
            {
                

                if (numCompte != 0 && auteur != "" && solde != 0)
                {
                    CompteBancaire account = new CompteBancaire();
                    account.numCompte = numCompte;
                    account.nomAuteur = auteur;
                    account.crediter(solde);
                    EnvoyerRequete("Insert into CompteBancaire (numCompte, auteur, solde) " +
                        "VALUES ('" + account.numCompte + "', '" + account.nomAuteur + "', " + account.solde + ")");
                    MessageBox.Show("Le Compte Bancaire a été créé avec succès !");
                }
                else
                    MessageBox.Show("Veuillez vérifiez les informations saisies !!", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
            catch (SqlException exc)
            {
                MessageBox.Show(exc.Message, exc.Source, MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }
        public void createAccountLocal(string name, string fname, string sexe, string address, string phone,
            string username, string password, string statut, int idAccount, DateTime dateN)
        {
            try
            {
                if (name != "" && fname != "" && sexe != "" && address != "" && phone != ""
                && username != "" && password != "" && statut != "" && idAccount != 0)
                {
                    Utilisateur user = new Utilisateur(username, password, statut, nom, prenom, 
                        Convert.ToChar(sexe),
                        dateN, new CompteBancaire(), address, int.Parse(phone));
                    user.account.idCompte = idAccount;

                    EnvoyerRequete("Insert into utilisateur(idCompte, username, password, name, address, phone, statut" +
                        ", sexe) " +
                        "VALUES (" + user.account.idCompte + ", '" + user.username + "', '" + user.password + "', '" +
                        user.nom + " " + user.prenom + "', '" + user.adresse + "', " + user.phone + ", '" + user.statut +
                        "', '" + user.sexe + "')");
                    MessageBox.Show("Félicitation !!!, Vous êtes maintenant un membre de notre communauté.");
                }
                else
                    MessageBox.Show("Veuillez vérifiez les informations saisies !!", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, exc.Source, MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            
        }

        public void NoteProduct()
        {

        }

    }
}
