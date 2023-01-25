using iTextSharp.text.pdf;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace shopApp
{
    public partial class GestionProduit : Form
    {
        BDConnexion bd;
        string filename;
        public GestionProduit()
        {
            InitializeComponent();
            bd = new BDConnexion();
            LoadProducts();
            LoadCategory();
            LoadBarCode();
            ResetAllDatas();
        }

        // Evènement lors d'un click sur pictProduct
        private void pictProduct_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            try
            {
                if (file.ShowDialog() == DialogResult.OK)
                {
                    filename = file.FileName;
                    pictProduct.Image = Image.FromFile(filename);
                    MessageBox.Show(filename);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }

        // Réinitialiser tout les champs
        public void ResetAllDatas()
        {
            cbCategory.Text = "";
            txtBarcode.Text = "";
            product.Text = "";
            dateExpiration.Text = "";
            txtAdmin.Text = "";
            txtPrix.Text = "0";
            cbStock.Visible = true;
            cbStock.Enabled = false;
            pictProduct.Image = Image.FromFile("C:\\Users\\Bobi\\Desktop\\TP Csharp\\shopApp\\shopApp\\Resources\\Images\\Products\\woocommerce-placeholder.png");
            IdProduct.Text = "ID";
        }

        // Evènement lors d'un double click sur un champ enregistré
        private void dgrProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IdProduct.Text = dgrProduct[0, e.RowIndex].Value.ToString();
            cbCategory.Text = dgrProduct[1, e.RowIndex].Value.ToString();
            cbStock.Text = dgrProduct[2, e.RowIndex].Value.ToString();
            txtAdmin.Text = dgrProduct[3, e.RowIndex].Value.ToString();
            product.Text = dgrProduct[4, e.RowIndex].Value.ToString();
            pdesc.Text = dgrProduct[5, e.RowIndex].Value.ToString();
            pictProduct.Image = Image.FromFile(dgrProduct[6, e.RowIndex].Value.ToString());
            filename = dgrProduct[6, e.RowIndex].Value.ToString();
            filename = filename.Replace("\\\\", "\\");
            txtBarcode.Text = dgrProduct[7, e.RowIndex].Value.ToString();
            txtPrix.Text = dgrProduct[8, e.RowIndex].Value.ToString();
            txtPrix.Text = txtPrix.Text.Replace(',', '.');
            dateExpiration.Text = dgrProduct[9, e.RowIndex].Value.ToString();
            numStock.Text = dgrProduct["qty", e.RowIndex].Value.ToString();

            BtnSave.Enabled = false;
        }

        // Liste des produits
        public void LoadProducts()
        {
            dgrProduct.DataSource = bd.RecupererInformations("select * from Produit as p " +
                "INNER JOIN categorie as cat ON p.idCategorie = cat.idCat INNER JOIN " +
                "stock as st ON p.idStock = st.idStock INNER JOIN barcode as brcd ON p.idbarcode=brcd.idCodeBar");

            DataTableReader dtr = new DataTableReader(bd.table);
            cbStock.Items.Clear();

            while (dtr.Read())
            {
                cbStock.Items.Add(dtr["idStock"].ToString());
            }
        }

        // Liste des catégories
        private void LoadCategory()
        {
            try
            {
                bd.cn.Open();
                bd.cmd.CommandText = "select IdCat from Categorie order by IdCat ASC";
                bd.dr = bd.cmd.ExecuteReader();
                cbCategory.Items.Clear();

                while (bd.dr.Read()) cbCategory.Items.Add(bd.dr[0].ToString());

                bd.cn.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        // Liste des codes bares
        public void LoadBarCode()
        {
            try
            {
                bd.cn.Open();
                bd.cmd.CommandText = "select idCodeBar from barcode as brcd " +
                    "where brcd.state LIKE 'non utilisé'";
                bd.dr = bd.cmd.ExecuteReader();
                txtBarcode.Items.Clear();

                while (bd.dr.Read()) txtBarcode.Items.Add(bd.dr["idCodeBar"].ToString());

                bd.cn.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        // Ajouter un produit
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (txtBarcode.Text == "" || cbCategory.Text == ""
                || product.Text == "" || pdesc.Text == "" || 
                dateExpiration.Text == "" || txtAdmin.Text == ""
                || filename == "" || txtPrix.Text == ""
                || txtPrix.Text == "0" || numStock.Value == 0)
            {
                MessageBox.Show("Veillez remplir les champs vides !!");
            }
            else
            {
                int id = new Random().Next();
                bd.EnvoyerRequete("INSERT INTO stock VALUES (" +
                    id.ToString() + "," +
                    int.Parse(numStock.Value.ToString())+"," +
                    (int.Parse(numStock.Value.ToString()) <= 0 ? "'false'":"'true'")+");");
                bd.EnvoyerRequete("INSERT INTO produit(idCategorie, idStock, idAdmin, nomProduit, description, image, " +
                    "idbarcode, prix, date_expiration) " +
                    "VALUES (" + int.Parse(cbCategory.Text) + ", " +
                    id.ToString() + ", " + int.Parse(txtAdmin.Text) + ", '" + product.Text + "', '" +
                    pdesc.Text + "', '" + filename + "', " + int.Parse(txtBarcode.Text) + ", " +
                    decimal.Parse(txtPrix.Text) + ", '" + dateExpiration.Text+ "');");
                bd.EnvoyerRequete("UPDATE BarCode SET " +
                    "state = 'utilisé', date_update = getDate() where " +
                    "idCodebar = " + int.Parse(txtBarcode.Text)+";");

                ResetAllDatas();
                LoadProducts();
            }
        }

        // Modifier un produit
        private void BtnModify_Click(object sender, EventArgs e)
        {
            if (txtBarcode.Text == "" || cbCategory.Text == ""
                || product.Text == "" || pdesc.Text == "" ||
                dateExpiration.Text == "" || txtAdmin.Text == ""
                || filename == "" || txtPrix.Text == "" || cbStock.Text == ""
                || txtPrix.Text == "0" || numStock.Value == 0 || IdProduct.Text == "ID")
            {
                MessageBox.Show("Veillez remplir les champs vides !!");
            }
            else
            {
                filename = filename.Replace("\\\\", "\\");
                bd.EnvoyerRequete("UPDATE Produit SET " +
                    "idAdmin = " + int.Parse(txtAdmin.Text) + ", " +
                    "nomProduit = '" + product.Text + "'," +
                    "description = '" + pdesc.Text + "'," +
                    "image = '" + filename + "'," +
                    "idbarcode = " + txtBarcode.Text + "," +
                    "prix = " + txtPrix.Text + "," +
                    "idCategorie = "+ int.Parse(cbCategory.Text) + "," +
                    "date_expiration = " + dateExpiration.Value.ToString()+"," +
                    "date_update = getDate() where idProduit = "+IdProduct.Text);

                bd.EnvoyerRequete("Update stock Set " +
                    "qty = " + int.Parse(numStock.Value.ToString()) + "," +
                    "inStock = " + (numStock.Value <= 0 ? "false" : "true"));
                ResetAllDatas();
                LoadProducts();
                BtnSave.Enabled = true;
            }
        }

        // Supprimer un produit
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (txtBarcode.Text == "" || cbCategory.Text == ""
                || product.Text == "" || pdesc.Text == "" ||
                dateExpiration.Text == "" || txtAdmin.Text == ""
                || filename == "" || txtPrix.Text == "" || cbStock.Text == ""
                || txtPrix.Text == "0" || txtPrix.Text == "" || IdProduct.Text == "ID")
            {
                MessageBox.Show("Veillez remplir les champs vides !!");
            }
            else
            {
                bd.EnvoyerRequete("Delete produit where idProduit = " + IdProduct.Text);
                ResetAllDatas();
                LoadProducts();
                BtnSave.Enabled = true;
            }
        }
    }
}
