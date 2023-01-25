using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace shopApp
{
    public partial class Home : Form
    {
        BDConnexion bd;
        SqlDataReader dr;
        int cmpt = 0;

        readonly int X_pl1, Y_pl1, X_pl2, Y_pl2;

        public Home()
        {
            InitializeComponent();
            bd = new BDConnexion();
            X_pl1 = panel1.Size.Width;
            Y_pl1 = panel1.Size.Height;
            X_pl2 = panel2.Size.Width;
            Y_pl2 = panel2.Size.Height;

            this.timer1.Start();
        }

        private void lblInscription(object sender, EventArgs e)
        {
            Hide();
            GestionInfos infos = new GestionInfos(new Dashboard());
            infos.lblID.Text = "ID";
            infos.cbStatut.Items.Clear();
            infos.cbStatut.Items.Add("Standard");
            infos.btnAccountBank.Enabled = false;
            infos.btnUpdateUser.Enabled = false;
            infos.btnDelete.Enabled = false;
            infos.btnDeleteAccountBank.Enabled = true;
            infos.txtDevise.Text = "XAF";

            infos.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Fermer la fenêtre
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            try
            {
                if (!TbUsername.Text.Equals("") && !TbPassword.Text.Equals(""))
                {
                    bd.cn.Open();
                    bd.cmd.CommandText = "select * from utilisateur where username = '" + TbUsername.Text + "' and password = '" + TbPassword.Text + "'";
                    dr = bd.cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            if (dr["password"].Equals(TbPassword.Text))
                            {
                                string username = dr["username"].ToString().ToUpper();
                                Hide();
                                Dashboard FormUser = new Dashboard();
                                FormUser.lblId.Text = dr["idUser"].ToString();
                                FormUser.lblUsername.Text = username;
                                
                                FormUser.lblStatut.Text = dr["statut"].ToString();
                                FormUser.LoadCommandes();
                                if (FormUser.lblStatut.Text == "Standard")
                                {
                                    FormUser.PanelMenu.Controls.Remove(FormUser.btnAccount);
                                    FormUser.PanelMenu.Controls.Remove(FormUser.btnBarCodes);
                                    FormUser.PanelMenu.Controls.Remove(FormUser.btnCategories);
                                    FormUser.PanelMenu.Controls.Remove(FormUser.btnOrder);
                                    FormUser.PanelMenu.Controls.Remove(FormUser.btnProduct);
                                    FormUser.PanelMenu.Controls.Remove(FormUser.btnUser);
                                    FormUser.picLogo.Image = Image.FromFile("C:\\Users\\Bobi\\Desktop\\TP Csharp\\shopApp\\shopApp\\Resources\\Images\\find_user_female_100px.png");
                                }
                                FormUser.Show();
                            }
                            else
                            {
                                MessageBox.Show("Mot de passe incorrect !!");
                            }
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("This user doesn't exists !!");
                    }
                    bd.cn.Close();
                }
                else
                    MessageBox.Show("Veuillez insérer des données !!!");
            }
            catch (SqlException exc)
            {
                MessageBox.Show(exc.Message);
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            eventHome(); 
        }

        public void eventHome()
        {
                cmpt+=20;
                panel1.Size = new Size(X_pl1 + cmpt, Y_pl1);
                panel2.Size = new Size(X_pl2 - cmpt, Y_pl2);

                if (panel1.Size.Width <= 0 || panel2.Size.Width <= 0)
                {
                    cmpt = 0;
                    panel1.Size = new Size(X_pl1, Y_pl1);
                    panel2.Size = new Size(X_pl2, Y_pl2);
                    panel3.Visible = true;
                }
        }
    }
}
