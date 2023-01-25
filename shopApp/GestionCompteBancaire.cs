using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.IO;
using System.Windows.Forms;

namespace shopApp
{
    public partial class GestionCompteBancaire : Form
    {
        BDConnexion bd;
        public GestionCompteBancaire()
        {
            InitializeComponent();
            bd = new BDConnexion();
            LoadAllAccountBank();
        }

        // Liste tous les comptes bancaires
        public void LoadAllAccountBank()
        {
            dgrAccountBank.DataSource = bd.RecupererInformations("select * from CompteBancaire");
        }

        // évènement lors d'un click sur les tuples du dgrAccountBank
        private void dgrAccountBank_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNumCompte.Text = dgrAccountBank[1, e.RowIndex].Value.ToString();
            txtAuteur.Text = dgrAccountBank[2, e.RowIndex].Value.ToString();
            txtSoldeBank.Text = dgrAccountBank[3, e.RowIndex].Value.ToString();
            txtDevise.Text = dgrAccountBank[4, e.RowIndex].Value.ToString();
            lblID.Text = dgrAccountBank[0, e.RowIndex].Value.ToString();
        }

        // Enregistrer un nouveau Compte Bancaire
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (txtNumCompte.Text == "" || txtAuteur.Text == "" || txtSoldeBank.Text == "" || txtDevise.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs !!!");
            }
            else
            {
                bd.EnvoyerRequete("Insert into CompteBancaire(numCompte, idUser, solde, devise) VALUES (" + int.Parse(txtNumCompte.Text) + ", " + int.Parse(txtAuteur.Text)+
                    ", "+lblID.Text+", "+ decimal.Parse(txtSoldeBank.Text)+", "+txtDevise.Text+")");
                MessageBox.Show("Compte Bancaire enregistré !!!");
                LoadAllAccountBank();
            }
        }

        // Modifier un Compte Bancaire
        private void BtnModify_Click(object sender, EventArgs e)
        {
            if (txtNumCompte.Text == "" || txtAuteur.Text == "" || txtSoldeBank.Text == "" || txtDevise.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs !!!");
            }
            else
            {
                bd.EnvoyerRequete("Update CompteBancaire Set " +
                    "numCompte = " + txtNumCompte.Text + ", idUser = " + txtAuteur.Text + ", solde = " +
                    decimal.Parse(txtSoldeBank.Text) + ", devise = '" + txtDevise.Text +"' where idCompte = "+
                    lblID.Text);

                MessageBox.Show("Mise du compte Bancaire effectuée !!");
                LoadAllAccountBank();
            }
        }

        // Supprime un Compte Bancaire
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (txtNumCompte.Text == "" || txtAuteur.Text == "" || txtSoldeBank.Text == "" || txtDevise.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs !!!");
            }
            else
            {
                if (MessageBox.Show("Voulez-vous vraiment supprimer ce compte ?", "Suppression",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    bd.EnvoyerRequete("DELETE CompteBancaire where idCompte = " +
                    lblID.Text);

                    MessageBox.Show("Mise du compte Bancaire effectuée !!");
                    LoadAllAccountBank();
                }
               
            }
        }

        // génère un numéro aléatoire de compte bancaire
        private void generate_num_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            this.txtNumCompte.Text = rand.Next(100000000, 999999999).ToString();
        }

        // Exporter les données en PDF ou Excel
        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dgrAccountBank.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (*.pdf)|*.pdf|EXCEL (*.xlsx)|*.xlsx";
                save.FileName = "Comptes Bancaires";
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
                                PdfPTable pTable = new PdfPTable(dgrAccountBank.Columns.Count);
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



                                foreach (DataGridViewColumn col in dgrAccountBank.Columns)
                                {
                                    PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
                                    pCell.BackgroundColor = BaseColor.BLACK;
                                    pCell.Phrase.Font.Color = BaseColor.WHITE;
                                    pTable.AddCell(pCell);
                                }

                                foreach (DataGridViewRow viewRow in dgrAccountBank.Rows)
                                {
                                    foreach (DataGridViewCell dCell in viewRow.Cells)
                                    {
                                        pTable.AddCell(dCell.Value.ToString());
                                    }
                                }

                                using (FileStream fileStream = new FileStream(save.FileName,
                                    FileMode.Create, FileAccess.ReadWrite))
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

                                for (int i = 1; i < dgrAccountBank.Columns.Count + 1; i++)
                                {
                                    excelApp.Cells[1, i] = dgrAccountBank.Columns[i - 1].HeaderText;
                                }
                                for (int i = 0; i < dgrAccountBank.Rows.Count; i++)
                                {
                                    for (int j = 0; j < dgrAccountBank.Columns.Count; j++)
                                    {
                                        excelApp.Cells[i + 2, j + 1] = dgrAccountBank.Rows[i].Cells[j].Value.ToString();
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
    }
}
