namespace PayrollAppForms
{
    partial class FrmCreateEmployee
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.entFirstName = new System.Windows.Forms.TextBox();
            this.entAreaCode = new System.Windows.Forms.TextBox();
            this.entPrefix = new System.Windows.Forms.TextBox();
            this.cbMale = new System.Windows.Forms.CheckBox();
            this.entNumber = new System.Windows.Forms.TextBox();
            this.entStreet = new System.Windows.Forms.TextBox();
            this.entCity = new System.Windows.Forms.TextBox();
            this.entState = new System.Windows.Forms.TextBox();
            this.entZipCode = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.entLineNumber = new System.Windows.Forms.TextBox();
            this.lblPhoneNumberFormat = new System.Windows.Forms.Label();
            this.pnlLastName = new System.Windows.Forms.Panel();
            this.entLastName = new System.Windows.Forms.TextBox();
            this.pnlFirstName = new System.Windows.Forms.Panel();
            this.cbFemale = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblClose = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lblHours = new System.Windows.Forms.Label();
            this.nudHours = new System.Windows.Forms.NumericUpDown();
            this.lblWage = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.nudWage = new System.Windows.Forms.NumericUpDown();
            this.entTitle = new System.Windows.Forms.TextBox();
            this.cbPayroll = new System.Windows.Forms.CheckBox();
            this.tmrMoveOut = new System.Windows.Forms.Timer(this.components);
            this.tmrMoveIn = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.Black;
            this.btnCreate.Location = new System.Drawing.Point(234, 533);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(188, 86);
            this.btnCreate.TabIndex = 3;
            this.btnCreate.Text = "&Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // entFirstName
            // 
            this.entFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(48)))), ((int)(((byte)(75)))));
            this.entFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.entFirstName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.entFirstName.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entFirstName.ForeColor = System.Drawing.Color.White;
            this.entFirstName.Location = new System.Drawing.Point(6, 39);
            this.entFirstName.Name = "entFirstName";
            this.entFirstName.Size = new System.Drawing.Size(182, 21);
            this.entFirstName.TabIndex = 1;
            this.entFirstName.Text = "First Name";
            this.entFirstName.Click += new System.EventHandler(this.EntFirstName_Click);
            // 
            // entAreaCode
            // 
            this.entAreaCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(48)))), ((int)(((byte)(75)))));
            this.entAreaCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.entAreaCode.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entAreaCode.ForeColor = System.Drawing.Color.White;
            this.entAreaCode.Location = new System.Drawing.Point(24, 32);
            this.entAreaCode.Name = "entAreaCode";
            this.entAreaCode.Size = new System.Drawing.Size(50, 21);
            this.entAreaCode.TabIndex = 3;
            this.entAreaCode.Text = "111";
            this.entAreaCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.entAreaCode.Click += new System.EventHandler(this.EntAreaCode_Click);
            // 
            // entPrefix
            // 
            this.entPrefix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(48)))), ((int)(((byte)(75)))));
            this.entPrefix.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.entPrefix.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entPrefix.ForeColor = System.Drawing.Color.White;
            this.entPrefix.Location = new System.Drawing.Point(91, 32);
            this.entPrefix.Name = "entPrefix";
            this.entPrefix.Size = new System.Drawing.Size(50, 21);
            this.entPrefix.TabIndex = 4;
            this.entPrefix.Text = "222";
            this.entPrefix.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.entPrefix.Click += new System.EventHandler(this.EntPrefix_Click);
            // 
            // cbMale
            // 
            this.cbMale.AutoSize = true;
            this.cbMale.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMale.ForeColor = System.Drawing.Color.White;
            this.cbMale.Location = new System.Drawing.Point(276, 86);
            this.cbMale.Name = "cbMale";
            this.cbMale.Size = new System.Drawing.Size(72, 26);
            this.cbMale.TabIndex = 6;
            this.cbMale.Text = "Male";
            this.cbMale.UseVisualStyleBackColor = true;
            // 
            // entNumber
            // 
            this.entNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(48)))), ((int)(((byte)(75)))));
            this.entNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.entNumber.Font = new System.Drawing.Font("Arial", 11F);
            this.entNumber.ForeColor = System.Drawing.Color.White;
            this.entNumber.Location = new System.Drawing.Point(6, 93);
            this.entNumber.Name = "entNumber";
            this.entNumber.Size = new System.Drawing.Size(80, 22);
            this.entNumber.TabIndex = 9;
            this.entNumber.Text = "Number";
            this.entNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.entNumber.Click += new System.EventHandler(this.EntNumber_Click);
            // 
            // entStreet
            // 
            this.entStreet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(48)))), ((int)(((byte)(75)))));
            this.entStreet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.entStreet.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entStreet.ForeColor = System.Drawing.Color.White;
            this.entStreet.Location = new System.Drawing.Point(8, 34);
            this.entStreet.Name = "entStreet";
            this.entStreet.Size = new System.Drawing.Size(396, 21);
            this.entStreet.TabIndex = 8;
            this.entStreet.Text = "Street Name";
            this.entStreet.Click += new System.EventHandler(this.EntStreet_Click);
            // 
            // entCity
            // 
            this.entCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(48)))), ((int)(((byte)(75)))));
            this.entCity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.entCity.Font = new System.Drawing.Font("Arial", 11F);
            this.entCity.ForeColor = System.Drawing.Color.White;
            this.entCity.Location = new System.Drawing.Point(99, 92);
            this.entCity.Name = "entCity";
            this.entCity.Size = new System.Drawing.Size(117, 22);
            this.entCity.TabIndex = 10;
            this.entCity.Text = "City";
            this.entCity.Click += new System.EventHandler(this.EntCity_Click);
            // 
            // entState
            // 
            this.entState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(48)))), ((int)(((byte)(75)))));
            this.entState.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.entState.Font = new System.Drawing.Font("Arial", 11F);
            this.entState.ForeColor = System.Drawing.Color.White;
            this.entState.Location = new System.Drawing.Point(229, 92);
            this.entState.Name = "entState";
            this.entState.Size = new System.Drawing.Size(50, 22);
            this.entState.TabIndex = 11;
            this.entState.Text = "State";
            this.entState.Click += new System.EventHandler(this.EntState_Click);
            // 
            // entZipCode
            // 
            this.entZipCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(48)))), ((int)(((byte)(75)))));
            this.entZipCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.entZipCode.Font = new System.Drawing.Font("Arial", 11F);
            this.entZipCode.ForeColor = System.Drawing.Color.White;
            this.entZipCode.Location = new System.Drawing.Point(297, 92);
            this.entZipCode.Name = "entZipCode";
            this.entZipCode.Size = new System.Drawing.Size(115, 22);
            this.entZipCode.TabIndex = 12;
            this.entZipCode.Text = "Zipcode";
            this.entZipCode.Click += new System.EventHandler(this.EntZipCode_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel7);
            this.groupBox1.Controls.Add(this.panel6);
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.entStreet);
            this.groupBox1.Controls.Add(this.entZipCode);
            this.groupBox1.Controls.Add(this.entNumber);
            this.groupBox1.Controls.Add(this.entCity);
            this.groupBox1.Controls.Add(this.entState);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9F);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Location = new System.Drawing.Point(12, 229);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 145);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Address";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Location = new System.Drawing.Point(295, 115);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(117, 1);
            this.panel7.TabIndex = 30;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(228, 115);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(50, 1);
            this.panel6.TabIndex = 30;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(97, 115);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(117, 1);
            this.panel5.TabIndex = 30;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(7, 115);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(80, 1);
            this.panel4.TabIndex = 29;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(7, 54);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(396, 1);
            this.panel3.TabIndex = 28;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.pnlLastName);
            this.groupBox2.Controls.Add(this.entLastName);
            this.groupBox2.Controls.Add(this.pnlFirstName);
            this.groupBox2.Controls.Add(this.cbFemale);
            this.groupBox2.Controls.Add(this.cbMale);
            this.groupBox2.Controls.Add(this.entFirstName);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 9F);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox2.Location = new System.Drawing.Point(12, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(416, 149);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Demographic";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.panel2);
            this.groupBox4.Controls.Add(this.entLineNumber);
            this.groupBox4.Controls.Add(this.entAreaCode);
            this.groupBox4.Controls.Add(this.entPrefix);
            this.groupBox4.Controls.Add(this.lblPhoneNumberFormat);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox4.Location = new System.Drawing.Point(6, 74);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(235, 69);
            this.groupBox4.TabIndex = 28;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Phone Number";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(7, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 1);
            this.panel2.TabIndex = 27;
            // 
            // entLineNumber
            // 
            this.entLineNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(48)))), ((int)(((byte)(75)))));
            this.entLineNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.entLineNumber.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entLineNumber.ForeColor = System.Drawing.Color.White;
            this.entLineNumber.Location = new System.Drawing.Point(157, 32);
            this.entLineNumber.Name = "entLineNumber";
            this.entLineNumber.Size = new System.Drawing.Size(49, 21);
            this.entLineNumber.TabIndex = 5;
            this.entLineNumber.Text = "3333";
            this.entLineNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.entLineNumber.Click += new System.EventHandler(this.EntLineNumber_Click);
            // 
            // lblPhoneNumberFormat
            // 
            this.lblPhoneNumberFormat.AutoSize = true;
            this.lblPhoneNumberFormat.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumberFormat.ForeColor = System.Drawing.Color.White;
            this.lblPhoneNumberFormat.Location = new System.Drawing.Point(10, 31);
            this.lblPhoneNumberFormat.Name = "lblPhoneNumberFormat";
            this.lblPhoneNumberFormat.Size = new System.Drawing.Size(148, 22);
            this.lblPhoneNumberFormat.TabIndex = 27;
            this.lblPhoneNumberFormat.Text = "(            )            -";
            // 
            // pnlLastName
            // 
            this.pnlLastName.BackColor = System.Drawing.Color.White;
            this.pnlLastName.Location = new System.Drawing.Point(222, 59);
            this.pnlLastName.Name = "pnlLastName";
            this.pnlLastName.Size = new System.Drawing.Size(181, 1);
            this.pnlLastName.TabIndex = 26;
            // 
            // entLastName
            // 
            this.entLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(48)))), ((int)(((byte)(75)))));
            this.entLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.entLastName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.entLastName.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entLastName.ForeColor = System.Drawing.Color.White;
            this.entLastName.Location = new System.Drawing.Point(222, 39);
            this.entLastName.Name = "entLastName";
            this.entLastName.Size = new System.Drawing.Size(182, 21);
            this.entLastName.TabIndex = 2;
            this.entLastName.Text = "Last Name";
            this.entLastName.Click += new System.EventHandler(this.EntLastName_Click);
            // 
            // pnlFirstName
            // 
            this.pnlFirstName.BackColor = System.Drawing.Color.White;
            this.pnlFirstName.Location = new System.Drawing.Point(6, 59);
            this.pnlFirstName.Name = "pnlFirstName";
            this.pnlFirstName.Size = new System.Drawing.Size(181, 1);
            this.pnlFirstName.TabIndex = 24;
            // 
            // cbFemale
            // 
            this.cbFemale.AutoSize = true;
            this.cbFemale.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFemale.ForeColor = System.Drawing.Color.White;
            this.cbFemale.Location = new System.Drawing.Point(276, 113);
            this.cbFemale.Name = "cbFemale";
            this.cbFemale.Size = new System.Drawing.Size(96, 26);
            this.cbFemale.TabIndex = 7;
            this.cbFemale.Text = "Female";
            this.cbFemale.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 518);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 1);
            this.panel1.TabIndex = 23;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(10, 533);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(188, 86);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "C&ancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.White;
            this.lblClose.Location = new System.Drawing.Point(405, 9);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(23, 22);
            this.lblClose.TabIndex = 25;
            this.lblClose.Text = "&X";
            this.lblClose.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 35);
            this.label1.TabIndex = 26;
            this.label1.Text = "-Create Employee-";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel10);
            this.groupBox3.Controls.Add(this.panel9);
            this.groupBox3.Controls.Add(this.lblHours);
            this.groupBox3.Controls.Add(this.nudHours);
            this.groupBox3.Controls.Add(this.lblWage);
            this.groupBox3.Controls.Add(this.panel8);
            this.groupBox3.Controls.Add(this.nudWage);
            this.groupBox3.Controls.Add(this.entTitle);
            this.groupBox3.Controls.Add(this.cbPayroll);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 9F);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox3.Location = new System.Drawing.Point(12, 389);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(416, 108);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Position";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.White;
            this.panel10.Location = new System.Drawing.Point(257, 93);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(115, 1);
            this.panel10.TabIndex = 34;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Location = new System.Drawing.Point(257, 49);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(115, 1);
            this.panel9.TabIndex = 33;
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Font = new System.Drawing.Font("Arial", 11F);
            this.lblHours.ForeColor = System.Drawing.Color.White;
            this.lblHours.Location = new System.Drawing.Point(198, 72);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(65, 22);
            this.lblHours.TabIndex = 35;
            this.lblHours.Text = "Hours:";
            // 
            // nudHours
            // 
            this.nudHours.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(48)))), ((int)(((byte)(75)))));
            this.nudHours.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudHours.DecimalPlaces = 2;
            this.nudHours.Font = new System.Drawing.Font("Arial", 11F);
            this.nudHours.ForeColor = System.Drawing.Color.White;
            this.nudHours.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudHours.Location = new System.Drawing.Point(276, 69);
            this.nudHours.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudHours.Name = "nudHours";
            this.nudHours.Size = new System.Drawing.Size(120, 25);
            this.nudHours.TabIndex = 16;
            // 
            // lblWage
            // 
            this.lblWage.AutoSize = true;
            this.lblWage.Font = new System.Drawing.Font("Arial", 11F);
            this.lblWage.ForeColor = System.Drawing.Color.White;
            this.lblWage.Location = new System.Drawing.Point(198, 28);
            this.lblWage.Name = "lblWage";
            this.lblWage.Size = new System.Drawing.Size(65, 22);
            this.lblWage.TabIndex = 33;
            this.lblWage.Text = "Wage:";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Location = new System.Drawing.Point(20, 45);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(144, 1);
            this.panel8.TabIndex = 32;
            // 
            // nudWage
            // 
            this.nudWage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(48)))), ((int)(((byte)(75)))));
            this.nudWage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudWage.DecimalPlaces = 2;
            this.nudWage.Font = new System.Drawing.Font("Arial", 11F);
            this.nudWage.ForeColor = System.Drawing.Color.White;
            this.nudWage.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudWage.Location = new System.Drawing.Point(276, 25);
            this.nudWage.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudWage.Name = "nudWage";
            this.nudWage.Size = new System.Drawing.Size(120, 25);
            this.nudWage.TabIndex = 14;
            // 
            // entTitle
            // 
            this.entTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(48)))), ((int)(((byte)(75)))));
            this.entTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.entTitle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.entTitle.Font = new System.Drawing.Font("Arial", 11F);
            this.entTitle.ForeColor = System.Drawing.Color.White;
            this.entTitle.Location = new System.Drawing.Point(20, 24);
            this.entTitle.Name = "entTitle";
            this.entTitle.Size = new System.Drawing.Size(144, 22);
            this.entTitle.TabIndex = 13;
            this.entTitle.Text = "Title";
            this.entTitle.Click += new System.EventHandler(this.EntTitle_Click);
            // 
            // cbPayroll
            // 
            this.cbPayroll.AutoSize = true;
            this.cbPayroll.Font = new System.Drawing.Font("Arial", 11F);
            this.cbPayroll.ForeColor = System.Drawing.Color.White;
            this.cbPayroll.Location = new System.Drawing.Point(30, 66);
            this.cbPayroll.Name = "cbPayroll";
            this.cbPayroll.Size = new System.Drawing.Size(130, 26);
            this.cbPayroll.TabIndex = 15;
            this.cbPayroll.Text = "On Payroll?";
            this.cbPayroll.UseVisualStyleBackColor = true;
            // 
            // tmrMoveOut
            // 
            this.tmrMoveOut.Interval = 1;
            this.tmrMoveOut.Tick += new System.EventHandler(this.TmrMoveOut_Tick);
            // 
            // tmrMoveIn
            // 
            this.tmrMoveIn.Interval = 1;
            this.tmrMoveIn.Tick += new System.EventHandler(this.TmrMoveIn_Tick);
            // 
            // FrmCreateEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(48)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(440, 635);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCreate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCreateEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCreateEmployee";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox entFirstName;
        private System.Windows.Forms.TextBox entAreaCode;
        private System.Windows.Forms.TextBox entPrefix;
        private System.Windows.Forms.CheckBox cbMale;
        private System.Windows.Forms.TextBox entNumber;
        private System.Windows.Forms.TextBox entStreet;
        private System.Windows.Forms.TextBox entCity;
        private System.Windows.Forms.TextBox entState;
        private System.Windows.Forms.TextBox entZipCode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox entLineNumber;
        private System.Windows.Forms.CheckBox cbFemale;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Panel pnlFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlLastName;
        private System.Windows.Forms.TextBox entLastName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblPhoneNumberFormat;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.NumericUpDown nudHours;
        private System.Windows.Forms.Label lblWage;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.NumericUpDown nudWage;
        private System.Windows.Forms.TextBox entTitle;
        private System.Windows.Forms.CheckBox cbPayroll;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Timer tmrMoveOut;
        private System.Windows.Forms.Timer tmrMoveIn;
    }
}