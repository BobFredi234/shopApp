using System;
using System.Data.SqlClient;

namespace shopApp
{
    public interface IAdminConfig 
    {
        #region Insertion
            int AddUser(); // Ajouter un utilisateur
            int AddProduit(); // Ajouter un produit
            int AddCategory(); // Ajouter une catégorie de produits 
            int AddAccountBank(); // Ajouter un nouveau compte Bancaire
            int AddOrder(); // ajouter une nouvelle commande
            int AddStock(int quantity); // Ajouter un stock de produit
        #endregion

        #region Mise à jour
            int UpdateUser(int id); // Mise à jour d'un utilisateur
            int UpdateProduct(int id); // Mise à jour d'un produit
            int UpdateCategory(int id); // Mise à jour d'une catégorie de produits 
            int UpdateAccountBank(int id); // Mise à jour d'un nouveau compte Bancaire
            int UpdateOrder(int id); // Mise à jour d'une nouvelle commande
            int UpdateStock(int id); // Mise à jour d'un stock de produit
        #endregion

        #region Lire
            void ListUser(); // Liste des utilisateurs
            void ListProduct(); // Liste des produits
            void ListCategory(); // Liste des catégories
            void ListAccountBank(); // Liste des différents compte Bancaire
            void ListOrder(); // Liste des différentes commandes
        #endregion

    }
}
