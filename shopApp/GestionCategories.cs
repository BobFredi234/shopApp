using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.IO;
using System.Windows.Forms;

namespace shopApp
{
    public partial class GestionCategories : Form
    {
        BDConnexion bd;
        public GestionCategories()
        {
            InitializeComponent();
            bd = new BDConnexion();
        }

        private void GestionCategories_Load(object sender, EventArgs e)
        {
            LoadCategory();

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (txtCategorie.Text == "")
            {
                MessageBox.Show("Veuillez remplir tout les champs !!");
            }else
            {
                bd.EnvoyerRequete("Insert into categorie (category) VALUES ('" + txtCategorie.Text + "')");
                MessageBox.Show("Catégorie ajoutée !!");
                LoadCategory();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (txtCategorie.Text == "")
            {
                MessageBox.Show("Veuillez remplir tout les champs !!");
            }
            else
            {
                bd.EnvoyerRequete("DELETE categorie WHERE idCat = " + label1.Text);
                MessageBox.Show("Catégorie supprimer !!");
                LoadCategory();
            }
        }

        private void BtnModify_Click(object sender, EventArgs e)
        {
            if (txtCategorie.Text == "")
            {
                MessageBox.Show("Veuillez remplir tout les champs !!");
            }
            else
            {
                bd.EnvoyerRequete("UPDATE categorie Set category = '" + txtCategorie.Text+"',date_update = getDate() where idCat = "+label1.Text);
                MessageBox.Show("Mise à jour réussie !!");
                LoadCategory();
            }
        }

        public void LoadCategory()
        {
            dgrCategory.DataSource = bd.RecupererInformations("select * from categorie");
        }

        private void dgrCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCategorie.Text = dgrCategory[1, e.RowIndex].Value.ToString();
            label1.Text = dgrCategory[0, e.RowIndex].Value.ToString();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dgrCategory.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (*.pdf)|*.pdf|EXCEL (*.xlsx)|*.xlsx";
                save.FileName = "Catégories";
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
                                PdfPTable pTable = new PdfPTable(dgrCategory.Columns.Count);
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



                                foreach (DataGridViewColumn col in dgrCategory.Columns)
                                {
                                    PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
                                    pCell.BackgroundColor = BaseColor.BLACK;
                                    pCell.Phrase.Font.Color = BaseColor.WHITE;
                                    pTable.AddCell(pCell);
                                }

                                foreach (DataGridViewRow viewRow in dgrCategory.Rows)
                                {
                                    foreach (DataGridViewCell dCell in viewRow.Cells)
                                    {
                                        pTable.AddCell(dCell.Value.ToString());
                                    }
                                }

                                using (FileStream fileStream = new FileStream(save.FileName,
                                    FileMode.OpenOrCreate, FileAccess.ReadWrite))
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

                                for (int i = 1; i < dgrCategory.Columns.Count + 1; i++)
                                {
                                    excelApp.Cells[1, i] = dgrCategory.Columns[i - 1].HeaderText;
                                }
                                for (int i = 0; i < dgrCategory.Rows.Count; i++)
                                {
                                    for (int j = 0; j < dgrCategory.Columns.Count; j++)
                                    {
                                        excelApp.Cells[i + 2, j + 1] = dgrCategory.Rows[i].Cells[j].Value.ToString();
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
