using System;

namespace shopApp
{
    public class CompteBancaire
    {
        public int idCompte = 0;
        public int numCompte;
        public string nomAuteur;
        public double solde;

        public CompteBancaire()
        {
            this.idCompte++;
            this.numCompte = 0;
            this.nomAuteur = "";
            this.solde = 0;
        }

        public CompteBancaire(int numCompte, string nomAuteur, double solde)
        {
            this.numCompte = numCompte;
            this.nomAuteur = nomAuteur;
            this.solde = solde;
        }

        public bool debiter(double montant)
        {
            if (solde < montant) return false;
            else
            {
                solde -= montant;

                return true;
            }
        } // Débiter 
        public void crediter(double montant) 
        {
            if (montant > 0) this.solde += montant;
        }//Créditer
        public string pret(string statut, double montant)
        {
            debiter(montant);
            return statut +" montant prêté est " + montant;
        }

        public string getInfosCompte() // Informations du Compte
        {
            string data = "id :{0}, Numéro de compte : {1}, solde : {2} XAF, Nom du détenteur du compte : {3}";
            data = string.Format(data, idCompte, numCompte, solde, nomAuteur);

            return data;
        }
    }
}
