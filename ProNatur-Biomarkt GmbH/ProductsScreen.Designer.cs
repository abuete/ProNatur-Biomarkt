namespace ProNatur_Biomarkt_GmbH
{
    partial class ProductsScreen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblName = new System.Windows.Forms.Label();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.textBoxProductBrand = new System.Windows.Forms.TextBox();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.textBoxProductPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.comboBoxProductCategory = new System.Windows.Forms.ComboBox();
            this.btnProductSave = new System.Windows.Forms.Button();
            this.btnProductEdit = new System.Windows.Forms.Button();
            this.btnProductDelete = new System.Windows.Forms.Button();
            this.btnProductClear = new System.Windows.Forms.Button();
            this.productsDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.productsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(29, 26);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(48, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxProductName.CausesValidation = false;
            this.textBoxProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProductName.ForeColor = System.Drawing.Color.White;
            this.textBoxProductName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBoxProductName.Location = new System.Drawing.Point(124, 27);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(271, 22);
            this.textBoxProductName.TabIndex = 1;
            // 
            // textBoxProductBrand
            // 
            this.textBoxProductBrand.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxProductBrand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxProductBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProductBrand.ForeColor = System.Drawing.Color.White;
            this.textBoxProductBrand.Location = new System.Drawing.Point(124, 60);
            this.textBoxProductBrand.Name = "textBoxProductBrand";
            this.textBoxProductBrand.Size = new System.Drawing.Size(270, 22);
            this.textBoxProductBrand.TabIndex = 3;
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.BackColor = System.Drawing.Color.Transparent;
            this.lblBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrand.ForeColor = System.Drawing.Color.White;
            this.lblBrand.Location = new System.Drawing.Point(29, 59);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(50, 16);
            this.lblBrand.TabIndex = 2;
            this.lblBrand.Text = "Marke";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.BackColor = System.Drawing.Color.Transparent;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.Color.White;
            this.lblCategory.Location = new System.Drawing.Point(29, 94);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(74, 16);
            this.lblCategory.TabIndex = 4;
            this.lblCategory.Text = "Kategorie";
            // 
            // textBoxProductPrice
            // 
            this.textBoxProductPrice.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxProductPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProductPrice.ForeColor = System.Drawing.Color.White;
            this.textBoxProductPrice.Location = new System.Drawing.Point(124, 129);
            this.textBoxProductPrice.Name = "textBoxProductPrice";
            this.textBoxProductPrice.Size = new System.Drawing.Size(271, 22);
            this.textBoxProductPrice.TabIndex = 7;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.White;
            this.lblPrice.Location = new System.Drawing.Point(29, 129);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(43, 16);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "Preis";
            // 
            // comboBoxProductCategory
            // 
            this.comboBoxProductCategory.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.comboBoxProductCategory.DropDownHeight = 100;
            this.comboBoxProductCategory.DropDownWidth = 270;
            this.comboBoxProductCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxProductCategory.ForeColor = System.Drawing.Color.White;
            this.comboBoxProductCategory.FormattingEnabled = true;
            this.comboBoxProductCategory.IntegralHeight = false;
            this.comboBoxProductCategory.Items.AddRange(new object[] {
            "Obst",
            "Gemüse",
            "Fleisch",
            "Fisch",
            "Drogerie",
            "Getränke"});
            this.comboBoxProductCategory.Location = new System.Drawing.Point(124, 91);
            this.comboBoxProductCategory.Name = "comboBoxProductCategory";
            this.comboBoxProductCategory.Size = new System.Drawing.Size(270, 24);
            this.comboBoxProductCategory.TabIndex = 8;
            this.comboBoxProductCategory.Text = "Bitte wählen...";
            // 
            // btnProductSave
            // 
            this.btnProductSave.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnProductSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductSave.Location = new System.Drawing.Point(263, 213);
            this.btnProductSave.Name = "btnProductSave";
            this.btnProductSave.Size = new System.Drawing.Size(132, 34);
            this.btnProductSave.TabIndex = 9;
            this.btnProductSave.Text = "Speichern";
            this.btnProductSave.UseVisualStyleBackColor = false;
            this.btnProductSave.Click += new System.EventHandler(this.btnProductSave_Click);
            // 
            // btnProductEdit
            // 
            this.btnProductEdit.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnProductEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductEdit.Location = new System.Drawing.Point(124, 213);
            this.btnProductEdit.Name = "btnProductEdit";
            this.btnProductEdit.Size = new System.Drawing.Size(132, 34);
            this.btnProductEdit.TabIndex = 10;
            this.btnProductEdit.Text = "Bearbeiten";
            this.btnProductEdit.UseVisualStyleBackColor = false;
            this.btnProductEdit.Click += new System.EventHandler(this.btnProductEdit_Click);
            // 
            // btnProductDelete
            // 
            this.btnProductDelete.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnProductDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductDelete.Location = new System.Drawing.Point(400, 213);
            this.btnProductDelete.Name = "btnProductDelete";
            this.btnProductDelete.Size = new System.Drawing.Size(132, 34);
            this.btnProductDelete.TabIndex = 11;
            this.btnProductDelete.Text = "Löschen";
            this.btnProductDelete.UseVisualStyleBackColor = false;
            this.btnProductDelete.Click += new System.EventHandler(this.btnProductDelete_Click);
            // 
            // btnProductClear
            // 
            this.btnProductClear.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnProductClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductClear.Location = new System.Drawing.Point(836, 213);
            this.btnProductClear.Name = "btnProductClear";
            this.btnProductClear.Size = new System.Drawing.Size(132, 34);
            this.btnProductClear.TabIndex = 12;
            this.btnProductClear.Text = "Zurücksetzen";
            this.btnProductClear.UseVisualStyleBackColor = false;
            this.btnProductClear.Click += new System.EventHandler(this.btnProductClear_Click);
            // 
            // productsDGV
            // 
            this.productsDGV.AllowUserToAddRows = false;
            this.productsDGV.AllowUserToDeleteRows = false;
            this.productsDGV.AllowUserToResizeColumns = false;
            this.productsDGV.AllowUserToResizeRows = false;
            this.productsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productsDGV.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productsDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.productsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.productsDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.productsDGV.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.productsDGV.Location = new System.Drawing.Point(124, 289);
            this.productsDGV.MultiSelect = false;
            this.productsDGV.Name = "productsDGV";
            this.productsDGV.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productsDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.productsDGV.RowHeadersVisible = false;
            this.productsDGV.RowHeadersWidth = 51;
            this.productsDGV.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.productsDGV.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.productsDGV.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            this.productsDGV.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.productsDGV.RowTemplate.Height = 24;
            this.productsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productsDGV.Size = new System.Drawing.Size(844, 235);
            this.productsDGV.TabIndex = 13;
            this.productsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productsDGV_CellContentClick);
            // 
            // ProductsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = global::ProNatur_Biomarkt_GmbH.Properties.Resources.ImgBgProducts;
            this.ClientSize = new System.Drawing.Size(1009, 552);
            this.Controls.Add(this.productsDGV);
            this.Controls.Add(this.btnProductClear);
            this.Controls.Add(this.btnProductDelete);
            this.Controls.Add(this.btnProductEdit);
            this.Controls.Add(this.btnProductSave);
            this.Controls.Add(this.comboBoxProductCategory);
            this.Controls.Add(this.textBoxProductPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.textBoxProductBrand);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.textBoxProductName);
            this.Controls.Add(this.lblName);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ProductsScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produkte";
            ((System.ComponentModel.ISupportInitialize)(this.productsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.TextBox textBoxProductBrand;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox textBoxProductPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.ComboBox comboBoxProductCategory;
        private System.Windows.Forms.Button btnProductSave;
        private System.Windows.Forms.Button btnProductEdit;
        private System.Windows.Forms.Button btnProductDelete;
        private System.Windows.Forms.Button btnProductClear;
        private System.Windows.Forms.DataGridView productsDGV;
    }
}