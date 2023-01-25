using System;

namespace shopApp
{

    public class Utilisateur : Personne, IUserConfig
    {
        public int idUser = 0;
        public string username, password, statut;
        public int phone;

        public Utilisateur(string username, string password, string statut,
            string nom, string prenom, char sexe, DateTime dateNaissance, CompteBancaire account, string adresse, int phone) :
            base(nom, prenom, sexe, dateNaissance, account, adresse)
        {
            this.idUser++;
            this.username = username;
            this.password = password;
            this.statut = statut;
            this.phone = phone;
        }

        public Utilisateur():
            base("", "", char.Parse(""), new DateTime(), null, "")
        {
            username = "";
            password = "";
            statut = "Standard";
            phone = 0;
        }
        public void ConsulterInfos() // Consultation d'informations
        {
            throw new NotImplementedException();
        }

        public void ModifierInfos() // Update Information
        {
            throw new NotImplementedException();
        }

        public void SupprimerCompte(int id) // Supprimer Compte
        {
            throw new NotImplementedException();
        }
    }
}
