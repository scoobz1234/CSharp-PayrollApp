namespace PayrollAppForms
{
    partial class FrmReport
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
            this.components = new System.ComponentModel.Container();
            this.cmbEmployees = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblWarningTop = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblZipCode = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblWarningBottom = new System.Windows.Forms.Label();
            this.lblPay = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblWage = new System.Windows.Forms.Label();
            this.lblCalculatedPay = new System.Windows.Forms.Label();
            this.lblCurrentWage = new System.Windows.Forms.Label();
            this.lblHoursWorked = new System.Windows.Forms.Label();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbEmployees
            // 
            this.cmbEmployees.Font = new System.Drawing.Font("Arial", 11F);
            this.cmbEmployees.FormattingEnabled = true;
            this.cmbEmployees.Location = new System.Drawing.Point(34, 60);
            this.cmbEmployees.Name = "cmbEmployees";
            this.cmbEmployees.Size = new System.Drawing.Size(346, 29);
            this.cmbEmployees.TabIndex = 0;
            this.cmbEmployees.SelectedIndexChanged += new System.EventHandler(this.CmbEmployees_SelectedIndexChanged);
            this.cmbEmployees.Click += new System.EventHandler(this.CmbEmployees_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblWarningTop);
            this.groupBox1.Controls.Add(this.lblPhoneNumber);
            this.groupBox1.Controls.Add(this.lblZipCode);
            this.groupBox1.Controls.Add(this.lblCity);
            this.groupBox1.Controls.Add(this.lblStreet);
            this.groupBox1.Controls.Add(this.lblState);
            this.groupBox1.Controls.Add(this.lblNumber);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 11F);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Location = new System.Drawing.Point(34, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 201);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Address, Phone";
            // 
            // lblWarningTop
            // 
            this.lblWarningTop.AutoSize = true;
            this.lblWarningTop.Location = new System.Drawing.Point(66, 88);
            this.lblWarningTop.Name = "lblWarningTop";
            this.lblWarningTop.Size = new System.Drawing.Size(212, 22);
            this.lblWarningTop.TabIndex = 6;
            this.lblWarningTop.Text = "No Employee Selected!";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Arial", 11F);
            this.lblPhoneNumber.ForeColor = System.Drawing.Color.White;
            this.lblPhoneNumber.Location = new System.Drawing.Point(66, 126);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(153, 22);
            this.lblPhoneNumber.TabIndex = 5;
            this.lblPhoneNumber.Text = "(503) 351 - 1867";
            this.lblPhoneNumber.Visible = false;
            // 
            // lblZipCode
            // 
            this.lblZipCode.AutoSize = true;
            this.lblZipCode.Font = new System.Drawing.Font("Arial", 11F);
            this.lblZipCode.ForeColor = System.Drawing.Color.White;
            this.lblZipCode.Location = new System.Drawing.Point(217, 79);
            this.lblZipCode.Name = "lblZipCode";
            this.lblZipCode.Size = new System.Drawing.Size(65, 22);
            this.lblZipCode.TabIndex = 4;
            this.lblZipCode.Text = "85295";
            this.lblZipCode.Visible = false;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Arial", 11F);
            this.lblCity.ForeColor = System.Drawing.Color.White;
            this.lblCity.Location = new System.Drawing.Point(66, 79);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(66, 22);
            this.lblCity.TabIndex = 3;
            this.lblCity.Text = "Gilbert";
            this.lblCity.Visible = false;
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Font = new System.Drawing.Font("Arial", 11F);
            this.lblStreet.ForeColor = System.Drawing.Color.White;
            this.lblStreet.Location = new System.Drawing.Point(126, 57);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(119, 22);
            this.lblStreet.TabIndex = 2;
            this.lblStreet.Text = "S. Arroyo Ln.";
            this.lblStreet.Visible = false;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Arial", 11F);
            this.lblState.ForeColor = System.Drawing.Color.White;
            this.lblState.Location = new System.Drawing.Point(138, 79);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(73, 22);
            this.lblState.TabIndex = 1;
            this.lblState.Text = "Arizona";
            this.lblState.Visible = false;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Arial", 11F);
            this.lblNumber.ForeColor = System.Drawing.Color.White;
            this.lblNumber.Location = new System.Drawing.Point(66, 57);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(54, 22);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.Text = "2887";
            this.lblNumber.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblWarningBottom);
            this.groupBox2.Controls.Add(this.lblPay);
            this.groupBox2.Controls.Add(this.lblHours);
            this.groupBox2.Controls.Add(this.lblWage);
            this.groupBox2.Controls.Add(this.lblCalculatedPay);
            this.groupBox2.Controls.Add(this.lblCurrentWage);
            this.groupBox2.Controls.Add(this.lblHoursWorked);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 11F);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox2.Location = new System.Drawing.Point(34, 369);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(346, 171);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pay Information";
            // 
            // lblWarningBottom
            // 
            this.lblWarningBottom.AutoSize = true;
            this.lblWarningBottom.Location = new System.Drawing.Point(70, 76);
            this.lblWarningBottom.Name = "lblWarningBottom";
            this.lblWarningBottom.Size = new System.Drawing.Size(212, 22);
            this.lblWarningBottom.TabIndex = 7;
            this.lblWarningBottom.Text = "No Employee Selected!";
            // 
            // lblPay
            // 
            this.lblPay.AutoSize = true;
            this.lblPay.Font = new System.Drawing.Font("Arial", 11F);
            this.lblPay.ForeColor = System.Drawing.Color.White;
            this.lblPay.Location = new System.Drawing.Point(95, 98);
            this.lblPay.Name = "lblPay";
            this.lblPay.Size = new System.Drawing.Size(141, 22);
            this.lblPay.TabIndex = 7;
            this.lblPay.Text = "Calculated Pay:";
            this.lblPay.Visible = false;
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Font = new System.Drawing.Font("Arial", 11F);
            this.lblHours.ForeColor = System.Drawing.Color.White;
            this.lblHours.Location = new System.Drawing.Point(223, 38);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(65, 22);
            this.lblHours.TabIndex = 6;
            this.lblHours.Text = "Hours:";
            this.lblHours.Visible = false;
            // 
            // lblWage
            // 
            this.lblWage.AutoSize = true;
            this.lblWage.Font = new System.Drawing.Font("Arial", 11F);
            this.lblWage.ForeColor = System.Drawing.Color.White;
            this.lblWage.Location = new System.Drawing.Point(43, 40);
            this.lblWage.Name = "lblWage";
            this.lblWage.Size = new System.Drawing.Size(65, 22);
            this.lblWage.TabIndex = 5;
            this.lblWage.Text = "Wage:";
            this.lblWage.Visible = false;
            // 
            // lblCalculatedPay
            // 
            this.lblCalculatedPay.AutoSize = true;
            this.lblCalculatedPay.Font = new System.Drawing.Font("Arial", 11F);
            this.lblCalculatedPay.ForeColor = System.Drawing.Color.White;
            this.lblCalculatedPay.Location = new System.Drawing.Point(128, 129);
            this.lblCalculatedPay.Name = "lblCalculatedPay";
            this.lblCalculatedPay.Size = new System.Drawing.Size(72, 22);
            this.lblCalculatedPay.TabIndex = 4;
            this.lblCalculatedPay.Text = "VALUE";
            this.lblCalculatedPay.Visible = false;
            // 
            // lblCurrentWage
            // 
            this.lblCurrentWage.AutoSize = true;
            this.lblCurrentWage.Font = new System.Drawing.Font("Arial", 11F);
            this.lblCurrentWage.ForeColor = System.Drawing.Color.White;
            this.lblCurrentWage.Location = new System.Drawing.Point(46, 70);
            this.lblCurrentWage.Name = "lblCurrentWage";
            this.lblCurrentWage.Size = new System.Drawing.Size(48, 22);
            this.lblCurrentWage.TabIndex = 3;
            this.lblCurrentWage.Text = "56.5";
            this.lblCurrentWage.Visible = false;
            // 
            // lblHoursWorked
            // 
            this.lblHoursWorked.AutoSize = true;
            this.lblHoursWorked.Font = new System.Drawing.Font("Arial", 11F);
            this.lblHoursWorked.ForeColor = System.Drawing.Color.White;
            this.lblHoursWorked.Location = new System.Drawing.Point(230, 70);
            this.lblHoursWorked.Name = "lblHoursWorked";
            this.lblHoursWorked.Size = new System.Drawing.Size(48, 22);
            this.lblHoursWorked.TabIndex = 2;
            this.lblHoursWorked.Text = "25.5";
            this.lblHoursWorked.Visible = false;
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
            this.btnGoBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGoBack.Font = new System.Drawing.Font("Arial", 11F);
            this.btnGoBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGoBack.Location = new System.Drawing.Point(256, 560);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(124, 53);
            this.btnGoBack.TabIndex = 3;
            this.btnGoBack.Text = "Go Back";
            this.btnGoBack.UseVisualStyleBackColor = false;
            this.btnGoBack.Click += new System.EventHandler(this.BtnGoBack_Click);
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataSource = typeof(PayrollAppForms.Classes.Employees);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 18F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(33, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(237, 35);
            this.label7.TabIndex = 4;
            this.label7.Text = "Select Employee";
            // 
            // FrmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(48)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(440, 635);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbEmployees);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmReport";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEmployees;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblZipCode;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblPay;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label lblWage;
        private System.Windows.Forms.Label lblCalculatedPay;
        private System.Windows.Forms.Label lblCurrentWage;
        private System.Windows.Forms.Label lblHoursWorked;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblWarningTop;
        private System.Windows.Forms.Label lblWarningBottom;
    }
}