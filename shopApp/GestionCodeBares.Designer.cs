namespace shopApp
{
    partial class GestionCodeBares
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
            this.dgrBarcode = new System.Windows.Forms.DataGridView();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnModify = new System.Windows.Forms.Button();
            this.txtBarCode = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblbarcode = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgrBarcode)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrBarcode
            // 
            this.dgrBarcode.AllowUserToAddRows = false;
            this.dgrBarcode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrBarcode.Location = new System.Drawing.Point(14, 104);
            this.dgrBarcode.Name = "dgrBarcode";
            this.dgrBarcode.Size = new System.Drawing.Size(637, 368);
            this.dgrBarcode.TabIndex = 60;
            this.dgrBarcode.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrBarcode_CellContentClick);
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.Red;
            this.BtnDelete.FlatAppearance.BorderSize = 0;
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.Location = new System.Drawing.Point(271, 50);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(99, 34);
            this.BtnDelete.TabIndex = 59;
            this.BtnDelete.Text = "Supprimer";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.GreenYellow;
            this.BtnSave.FlatAppearance.BorderSize = 0;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.Location = new System.Drawing.Point(421, 50);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(98, 34);
            this.BtnSave.TabIndex = 58;
            this.BtnSave.Text = "Enregistrer";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnModify
            // 
            this.BtnModify.BackColor = System.Drawing.Color.Orange;
            this.BtnModify.FlatAppearance.BorderSize = 0;
            this.BtnModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModify.Location = new System.Drawing.Point(127, 50);
            this.BtnModify.Name = "BtnModify";
            this.BtnModify.Size = new System.Drawing.Size(85, 34);
            this.BtnModify.TabIndex = 57;
            this.BtnModify.Text = "Modifier";
            this.BtnModify.UseVisualStyleBackColor = false;
            this.BtnModify.Click += new System.EventHandler(this.BtnModify_Click);
            // 
            // txtBarCode
            // 
            this.txtBarCode.Location = new System.Drawing.Point(231, 19);
            this.txtBarCode.Name = "txtBarCode";
            this.txtBarCode.Size = new System.Drawing.Size(197, 20);
            this.txtBarCode.TabIndex = 56;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(11, 10);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 54;
            this.lblId.Text = "ID";
            // 
            // lblbarcode
            // 
            this.lblbarcode.AutoSize = true;
            this.lblbarcode.Location = new System.Drawing.Point(177, 23);
            this.lblbarcode.Name = "lblbarcode";
            this.lblbarcode.Size = new System.Drawing.Size(57, 13);
            this.lblbarcode.TabIndex = 55;
            this.lblbarcode.Text = "Code Bar :";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.BackColor = System.Drawing.Color.White;
            this.lblNum.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum.ForeColor = System.Drawing.Color.Salmon;
            this.lblNum.Location = new System.Drawing.Point(459, 18);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(163, 20);
            this.lblNum.TabIndex = 61;
            this.lblNum.Text = "[Générer un numéro]";
            this.lblNum.Click += new System.EventHandler(this.generateBarCode);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.Orange;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Location = new System.Drawing.Point(566, 50);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(85, 34);
            this.btnExport.TabIndex = 57;
            this.btnExport.Text = "Exporter";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // GestionCodeBares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 483);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.dgrBarcode);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.BtnModify);
            this.Controls.Add(this.txtBarCode);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblbarcode);
            this.Name = "GestionCodeBares";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestionCodeBares";
            ((System.ComponentModel.ISupportInitialize)(this.dgrBarcode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrBarcode;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnModify;
        private System.Windows.Forms.TextBox txtBarCode;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblbarcode;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Button btnExport;
    }
}