namespace shopApp
{
    partial class GestionProduit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgrProduct = new System.Windows.Forms.DataGridView();
            this.btnExport = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnModify = new System.Windows.Forms.Button();
            this.product = new System.Windows.Forms.TextBox();
            this.pdesc = new System.Windows.Forms.TextBox();
            this.LbAdress = new System.Windows.Forms.Label();
            this.LbPassword = new System.Windows.Forms.Label();
            this.LbPrice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LbVend = new System.Windows.Forms.Label();
            this.numStock = new System.Windows.Forms.NumericUpDown();
            this.lblAuteur = new System.Windows.Forms.Label();
            this.lblImage = new System.Windows.Forms.Label();
            this.pictProduct = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrix = new System.Windows.Forms.TextBox();
            this.IdProduct = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.LbNumRef = new System.Windows.Forms.Label();
            this.LbDateCreation = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateExpiration = new System.Windows.Forms.DateTimePicker();
            this.txtAdmin = new System.Windows.Forms.TextBox();
            this.cbStock = new System.Windows.Forms.ComboBox();
            this.txtBarcode = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgrProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrProduct
            // 
            this.dgrProduct.AllowUserToAddRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgrProduct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgrProduct.BackgroundColor = System.Drawing.Color.White;
            this.dgrProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgrProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrProduct.Location = new System.Drawing.Point(5, 250);
            this.dgrProduct.Name = "dgrProduct";
            this.dgrProduct.RowHeadersVisible = false;
            this.dgrProduct.Size = new System.Drawing.Size(686, 299);
            this.dgrProduct.TabIndex = 51;
            this.dgrProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrProduct_CellContentClick);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.DarkOrange;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Location = new System.Drawing.Point(589, 210);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(100, 34);
            this.btnExport.TabIndex = 50;
            this.btnExport.Text = "Exporter";
            this.btnExport.UseVisualStyleBackColor = false;
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.Red;
            this.BtnDelete.FlatAppearance.BorderSize = 0;
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.Location = new System.Drawing.Point(3, 153);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(99, 34);
            this.BtnDelete.TabIndex = 49;
            this.BtnDelete.Text = "Supprimer";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.GreenYellow;
            this.BtnSave.FlatAppearance.BorderSize = 0;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.Location = new System.Drawing.Point(4, 197);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(98, 34);
            this.BtnSave.TabIndex = 48;
            this.BtnSave.Text = "Enregistrer";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnModify
            // 
            this.BtnModify.BackColor = System.Drawing.Color.Orange;
            this.BtnModify.FlatAppearance.BorderSize = 0;
            this.BtnModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModify.Location = new System.Drawing.Point(3, 104);
            this.BtnModify.Name = "BtnModify";
            this.BtnModify.Size = new System.Drawing.Size(85, 34);
            this.BtnModify.TabIndex = 47;
            this.BtnModify.Text = "Modifier";
            this.BtnModify.UseVisualStyleBackColor = false;
            this.BtnModify.Click += new System.EventHandler(this.BtnModify_Click);
            // 
            // product
            // 
            this.product.Location = new System.Drawing.Point(3, 72);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(152, 20);
            this.product.TabIndex = 45;
            // 
            // pdesc
            // 
            this.pdesc.Location = new System.Drawing.Point(446, 102);
            this.pdesc.Multiline = true;
            this.pdesc.Name = "pdesc";
            this.pdesc.Size = new System.Drawing.Size(245, 102);
            this.pdesc.TabIndex = 43;
            // 
            // LbAdress
            // 
            this.LbAdress.AutoSize = true;
            this.LbAdress.Location = new System.Drawing.Point(363, 147);
            this.LbAdress.Name = "LbAdress";
            this.LbAdress.Size = new System.Drawing.Size(64, 13);
            this.LbAdress.TabIndex = 40;
            this.LbAdress.Text = "description :";
            // 
            // LbPassword
            // 
            this.LbPassword.AutoSize = true;
            this.LbPassword.Location = new System.Drawing.Point(246, 16);
            this.LbPassword.Name = "LbPassword";
            this.LbPassword.Size = new System.Drawing.Size(41, 13);
            this.LbPassword.TabIndex = 39;
            this.LbPassword.Text = "Stock :";
            // 
            // LbPrice
            // 
            this.LbPrice.AutoSize = true;
            this.LbPrice.Location = new System.Drawing.Point(443, 16);
            this.LbPrice.Name = "LbPrice";
            this.LbPrice.Size = new System.Drawing.Size(58, 13);
            this.LbPrice.TabIndex = 38;
            this.LbPrice.Text = "Catégorie :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(279, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "Liste de produits :";
            // 
            // LbVend
            // 
            this.LbVend.AutoSize = true;
            this.LbVend.Location = new System.Drawing.Point(6, 51);
            this.LbVend.Name = "LbVend";
            this.LbVend.Size = new System.Drawing.Size(85, 13);
            this.LbVend.TabIndex = 34;
            this.LbVend.Text = "Nom du produit :";
            // 
            // numStock
            // 
            this.numStock.Location = new System.Drawing.Point(293, 12);
            this.numStock.Name = "numStock";
            this.numStock.Size = new System.Drawing.Size(51, 20);
            this.numStock.TabIndex = 52;
            this.numStock.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblAuteur
            // 
            this.lblAuteur.AutoSize = true;
            this.lblAuteur.Location = new System.Drawing.Point(499, 51);
            this.lblAuteur.Name = "lblAuteur";
            this.lblAuteur.Size = new System.Drawing.Size(53, 13);
            this.lblAuteur.TabIndex = 39;
            this.lblAuteur.Text = "Createur :";
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Location = new System.Drawing.Point(119, 130);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(92, 13);
            this.lblImage.TabIndex = 40;
            this.lblImage.Text = "Image du produit :";
            // 
            // pictProduct
            // 
            this.pictProduct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictProduct.Location = new System.Drawing.Point(226, 102);
            this.pictProduct.Name = "pictProduct";
            this.pictProduct.Size = new System.Drawing.Size(111, 68);
            this.pictProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictProduct.TabIndex = 53;
            this.pictProduct.TabStop = false;
            this.pictProduct.Click += new System.EventHandler(this.pictProduct_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Prix :";
            // 
            // txtPrix
            // 
            this.txtPrix.Location = new System.Drawing.Point(174, 188);
            this.txtPrix.Name = "txtPrix";
            this.txtPrix.Size = new System.Drawing.Size(163, 20);
            this.txtPrix.TabIndex = 44;
            this.txtPrix.Text = "0";
            // 
            // IdProduct
            // 
            this.IdProduct.AutoSize = true;
            this.IdProduct.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdProduct.Location = new System.Drawing.Point(442, 216);
            this.IdProduct.Name = "IdProduct";
            this.IdProduct.Size = new System.Drawing.Size(25, 20);
            this.IdProduct.TabIndex = 54;
            this.IdProduct.Text = "ID";
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(524, 13);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(165, 21);
            this.cbCategory.TabIndex = 55;
            // 
            // LbNumRef
            // 
            this.LbNumRef.AutoSize = true;
            this.LbNumRef.Location = new System.Drawing.Point(6, 16);
            this.LbNumRef.Name = "LbNumRef";
            this.LbNumRef.Size = new System.Drawing.Size(58, 13);
            this.LbNumRef.TabIndex = 35;
            this.LbNumRef.Text = "code bar : ";
            // 
            // LbDateCreation
            // 
            this.LbDateCreation.AutoSize = true;
            this.LbDateCreation.Location = new System.Drawing.Point(313, 16);
            this.LbDateCreation.Name = "LbDateCreation";
            this.LbDateCreation.Size = new System.Drawing.Size(13, 13);
            this.LbDateCreation.TabIndex = 36;
            this.LbDateCreation.Text = " :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Date Expiration :";
            // 
            // dateExpiration
            // 
            this.dateExpiration.Location = new System.Drawing.Point(226, 72);
            this.dateExpiration.Name = "dateExpiration";
            this.dateExpiration.Size = new System.Drawing.Size(165, 20);
            this.dateExpiration.TabIndex = 56;
            // 
            // txtAdmin
            // 
            this.txtAdmin.Location = new System.Drawing.Point(502, 72);
            this.txtAdmin.Name = "txtAdmin";
            this.txtAdmin.Size = new System.Drawing.Size(126, 20);
            this.txtAdmin.TabIndex = 44;
            // 
            // cbStock
            // 
            this.cbStock.FormattingEnabled = true;
            this.cbStock.Location = new System.Drawing.Point(344, 12);
            this.cbStock.Name = "cbStock";
            this.cbStock.Size = new System.Drawing.Size(47, 21);
            this.cbStock.TabIndex = 55;
            this.cbStock.Visible = false;
            // 
            // txtBarcode
            // 
            this.txtBarcode.FormattingEnabled = true;
            this.txtBarcode.Location = new System.Drawing.Point(70, 13);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(141, 21);
            this.txtBarcode.TabIndex = 55;
            // 
            // GestionProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 561);
            this.ControlBox = false;
            this.Controls.Add(this.dateExpiration);
            this.Controls.Add(this.cbStock);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.IdProduct);
            this.Controls.Add(this.pictProduct);
            this.Controls.Add(this.numStock);
            this.Controls.Add(this.dgrProduct);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnModify);
            this.Controls.Add(this.product);
            this.Controls.Add(this.txtPrix);
            this.Controls.Add(this.txtAdmin);
            this.Controls.Add(this.pdesc);
            this.Controls.Add(this.lblImage);
            this.Controls.Add(this.LbAdress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAuteur);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LbPassword);
            this.Controls.Add(this.LbPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LbDateCreation);
            this.Controls.Add(this.LbNumRef);
            this.Controls.Add(this.LbVend);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GestionProduit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion des Produits";
            ((System.ComponentModel.ISupportInitialize)(this.dgrProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnModify;
        private System.Windows.Forms.TextBox product;
        private System.Windows.Forms.TextBox pdesc;
        private System.Windows.Forms.Label LbAdress;
        private System.Windows.Forms.Label LbPassword;
        private System.Windows.Forms.Label LbPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LbVend;
        private System.Windows.Forms.NumericUpDown numStock;
        private System.Windows.Forms.Label lblAuteur;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.PictureBox pictProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrix;
        private System.Windows.Forms.DataGridView dgrProduct;
        private System.Windows.Forms.Label IdProduct;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label LbNumRef;
        private System.Windows.Forms.Label LbDateCreation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateExpiration;
        private System.Windows.Forms.TextBox txtAdmin;
        private System.Windows.Forms.ComboBox cbStock;
        private System.Windows.Forms.ComboBox txtBarcode;
    }
}