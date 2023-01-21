namespace PharmacyAppNew
{
    partial class AddMedicineForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMedicineForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtMedName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nmInitial = new System.Windows.Forms.NumericUpDown();
            this.nmSell = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rctDescription = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbFirms = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtPro = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dtExpire = new System.Windows.Forms.DateTimePicker();
            this.ckReceipt = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.nmCount = new System.Windows.Forms.NumericUpDown();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cklBoxCategory = new System.Windows.Forms.CheckedListBox();
            this.dtgMedicine = new System.Windows.Forms.DataGridView();
            this.btnAddMedicine = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmInitial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmSell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMedicine)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1104, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1062, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // txtMedName
            // 
            this.txtMedName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMedName.Location = new System.Drawing.Point(13, 49);
            this.txtMedName.Name = "txtMedName";
            this.txtMedName.Size = new System.Drawing.Size(257, 34);
            this.txtMedName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(13, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Initial Price";
            // 
            // nmInitial
            // 
            this.nmInitial.DecimalPlaces = 2;
            this.nmInitial.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nmInitial.Location = new System.Drawing.Point(12, 181);
            this.nmInitial.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmInitial.Name = "nmInitial";
            this.nmInitial.Size = new System.Drawing.Size(257, 30);
            this.nmInitial.TabIndex = 6;
            // 
            // nmSell
            // 
            this.nmSell.DecimalPlaces = 2;
            this.nmSell.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nmSell.Location = new System.Drawing.Point(13, 250);
            this.nmSell.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmSell.Name = "nmSell";
            this.nmSell.Size = new System.Drawing.Size(257, 30);
            this.nmSell.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(13, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sell Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(632, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 28);
            this.label4.TabIndex = 9;
            this.label4.Text = "Description";
            // 
            // rctDescription
            // 
            this.rctDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rctDescription.Location = new System.Drawing.Point(632, 278);
            this.rctDescription.Name = "rctDescription";
            this.rctDescription.Size = new System.Drawing.Size(257, 147);
            this.rctDescription.TabIndex = 10;
            this.rctDescription.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(335, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 28);
            this.label5.TabIndex = 11;
            this.label5.Text = "Firm";
            // 
            // cmbFirms
            // 
            this.cmbFirms.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbFirms.FormattingEnabled = true;
            this.cmbFirms.Location = new System.Drawing.Point(335, 47);
            this.cmbFirms.Name = "cmbFirms";
            this.cmbFirms.Size = new System.Drawing.Size(251, 36);
            this.cmbFirms.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(335, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 28);
            this.label6.TabIndex = 13;
            this.label6.Text = "Produce Date";
            // 
            // dtPro
            // 
            this.dtPro.Location = new System.Drawing.Point(335, 140);
            this.dtPro.Name = "dtPro";
            this.dtPro.Size = new System.Drawing.Size(251, 27);
            this.dtPro.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(335, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 28);
            this.label7.TabIndex = 15;
            this.label7.Text = "Expire Date";
            // 
            // dtExpire
            // 
            this.dtExpire.Location = new System.Drawing.Point(335, 233);
            this.dtExpire.Name = "dtExpire";
            this.dtExpire.Size = new System.Drawing.Size(251, 27);
            this.dtExpire.TabIndex = 16;
            // 
            // ckReceipt
            // 
            this.ckReceipt.AutoSize = true;
            this.ckReceipt.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ckReceipt.Location = new System.Drawing.Point(13, 97);
            this.ckReceipt.Name = "ckReceipt";
            this.ckReceipt.Size = new System.Drawing.Size(146, 29);
            this.ckReceipt.TabIndex = 17;
            this.ckReceipt.Text = "With Receipt";
            this.ckReceipt.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(13, 295);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 28);
            this.label8.TabIndex = 18;
            this.label8.Text = "Count";
            // 
            // nmCount
            // 
            this.nmCount.Location = new System.Drawing.Point(13, 335);
            this.nmCount.Name = "nmCount";
            this.nmCount.Size = new System.Drawing.Size(150, 27);
            this.nmCount.TabIndex = 19;
            // 
            // cmbCategory
            // 
            this.cmbCategory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(629, 47);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(251, 36);
            this.cmbCategory.TabIndex = 21;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            this.cmbCategory.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cmbCategory_KeyUp);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(629, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 28);
            this.label9.TabIndex = 20;
            this.label9.Text = "Categories";
            // 
            // cklBoxCategory
            // 
            this.cklBoxCategory.FormattingEnabled = true;
            this.cklBoxCategory.Location = new System.Drawing.Point(632, 97);
            this.cklBoxCategory.Name = "cklBoxCategory";
            this.cklBoxCategory.Size = new System.Drawing.Size(248, 136);
            this.cklBoxCategory.TabIndex = 22;
            // 
            // dtgMedicine
            // 
            this.dtgMedicine.AllowUserToAddRows = false;
            this.dtgMedicine.AllowUserToDeleteRows = false;
            this.dtgMedicine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgMedicine.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgMedicine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMedicine.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgMedicine.Location = new System.Drawing.Point(0, 441);
            this.dtgMedicine.Name = "dtgMedicine";
            this.dtgMedicine.ReadOnly = true;
            this.dtgMedicine.RowHeadersWidth = 51;
            this.dtgMedicine.RowTemplate.Height = 29;
            this.dtgMedicine.Size = new System.Drawing.Size(1154, 348);
            this.dtgMedicine.TabIndex = 23;
            // 
            // btnAddMedicine
            // 
            this.btnAddMedicine.BackColor = System.Drawing.Color.YellowGreen;
            this.btnAddMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMedicine.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddMedicine.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddMedicine.Location = new System.Drawing.Point(358, 313);
            this.btnAddMedicine.Name = "btnAddMedicine";
            this.btnAddMedicine.Size = new System.Drawing.Size(201, 62);
            this.btnAddMedicine.TabIndex = 24;
            this.btnAddMedicine.Text = "Add Medicine";
            this.btnAddMedicine.UseVisualStyleBackColor = false;
            this.btnAddMedicine.Click += new System.EventHandler(this.btnAddMedicine_Click);
            // 
            // AddMedicineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 789);
            this.Controls.Add(this.btnAddMedicine);
            this.Controls.Add(this.dtgMedicine);
            this.Controls.Add(this.cklBoxCategory);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.nmCount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ckReceipt);
            this.Controls.Add(this.dtExpire);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtPro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbFirms);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rctDescription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nmSell);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nmInitial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMedName);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.OliveDrab;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddMedicineForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddMedicineForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AddMedicineForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmInitial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmSell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMedicine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox txtMedName;
        private Label label1;
        private Label label2;
        private NumericUpDown nmInitial;
        private NumericUpDown nmSell;
        private Label label3;
        private Label label4;
        private RichTextBox rctDescription;
        private Label label5;
        private ComboBox cmbFirms;
        private Label label6;
        private DateTimePicker dtPro;
        private Label label7;
        private DateTimePicker dtExpire;
        private CheckBox ckReceipt;
        private Label label8;
        private NumericUpDown nmCount;
        private ComboBox cmbCategory;
        private Label label9;
        private CheckedListBox cklBoxCategory;
        private DataGridView dtgMedicine;
        private Button btnAddMedicine;
    }
}