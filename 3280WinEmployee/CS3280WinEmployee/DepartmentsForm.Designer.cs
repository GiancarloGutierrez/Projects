
namespace CS3280WinEmployee
{
    partial class DepartmentsForm
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
            this.lblDeptName = new System.Windows.Forms.Label();
            this.lblDeptLocation = new System.Windows.Forms.Label();
            this.txtDeptName = new System.Windows.Forms.TextBox();
            this.txtDeptLocation = new System.Windows.Forms.TextBox();
            this.dgDepartment = new System.Windows.Forms.DataGridView();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblContactName = new System.Windows.Forms.Label();
            this.lblContactPhone = new System.Windows.Forms.Label();
            this.txtContactName = new System.Windows.Forms.TextBox();
            this.txtContactPhone = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btNew = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.gpDataFields = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgDepartment)).BeginInit();
            this.gpDataFields.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDeptName
            // 
            this.lblDeptName.AutoSize = true;
            this.lblDeptName.Location = new System.Drawing.Point(42, 69);
            this.lblDeptName.Name = "lblDeptName";
            this.lblDeptName.Size = new System.Drawing.Size(123, 17);
            this.lblDeptName.TabIndex = 0;
            this.lblDeptName.Text = "Department Name";
            // 
            // lblDeptLocation
            // 
            this.lblDeptLocation.AutoSize = true;
            this.lblDeptLocation.Location = new System.Drawing.Point(25, 113);
            this.lblDeptLocation.Name = "lblDeptLocation";
            this.lblDeptLocation.Size = new System.Drawing.Size(140, 17);
            this.lblDeptLocation.TabIndex = 1;
            this.lblDeptLocation.Text = "Department Location";
            // 
            // txtDeptName
            // 
            this.txtDeptName.Location = new System.Drawing.Point(195, 64);
            this.txtDeptName.Name = "txtDeptName";
            this.txtDeptName.Size = new System.Drawing.Size(196, 22);
            this.txtDeptName.TabIndex = 2;
            // 
            // txtDeptLocation
            // 
            this.txtDeptLocation.Location = new System.Drawing.Point(195, 113);
            this.txtDeptLocation.Name = "txtDeptLocation";
            this.txtDeptLocation.Size = new System.Drawing.Size(196, 22);
            this.txtDeptLocation.TabIndex = 3;
            // 
            // dgDepartment
            // 
            this.dgDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDepartment.Location = new System.Drawing.Point(92, 69);
            this.dgDepartment.Name = "dgDepartment";
            this.dgDepartment.RowHeadersWidth = 51;
            this.dgDepartment.RowTemplate.Height = 24;
            this.dgDepartment.Size = new System.Drawing.Size(896, 225);
            this.dgDepartment.TabIndex = 4;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(171, 257);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(115, 37);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(124, 26);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(82, 17);
            this.lblSearch.TabIndex = 6;
            this.lblSearch.Text = "Search For:";
            // 
            // lblContactName
            // 
            this.lblContactName.AutoSize = true;
            this.lblContactName.Location = new System.Drawing.Point(68, 159);
            this.lblContactName.Name = "lblContactName";
            this.lblContactName.Size = new System.Drawing.Size(97, 17);
            this.lblContactName.TabIndex = 7;
            this.lblContactName.Text = "Contact Name";
            // 
            // lblContactPhone
            // 
            this.lblContactPhone.AutoSize = true;
            this.lblContactPhone.Location = new System.Drawing.Point(64, 198);
            this.lblContactPhone.Name = "lblContactPhone";
            this.lblContactPhone.Size = new System.Drawing.Size(101, 17);
            this.lblContactPhone.TabIndex = 8;
            this.lblContactPhone.Text = "Contact Phone";
            // 
            // txtContactName
            // 
            this.txtContactName.Location = new System.Drawing.Point(195, 159);
            this.txtContactName.Name = "txtContactName";
            this.txtContactName.Size = new System.Drawing.Size(196, 22);
            this.txtContactName.TabIndex = 9;
            // 
            // txtContactPhone
            // 
            this.txtContactPhone.Location = new System.Drawing.Point(195, 198);
            this.txtContactPhone.Name = "txtContactPhone";
            this.txtContactPhone.Size = new System.Drawing.Size(196, 22);
            this.txtContactPhone.TabIndex = 10;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(228, 26);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(196, 22);
            this.txtSearch.TabIndex = 11;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(474, 21);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(97, 32);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btNew
            // 
            this.btNew.Location = new System.Drawing.Point(324, 257);
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(148, 37);
            this.btNew.TabIndex = 15;
            this.btNew.Text = "New Department";
            this.btNew.UseVisualStyleBackColor = true;
            this.btNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(830, 12);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(105, 43);
            this.btnReset.TabIndex = 16;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(749, 314);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(126, 59);
            this.btnShow.TabIndex = 17;
            this.btnShow.Text = "Add Department";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // gpDataFields
            // 
            this.gpDataFields.Controls.Add(this.lblDeptName);
            this.gpDataFields.Controls.Add(this.lblDeptLocation);
            this.gpDataFields.Controls.Add(this.btNew);
            this.gpDataFields.Controls.Add(this.txtDeptName);
            this.gpDataFields.Controls.Add(this.txtDeptLocation);
            this.gpDataFields.Controls.Add(this.lblContactName);
            this.gpDataFields.Controls.Add(this.lblContactPhone);
            this.gpDataFields.Controls.Add(this.btnSubmit);
            this.gpDataFields.Controls.Add(this.txtContactPhone);
            this.gpDataFields.Controls.Add(this.txtContactName);
            this.gpDataFields.Location = new System.Drawing.Point(127, 300);
            this.gpDataFields.Name = "gpDataFields";
            this.gpDataFields.Size = new System.Drawing.Size(581, 316);
            this.gpDataFields.TabIndex = 18;
            this.gpDataFields.TabStop = false;
            this.gpDataFields.Text = "Data Fields";
            // 
            // DepartmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 642);
            this.ControlBox = false;
            this.Controls.Add(this.gpDataFields);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.dgDepartment);
            this.Name = "DepartmentsForm";
            this.Text = "DepartmentsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgDepartment)).EndInit();
            this.gpDataFields.ResumeLayout(false);
            this.gpDataFields.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDeptName;
        private System.Windows.Forms.Label lblDeptLocation;
        private System.Windows.Forms.TextBox txtDeptName;
        private System.Windows.Forms.TextBox txtDeptLocation;
        private System.Windows.Forms.DataGridView dgDepartment;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblContactName;
        private System.Windows.Forms.Label lblContactPhone;
        private System.Windows.Forms.TextBox txtContactName;
        private System.Windows.Forms.TextBox txtContactPhone;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btNew;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.GroupBox gpDataFields;
    }
}