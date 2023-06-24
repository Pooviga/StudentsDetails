namespace StudentsDetails.UI
{
    partial class frmStudentDetails
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Button button1;
            grpDetails = new GroupBox();
            txtId = new TextBox();
            lblId = new Label();
            btnUpdate = new Button();
            btnSave = new Button();
            txtAmount = new TextBox();
            txtCity = new TextBox();
            txtMail = new TextBox();
            txtNumber = new TextBox();
            txtName = new TextBox();
            lblMail = new Label();
            lblNumber = new Label();
            lblCity = new Label();
            lblAmount = new Label();
            lblName = new Label();
            gdvDetails = new DataGridView();
            button1 = new Button();
            grpDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gdvDetails).BeginInit();
            SuspendLayout();
            // 
            // grpDetails
            // 
            grpDetails.BackColor = Color.Salmon;
            grpDetails.Controls.Add(button1);
            grpDetails.Controls.Add(txtId);
            grpDetails.Controls.Add(lblId);
            grpDetails.Controls.Add(btnUpdate);
            grpDetails.Controls.Add(btnSave);
            grpDetails.Controls.Add(txtAmount);
            grpDetails.Controls.Add(txtCity);
            grpDetails.Controls.Add(txtMail);
            grpDetails.Controls.Add(txtNumber);
            grpDetails.Controls.Add(txtName);
            grpDetails.Controls.Add(lblMail);
            grpDetails.Controls.Add(lblNumber);
            grpDetails.Controls.Add(lblCity);
            grpDetails.Controls.Add(lblAmount);
            grpDetails.Controls.Add(lblName);
            grpDetails.Location = new Point(24, 23);
            grpDetails.Name = "grpDetails";
            grpDetails.Size = new Size(583, 395);
            grpDetails.TabIndex = 0;
            grpDetails.TabStop = false;
            grpDetails.Text = "Student Details Box";
            grpDetails.Enter += grpDetails_Enter;
            // 
            // txtId
            // 
            txtId.Location = new Point(212, 36);
            txtId.Name = "txtId";
            txtId.Size = new Size(295, 27);
            txtId.TabIndex = 13;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(94, 36);
            lblId.Name = "lblId";
            lblId.Size = new Size(22, 20);
            lblId.TabIndex = 12;
            lblId.Text = "Id";
            lblId.Click += label1_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(258, 335);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(127, 29);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Delete";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += button1_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(63, 335);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(129, 29);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(212, 283);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(295, 27);
            txtAmount.TabIndex = 9;
            txtAmount.TextChanged += textBox5_TextChanged;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(212, 228);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(295, 27);
            txtCity.TabIndex = 8;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(212, 124);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(295, 27);
            txtMail.TabIndex = 7;
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(212, 174);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(295, 27);
            txtNumber.TabIndex = 6;
            // 
            // txtName
            // 
            txtName.Location = new Point(212, 72);
            txtName.Name = "txtName";
            txtName.Size = new Size(295, 27);
            txtName.TabIndex = 5;
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.Location = new Point(94, 124);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(38, 20);
            lblMail.TabIndex = 4;
            lblMail.Text = "Mail";
            // 
            // lblNumber
            // 
            lblNumber.AutoSize = true;
            lblNumber.Location = new Point(94, 177);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(63, 20);
            lblNumber.TabIndex = 3;
            lblNumber.Text = "Number";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new Point(94, 228);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(34, 20);
            lblCity.TabIndex = 2;
            lblCity.Text = "City";
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(94, 283);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(62, 20);
            lblAmount.TabIndex = 1;
            lblAmount.Text = "Amount";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(94, 72);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            // 
            // gdvDetails
            // 
            gdvDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gdvDetails.Location = new Point(696, 27);
            gdvDetails.Name = "gdvDetails";
            gdvDetails.RowHeadersWidth = 51;
            gdvDetails.RowTemplate.Height = 29;
            gdvDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gdvDetails.Size = new Size(581, 391);
            gdvDetails.TabIndex = 1;
            gdvDetails.CellContentClick += gdvDetails_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(432, 335);
            button1.Name = "button1";
            button1.Size = new Size(116, 29);
            button1.TabIndex = 14;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // frmStudentDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1340, 450);
            Controls.Add(gdvDetails);
            Controls.Add(grpDetails);
            Name = "frmStudentDetails";
            Text = "Student Details";
            grpDetails.ResumeLayout(false);
            grpDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gdvDetails).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpDetails;
        private TextBox txtAmount;
        private TextBox txtCity;
        private TextBox txtMail;
        private TextBox txtNumber;
        private TextBox txtName;
        private Label lblMail;
        private Label lblNumber;
        private Label lblCity;
        private Label lblAmount;
        private Label lblName;
        private Button btnSave;
        private Button btnUpdate;
        private DataGridView gdvDetails;
        private Label lblId;
        private TextBox txtId;
    }
}