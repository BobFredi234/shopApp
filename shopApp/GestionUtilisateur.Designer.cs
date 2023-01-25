namespace shopApp
{
    partial class GestionUtilisateur
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionUtilisateur));
            this.dgrUser = new System.Windows.Forms.DataGridView();
            this.BtnExport = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnModify = new System.Windows.Forms.Button();
            this.dateNaissance = new System.Windows.Forms.DateTimePicker();
            this.nom = new System.Windows.Forms.TextBox();
            this.prenom = new System.Windows.Forms.TextBox();
            this.adresse = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.TextBox();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LbDateNaissance = new System.Windows.Forms.Label();
            this.LbNom = new System.Windows.Forms.Label();
            this.lblSexe = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.cbSexe = new System.Windows.Forms.ComboBox();
            this.IdUser = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.lblStatut = new System.Windows.Forms.Label();
            this.cbStatut = new System.Windows.Forms.ComboBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.picPassword = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgrUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrUser
            // 
            this.dgrUser.AllowUserToAddRows = false;
            this.dgrUser.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgrUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrUser.Location = new System.Drawing.Point(5, 247);
            this.dgrUser.Name = "dgrUser";
            this.dgrUser.RowHeadersVisible = false;
            this.dgrUser.Size = new System.Drawing.Size(686, 311);
            this.dgrUser.TabIndex = 51;
            this.dgrUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrUser_CellContentClick);
            // 
            // BtnExport
            // 
            this.BtnExport.BackColor = System.Drawing.Color.DarkOrange;
            this.BtnExport.FlatAppearance.BorderSize = 0;
            this.BtnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExport.Location = new System.Drawing.Point(589, 207);
            this.BtnExport.Name = "BtnExport";
            this.BtnExport.Size = new System.Drawing.Size(100, 34);
            this.BtnExport.TabIndex = 50;
            this.BtnExport.Text = "Exporter";
            this.BtnExport.UseVisualStyleBackColor = false;
            this.BtnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.Red;
            this.BtnDelete.FlatAppearance.BorderSize = 0;
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.Location = new System.Drawing.Point(3, 150);
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
            this.BtnSave.Location = new System.Drawing.Point(4, 194);
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
            this.BtnModify.Location = new System.Drawing.Point(3, 101);
            this.BtnModify.Name = "BtnModify";
            this.BtnModify.Size = new System.Drawing.Size(85, 34);
            this.BtnModify.TabIndex = 47;
            this.BtnModify.Text = "Modifier";
            this.BtnModify.UseVisualStyleBackColor = false;
            this.BtnModify.Click += new System.EventHandler(this.BtnModify_Click);
            // 
            // dateNaissance
            // 
            this.dateNaissance.Location = new System.Drawing.Point(134, 65);
            this.dateNaissance.Name = "dateNaissance";
            this.dateNaissance.Size = new System.Drawing.Size(163, 20);
            this.dateNaissance.TabIndex = 46;
            // 
            // nom
            // 
            this.nom.Location = new System.Drawing.Point(47, 10);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(145, 20);
            this.nom.TabIndex = 45;
            // 
            // prenom
            // 
            this.prenom.Location = new System.Drawing.Point(325, 10);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(176, 20);
            this.prenom.TabIndex = 44;
            // 
            // adresse
            // 
            this.adresse.Location = new System.Drawing.Point(378, 46);
            this.adresse.Multiline = true;
            this.adresse.Name = "adresse";
            this.adresse.Size = new System.Drawing.Size(174, 59);
            this.adresse.TabIndex = 43;
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(134, 138);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(147, 20);
            this.login.TabIndex = 42;
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Location = new System.Drawing.Point(313, 69);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(51, 13);
            this.lblAdresse.TabIndex = 40;
            this.lblAdresse.Text = "Adresse :";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(131, 122);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(61, 13);
            this.lblUser.TabIndex = 39;
            this.lblUser.Text = "Username :";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(270, 14);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(49, 13);
            this.lblPrenom.TabIndex = 38;
            this.lblPrenom.Text = "Prénom :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(280, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "Liste des utilisateurs :";
            // 
            // LbDateNaissance
            // 
            this.LbDateNaissance.AutoSize = true;
            this.LbDateNaissance.Location = new System.Drawing.Point(6, 69);
            this.LbDateNaissance.Name = "LbDateNaissance";
            this.LbDateNaissance.Size = new System.Drawing.Size(104, 13);
            this.LbDateNaissance.TabIndex = 36;
            this.LbDateNaissance.Text = "Date de Naissance :";
            // 
            // LbNom
            // 
            this.LbNom.AutoSize = true;
            this.LbNom.Location = new System.Drawing.Point(6, 14);
            this.LbNom.Name = "LbNom";
            this.LbNom.Size = new System.Drawing.Size(35, 13);
            this.LbNom.TabIndex = 34;
            this.LbNom.Text = "Nom :";
            // 
            // lblSexe
            // 
            this.lblSexe.AutoSize = true;
            this.lblSexe.Location = new System.Drawing.Point(529, 17);
            this.lblSexe.Name = "lblSexe";
            this.lblSexe.Size = new System.Drawing.Size(37, 13);
            this.lblSexe.TabIndex = 38;
            this.lblSexe.Text = "Sexe :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(570, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "numéro de téléphone :";
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(570, 71);
            this.txtphone.MaxLength = 9;
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(113, 20);
            this.txtphone.TabIndex = 44;
            // 
            // cbSexe
            // 
            this.cbSexe.FormattingEnabled = true;
            this.cbSexe.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cbSexe.Location = new System.Drawing.Point(572, 13);
            this.cbSexe.Name = "cbSexe";
            this.cbSexe.Size = new System.Drawing.Size(111, 21);
            this.cbSexe.TabIndex = 52;
            // 
            // IdUser
            // 
            this.IdUser.AutoSize = true;
            this.IdUser.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdUser.Location = new System.Drawing.Point(660, 172);
            this.IdUser.Name = "IdUser";
            this.IdUser.Size = new System.Drawing.Size(25, 20);
            this.IdUser.TabIndex = 53;
            this.IdUser.Text = "ID";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(313, 122);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(59, 13);
            this.lblPassword.TabIndex = 39;
            this.lblPassword.Text = "Password :";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(316, 138);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(147, 20);
            this.password.TabIndex = 42;
            this.password.UseSystemPasswordChar = true;
            // 
            // lblStatut
            // 
            this.lblStatut.AutoSize = true;
            this.lblStatut.Location = new System.Drawing.Point(548, 122);
            this.lblStatut.Name = "lblStatut";
            this.lblStatut.Size = new System.Drawing.Size(41, 13);
            this.lblStatut.TabIndex = 38;
            this.lblStatut.Text = "Statut :";
            // 
            // cbStatut
            // 
            this.cbStatut.FormattingEnabled = true;
            this.cbStatut.Items.AddRange(new object[] {
            "Standard",
            "Administrator"});
            this.cbStatut.Location = new System.Drawing.Point(551, 138);
            this.cbStatut.Name = "cbStatut";
            this.cbStatut.Size = new System.Drawing.Size(132, 21);
            this.cbStatut.TabIndex = 52;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(190, 184);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(38, 13);
            this.lblEmail.TabIndex = 39;
            this.lblEmail.Text = "Email :";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(273, 180);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(262, 20);
            this.email.TabIndex = 42;
            // 
            // picPassword
            // 
            this.picPassword.BackColor = System.Drawing.Color.Black;
            this.picPassword.Image = ((System.Drawing.Image)(resources.GetObject("picPassword.Image")));
            this.picPassword.Location = new System.Drawing.Point(463, 138);
            this.picPassword.Name = "picPassword";
            this.picPassword.Size = new System.Drawing.Size(21, 21);
            this.picPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPassword.TabIndex = 54;
            this.picPassword.TabStop = false;
            this.picPassword.Tag = "";
            this.picPassword.Click += new System.EventHandler(this.PicPassword_Click);
            // 
            // GestionUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 561);
            this.Controls.Add(this.picPassword);
            this.Controls.Add(this.IdUser);
            this.Controls.Add(this.cbStatut);
            this.Controls.Add(this.cbSexe);
            this.Controls.Add(this.dgrUser);
            this.Controls.Add(this.BtnExport);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnModify);
            this.Controls.Add(this.dateNaissance);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.prenom);
            this.Controls.Add(this.adresse);
            this.Controls.Add(this.password);
            this.Controls.Add(this.email);
            this.Controls.Add(this.login);
            this.Controls.Add(this.lblAdresse);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblStatut);
            this.Controls.Add(this.lblSexe);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LbDateNaissance);
            this.Controls.Add(this.LbNom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GestionUtilisateur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion des Utilisateurs";
            ((System.ComponentModel.ISupportInitialize)(this.dgrUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateNaissance;
        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.TextBox prenom;
        private System.Windows.Forms.TextBox adresse;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LbDateNaissance;
        private System.Windows.Forms.Label LbNom;
        private System.Windows.Forms.DataGridView dgrUser;
        private System.Windows.Forms.Label lblSexe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.ComboBox cbSexe;
        public System.Windows.Forms.Button BtnExport;
        public System.Windows.Forms.Button BtnDelete;
        public System.Windows.Forms.Button BtnSave;
        public System.Windows.Forms.Button BtnModify;
        private System.Windows.Forms.Label IdUser;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label lblStatut;
        private System.Windows.Forms.ComboBox cbStatut;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.PictureBox picPassword;
    }
}