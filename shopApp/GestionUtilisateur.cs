using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace shopApp
{
    public partial class GestionUtilisateur : Form
    {
        BDConnexion bd;
        public GestionUtilisateur()
        {
            bd = new BDConnexion();
            InitializeComponent();
            dateNaissance.MaxDate = DateTime.Now;
            LoadUsers();
        }

        // permet de lire tout les Utilisateurs et les affichés dans un datagridview
        public void LoadUsers()
        {
            dgrUser.DataSource = bd.RecupererInformations("select * from utilisateur");
            ResetAllDatas();
        }

        // Export en pdf ou xlsx [Les Utilisateurs]
        private void BtnExport_Click(object sender, EventArgs e)
        {
            if (dgrUser.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (*.pdf)|*.pdf|EXCEL (*.xlsx)|*.xlsx";
                save.FileName = "Users";
                bool ErrorMessage = false;

                if (save.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(save.FileName))
                    {
                        try
                        {
                            File.Delete(save.FileName);
                        }
                        catch (Exception ex)
                        {
                            ErrorMessage = true;
                            MessageBox.Show("Unable to write data in disk, " + ex.Message);
                        }
                    }
                    if (!ErrorMessage)
                    {
                        if (save.DefaultExt == "pdf")
                        {
                            try
                            {
                                PdfPTable pTable = new PdfPTable(dgrUser.Columns.Count);
                                pTable.DefaultCell.Padding = 2;
                                pTable.WidthPercentage = 100;
                                pTable.HorizontalAlignment = Element.ALIGN_CENTER;

                                PdfPTable pTable1 = new PdfPTable(1);
                                pTable1.WidthPercentage = 100;
                                pTable1.HorizontalAlignment = Element.ALIGN_CENTER;
                                PdfPCell pCell1 = new PdfPCell(new Phrase("Codes Bar"));
                                pCell1.BackgroundColor = BaseColor.RED;
                                pCell1.Phrase.Font.Color = BaseColor.WHITE;
                                pCell1.Phrase.Font.Size = 14F;
                                pCell1.Phrase.Font.SetStyle("bold");
                                pCell1.HorizontalAlignment = Element.ALIGN_CENTER;
                                pTable1.AddCell(pCell1);



                                foreach (DataGridViewColumn col in dgrUser.Columns)
                                {
                                    PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
                                    pCell.BackgroundColor = BaseColor.BLACK;
                                    pCell.Phrase.Font.Color = BaseColor.WHITE;
                                    pTable.AddCell(pCell);
                                }

                                foreach (DataGridViewRow viewRow in dgrUser.Rows)
                                {
                                    foreach (DataGridViewCell dCell in viewRow.Cells)
                                    {
                                        pTable.AddCell(dCell.Value.ToString());
                                    }
                                }

                                using (FileStream fileStream = new FileStream(save.FileName,
                                    FileMode.OpenOrCreate))
                                {
                                    Document document = new Document(PageSize.A4, 8f, 16f, 16F, 6F);
                                    PdfWriter.GetInstance(document, fileStream);
                                    document.Open();
                                    document.Add(pTable1);
                                    document.Add(pTable);
                                    document.Close();
                                    fileStream.Close();
                                }
                                MessageBox.Show("Data Export Successfully", "info");
                            }
                            catch (Exception exc)
                            {
                                MessageBox.Show("Error while exporting Data " + exc.Message);
                            }
                        }
                        else
                        {
                            try
                            {
                                Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
                                excelApp.Application.Workbooks.Add(Type.Missing);

                                for (int i = 1; i < dgrUser.Columns.Count + 1; i++)
                                {
                                    excelApp.Cells[1, i] = dgrUser.Columns[i - 1].HeaderText;
                                }
                                for (int i = 0; i < dgrUser.Rows.Count; i++)
                                {
                                    for (int j = 0; j < dgrUser.Columns.Count; j++)
                                    {
                                        excelApp.Cells[i + 2, j + 1] = dgrUser.Rows[i].Cells[j].Value.ToString();
                                    }
                                }
                                excelApp.Columns.AutoFit();
                                excelApp.Visible = true;

                            }
                            catch (Exception exc)
                            {
                                MessageBox.Show(exc.Message);
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("No Record Found", "Info");
                    }
                }
            }

        }

        // Réinitialisation de toutes les variables
        public void ResetAllDatas()
        {
            nom.Clear();
            prenom.Clear();
            cbSexe.Text = "";
            dateNaissance.Text = "";
            adresse.Clear();
            txtphone.Clear();
            login.Clear();
            password.Clear();
            cbStatut.Text = "";
            email.Clear();
            IdUser.Text = "ID";
        }

        // Evènement de récupération de données lors d'un clic sur un tuple de données
        private void dgrUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IdUser.Text = dgrUser[0, e.RowIndex].Value.ToString();
            nom.Text = dgrUser[1, e.RowIndex].Value.ToString();
            prenom.Text = dgrUser[2, e.RowIndex].Value.ToString();
            cbSexe.Text = dgrUser[3, e.RowIndex].Value.ToString();
            dateNaissance.Text = dgrUser[4, e.RowIndex].Value.ToString();
            adresse.Text = dgrUser[5, e.RowIndex].Value.ToString();
            txtphone.Text = dgrUser[6, e.RowIndex].Value.ToString();
            login.Text = dgrUser[7, e.RowIndex].Value.ToString();
            password.Text = dgrUser[8, e.RowIndex].Value.ToString();
            cbStatut.Text = dgrUser[9, e.RowIndex].Value.ToString();
            email.Text = dgrUser[12, e.RowIndex].Value.ToString();

            BtnSave.Enabled = false;
        }

        // Percevoir les caractères du mot de passe de l'utilisateur
        private void PicPassword_Click(object sender, EventArgs e)
        {
            MessageBox.Show(picPassword.Image.ToString());
            if(picPassword.BackColor == Color.Black)
            {
                picPassword.Image = System.Drawing.Image.FromFile("C:\\Users\\Bobi\\Desktop\\TP Csharp\\shopApp\\shopApp\\Resources\\Images\\Config\\icons8_eye_40px.png");
                password.UseSystemPasswordChar = false;
                picPassword.BackColor = Color.Brown;
            }
            else
            {
                picPassword.Image = System.Drawing.Image.FromFile("C:\\Users\\Bobi\\Desktop\\TP Csharp\\shopApp\\shopApp\\Resources\\Images\\Config\\icons8_invisible_40px.png");
                password.UseSystemPasswordChar = true;
                picPassword.BackColor = Color.Black;
            }
        }

        // Modifier les données d'un utilisateur
        private void BtnModify_Click(object sender, EventArgs e)
        {
            if (nom.Text == "" || prenom.Text == "" ||
                cbSexe.Text == "" || dateNaissance.Text == "" ||
                adresse.Text == "" || txtphone.Text == "" ||
                login.Text == "" || password.Text == "" ||
                cbStatut.Text == "" || email.Text == "" ||
                IdUser.Text == "ID")
            {
                MessageBox.Show("Veillez remplir les champs vides!!");
            }
            else
            {
                bd.EnvoyerRequete("Update utilisateur SET " +
                    "nom = '" + nom.Text + "', " +
                    "prenom = '" +
                    prenom.Text + "'," +
                    "dateNaissance = '" + dateNaissance.Text + "', " +
                    "adresse = '" + adresse.Text + "', phone = '" +
                    txtphone.Text + "', username = '" + login.Text + "'," +
                    "password = '" + password.Text + "', statut = '" +
                    cbStatut.Text + "', email = '" + email.Text + "', " +
                    "date_update = getDate() WHERE idUser = "+IdUser.Text);
                ResetAllDatas();
            }
        }

        // Suppression des données d'un utilisateur
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (nom.Text == ""||prenom.Text ==""|| 
                cbSexe.Text == "" || dateNaissance.Text == ""||
                adresse.Text == "" || txtphone.Text == "" || 
                login.Text == "" || password.Text == "" ||
                cbStatut.Text == "" || email.Text == "" || 
                IdUser.Text =="ID")
            {
                MessageBox.Show("Veillez remplir les champs vides!!");
            }
            else
            {
                bd.EnvoyerRequete("Delete utilisateur where idUser = " + IdUser.Text);
                ResetAllDatas();
            }
        }
        
        // Enregistrement d'un nouveau utilisateur
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (nom.Text == "" || prenom.Text == "" ||
                cbSexe.Text == "" || dateNaissance.Text == "" ||
                adresse.Text == "" || txtphone.Text == "" ||
                login.Text == "" || password.Text == "" ||
                cbStatut.Text == "" || email.Text == "" ||
                IdUser.Text == "ID")
            {
                MessageBox.Show("Veillez remplir les champs vides!!");
            }
            else
            {
                if (dateNaissance.Value == DateTime.Now)
                {
                    MessageBox.Show("Désolé mais il y'a une erreur !!");
                }
                else
                {
                    bd.EnvoyerRequete("INSERT INTO utilisateur(nom, prenom, sexe, dateNaissance, adresse, phone, username, password, statut, email) " +
                    " VALUES ('" + nom.Text + "','" +
                    prenom.Text + "', '" + cbSexe.Text + "','" +
                    dateNaissance.Text + "', '" +
                    adresse.Text + "', '" +
                    txtphone.Text + "', '" +
                    login.Text + "', '" +
                    password.Text + "', '" +
                    cbStatut.Text + "', '" +
                    email.Text + "')");
                    ResetAllDatas();
                }
                
            }
        }
    }
}
