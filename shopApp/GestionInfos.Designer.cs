namespace shopApp
{
    partial class GestionInfos
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
            this.accountInfos = new MetroFramework.Controls.MetroTabControl();
            this.Information = new MetroFramework.Controls.MetroTabPage();
            this.lblID = new System.Windows.Forms.Label();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdMal = new System.Windows.Forms.RadioButton();
            this.rdFemal = new System.Windows.Forms.RadioButton();
            this.panBtInformation = new System.Windows.Forms.Panel();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cbStatut = new System.Windows.Forms.ComboBox();
            this.dtDateUpdate = new System.Windows.Forms.DateTimePicker();
            this.dtDateCreation = new System.Windows.Forms.DateTimePicker();
            this.dtDateNaissance = new System.Windows.Forms.DateTimePicker();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblStatut = new System.Windows.Forms.Label();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblDateUpdate = new System.Windows.Forms.Label();
            this.lblDateCreation = new System.Windows.Forms.Label();
            this.lblDateNaissance = new System.Windows.Forms.Label();
            this.lblSexe = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.AccountBank = new MetroFramework.Controls.MetroTabPage();
            this.cbNumCompte = new MetroFramework.Controls.MetroComboBox();
            this.IDUserAcc = new System.Windows.Forms.Label();
            this.lblIdBank = new System.Windows.Forms.Label();
            this.panelBottomAccountBank = new System.Windows.Forms.Panel();
            this.btnCreateAcc = new System.Windows.Forms.Button();
            this.btnAccountBank = new System.Windows.Forms.Button();
            this.btnDeleteAccountBank = new System.Windows.Forms.Button();
            this.dtUpdateAccountBank = new System.Windows.Forms.DateTimePicker();
            this.dateCreationAcccountBank = new System.Windows.Forms.DateTimePicker();
            this.txtDevise = new System.Windows.Forms.TextBox();
            this.txtSoldeBank = new System.Windows.Forms.TextBox();
            this.txtAuteur = new System.Windows.Forms.TextBox();
            this.lblSolde = new System.Windows.Forms.Label();
            this.lblLastUpdate = new System.Windows.Forms.Label();
            this.lblDateCrd = new System.Windows.Forms.Label();
            this.lblAuteur = new System.Windows.Forms.Label();
            this.lblGnNm = new System.Windows.Forms.Label();
            this.lblNumCompte = new System.Windows.Forms.Label();
            this.accountInfos.SuspendLayout();
            this.Information.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panBtInformation.SuspendLayout();
            this.AccountBank.SuspendLayout();
            this.panelBottomAccountBank.SuspendLayout();
            this.SuspendLayout();
            // 
            // accountInfos
            // 
            this.accountInfos.Controls.Add(this.Information);
            this.accountInfos.Controls.Add(this.AccountBank);
            this.accountInfos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accountInfos.Location = new System.Drawing.Point(0, 0);
            this.accountInfos.Name = "accountInfos";
            this.accountInfos.SelectedIndex = 1;
            this.accountInfos.Size = new System.Drawing.Size(679, 522);
            this.accountInfos.TabIndex = 1;
            this.accountInfos.UseSelectable = true;
            // 
            // Information
            // 
            this.Information.Controls.Add(this.lblID);
            this.Information.Controls.Add(this.txtPassword);
            this.Information.Controls.Add(this.panel2);
            this.Information.Controls.Add(this.panBtInformation);
            this.Information.Controls.Add(this.cbStatut);
            this.Information.Controls.Add(this.dtDateUpdate);
            this.Information.Controls.Add(this.dtDateCreation);
            this.Information.Controls.Add(this.dtDateNaissance);
            this.Information.Controls.Add(this.txtUsername);
            this.Information.Controls.Add(this.txtAdresse);
            this.Information.Controls.Add(this.txtPhone);
            this.Information.Controls.Add(this.txtPrenom);
            this.Information.Controls.Add(this.txtEmail);
            this.Information.Controls.Add(this.txtName);
            this.Information.Controls.Add(this.lblPassword);
            this.Information.Controls.Add(this.lblLogin);
            this.Information.Controls.Add(this.lblStatut);
            this.Information.Controls.Add(this.lblAdresse);
            this.Information.Controls.Add(this.lblPhone);
            this.Information.Controls.Add(this.lblDateUpdate);
            this.Information.Controls.Add(this.lblDateCreation);
            this.Information.Controls.Add(this.lblDateNaissance);
            this.Information.Controls.Add(this.lblSexe);
            this.Information.Controls.Add(this.lblPrenom);
            this.Information.Controls.Add(this.lblEmail);
            this.Information.Controls.Add(this.lblNom);
            this.Information.HorizontalScrollbarBarColor = true;
            this.Information.HorizontalScrollbarHighlightOnWheel = false;
            this.Information.HorizontalScrollbarSize = 10;
            this.Information.Location = new System.Drawing.Point(4, 38);
            this.Information.Name = "Information";
            this.Information.Size = new System.Drawing.Size(671, 480);
            this.Information.TabIndex = 0;
            this.Information.Text = "Informations Personnelles";
            this.Information.VerticalScrollbarBarColor = true;
            this.Information.VerticalScrollbarHighlightOnWheel = false;
            this.Information.VerticalScrollbarSize = 10;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.White;
            this.lblID.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(8, 16);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(25, 20);
            this.lblID.TabIndex = 10;
            this.lblID.Text = "ID";
            this.lblID.Visible = false;
            // 
            // txtPassword
            // 
            // 
            // 
            // 
            this.txtPassword.CustomButton.Image = null;
            this.txtPassword.CustomButton.Location = new System.Drawing.Point(192, 1);
            this.txtPassword.CustomButton.Name = "";
            this.txtPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassword.CustomButton.TabIndex = 1;
            this.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassword.CustomButton.UseSelectable = true;
            this.txtPassword.CustomButton.Visible = false;
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(448, 239);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(214, 23);
            this.txtPassword.TabIndex = 10;
            this.txtPassword.UseSelectable = true;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel2.Controls.Add(this.rdMal);
            this.panel2.Controls.Add(this.rdFemal);
            this.panel2.Location = new System.Drawing.Point(80, 92);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(173, 32);
            this.panel2.TabIndex = 8;
            // 
            // rdMal
            // 
            this.rdMal.AutoSize = true;
            this.rdMal.BackColor = System.Drawing.Color.White;
            this.rdMal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMal.Location = new System.Drawing.Point(4, 6);
            this.rdMal.Name = "rdMal";
            this.rdMal.Size = new System.Drawing.Size(81, 21);
            this.rdMal.TabIndex = 4;
            this.rdMal.TabStop = true;
            this.rdMal.Text = "Masculin";
            this.rdMal.UseVisualStyleBackColor = false;
            this.rdMal.CheckedChanged += new System.EventHandler(this.rdMal_CheckedChanged);
            // 
            // rdFemal
            // 
            this.rdFemal.AutoSize = true;
            this.rdFemal.BackColor = System.Drawing.Color.White;
            this.rdFemal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdFemal.Location = new System.Drawing.Point(90, 6);
            this.rdFemal.Name = "rdFemal";
            this.rdFemal.Size = new System.Drawing.Size(75, 21);
            this.rdFemal.TabIndex = 5;
            this.rdFemal.TabStop = true;
            this.rdFemal.Text = "Féminin";
            this.rdFemal.UseVisualStyleBackColor = false;
            this.rdFemal.CheckedChanged += new System.EventHandler(this.rdFemal_CheckedChanged);
            // 
            // panBtInformation
            // 
            this.panBtInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panBtInformation.Controls.Add(this.btnCreateUser);
            this.panBtInformation.Controls.Add(this.btnUpdateUser);
            this.panBtInformation.Controls.Add(this.btnDelete);
            this.panBtInformation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panBtInformation.Location = new System.Drawing.Point(0, 400);
            this.panBtInformation.Name = "panBtInformation";
            this.panBtInformation.Size = new System.Drawing.Size(671, 80);
            this.panBtInformation.TabIndex = 8;
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCreateUser.FlatAppearance.BorderSize = 0;
            this.btnCreateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateUser.ForeColor = System.Drawing.Color.White;
            this.btnCreateUser.Location = new System.Drawing.Point(84, 20);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(117, 42);
            this.btnCreateUser.TabIndex = 14;
            this.btnCreateUser.Text = "Créer un Compte Personnel";
            this.btnCreateUser.UseVisualStyleBackColor = false;
            this.btnCreateUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.BackColor = System.Drawing.Color.Brown;
            this.btnUpdateUser.FlatAppearance.BorderSize = 0;
            this.btnUpdateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateUser.ForeColor = System.Drawing.Color.White;
            this.btnUpdateUser.Location = new System.Drawing.Point(251, 20);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(117, 42);
            this.btnUpdateUser.TabIndex = 14;
            this.btnUpdateUser.Text = "Mise à jour";
            this.btnUpdateUser.UseVisualStyleBackColor = false;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(431, 20);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(114, 42);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Supprimer";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cbStatut
            // 
            this.cbStatut.FormattingEnabled = true;
            this.cbStatut.Items.AddRange(new object[] {
            "Standard",
            "Administrator"});
            this.cbStatut.Location = new System.Drawing.Point(95, 294);
            this.cbStatut.Name = "cbStatut";
            this.cbStatut.Size = new System.Drawing.Size(177, 21);
            this.cbStatut.TabIndex = 11;
            // 
            // dtDateUpdate
            // 
            this.dtDateUpdate.Enabled = false;
            this.dtDateUpdate.Location = new System.Drawing.Point(448, 340);
            this.dtDateUpdate.Name = "dtDateUpdate";
            this.dtDateUpdate.Size = new System.Drawing.Size(216, 20);
            this.dtDateUpdate.TabIndex = 13;
            // 
            // dtDateCreation
            // 
            this.dtDateCreation.Location = new System.Drawing.Point(448, 294);
            this.dtDateCreation.Name = "dtDateCreation";
            this.dtDateCreation.Size = new System.Drawing.Size(215, 20);
            this.dtDateCreation.TabIndex = 12;
            // 
            // dtDateNaissance
            // 
            this.dtDateNaissance.Location = new System.Drawing.Point(448, 97);
            this.dtDateNaissance.Name = "dtDateNaissance";
            this.dtDateNaissance.Size = new System.Drawing.Size(215, 20);
            this.dtDateNaissance.TabIndex = 6;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(96, 240);
            this.txtUsername.MaxLength = 10;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(176, 23);
            this.txtUsername.TabIndex = 9;
            // 
            // txtAdresse
            // 
            this.txtAdresse.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdresse.Location = new System.Drawing.Point(81, 136);
            this.txtAdresse.Multiline = true;
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(191, 89);
            this.txtAdresse.TabIndex = 7;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(448, 165);
            this.txtPhone.MaxLength = 9;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(215, 23);
            this.txtPhone.TabIndex = 8;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrenom.Location = new System.Drawing.Point(373, 43);
            this.txtPrenom.MaxLength = 30;
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(290, 23);
            this.txtPrenom.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(95, 340);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(177, 23);
            this.txtEmail.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(80, 43);
            this.txtName.MaxLength = 20;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(173, 23);
            this.txtName.TabIndex = 2;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.White;
            this.lblPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(336, 242);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(101, 17);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Mot de Passe :";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.White;
            this.lblLogin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(8, 242);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(79, 17);
            this.lblLogin.TabIndex = 2;
            this.lblLogin.Text = "Username :";
            // 
            // lblStatut
            // 
            this.lblStatut.AutoSize = true;
            this.lblStatut.BackColor = System.Drawing.Color.White;
            this.lblStatut.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatut.Location = new System.Drawing.Point(8, 296);
            this.lblStatut.Name = "lblStatut";
            this.lblStatut.Size = new System.Drawing.Size(50, 17);
            this.lblStatut.TabIndex = 2;
            this.lblStatut.Text = "Statut:";
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.BackColor = System.Drawing.Color.White;
            this.lblAdresse.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdresse.Location = new System.Drawing.Point(8, 171);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(64, 17);
            this.lblAdresse.TabIndex = 2;
            this.lblAdresse.Text = "Adresse :";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.BackColor = System.Drawing.Color.White;
            this.lblPhone.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(278, 171);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(159, 17);
            this.lblPhone.TabIndex = 2;
            this.lblPhone.Text = "Numéro de Téléphone :";
            // 
            // lblDateUpdate
            // 
            this.lblDateUpdate.AutoSize = true;
            this.lblDateUpdate.BackColor = System.Drawing.Color.White;
            this.lblDateUpdate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateUpdate.Location = new System.Drawing.Point(288, 343);
            this.lblDateUpdate.Name = "lblDateUpdate";
            this.lblDateUpdate.Size = new System.Drawing.Size(141, 17);
            this.lblDateUpdate.TabIndex = 2;
            this.lblDateUpdate.Text = "Dernière Mise à jour :";
            // 
            // lblDateCreation
            // 
            this.lblDateCreation.AutoSize = true;
            this.lblDateCreation.BackColor = System.Drawing.Color.White;
            this.lblDateCreation.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateCreation.Location = new System.Drawing.Point(299, 296);
            this.lblDateCreation.Name = "lblDateCreation";
            this.lblDateCreation.Size = new System.Drawing.Size(130, 17);
            this.lblDateCreation.TabIndex = 2;
            this.lblDateCreation.Text = "Date de Création :";
            // 
            // lblDateNaissance
            // 
            this.lblDateNaissance.AutoSize = true;
            this.lblDateNaissance.BackColor = System.Drawing.Color.White;
            this.lblDateNaissance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateNaissance.Location = new System.Drawing.Point(278, 100);
            this.lblDateNaissance.Name = "lblDateNaissance";
            this.lblDateNaissance.Size = new System.Drawing.Size(138, 17);
            this.lblDateNaissance.TabIndex = 2;
            this.lblDateNaissance.Text = "Date de Naissance :";
            // 
            // lblSexe
            // 
            this.lblSexe.AutoSize = true;
            this.lblSexe.BackColor = System.Drawing.Color.White;
            this.lblSexe.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexe.Location = new System.Drawing.Point(8, 100);
            this.lblSexe.Name = "lblSexe";
            this.lblSexe.Size = new System.Drawing.Size(44, 17);
            this.lblSexe.TabIndex = 2;
            this.lblSexe.Text = "Sexe :";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.BackColor = System.Drawing.Color.White;
            this.lblPrenom.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenom.Location = new System.Drawing.Point(278, 46);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(66, 17);
            this.lblPrenom.TabIndex = 2;
            this.lblPrenom.Text = "Prénom :";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.White;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(8, 340);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(51, 17);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email :";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.BackColor = System.Drawing.Color.White;
            this.lblNom.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(8, 46);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(48, 17);
            this.lblNom.TabIndex = 2;
            this.lblNom.Text = "Nom :";
            // 
            // AccountBank
            // 
            this.AccountBank.Controls.Add(this.cbNumCompte);
            this.AccountBank.Controls.Add(this.IDUserAcc);
            this.AccountBank.Controls.Add(this.lblIdBank);
            this.AccountBank.Controls.Add(this.panelBottomAccountBank);
            this.AccountBank.Controls.Add(this.dtUpdateAccountBank);
            this.AccountBank.Controls.Add(this.dateCreationAcccountBank);
            this.AccountBank.Controls.Add(this.txtDevise);
            this.AccountBank.Controls.Add(this.txtSoldeBank);
            this.AccountBank.Controls.Add(this.txtAuteur);
            this.AccountBank.Controls.Add(this.lblSolde);
            this.AccountBank.Controls.Add(this.lblLastUpdate);
            this.AccountBank.Controls.Add(this.lblDateCrd);
            this.AccountBank.Controls.Add(this.lblAuteur);
            this.AccountBank.Controls.Add(this.lblGnNm);
            this.AccountBank.Controls.Add(this.lblNumCompte);
            this.AccountBank.HorizontalScrollbarBarColor = true;
            this.AccountBank.HorizontalScrollbarHighlightOnWheel = false;
            this.AccountBank.HorizontalScrollbarSize = 10;
            this.AccountBank.Location = new System.Drawing.Point(4, 38);
            this.AccountBank.Name = "AccountBank";
            this.AccountBank.Size = new System.Drawing.Size(671, 480);
            this.AccountBank.TabIndex = 1;
            this.AccountBank.Text = "Compte Bancaire";
            this.AccountBank.VerticalScrollbarBarColor = true;
            this.AccountBank.VerticalScrollbarHighlightOnWheel = false;
            this.AccountBank.VerticalScrollbarSize = 10;
            // 
            // cbNumCompte
            // 
            this.cbNumCompte.FormattingEnabled = true;
            this.cbNumCompte.ItemHeight = 23;
            this.cbNumCompte.Location = new System.Drawing.Point(205, 23);
            this.cbNumCompte.Name = "cbNumCompte";
            this.cbNumCompte.Size = new System.Drawing.Size(267, 29);
            this.cbNumCompte.TabIndex = 25;
            this.cbNumCompte.UseSelectable = true;
            this.cbNumCompte.SelectedIndexChanged += new System.EventHandler(this.cbNumCompte_SelectedIndexChanged);
            // 
            // IDUserAcc
            // 
            this.IDUserAcc.AutoSize = true;
            this.IDUserAcc.BackColor = System.Drawing.Color.White;
            this.IDUserAcc.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDUserAcc.Location = new System.Drawing.Point(478, 89);
            this.IDUserAcc.Name = "IDUserAcc";
            this.IDUserAcc.Size = new System.Drawing.Size(25, 20);
            this.IDUserAcc.TabIndex = 24;
            this.IDUserAcc.Text = "ID";
            // 
            // lblIdBank
            // 
            this.lblIdBank.AutoSize = true;
            this.lblIdBank.BackColor = System.Drawing.Color.White;
            this.lblIdBank.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdBank.Location = new System.Drawing.Point(7, 341);
            this.lblIdBank.Name = "lblIdBank";
            this.lblIdBank.Size = new System.Drawing.Size(25, 20);
            this.lblIdBank.TabIndex = 24;
            this.lblIdBank.Text = "ID";
            // 
            // panelBottomAccountBank
            // 
            this.panelBottomAccountBank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panelBottomAccountBank.Controls.Add(this.btnCreateAcc);
            this.panelBottomAccountBank.Controls.Add(this.btnAccountBank);
            this.panelBottomAccountBank.Controls.Add(this.btnDeleteAccountBank);
            this.panelBottomAccountBank.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottomAccountBank.Location = new System.Drawing.Point(0, 400);
            this.panelBottomAccountBank.Name = "panelBottomAccountBank";
            this.panelBottomAccountBank.Size = new System.Drawing.Size(671, 80);
            this.panelBottomAccountBank.TabIndex = 22;
            // 
            // btnCreateAcc
            // 
            this.btnCreateAcc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCreateAcc.FlatAppearance.BorderSize = 0;
            this.btnCreateAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateAcc.ForeColor = System.Drawing.Color.White;
            this.btnCreateAcc.Location = new System.Drawing.Point(111, 20);
            this.btnCreateAcc.Name = "btnCreateAcc";
            this.btnCreateAcc.Size = new System.Drawing.Size(117, 42);
            this.btnCreateAcc.TabIndex = 23;
            this.btnCreateAcc.Text = "Créer un compte Bancaire";
            this.btnCreateAcc.UseVisualStyleBackColor = false;
            this.btnCreateAcc.Click += new System.EventHandler(this.btnCreateAcBank_Click);
            // 
            // btnAccountBank
            // 
            this.btnAccountBank.BackColor = System.Drawing.Color.Brown;
            this.btnAccountBank.FlatAppearance.BorderSize = 0;
            this.btnAccountBank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccountBank.ForeColor = System.Drawing.Color.White;
            this.btnAccountBank.Location = new System.Drawing.Point(256, 20);
            this.btnAccountBank.Name = "btnAccountBank";
            this.btnAccountBank.Size = new System.Drawing.Size(117, 42);
            this.btnAccountBank.TabIndex = 24;
            this.btnAccountBank.Text = "Mise à jour";
            this.btnAccountBank.UseVisualStyleBackColor = false;
            this.btnAccountBank.Click += new System.EventHandler(this.btnUpdateAccountBank);
            // 
            // btnDeleteAccountBank
            // 
            this.btnDeleteAccountBank.BackColor = System.Drawing.Color.Red;
            this.btnDeleteAccountBank.FlatAppearance.BorderSize = 0;
            this.btnDeleteAccountBank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAccountBank.ForeColor = System.Drawing.Color.White;
            this.btnDeleteAccountBank.Location = new System.Drawing.Point(399, 20);
            this.btnDeleteAccountBank.Name = "btnDeleteAccountBank";
            this.btnDeleteAccountBank.Size = new System.Drawing.Size(114, 42);
            this.btnDeleteAccountBank.TabIndex = 25;
            this.btnDeleteAccountBank.Text = "Supprimer";
            this.btnDeleteAccountBank.UseVisualStyleBackColor = false;
            this.btnDeleteAccountBank.Click += new System.EventHandler(this.btnDeleteAccountBank_Click);
            // 
            // dtUpdateAccountBank
            // 
            this.dtUpdateAccountBank.Enabled = false;
            this.dtUpdateAccountBank.Location = new System.Drawing.Point(205, 252);
            this.dtUpdateAccountBank.Name = "dtUpdateAccountBank";
            this.dtUpdateAccountBank.Size = new System.Drawing.Size(267, 20);
            this.dtUpdateAccountBank.TabIndex = 22;
            // 
            // dateCreationAcccountBank
            // 
            this.dateCreationAcccountBank.Enabled = false;
            this.dateCreationAcccountBank.Location = new System.Drawing.Point(205, 199);
            this.dateCreationAcccountBank.Name = "dateCreationAcccountBank";
            this.dateCreationAcccountBank.Size = new System.Drawing.Size(267, 20);
            this.dateCreationAcccountBank.TabIndex = 21;
            // 
            // txtDevise
            // 
            this.txtDevise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDevise.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDevise.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDevise.ForeColor = System.Drawing.Color.White;
            this.txtDevise.Location = new System.Drawing.Point(205, 143);
            this.txtDevise.MaxLength = 3;
            this.txtDevise.Multiline = true;
            this.txtDevise.Name = "txtDevise";
            this.txtDevise.Size = new System.Drawing.Size(50, 23);
            this.txtDevise.TabIndex = 19;
            // 
            // txtSoldeBank
            // 
            this.txtSoldeBank.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoldeBank.Location = new System.Drawing.Point(256, 143);
            this.txtSoldeBank.MaxLength = 10;
            this.txtSoldeBank.Name = "txtSoldeBank";
            this.txtSoldeBank.Size = new System.Drawing.Size(216, 23);
            this.txtSoldeBank.TabIndex = 20;
            // 
            // txtAuteur
            // 
            this.txtAuteur.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuteur.Location = new System.Drawing.Point(205, 87);
            this.txtAuteur.MaxLength = 30;
            this.txtAuteur.Name = "txtAuteur";
            this.txtAuteur.Size = new System.Drawing.Size(267, 23);
            this.txtAuteur.TabIndex = 18;
            // 
            // lblSolde
            // 
            this.lblSolde.AutoSize = true;
            this.lblSolde.BackColor = System.Drawing.Color.White;
            this.lblSolde.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSolde.Location = new System.Drawing.Point(25, 144);
            this.lblSolde.Name = "lblSolde";
            this.lblSolde.Size = new System.Drawing.Size(51, 17);
            this.lblSolde.TabIndex = 12;
            this.lblSolde.Text = "Solde :";
            // 
            // lblLastUpdate
            // 
            this.lblLastUpdate.AutoSize = true;
            this.lblLastUpdate.BackColor = System.Drawing.Color.White;
            this.lblLastUpdate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastUpdate.Location = new System.Drawing.Point(25, 254);
            this.lblLastUpdate.Name = "lblLastUpdate";
            this.lblLastUpdate.Size = new System.Drawing.Size(141, 17);
            this.lblLastUpdate.TabIndex = 13;
            this.lblLastUpdate.Text = "Dernière Mise à jour :";
            // 
            // lblDateCrd
            // 
            this.lblDateCrd.AutoSize = true;
            this.lblDateCrd.BackColor = System.Drawing.Color.White;
            this.lblDateCrd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateCrd.Location = new System.Drawing.Point(25, 199);
            this.lblDateCrd.Name = "lblDateCrd";
            this.lblDateCrd.Size = new System.Drawing.Size(130, 17);
            this.lblDateCrd.TabIndex = 14;
            this.lblDateCrd.Text = "Date de Création :";
            // 
            // lblAuteur
            // 
            this.lblAuteur.AutoSize = true;
            this.lblAuteur.BackColor = System.Drawing.Color.White;
            this.lblAuteur.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuteur.Location = new System.Drawing.Point(25, 89);
            this.lblAuteur.Name = "lblAuteur";
            this.lblAuteur.Size = new System.Drawing.Size(64, 17);
            this.lblAuteur.TabIndex = 15;
            this.lblAuteur.Text = "Titulaire :";
            // 
            // lblGnNm
            // 
            this.lblGnNm.AutoSize = true;
            this.lblGnNm.BackColor = System.Drawing.Color.White;
            this.lblGnNm.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGnNm.ForeColor = System.Drawing.Color.Salmon;
            this.lblGnNm.Location = new System.Drawing.Point(501, 32);
            this.lblGnNm.Name = "lblGnNm";
            this.lblGnNm.Size = new System.Drawing.Size(163, 20);
            this.lblGnNm.TabIndex = 17;
            this.lblGnNm.Text = "[Générer un numéro]";
            this.lblGnNm.Click += new System.EventHandler(this.getNewNumero);
            // 
            // lblNumCompte
            // 
            this.lblNumCompte.AutoSize = true;
            this.lblNumCompte.BackColor = System.Drawing.Color.White;
            this.lblNumCompte.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumCompte.Location = new System.Drawing.Point(25, 34);
            this.lblNumCompte.Name = "lblNumCompte";
            this.lblNumCompte.Size = new System.Drawing.Size(148, 17);
            this.lblNumCompte.TabIndex = 16;
            this.lblNumCompte.Text = "Numéro de Compte :";
            // 
            // GestionInfos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 522);
            this.ControlBox = false;
            this.Controls.Add(this.accountInfos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GestionInfos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion Informations";
            this.accountInfos.ResumeLayout(false);
            this.Information.ResumeLayout(false);
            this.Information.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panBtInformation.ResumeLayout(false);
            this.AccountBank.ResumeLayout(false);
            this.AccountBank.PerformLayout();
            this.panelBottomAccountBank.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl accountInfos;
        private MetroFramework.Controls.MetroTabPage Information;
        private MetroFramework.Controls.MetroTabPage AccountBank;
        private System.Windows.Forms.Label lblStatut;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblDateNaissance;
        private System.Windows.Forms.Label lblSexe;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panBtInformation;
        public System.Windows.Forms.DateTimePicker dtDateNaissance;
        public System.Windows.Forms.RadioButton rdFemal;
        public System.Windows.Forms.RadioButton rdMal;
        public System.Windows.Forms.TextBox txtAdresse;
        public System.Windows.Forms.TextBox txtPhone;
        public System.Windows.Forms.TextBox txtPrenom;
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.TextBox txtUsername;
        public System.Windows.Forms.ComboBox cbStatut;
        public MetroFramework.Controls.MetroTextBox txtPassword;
        public System.Windows.Forms.Label lblID;
        public System.Windows.Forms.DateTimePicker dtDateCreation;
        private System.Windows.Forms.Label lblDateCreation;
        public System.Windows.Forms.DateTimePicker dtDateUpdate;
        private System.Windows.Forms.Label lblDateUpdate;
        public System.Windows.Forms.Label lblIdBank;
        private System.Windows.Forms.Panel panelBottomAccountBank;
        public System.Windows.Forms.DateTimePicker dtUpdateAccountBank;
        public System.Windows.Forms.DateTimePicker dateCreationAcccountBank;
        public System.Windows.Forms.TextBox txtAuteur;
        private System.Windows.Forms.Label lblSolde;
        private System.Windows.Forms.Label lblLastUpdate;
        private System.Windows.Forms.Label lblDateCrd;
        private System.Windows.Forms.Label lblAuteur;
        private System.Windows.Forms.Label lblNumCompte;
        private System.Windows.Forms.Label lblGnNm;
        public System.Windows.Forms.TextBox txtSoldeBank;
        public System.Windows.Forms.TextBox txtDevise;
        public System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        public MetroFramework.Controls.MetroComboBox cbNumCompte;
        public System.Windows.Forms.Label IDUserAcc;
        public System.Windows.Forms.Button btnAccountBank;
        public System.Windows.Forms.Button btnCreateAcc;
        public System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.Button btnUpdateUser;
        public System.Windows.Forms.Button btnCreateUser;
        public System.Windows.Forms.Button btnDeleteAccountBank;
    }
}