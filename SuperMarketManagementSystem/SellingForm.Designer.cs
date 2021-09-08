
namespace SuperMarketManagementSystem
{
    partial class SellingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellingForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ExitButton = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BillIDTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.ProductNameTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.ProductQuantityTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.AddButton = new System.Windows.Forms.Button();
            this.PrintButton = new System.Windows.Forms.Button();
            this.BillDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.DateLabel = new System.Windows.Forms.Label();
            this.SellingProductDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.ProductPriceTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.SellerNameLabel = new System.Windows.Forms.Label();
            this.AddProductButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.OrderDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BillDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SellingProductDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.DarkOrange;
            this.ExitButton.Location = new System.Drawing.Point(961, -8);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(21, 26);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "x";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.Font = new System.Drawing.Font("Courgette", 14.25F);
            this.label7.ForeColor = System.Drawing.Color.Bisque;
            this.label7.Location = new System.Drawing.Point(898, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 24);
            this.label7.TabIndex = 23;
            this.label7.Text = "Logout";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courgette", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Bisque;
            this.label1.Location = new System.Drawing.Point(427, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "SELLING";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courgette", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Bisque;
            this.label2.Location = new System.Drawing.Point(623, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "BILL ID";
            // 
            // BillIDTextBox
            // 
            this.BillIDTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BillIDTextBox.Font = new System.Drawing.Font("Courgette", 12F, System.Drawing.FontStyle.Bold);
            this.BillIDTextBox.ForeColor = System.Drawing.Color.Gold;
            this.BillIDTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.BillIDTextBox.HintText = "";
            this.BillIDTextBox.isPassword = false;
            this.BillIDTextBox.LineFocusedColor = System.Drawing.Color.Yellow;
            this.BillIDTextBox.LineIdleColor = System.Drawing.Color.Bisque;
            this.BillIDTextBox.LineMouseHoverColor = System.Drawing.Color.Yellow;
            this.BillIDTextBox.LineThickness = 4;
            this.BillIDTextBox.Location = new System.Drawing.Point(795, 396);
            this.BillIDTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.BillIDTextBox.Name = "BillIDTextBox";
            this.BillIDTextBox.Size = new System.Drawing.Size(157, 27);
            this.BillIDTextBox.TabIndex = 2;
            this.BillIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courgette", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Bisque;
            this.label3.Location = new System.Drawing.Point(623, 436);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Product Name";
            // 
            // ProductNameTextBox
            // 
            this.ProductNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProductNameTextBox.Enabled = false;
            this.ProductNameTextBox.Font = new System.Drawing.Font("Courgette", 12F, System.Drawing.FontStyle.Bold);
            this.ProductNameTextBox.ForeColor = System.Drawing.Color.Gold;
            this.ProductNameTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.ProductNameTextBox.HintText = "";
            this.ProductNameTextBox.isPassword = false;
            this.ProductNameTextBox.LineFocusedColor = System.Drawing.Color.Yellow;
            this.ProductNameTextBox.LineIdleColor = System.Drawing.Color.Bisque;
            this.ProductNameTextBox.LineMouseHoverColor = System.Drawing.Color.Yellow;
            this.ProductNameTextBox.LineThickness = 4;
            this.ProductNameTextBox.Location = new System.Drawing.Point(795, 428);
            this.ProductNameTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ProductNameTextBox.Name = "ProductNameTextBox";
            this.ProductNameTextBox.Size = new System.Drawing.Size(157, 27);
            this.ProductNameTextBox.TabIndex = 4;
            this.ProductNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courgette", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Bisque;
            this.label4.Location = new System.Drawing.Point(623, 510);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "QUANTITY";
            // 
            // ProductQuantityTextBox
            // 
            this.ProductQuantityTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProductQuantityTextBox.Font = new System.Drawing.Font("Courgette", 12F, System.Drawing.FontStyle.Bold);
            this.ProductQuantityTextBox.ForeColor = System.Drawing.Color.Gold;
            this.ProductQuantityTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.ProductQuantityTextBox.HintText = "";
            this.ProductQuantityTextBox.isPassword = false;
            this.ProductQuantityTextBox.LineFocusedColor = System.Drawing.Color.Yellow;
            this.ProductQuantityTextBox.LineIdleColor = System.Drawing.Color.Bisque;
            this.ProductQuantityTextBox.LineMouseHoverColor = System.Drawing.Color.Yellow;
            this.ProductQuantityTextBox.LineThickness = 4;
            this.ProductQuantityTextBox.Location = new System.Drawing.Point(795, 502);
            this.ProductQuantityTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ProductQuantityTextBox.Name = "ProductQuantityTextBox";
            this.ProductQuantityTextBox.Size = new System.Drawing.Size(157, 27);
            this.ProductQuantityTextBox.TabIndex = 6;
            this.ProductQuantityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.Transparent;
            this.AddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Courgette", 14.25F, System.Drawing.FontStyle.Bold);
            this.AddButton.ForeColor = System.Drawing.Color.Bisque;
            this.AddButton.Location = new System.Drawing.Point(111, 556);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(80, 32);
            this.AddButton.TabIndex = 11;
            this.AddButton.Text = "ADD";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // PrintButton
            // 
            this.PrintButton.BackColor = System.Drawing.Color.Transparent;
            this.PrintButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PrintButton.FlatAppearance.BorderSize = 0;
            this.PrintButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintButton.Font = new System.Drawing.Font("Courgette", 14.25F, System.Drawing.FontStyle.Bold);
            this.PrintButton.ForeColor = System.Drawing.Color.Bisque;
            this.PrintButton.Location = new System.Drawing.Point(354, 556);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(84, 32);
            this.PrintButton.TabIndex = 12;
            this.PrintButton.Text = "PRINT";
            this.PrintButton.UseVisualStyleBackColor = false;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // BillDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(231)))), ((int)(((byte)(203)))));
            this.BillDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.BillDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BillDataGridView.BackgroundColor = System.Drawing.Color.Green;
            this.BillDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BillDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.BillDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BillDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.BillDataGridView.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(239)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(201)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BillDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.BillDataGridView.EnableHeadersVisualStyles = false;
            this.BillDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(231)))), ((int)(((byte)(201)))));
            this.BillDataGridView.Location = new System.Drawing.Point(18, 409);
            this.BillDataGridView.Name = "BillDataGridView";
            this.BillDataGridView.RowHeadersVisible = false;
            this.BillDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BillDataGridView.Size = new System.Drawing.Size(559, 141);
            this.BillDataGridView.TabIndex = 14;
            this.BillDataGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Green;
            this.BillDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(231)))), ((int)(((byte)(203)))));
            this.BillDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.BillDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.BillDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.BillDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.BillDataGridView.ThemeStyle.BackColor = System.Drawing.Color.Green;
            this.BillDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(231)))), ((int)(((byte)(201)))));
            this.BillDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.BillDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.BillDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.BillDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.BillDataGridView.ThemeStyle.HeaderStyle.Height = 30;
            this.BillDataGridView.ThemeStyle.ReadOnly = false;
            this.BillDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(239)))), ((int)(((byte)(220)))));
            this.BillDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.BillDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.BillDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.BillDataGridView.ThemeStyle.RowsStyle.Height = 22;
            this.BillDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(201)))), ((int)(((byte)(138)))));
            this.BillDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.Font = new System.Drawing.Font("Courgette", 12F, System.Drawing.FontStyle.Bold);
            this.CategoryComboBox.ForeColor = System.Drawing.Color.DarkGreen;
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Items.AddRange(new object[] {
            "ADMIN",
            "SELLER"});
            this.CategoryComboBox.Location = new System.Drawing.Point(661, 71);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(164, 28);
            this.CategoryComboBox.TabIndex = 15;
            this.CategoryComboBox.Text = "Select Category";
            this.CategoryComboBox.SelectionChangeCommitted += new System.EventHandler(this.CategoryComboBox_SelectionChangeCommitted);
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackColor = System.Drawing.Color.Transparent;
            this.RefreshButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RefreshButton.FlatAppearance.BorderSize = 0;
            this.RefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshButton.Font = new System.Drawing.Font("Courgette", 14.25F, System.Drawing.FontStyle.Bold);
            this.RefreshButton.ForeColor = System.Drawing.Color.Bisque;
            this.RefreshButton.Location = new System.Drawing.Point(831, 71);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(114, 29);
            this.RefreshButton.TabIndex = 16;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = false;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.BackColor = System.Drawing.Color.Transparent;
            this.DateLabel.Font = new System.Drawing.Font("Courgette", 14.25F);
            this.DateLabel.ForeColor = System.Drawing.Color.Bisque;
            this.DateLabel.Location = new System.Drawing.Point(752, 25);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(48, 24);
            this.DateLabel.TabIndex = 18;
            this.DateLabel.Text = "Date";
            // 
            // SellingProductDataGridView
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(231)))), ((int)(((byte)(203)))));
            this.SellingProductDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.SellingProductDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SellingProductDataGridView.BackgroundColor = System.Drawing.Color.Green;
            this.SellingProductDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SellingProductDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.SellingProductDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SellingProductDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.SellingProductDataGridView.ColumnHeadersHeight = 30;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(239)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(201)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SellingProductDataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.SellingProductDataGridView.EnableHeadersVisualStyles = false;
            this.SellingProductDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(231)))), ((int)(((byte)(201)))));
            this.SellingProductDataGridView.Location = new System.Drawing.Point(607, 106);
            this.SellingProductDataGridView.Name = "SellingProductDataGridView";
            this.SellingProductDataGridView.RowHeadersVisible = false;
            this.SellingProductDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SellingProductDataGridView.Size = new System.Drawing.Size(359, 280);
            this.SellingProductDataGridView.TabIndex = 19;
            this.SellingProductDataGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Green;
            this.SellingProductDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(231)))), ((int)(((byte)(203)))));
            this.SellingProductDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.SellingProductDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.SellingProductDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.SellingProductDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.SellingProductDataGridView.ThemeStyle.BackColor = System.Drawing.Color.Green;
            this.SellingProductDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(231)))), ((int)(((byte)(201)))));
            this.SellingProductDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.SellingProductDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.SellingProductDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.SellingProductDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.SellingProductDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.SellingProductDataGridView.ThemeStyle.HeaderStyle.Height = 30;
            this.SellingProductDataGridView.ThemeStyle.ReadOnly = false;
            this.SellingProductDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(239)))), ((int)(((byte)(220)))));
            this.SellingProductDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.SellingProductDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.SellingProductDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.SellingProductDataGridView.ThemeStyle.RowsStyle.Height = 22;
            this.SellingProductDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(201)))), ((int)(((byte)(138)))));
            this.SellingProductDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.SellingProductDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SellingProductDataGridView_CellContentClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Courgette", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Bisque;
            this.label8.Location = new System.Drawing.Point(623, 473);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Price";
            // 
            // ProductPriceTextBox
            // 
            this.ProductPriceTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProductPriceTextBox.Enabled = false;
            this.ProductPriceTextBox.Font = new System.Drawing.Font("Courgette", 12F, System.Drawing.FontStyle.Bold);
            this.ProductPriceTextBox.ForeColor = System.Drawing.Color.Gold;
            this.ProductPriceTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.ProductPriceTextBox.HintText = "";
            this.ProductPriceTextBox.isPassword = false;
            this.ProductPriceTextBox.LineFocusedColor = System.Drawing.Color.Yellow;
            this.ProductPriceTextBox.LineIdleColor = System.Drawing.Color.Bisque;
            this.ProductPriceTextBox.LineMouseHoverColor = System.Drawing.Color.Yellow;
            this.ProductPriceTextBox.LineThickness = 4;
            this.ProductPriceTextBox.Location = new System.Drawing.Point(795, 465);
            this.ProductPriceTextBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ProductPriceTextBox.Name = "ProductPriceTextBox";
            this.ProductPriceTextBox.Size = new System.Drawing.Size(157, 27);
            this.ProductPriceTextBox.TabIndex = 21;
            this.ProductPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // SellerNameLabel
            // 
            this.SellerNameLabel.AutoSize = true;
            this.SellerNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.SellerNameLabel.Font = new System.Drawing.Font("Courgette", 14.25F);
            this.SellerNameLabel.ForeColor = System.Drawing.Color.Bisque;
            this.SellerNameLabel.Location = new System.Drawing.Point(527, 78);
            this.SellerNameLabel.Name = "SellerNameLabel";
            this.SellerNameLabel.Size = new System.Drawing.Size(55, 24);
            this.SellerNameLabel.TabIndex = 22;
            this.SellerNameLabel.Text = "Seller";
            // 
            // AddProductButton
            // 
            this.AddProductButton.BackColor = System.Drawing.Color.Transparent;
            this.AddProductButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddProductButton.FlatAppearance.BorderSize = 0;
            this.AddProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddProductButton.Font = new System.Drawing.Font("Courgette", 14.25F, System.Drawing.FontStyle.Bold);
            this.AddProductButton.ForeColor = System.Drawing.Color.Bisque;
            this.AddProductButton.Location = new System.Drawing.Point(702, 556);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(159, 32);
            this.AddProductButton.TabIndex = 23;
            this.AddProductButton.Text = "ADD PRODUCT";
            this.AddProductButton.UseVisualStyleBackColor = false;
            this.AddProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Courgette", 14.25F);
            this.label5.ForeColor = System.Drawing.Color.Bisque;
            this.label5.Location = new System.Drawing.Point(240, 381);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 24);
            this.label5.TabIndex = 24;
            this.label5.Text = "BILLS LIST";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Courgette", 14.25F);
            this.label6.ForeColor = System.Drawing.Color.Bisque;
            this.label6.Location = new System.Drawing.Point(163, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 24);
            this.label6.TabIndex = 25;
            this.label6.Text = "Amount Result:";
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.BackColor = System.Drawing.Color.Transparent;
            this.ResultLabel.Font = new System.Drawing.Font("Courgette", 14.25F);
            this.ResultLabel.ForeColor = System.Drawing.Color.Bisque;
            this.ResultLabel.Location = new System.Drawing.Point(332, 328);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(62, 24);
            this.ResultLabel.TabIndex = 26;
            this.ResultLabel.Text = "Result";
            // 
            // OrderDataGridView
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(231)))), ((int)(((byte)(203)))));
            this.OrderDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.OrderDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrderDataGridView.BackgroundColor = System.Drawing.Color.Green;
            this.OrderDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OrderDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.OrderDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrderDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.OrderDataGridView.ColumnHeadersHeight = 30;
            this.OrderDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ProductName,
            this.Price,
            this.Quantity,
            this.Total});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(239)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(201)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.OrderDataGridView.DefaultCellStyle = dataGridViewCellStyle9;
            this.OrderDataGridView.EnableHeadersVisualStyles = false;
            this.OrderDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(231)))), ((int)(((byte)(201)))));
            this.OrderDataGridView.Location = new System.Drawing.Point(18, 124);
            this.OrderDataGridView.Name = "OrderDataGridView";
            this.OrderDataGridView.RowHeadersVisible = false;
            this.OrderDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrderDataGridView.Size = new System.Drawing.Size(559, 201);
            this.OrderDataGridView.TabIndex = 27;
            this.OrderDataGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Green;
            this.OrderDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(231)))), ((int)(((byte)(203)))));
            this.OrderDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.OrderDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.OrderDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.OrderDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.OrderDataGridView.ThemeStyle.BackColor = System.Drawing.Color.Green;
            this.OrderDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(231)))), ((int)(((byte)(201)))));
            this.OrderDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.OrderDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.OrderDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.OrderDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.OrderDataGridView.ThemeStyle.HeaderStyle.Height = 30;
            this.OrderDataGridView.ThemeStyle.ReadOnly = false;
            this.OrderDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(239)))), ((int)(((byte)(220)))));
            this.OrderDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.OrderDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.OrderDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.OrderDataGridView.ThemeStyle.RowsStyle.Height = 22;
            this.OrderDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(201)))), ((int)(((byte)(138)))));
            this.OrderDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "NAME";
            this.ProductName.Name = "ProductName";
            // 
            // Price
            // 
            this.Price.HeaderText = "PRICE";
            this.Price.Name = "Price";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "QUANTITY";
            this.Quantity.Name = "Quantity";
            // 
            // Total
            // 
            this.Total.HeaderText = "TOTAL";
            this.Total.Name = "Total";
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.Transparent;
            this.DeleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Courgette", 14.25F, System.Drawing.FontStyle.Bold);
            this.DeleteButton.ForeColor = System.Drawing.Color.Bisque;
            this.DeleteButton.Location = new System.Drawing.Point(216, 556);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(105, 32);
            this.DeleteButton.TabIndex = 28;
            this.DeleteButton.Text = "DELETE";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Blackadder ITC", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label9.ForeColor = System.Drawing.Color.Gold;
            this.label9.Location = new System.Drawing.Point(10, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(354, 45);
            this.label9.TabIndex = 31;
            this.label9.Text = "SUPERMARKET";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Blackadder ITC", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label10.ForeColor = System.Drawing.Color.Gold;
            this.label10.Location = new System.Drawing.Point(62, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(214, 45);
            this.label10.TabIndex = 30;
            this.label10.Text = "RODOSTO";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Courgette", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Bisque;
            this.label11.Location = new System.Drawing.Point(419, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 30);
            this.label11.TabIndex = 32;
            this.label11.Text = "SELLER:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Bisque;
            this.label12.Location = new System.Drawing.Point(12, 587);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 15);
            this.label12.TabIndex = 33;
            this.label12.Text = "Version 1.0";
            // 
            // SellingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(994, 611);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.OrderDataGridView);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BillDataGridView);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddProductButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SellerNameLabel);
            this.Controls.Add(this.BillIDTextBox);
            this.Controls.Add(this.ProductPriceTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ProductNameTextBox);
            this.Controls.Add(this.SellingProductDataGridView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.ProductQuantityTextBox);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.PrintButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SellingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellingForm";
            this.Load += new System.EventHandler(this.SellingForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.SellingForm_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.BillDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SellingProductDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox BillIDTextBox;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ProductNameTextBox;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ProductQuantityTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button PrintButton;
        private Guna.UI2.WinForms.Guna2DataGridView BillDataGridView;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Label DateLabel;
        private Guna.UI2.WinForms.Guna2DataGridView SellingProductDataGridView;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ProductPriceTextBox;
        private System.Windows.Forms.Label SellerNameLabel;
        private System.Windows.Forms.Button AddProductButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label ResultLabel;
        private Guna.UI2.WinForms.Guna2DataGridView OrderDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}