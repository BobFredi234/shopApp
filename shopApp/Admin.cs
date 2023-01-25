using System;
using System.Data.SqlClient;

namespace shopApp
{
    class Admin : Utilisateur
    {
        public Admin(string username, string password, string statut, string nom, string prenom, char sexe, DateTime dateNaissance, CompteBancaire account, string adresse, int phone) : 
            base(username, password, statut, nom, prenom, sexe, dateNaissance, account, adresse, phone)
        {
        }

    }
}
