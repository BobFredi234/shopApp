using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace shopApp
{
    public partial class Boutique : Form
    {
        string[] images;
        Panel[] panels;
        Panel[] pTitle;
        Panel[] pProduct;
        Panel[] pPrice;
        Panel[] pQuantity;
        PictureBox[] picProduct;
        Label[] lblNameProduct;
        Label[] lblPrix;
        NumericUpDown[] qty;
        Label[] lblPrixHT;
        int x_pos = 12;
        int y_pos = 12;
        private int qtyP;
        Dashboard dsh;
        BDConnexion bd;

        int quantite;
        int idProduit;
        int idClient;
        double prix;
        int taille = 0;

        Button[] btn;
        public Boutique(Dashboard dsh)
        {
            InitializeComponent();
            panelContainer.AutoScroll = true;
            this.dsh = dsh;

            bd = new BDConnexion();
            qtyP = NbCommandes();

            getAllProducts();
        }

        // Récupérer tout les produits
        public void getAllProducts ()
        {
            bd.RecupererInformations("select * from Produit as p " +
                "INNER JOIN categorie as cat ON p.idCategorie = cat.idCat INNER JOIN " +
                "stock as st ON p.idStock = st.idStock INNER JOIN barcode as brcd ON p.idbarcode=brcd.idCodeBar");

            DataTableReader dtr = new DataTableReader(bd.table);

            taille= bd.table.Rows.Count;
            images = new string[taille];
            panels = new Panel[taille];
            btn = new Button[taille];
            pProduct = new Panel[taille];
            pPrice = new Panel[taille];
            picProduct = new PictureBox[taille];
            pQuantity = new Panel[taille];
            pTitle = new Panel[taille];
            lblNameProduct = new Label[taille];
            lblPrix = new Label[taille];
            lblPrixHT = new Label[taille];
            qty = new NumericUpDown[taille];


            int i = 0;
            while(dtr.Read())
            {
                    // Nouvelle instance d'objets
                    pProduct[i] = new Panel();
                    pPrice[i] = new Panel();
                    pQuantity[i] = new Panel();
                    pTitle[i] = new Panel();
                    lblNameProduct[i] = new Label();
                    lblPrix[i] = new Label();
                    picProduct[i] = new PictureBox();
                    btn[i] = new Button();
                    qty[i] = new NumericUpDown();
                    lblPrixHT[i] = new Label();
                    images[i] = dtr["image"].ToString();
                    // -----------------------------

                    pProduct[i].Size = new Size(166, 47);
                    pPrice[i].Size = new Size(169, 22);
                    pQuantity[i].Size = new Size(169, 22);

                    picProduct[i].Size = new Size(169, 100);
                    picProduct[i].Dock = DockStyle.Fill;
                    picProduct[i].BackColor = Color.Transparent;
                    picProduct[i].SizeMode = PictureBoxSizeMode.Zoom;
                    picProduct[i].Image = Image.FromFile(images[i]);
                    picProduct[i].Visible = true;
                    pTitle[i].Controls.Add(picProduct[i]);
                    pTitle[i].Dock = DockStyle.Top;
                    pTitle[i].Size = new Size(169, 100);
                    pTitle[i].Name = "pictureProduct" + dtr["idProduit"].ToString();

                    lblNameProduct[i].Text = dtr["nomProduit"].ToString();
                    lblNameProduct[i].Font = new Font("Cooper Black", 11F, FontStyle.Italic);
                    lblNameProduct[i].TextAlign = ContentAlignment.MiddleCenter;
                    lblNameProduct[i].Dock = DockStyle.Fill;
                    lblNameProduct[i].Visible = true;
                    pProduct[i].Controls.Add(lblNameProduct[i]);
                    pProduct[i].Dock = DockStyle.Top;
                    pProduct[i].Visible = true;

                    lblPrix[i].Text = dtr["prix"].ToString();
                    lblPrix[i].Dock = DockStyle.Fill;
                    lblPrix[i].BackColor = Color.Black;
                    lblPrix[i].Font = new Font("Century Gothic", 11F, FontStyle.Bold);
                    lblPrix[i].TextAlign = ContentAlignment.MiddleCenter;
                    lblPrix[i].ForeColor = Color.White;
                    lblPrix[i].Visible = true;
                    pPrice[i].Controls.Add(lblPrix[i]);
                    pPrice[i].Dock = DockStyle.Top;
                    pPrice[i].Visible = true;

                    qty[i].Value = 1;
                    qty[i].Size = new Size(54, 20);
                    qty[i].Dock = DockStyle.Left;
                    qty[i].Visible = true;
                    this.qty[i].ValueChanged += new System.EventHandler(qty_ValueChanged);
                    lblPrixHT[i].Text = "XAF";
                    lblPrixHT[i].BackColor = Color.IndianRed;
                    lblPrixHT[i].Size = new Size(115, 22);
                    lblPrixHT[i].Dock = DockStyle.Right;
                    lblPrixHT[i].Font = new Font("Century Gothic", 11F, FontStyle.Bold);
                    lblPrixHT[i].ForeColor = Color.White;
                    lblPrixHT[i].TextAlign = ContentAlignment.MiddleCenter;
                    lblPrixHT[i].Visible = true;
                    pQuantity[i].Dock = DockStyle.Top;
                    pQuantity[i].Controls.Add(qty[i]);
                    pQuantity[i].Controls.Add(lblPrixHT[i]);
                    pQuantity[i].Visible = true;

                    /* ---------------------------------------------- */
                    picProduct[i].Name = "picture" + i.ToString();
                    panels[i] = new Panel();
                    panels[i].Size = new Size(169, 228);
                    panels[i].BackColor = Color.White;
                    panels[i].Location = new Point(x_pos, y_pos);



                    btn[i].Size = new Size(169, 36);
                    btn[i].BackColor = Color.Chocolate;
                    btn[i].Dock = DockStyle.Bottom;
                    btn[i].FlatAppearance.BorderSize = 0;
                    btn[i].FlatStyle = FlatStyle.Flat;
                    btn[i].Name = dtr["idProduit"].ToString();
                    btn[i].Text = "Add to Cart";
                    btn[i].Font = new Font("Century Gothic", 11F, FontStyle.Bold);
                    btn[i].ForeColor = Color.White;
                    btn[i].Click += new EventHandler(this.btnAddCart_Click);

                    

                    panels[i].Controls.Add(pProduct[i]);
                    panels[i].Controls.Add(pPrice[i]);
                    panels[i].Controls.Add(pQuantity[i]);
                    panels[i].Controls.Add(pTitle[i]);
                    panels[i].Controls.Add(btn[i]);
                    panels[i].Visible = true;




                    panelContainer.Controls.Add(panels[i]);

                    if (x_pos >= panelContainer.Size.Width)
                    {
                        x_pos = 12;
                        y_pos += 272;
                    }
                    else
                    {
                        x_pos += 212;
                    }
                i++;
            }
            
        }

        // Calculer le Prix Hors Taxe d'un Produit
        private void CalculPrixHT(Label[] label2, NumericUpDown[] qty, Label[] prix)
        {

            for (int i = 0; i < qty.Length; i++)
            {
                if (qty[i].Focused)
                {
                    qty[i].Value = qty[i].Value == 0 ? qty[i].Value + 1 : qty[i].Value;
                    label2[i].Text = (Decimal.Parse(prix[i].Text) * qty[i].Value).ToString() + " XAF";
                }
                   
            }
        }

        // Evènement lors d'une modification de valeur de NumericUpDown
        private void qty_ValueChanged(object sender, EventArgs e)
        {
            CalculPrixHT(lblPrixHT, qty, lblPrix);
        }

        // Evènement lors d'un click sur un bouton Add to Cart
        private void btnAddCart_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < taille; i++)
            {
               if (btn[i].Focused)
               {
                    quantite = int.Parse(qty[i].Value.ToString());
                    idProduit = int.Parse(btn[i].Name);
                    idClient = int.Parse(dsh.lblId.Text);
                    prix = double.Parse(lblPrixHT[i].Text.Replace(" XAF", ""));

                    MessageBox.Show(quantite.ToString()+", "+idClient.ToString() + ", " + idProduit.ToString()+", " +prix.ToString());
                    /*bd.RecupererInformations("select st.qty from stock as st " +
                        "INNER JOIN produit as p on p.idStock = st.idstock and st.qty > " + quantite.ToString());

                    if (bd.table.Rows.Count > 0)
                    {
                        bd.RecupererInformations("select st.qty as quantite from stock as st, utilisateur as us " +
                        "INNER JOIN produit as p on p.idStock = st.idstock and p.idProduit = " + idProduit +
                        "INNER JOIN commande as cmd on cmd.idProduit = p.idProduit and cmd.idClient = " + idClient+" and us.idUser = cmd.idClient");

                        int numRef = new Random().Next();

                        if (bd.table.Rows.Count > 0)
                        {
                            if (bd.EnvoyerRequete("Update Commande set " +"qty = "+quantite+", prix = "+prix+" where idclient = "+idClient) == 0)
                            {
                                MessageBox.Show("Mise à jour effectuée !!");
                            }
                            else
                            {
                                MessageBox.Show("Erreur lors de la mise à jour !!");
                            }
                        }
                        else
                        {
                            int test = bd.EnvoyerRequete("Insert Into commande (numRef, idProduit, idClient, qty, prix) VALUES (" +
                                numRef + ", " + idProduit + ", " + quantite + ", " + prix + ")");
                            dsh.LoadCommandes();

                            if (test == 0)
                                MessageBox.Show("Enregistrement réussie !!");
                            else
                                MessageBox.Show("Erreur survenue lor de l'insertion !!");
                        }
                    }
                    else
                    {
                        DataTableReader dtr = new DataTableReader(bd.table);

                        while (dtr.Read())
                        {
                            MessageBox.Show("Quantité non valide !! + \nLa quantité en stock est de : " + dtr["quantite"].ToString());
                        }
                        
                    }*/
               }
            }
        }

        
        // Ajouter à la carte
        private void AddCart()
        {

        }

        // liste des commandes
        public int NbCommandes()
        {
            bd.RecupererInformations("select idCmd as ID, numRef as 'numéro de référence', nomProduit as produit, qty as " +
                "quantité, cmd.prix as prixHT from commande as cmd INNER JOIN produit as p " +
                "ON cmd.idProduit = p.IdProduit INNER JOIN utilisateur as us ON us.idUser = cmd.idClient");

            return bd.table.Rows.Count;
            
        }
    }
}
