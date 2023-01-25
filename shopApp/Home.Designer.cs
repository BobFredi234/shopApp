namespace shopApp
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            this.Menu_home = new System.Windows.Forms.Panel();
            this.login = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.TbPassword = new System.Windows.Forms.TextBox();
            this.LbUid = new System.Windows.Forms.Label();
            this.LbUid_password = new System.Windows.Forms.Label();
            this.TbUsername = new System.Windows.Forms.TextBox();
            this.AppTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            this.Menu_home.SuspendLayout();
            this.login.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu_home
            // 
            this.Menu_home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.Menu_home.Controls.Add(this.login);
            this.Menu_home.Controls.Add(this.AppTitle);
            this.Menu_home.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menu_home.Location = new System.Drawing.Point(0, 0);
            this.Menu_home.Name = "Menu_home";
            this.Menu_home.Size = new System.Drawing.Size(278, 345);
            this.Menu_home.TabIndex = 0;
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.login.Controls.Add(this.label1);
            this.login.Controls.Add(this.btnConnect);
            this.login.Controls.Add(this.TbPassword);
            this.login.Controls.Add(this.LbUid);
            this.login.Controls.Add(this.LbUid_password);
            this.login.Controls.Add(this.TbUsername);
            this.login.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.ForeColor = System.Drawing.Color.DarkOrange;
            this.login.Location = new System.Drawing.Point(12, 80);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(244, 236);
            this.login.TabIndex = 1;
            this.login.TabStop = false;
            this.login.Text = "Login";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(163, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "S\'inscrire";
            this.label1.Click += new System.EventHandler(this.lblInscription);
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.YellowGreen;
            this.btnConnect.FlatAppearance.BorderColor = System.Drawing.Color.Chartreuse;
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.ForeColor = System.Drawing.Color.White;
            this.btnConnect.Location = new System.Drawing.Point(58, 196);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(126, 34);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Se Connecter";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // TbPassword
            // 
            this.TbPassword.Location = new System.Drawing.Point(24, 133);
            this.TbPassword.Name = "TbPassword";
            this.TbPassword.PasswordChar = '*';
            this.TbPassword.Size = new System.Drawing.Size(199, 26);
            this.TbPassword.TabIndex = 1;
            // 
            // LbUid
            // 
            this.LbUid.AutoSize = true;
            this.LbUid.BackColor = System.Drawing.Color.Transparent;
            this.LbUid.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbUid.Location = new System.Drawing.Point(20, 35);
            this.LbUid.Name = "LbUid";
            this.LbUid.Size = new System.Drawing.Size(71, 20);
            this.LbUid.TabIndex = 1;
            this.LbUid.Text = "Username";
            // 
            // LbUid_password
            // 
            this.LbUid_password.AutoSize = true;
            this.LbUid_password.BackColor = System.Drawing.Color.Transparent;
            this.LbUid_password.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbUid_password.Location = new System.Drawing.Point(19, 108);
            this.LbUid_password.Name = "LbUid_password";
            this.LbUid_password.Size = new System.Drawing.Size(69, 20);
            this.LbUid_password.TabIndex = 1;
            this.LbUid_password.Text = "Password";
            // 
            // TbUsername
            // 
            this.TbUsername.Location = new System.Drawing.Point(24, 58);
            this.TbUsername.Name = "TbUsername";
            this.TbUsername.Size = new System.Drawing.Size(199, 26);
            this.TbUsername.TabIndex = 0;
            // 
            // AppTitle
            // 
            this.AppTitle.AutoSize = true;
            this.AppTitle.BackColor = System.Drawing.Color.Transparent;
            this.AppTitle.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.AppTitle.ForeColor = System.Drawing.Color.DarkOrange;
            this.AppTitle.Location = new System.Drawing.Point(76, 9);
            this.AppTitle.Name = "AppTitle";
            this.AppTitle.Size = new System.Drawing.Size(130, 22);
            this.AppTitle.TabIndex = 0;
            this.AppTitle.Text = "Market Place";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Olive;
            this.panel1.Location = new System.Drawing.Point(363, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(38, 141);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Location = new System.Drawing.Point(476, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(109, 41);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSalmon;
            this.panel3.Location = new System.Drawing.Point(363, 257);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(365, 41);
            this.panel3.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(450, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 40);
            this.label2.TabIndex = 0;
            this.label2.Text = "Market Place";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Red;
            this.panel4.Location = new System.Drawing.Point(476, 198);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(227, 10);
            this.panel4.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(740, 1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(45, 34);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(785, 345);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.Menu_home);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Menu_home.ResumeLayout(false);
            this.Menu_home.PerformLayout();
            this.login.ResumeLayout(false);
            this.login.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Menu_home;
        private System.Windows.Forms.Label AppTitle;
        private System.Windows.Forms.Label LbUid;
        private System.Windows.Forms.Label LbUid_password;
        private System.Windows.Forms.GroupBox login;
        private System.Windows.Forms.TextBox TbPassword;
        private System.Windows.Forms.TextBox TbUsername;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
    }
}

