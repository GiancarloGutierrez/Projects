namespace CS3280WinEmployee
{
    partial class Form1
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
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.lblSSN = new System.Windows.Forms.Label();
            this.txtSSN = new System.Windows.Forms.TextBox();
            this.lblAddress1 = new System.Windows.Forms.Label();
            this.txtAddress1 = new System.Windows.Forms.TextBox();
            this.lblAddress2 = new System.Windows.Forms.Label();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbState = new System.Windows.Forms.ComboBox();
            this.chkMarried = new System.Windows.Forms.CheckBox();
            this.radioSalaried = new System.Windows.Forms.RadioButton();
            this.radioCommision = new System.Windows.Forms.RadioButton();
            this.radioBaseComission = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblCommission = new System.Windows.Forms.Label();
            this.txtComission = new System.Windows.Forms.TextBox();
            this.lblSales = new System.Windows.Forms.Label();
            this.txtSales = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.cmbDepartments = new System.Windows.Forms.ComboBox();
            this.dgEmployee = new System.Windows.Forms.DataGridView();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.lblJoinDate = new System.Windows.Forms.Label();
            this.dpBirthday = new System.Windows.Forms.DateTimePicker();
            this.dpJoinDate = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblZip = new System.Windows.Forms.Label();
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnResetSelect = new System.Windows.Forms.Button();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.gbDataFields = new System.Windows.Forms.GroupBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            this.gbDataFields.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(198, 47);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(178, 22);
            this.txtFirstName.TabIndex = 1;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(61, 51);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(76, 17);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(61, 91);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(76, 17);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "Last Name";
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(198, 86);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(178, 22);
            this.txtLastname.TabIndex = 2;
            // 
            // lblSSN
            // 
            this.lblSSN.AutoSize = true;
            this.lblSSN.Location = new System.Drawing.Point(61, 128);
            this.lblSSN.Name = "lblSSN";
            this.lblSSN.Size = new System.Drawing.Size(36, 17);
            this.lblSSN.TabIndex = 5;
            this.lblSSN.Text = "SSN";
            this.lblSSN.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSSN
            // 
            this.txtSSN.Location = new System.Drawing.Point(198, 124);
            this.txtSSN.Name = "txtSSN";
            this.txtSSN.Size = new System.Drawing.Size(178, 22);
            this.txtSSN.TabIndex = 4;
            this.txtSSN.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblAddress1
            // 
            this.lblAddress1.AutoSize = true;
            this.lblAddress1.Location = new System.Drawing.Point(61, 168);
            this.lblAddress1.Name = "lblAddress1";
            this.lblAddress1.Size = new System.Drawing.Size(103, 17);
            this.lblAddress1.TabIndex = 7;
            this.lblAddress1.Text = "Address Line 1";
            // 
            // txtAddress1
            // 
            this.txtAddress1.Location = new System.Drawing.Point(198, 163);
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(178, 22);
            this.txtAddress1.TabIndex = 6;
            // 
            // lblAddress2
            // 
            this.lblAddress2.AutoSize = true;
            this.lblAddress2.Location = new System.Drawing.Point(61, 207);
            this.lblAddress2.Name = "lblAddress2";
            this.lblAddress2.Size = new System.Drawing.Size(103, 17);
            this.lblAddress2.TabIndex = 9;
            this.lblAddress2.Text = "Address Line 2";
            // 
            // txtAddress2
            // 
            this.txtAddress2.Location = new System.Drawing.Point(198, 202);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(178, 22);
            this.txtAddress2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "State";
            // 
            // cmbState
            // 
            this.cmbState.FormattingEnabled = true;
            this.cmbState.Items.AddRange(new object[] {
            "UT",
            "CA",
            "NV",
            "OR",
            "WA",
            "CO",
            "NY"});
            this.cmbState.Location = new System.Drawing.Point(198, 243);
            this.cmbState.Name = "cmbState";
            this.cmbState.Size = new System.Drawing.Size(108, 24);
            this.cmbState.TabIndex = 11;
            this.cmbState.SelectedIndexChanged += new System.EventHandler(this.cmbState_SelectedIndexChanged);
            // 
            // chkMarried
            // 
            this.chkMarried.AutoSize = true;
            this.chkMarried.Location = new System.Drawing.Point(64, 297);
            this.chkMarried.Name = "chkMarried";
            this.chkMarried.Size = new System.Drawing.Size(180, 21);
            this.chkMarried.TabIndex = 13;
            this.chkMarried.Text = "Is Married (For taxation)";
            this.chkMarried.UseVisualStyleBackColor = true;
            this.chkMarried.CheckedChanged += new System.EventHandler(this.chkMarried_CheckedChanged);
            // 
            // radioSalaried
            // 
            this.radioSalaried.AutoSize = true;
            this.radioSalaried.Location = new System.Drawing.Point(22, 36);
            this.radioSalaried.Name = "radioSalaried";
            this.radioSalaried.Size = new System.Drawing.Size(81, 21);
            this.radioSalaried.TabIndex = 14;
            this.radioSalaried.TabStop = true;
            this.radioSalaried.Text = "Salaried";
            this.radioSalaried.UseVisualStyleBackColor = true;
            this.radioSalaried.CheckedChanged += new System.EventHandler(this.radioSalaried_CheckedChanged);
            // 
            // radioCommision
            // 
            this.radioCommision.AutoSize = true;
            this.radioCommision.Location = new System.Drawing.Point(146, 36);
            this.radioCommision.Name = "radioCommision";
            this.radioCommision.Size = new System.Drawing.Size(104, 21);
            this.radioCommision.TabIndex = 14;
            this.radioCommision.TabStop = true;
            this.radioCommision.Text = "Commission";
            this.radioCommision.UseVisualStyleBackColor = true;
            this.radioCommision.CheckedChanged += new System.EventHandler(this.radioCommision_CheckedChanged);
            // 
            // radioBaseComission
            // 
            this.radioBaseComission.AutoSize = true;
            this.radioBaseComission.Location = new System.Drawing.Point(288, 36);
            this.radioBaseComission.Name = "radioBaseComission";
            this.radioBaseComission.Size = new System.Drawing.Size(133, 21);
            this.radioBaseComission.TabIndex = 15;
            this.radioBaseComission.TabStop = true;
            this.radioBaseComission.Text = "Base+Comission";
            this.radioBaseComission.UseVisualStyleBackColor = true;
            this.radioBaseComission.CheckedChanged += new System.EventHandler(this.radioBaseComission_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioSalaried);
            this.groupBox1.Controls.Add(this.radioCommision);
            this.groupBox1.Controls.Add(this.radioBaseComission);
            this.groupBox1.Location = new System.Drawing.Point(24, 337);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(485, 80);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee Type";
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(0, 447);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(89, 22);
            this.txtSalary.TabIndex = 20;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.Location = new System.Drawing.Point(-3, 429);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(147, 19);
            this.lblSalary.TabIndex = 21;
            this.lblSalary.Text = "Salary/Base Salary";
            // 
            // lblCommission
            // 
            this.lblCommission.AutoSize = true;
            this.lblCommission.Location = new System.Drawing.Point(160, 429);
            this.lblCommission.Name = "lblCommission";
            this.lblCommission.Size = new System.Drawing.Size(114, 17);
            this.lblCommission.TabIndex = 23;
            this.lblCommission.Text = "Commisson Rate";
            // 
            // txtComission
            // 
            this.txtComission.Location = new System.Drawing.Point(163, 447);
            this.txtComission.Name = "txtComission";
            this.txtComission.Size = new System.Drawing.Size(89, 22);
            this.txtComission.TabIndex = 22;
            // 
            // lblSales
            // 
            this.lblSales.AutoSize = true;
            this.lblSales.Location = new System.Drawing.Point(321, 429);
            this.lblSales.Name = "lblSales";
            this.lblSales.Size = new System.Drawing.Size(43, 17);
            this.lblSales.TabIndex = 25;
            this.lblSales.Text = "Sales";
            // 
            // txtSales
            // 
            this.txtSales.Location = new System.Drawing.Point(325, 447);
            this.txtSales.Name = "txtSales";
            this.txtSales.Size = new System.Drawing.Size(89, 22);
            this.txtSales.TabIndex = 24;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSubmit.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnSubmit.Location = new System.Drawing.Point(163, 488);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(99, 31);
            this.btnSubmit.TabIndex = 26;
            this.btnSubmit.Text = "submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(396, 243);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(89, 22);
            this.txtZip.TabIndex = 12;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(274, 300);
            this.lblDepartment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(82, 17);
            this.lblDepartment.TabIndex = 28;
            this.lblDepartment.Text = "Department";
            // 
            // cmbDepartments
            // 
            this.cmbDepartments.FormattingEnabled = true;
            this.cmbDepartments.Location = new System.Drawing.Point(360, 297);
            this.cmbDepartments.Margin = new System.Windows.Forms.Padding(2);
            this.cmbDepartments.Name = "cmbDepartments";
            this.cmbDepartments.Size = new System.Drawing.Size(149, 24);
            this.cmbDepartments.TabIndex = 29;
            // 
            // dgEmployee
            // 
            this.dgEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmployee.Location = new System.Drawing.Point(76, 54);
            this.dgEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.dgEmployee.Name = "dgEmployee";
            this.dgEmployee.RowHeadersWidth = 82;
            this.dgEmployee.RowTemplate.Height = 33;
            this.dgEmployee.Size = new System.Drawing.Size(951, 188);
            this.dgEmployee.TabIndex = 30;
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Location = new System.Drawing.Point(438, 47);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(71, 17);
            this.lblBirthday.TabIndex = 31;
            this.lblBirthday.Text = "Birth Date";
            // 
            // lblJoinDate
            // 
            this.lblJoinDate.AutoSize = true;
            this.lblJoinDate.Location = new System.Drawing.Point(441, 89);
            this.lblJoinDate.Name = "lblJoinDate";
            this.lblJoinDate.Size = new System.Drawing.Size(68, 17);
            this.lblJoinDate.TabIndex = 32;
            this.lblJoinDate.Text = "Join Date";
            // 
            // dpBirthday
            // 
            this.dpBirthday.Location = new System.Drawing.Point(553, 45);
            this.dpBirthday.Name = "dpBirthday";
            this.dpBirthday.Size = new System.Drawing.Size(200, 22);
            this.dpBirthday.TabIndex = 33;
            this.dpBirthday.ValueChanged += new System.EventHandler(this.dpBirthday_ValueChanged);
            // 
            // dpJoinDate
            // 
            this.dpJoinDate.Location = new System.Drawing.Point(553, 86);
            this.dpJoinDate.Name = "dpJoinDate";
            this.dpJoinDate.Size = new System.Drawing.Size(200, 22);
            this.dpJoinDate.TabIndex = 34;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Location = new System.Drawing.Point(348, 246);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(28, 17);
            this.lblZip.TabIndex = 35;
            this.lblZip.Text = "Zip";
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 36;
            this.label2.Text = "Search For:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(302, 18);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(178, 22);
            this.txtSearch.TabIndex = 37;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(500, 9);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(123, 34);
            this.btnSearch.TabIndex = 38;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(347, 488);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(138, 32);
            this.btnAddNew.TabIndex = 39;
            this.btnAddNew.Text = "New Employee";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnResetSelect
            // 
            this.btnResetSelect.Location = new System.Drawing.Point(845, 15);
            this.btnResetSelect.Name = "btnResetSelect";
            this.btnResetSelect.Size = new System.Drawing.Size(138, 29);
            this.btnResetSelect.TabIndex = 40;
            this.btnResetSelect.Text = "Reset";
            this.btnResetSelect.UseVisualStyleBackColor = true;
            this.btnResetSelect.Click += new System.EventHandler(this.btnResetSelect_Click);
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(396, 207);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(31, 17);
            this.lblCity.TabIndex = 42;
            this.lblCity.Text = "City";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(444, 202);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(143, 22);
            this.txtCity.TabIndex = 41;
            // 
            // gbDataFields
            // 
            this.gbDataFields.Controls.Add(this.txtFirstName);
            this.gbDataFields.Controls.Add(this.lblCity);
            this.gbDataFields.Controls.Add(this.btnAddNew);
            this.gbDataFields.Controls.Add(this.lblFirstName);
            this.gbDataFields.Controls.Add(this.txtCity);
            this.gbDataFields.Controls.Add(this.txtLastname);
            this.gbDataFields.Controls.Add(this.btnSubmit);
            this.gbDataFields.Controls.Add(this.lblLastName);
            this.gbDataFields.Controls.Add(this.txtSSN);
            this.gbDataFields.Controls.Add(this.lblSSN);
            this.gbDataFields.Controls.Add(this.txtAddress1);
            this.gbDataFields.Controls.Add(this.lblAddress1);
            this.gbDataFields.Controls.Add(this.lblZip);
            this.gbDataFields.Controls.Add(this.txtAddress2);
            this.gbDataFields.Controls.Add(this.dpJoinDate);
            this.gbDataFields.Controls.Add(this.lblAddress2);
            this.gbDataFields.Controls.Add(this.dpBirthday);
            this.gbDataFields.Controls.Add(this.label1);
            this.gbDataFields.Controls.Add(this.lblJoinDate);
            this.gbDataFields.Controls.Add(this.cmbState);
            this.gbDataFields.Controls.Add(this.lblBirthday);
            this.gbDataFields.Controls.Add(this.chkMarried);
            this.gbDataFields.Controls.Add(this.groupBox1);
            this.gbDataFields.Controls.Add(this.cmbDepartments);
            this.gbDataFields.Controls.Add(this.txtSalary);
            this.gbDataFields.Controls.Add(this.lblDepartment);
            this.gbDataFields.Controls.Add(this.lblSalary);
            this.gbDataFields.Controls.Add(this.txtZip);
            this.gbDataFields.Controls.Add(this.txtComission);
            this.gbDataFields.Controls.Add(this.lblCommission);
            this.gbDataFields.Controls.Add(this.lblSales);
            this.gbDataFields.Controls.Add(this.txtSales);
            this.gbDataFields.Location = new System.Drawing.Point(76, 247);
            this.gbDataFields.Name = "gbDataFields";
            this.gbDataFields.Size = new System.Drawing.Size(808, 526);
            this.gbDataFields.TabIndex = 43;
            this.gbDataFields.TabStop = false;
            this.gbDataFields.Text = "Data Fields";
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(892, 261);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(135, 54);
            this.btnShow.TabIndex = 44;
            this.btnShow.Text = "Add Employee";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1655, 803);
            this.ControlBox = false;
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.gbDataFields);
            this.Controls.Add(this.btnResetSelect);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgEmployee);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EmployeeForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            this.gbDataFields.ResumeLayout(false);
            this.gbDataFields.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.Label lblSSN;
        private System.Windows.Forms.TextBox txtSSN;
        private System.Windows.Forms.Label lblAddress1;
        private System.Windows.Forms.TextBox txtAddress1;
        private System.Windows.Forms.Label lblAddress2;
        private System.Windows.Forms.TextBox txtAddress2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbState;
        private System.Windows.Forms.CheckBox chkMarried;
        private System.Windows.Forms.RadioButton radioSalaried;
        private System.Windows.Forms.RadioButton radioCommision;
        private System.Windows.Forms.RadioButton radioBaseComission;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblCommission;
        private System.Windows.Forms.TextBox txtComission;
        private System.Windows.Forms.Label lblSales;
        private System.Windows.Forms.TextBox txtSales;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.ComboBox cmbDepartments;
        private System.Windows.Forms.DataGridView dgEmployee;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.Label lblJoinDate;
        private System.Windows.Forms.DateTimePicker dpBirthday;
        private System.Windows.Forms.DateTimePicker dpJoinDate;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.Button btnResetSelect;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.GroupBox gbDataFields;
        private System.Windows.Forms.Button btnShow;
    }
}

