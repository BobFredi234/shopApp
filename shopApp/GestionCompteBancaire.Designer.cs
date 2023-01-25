namespace shopApp
{
    partial class GestionCompteBancaire
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
            this.txtDevise = new System.Windows.Forms.TextBox();
            this.txtSoldeBank = new System.Windows.Forms.TextBox();
            this.txtAuteur = new System.Windows.Forms.TextBox();
            this.txtNumCompte = new System.Windows.Forms.TextBox();
            this.lblSolde = new System.Windows.Forms.Label();
            this.lblAuteur = new System.Windows.Forms.Label();
            this.lblGnNm = new System.Windows.Forms.Label();
            this.lblNumCompte = new System.Windows.Forms.Label();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnModify = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.dgrAccountBank = new System.Windows.Forms.DataGridView();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgrAccountBank)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDevise
            // 
            this.txtDevise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDevise.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDevise.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDevise.ForeColor = System.Drawing.Color.White;
            this.txtDevise.Location = new System.Drawing.Point(409, 46);
            this.txtDevise.MaxLength = 3;
            this.txtDevise.Multiline = true;
            this.txtDevise.Name = "txtDevise";
            this.txtDevise.Size = new System.Drawing.Size(50, 23);
            this.txtDevise.TabIndex = 31;
            // 
            // txtSoldeBank
            // 
            this.txtSoldeBank.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoldeBank.Location = new System.Drawing.Point(465, 46);
            this.txtSoldeBank.MaxLength = 10;
            this.txtSoldeBank.Name = "txtSoldeBank";
            this.txtSoldeBank.Size = new System.Drawing.Size(186, 23);
            this.txtSoldeBank.TabIndex = 32;
            // 
            // txtAuteur
            // 
            this.txtAuteur.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuteur.Location = new System.Drawing.Point(192, 44);
            this.txtAuteur.MaxLength = 30;
            this.txtAuteur.Name = "txtAuteur";
            this.txtAuteur.Size = new System.Drawing.Size(83, 23);
            this.txtAuteur.TabIndex = 30;
            // 
            // txtNumCompte
            // 
            this.txtNumCompte.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumCompte.Location = new System.Drawing.Point(192, 6);
            this.txtNumCompte.MaxLength = 20;
            this.txtNumCompte.Name = "txtNumCompte";
            this.txtNumCompte.Size = new System.Drawing.Size(267, 23);
            this.txtNumCompte.TabIndex = 27;
            // 
            // lblSolde
            // 
            this.lblSolde.AutoSize = true;
            this.lblSolde.BackColor = System.Drawing.Color.White;
            this.lblSolde.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSolde.Location = new System.Drawing.Point(338, 50);
            this.lblSolde.Name = "lblSolde";
            this.lblSolde.Size = new System.Drawing.Size(51, 17);
            this.lblSolde.TabIndex = 23;
            this.lblSolde.Text = "Solde :";
            // 
            // lblAuteur
            // 
            this.lblAuteur.AutoSize = true;
            this.lblAuteur.BackColor = System.Drawing.Color.White;
            this.lblAuteur.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuteur.Location = new System.Drawing.Point(12, 46);
            this.lblAuteur.Name = "lblAuteur";
            this.lblAuteur.Size = new System.Drawing.Size(64, 17);
            this.lblAuteur.TabIndex = 26;
            this.lblAuteur.Text = "Titulaire :";
            // 
            // lblGnNm
            // 
            this.lblGnNm.AutoSize = true;
            this.lblGnNm.BackColor = System.Drawing.Color.White;
            this.lblGnNm.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGnNm.ForeColor = System.Drawing.Color.Salmon;
            this.lblGnNm.Location = new System.Drawing.Point(488, 7);
            this.lblGnNm.Name = "lblGnNm";
            this.lblGnNm.Size = new System.Drawing.Size(163, 20);
            this.lblGnNm.TabIndex = 29;
            this.lblGnNm.Text = "[Générer un numéro]";
            this.lblGnNm.Click += new System.EventHandler(this.generate_num_Click);
            // 
            // lblNumCompte
            // 
            this.lblNumCompte.AutoSize = true;
            this.lblNumCompte.BackColor = System.Drawing.Color.White;
            this.lblNumCompte.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumCompte.Location = new System.Drawing.Point(12, 9);
            this.lblNumCompte.Name = "lblNumCompte";
            this.lblNumCompte.Size = new System.Drawing.Size(148, 17);
            this.lblNumCompte.TabIndex = 28;
            this.lblNumCompte.Text = "Numéro de Compte :";
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.Red;
            this.BtnDelete.FlatAppearance.BorderSize = 0;
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.Location = new System.Drawing.Point(176, 91);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(99, 34);
            this.BtnDelete.TabIndex = 52;
            this.BtnDelete.Text = "Supprimer";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.GreenYellow;
            this.BtnSave.FlatAppearance.BorderSize = 0;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.Location = new System.Drawing.Point(316, 91);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(98, 34);
            this.BtnSave.TabIndex = 51;
            this.BtnSave.Text = "Enregistrer";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnModify
            // 
            this.BtnModify.BackColor = System.Drawing.Color.Orange;
            this.BtnModify.FlatAppearance.BorderSize = 0;
            this.BtnModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModify.Location = new System.Drawing.Point(45, 91);
            this.BtnModify.Name = "BtnModify";
            this.BtnModify.Size = new System.Drawing.Size(85, 34);
            this.BtnModify.TabIndex = 50;
            this.BtnModify.Text = "Modifier";
            this.BtnModify.UseVisualStyleBackColor = false;
            this.BtnModify.Click += new System.EventHandler(this.BtnModify_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.White;
            this.lblID.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(587, 108);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 17);
            this.lblID.TabIndex = 26;
            this.lblID.Text = "ID";
            // 
            // dgrAccountBank
            // 
            this.dgrAccountBank.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrAccountBank.Location = new System.Drawing.Point(15, 156);
            this.dgrAccountBank.Name = "dgrAccountBank";
            this.dgrAccountBank.Size = new System.Drawing.Size(636, 329);
            this.dgrAccountBank.TabIndex = 53;
            this.dgrAccountBank.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrAccountBank_CellContentClick);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.Orange;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Location = new System.Drawing.Point(465, 91);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(85, 34);
            this.btnExport.TabIndex = 59;
            this.btnExport.Text = "Exporter";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // GestionCompteBancaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 522);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.dgrAccountBank);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnModify);
            this.Controls.Add(this.txtDevise);
            this.Controls.Add(this.txtSoldeBank);
            this.Controls.Add(this.txtAuteur);
            this.Controls.Add(this.txtNumCompte);
            this.Controls.Add(this.lblSolde);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblAuteur);
            this.Controls.Add(this.lblGnNm);
            this.Controls.Add(this.lblNumCompte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GestionCompteBancaire";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion des Comptes Bancaires";
            ((System.ComponentModel.ISupportInitialize)(this.dgrAccountBank)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtDevise;
        public System.Windows.Forms.TextBox txtSoldeBank;
        public System.Windows.Forms.TextBox txtAuteur;
        public System.Windows.Forms.TextBox txtNumCompte;
        private System.Windows.Forms.Label lblSolde;
        private System.Windows.Forms.Label lblAuteur;
        private System.Windows.Forms.Label lblGnNm;
        private System.Windows.Forms.Label lblNumCompte;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnModify;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.DataGridView dgrAccountBank;
        private System.Windows.Forms.Button btnExport;
    }
}