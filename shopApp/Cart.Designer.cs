namespace shopApp
{
    partial class Cart
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
            this.lblID = new System.Windows.Forms.Label();
            this.numCompte = new System.Windows.Forms.TextBox();
            this.btnPayer = new System.Windows.Forms.Button();
            this.dgrCart = new System.Windows.Forms.DataGridView();
            this.Tprix = new System.Windows.Forms.Label();
            this.IDCompteB = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgrCart)).BeginInit();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(12, 21);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(172, 21);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "Numéro de compte :";
            // 
            // numCompte
            // 
            this.numCompte.Location = new System.Drawing.Point(215, 16);
            this.numCompte.Multiline = true;
            this.numCompte.Name = "numCompte";
            this.numCompte.Size = new System.Drawing.Size(189, 31);
            this.numCompte.TabIndex = 0;
            this.numCompte.TextChanged += new System.EventHandler(this.numCompte_TextChanged);
            // 
            // btnPayer
            // 
            this.btnPayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPayer.FlatAppearance.BorderSize = 0;
            this.btnPayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayer.ForeColor = System.Drawing.Color.White;
            this.btnPayer.Location = new System.Drawing.Point(481, 12);
            this.btnPayer.Name = "btnPayer";
            this.btnPayer.Size = new System.Drawing.Size(133, 39);
            this.btnPayer.TabIndex = 2;
            this.btnPayer.Text = "PAYER";
            this.btnPayer.UseVisualStyleBackColor = false;
            // 
            // dgrCart
            // 
            this.dgrCart.AllowUserToAddRows = false;
            this.dgrCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrCart.Location = new System.Drawing.Point(16, 68);
            this.dgrCart.Name = "dgrCart";
            this.dgrCart.RowHeadersVisible = false;
            this.dgrCart.Size = new System.Drawing.Size(598, 391);
            this.dgrCart.TabIndex = 3;
            // 
            // Tprix
            // 
            this.Tprix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Tprix.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tprix.ForeColor = System.Drawing.Color.White;
            this.Tprix.Location = new System.Drawing.Point(453, 462);
            this.Tprix.Name = "Tprix";
            this.Tprix.Size = new System.Drawing.Size(161, 39);
            this.Tprix.TabIndex = 1;
            this.Tprix.Text = "NET A PAYER";
            this.Tprix.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IDCompteB
            // 
            this.IDCompteB.AutoSize = true;
            this.IDCompteB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDCompteB.Location = new System.Drawing.Point(410, 21);
            this.IDCompteB.Name = "IDCompteB";
            this.IDCompteB.Size = new System.Drawing.Size(27, 21);
            this.IDCompteB.TabIndex = 1;
            this.IDCompteB.Text = "ID";
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 533);
            this.ControlBox = false;
            this.Controls.Add(this.dgrCart);
            this.Controls.Add(this.btnPayer);
            this.Controls.Add(this.Tprix);
            this.Controls.Add(this.IDCompteB);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.numCompte);
            this.Name = "Cart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cart";
            ((System.ComponentModel.ISupportInitialize)(this.dgrCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox numCompte;
        private System.Windows.Forms.Button btnPayer;
        private System.Windows.Forms.DataGridView dgrCart;
        private System.Windows.Forms.Label Tprix;
        private System.Windows.Forms.Label IDCompteB;
    }
}