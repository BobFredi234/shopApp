using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.IO;
using System.Windows.Forms;

namespace shopApp
{
    public partial class GestionCodeBares : Form
    {
        BDConnexion bd;
        public GestionCodeBares()
        {
            InitializeComponent();
            bd = new BDConnexion();
            LoadAllBarcode();
        }

        // Afficher tous les codes bar dans le dgrBarcode
        public void LoadAllBarcode()
        {
            this.dgrBarcode.DataSource = bd.RecupererInformations("select * from BarCode");
            ResetAllDatas();
        }

        // Sauvegarder un code bar
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (txtBarCode.Text == "")
            {
                MessageBox.Show("Veuillez remplir tout les champs !!");
            }
            else
            {
                bd.EnvoyerRequete("Insert into BarCode (codeBar) VALUES ('" + txtBarCode.Text + "')");
                MessageBox.Show("Code Bar ajouté !!");
                LoadAllBarcode();
            }
        }

        // Supprimer un code bar
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (txtBarCode.Text == "")
            {
                MessageBox.Show("Veuillez remplir tout les champs !!");
            }
            else
            {
                bd.EnvoyerRequete("DELETE BarCode WHERE idCodeBar = " + lblId.Text);
                MessageBox.Show("Catégorie supprimer !!");
                LoadAllBarcode();
                ResetAllDatas();
            }
        }

        //Modifier un code bar
        private void BtnModify_Click(object sender, EventArgs e)
        {
            if (txtBarCode.Text == "")
            {
                MessageBox.Show("Veuillez remplir tout les champs !!");
            }
            else
            {
                bd.EnvoyerRequete("UPDATE BarCode Set codeBar = '" + int.Parse(txtBarCode.Text) + "',date_update = getDate() where idCodeBar = " + lblId.Text);
                MessageBox.Show("Mise à jour réussie !!");
                LoadAllBarcode();
                ResetAllDatas();
                BtnSave.Enabled = true;
            }
        }

        // générateur de code bar aléatoire
        private void generateBarCode(object sender, EventArgs e)
        {
            Random rand = new Random();
            this.txtBarCode.Text = rand.Next(100000000, 999999999).ToString();
        }

        // Evènement lors d'un click sur une colonne du dgrBarcode
        private void dgrBarcode_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBarCode.Text = dgrBarcode[1, e.RowIndex].Value.ToString();
            lblId.Text = dgrBarcode[0, e.RowIndex].Value.ToString();
            BtnSave.Enabled = false;
        }

        // Exportation PDF ou Excel des codes bar
        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dgrBarcode.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (*.pdf)|*.pdf|EXCEL (*.xlsx)|*.xlsx";
                save.FileName = "Barcodes";
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
                        if(save.DefaultExt == "pdf")
                        {
                            try
                            {
                                PdfPTable pTable = new PdfPTable(dgrBarcode.Columns.Count);
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



                                foreach (DataGridViewColumn col in dgrBarcode.Columns)
                                {
                                    PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
                                    pCell.BackgroundColor = BaseColor.BLACK;
                                    pCell.Phrase.Font.Color = BaseColor.WHITE;
                                    pTable.AddCell(pCell);
                                }

                                foreach (DataGridViewRow viewRow in dgrBarcode.Rows)
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

                                for (int i = 1; i < dgrBarcode.Columns.Count+1; i++)
                                {
                                    excelApp.Cells[1, i] = dgrBarcode.Columns[i-1].HeaderText;
                                }
                                for (int i = 0; i < dgrBarcode.Rows.Count; i++)
                                {
                                    for (int j = 0; j < dgrBarcode.Columns.Count; j++)
                                    {
                                        excelApp.Cells[i + 2, j + 1] = dgrBarcode.Rows[i].Cells[j].Value.ToString();
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

        // Réinitialise le txtBarcode.Text et le lblID.Text
        public void ResetAllDatas()
        {
            txtBarCode.Clear();
            lblId.Text = "ID";
        }
    }
}
