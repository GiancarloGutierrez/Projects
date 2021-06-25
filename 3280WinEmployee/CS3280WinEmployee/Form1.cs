using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;

namespace CS3280WinEmployee
{
    public partial class Form1 : Form
    {
        Color originalGroupBoxColor = Color.White;
        Color originalSubmitBtnColor = Color.White;
        bool updateSelected = false;
        int updateRow = 0;
        int updateID = 0;
        public Form1()
        {
            InitializeComponent();
            btnSubmit.BackColor = Color.White;
            originalGroupBoxColor = groupBox1.BackColor;
            groupBox1.BackColor = Color.White;
            cmbState.SelectedItem = "CA";
            radioSalaried.Checked = true;
            originalSubmitBtnColor = btnSubmit.BackColor;
            btnAddNew.Visible = false;
            gbDataFields.Visible = false;

            #region Event intialization region
            btnSubmit.MouseEnter += BtnSubmit_MouseEnter;
            btnSubmit.MouseLeave += BtnSubmit_MouseLeave;

            txtLastname.MouseEnter += TxtLastname_MouseEnter;
            txtLastname.MouseLeave += TxtLastname_MouseLeave;
            txtSSN.Leave += TxtSSN_Leave;
            #endregion

            #region Control Initialization Code
            Organization.DepartmentsDataTable dtDeptTable = null;

            try
            {
                dtDeptTable = Utility.GetDepartments(); //Possibility of exception
            }
            catch(SqlException sqlEx)
            {
                MessageBox.Show(sqlEx.Message);
                MessageBox.Show("Application will close. Contact the Administrator on 1-888-888-8888");
                return;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Application will close. Contact the Administrator on 1-888-888-8888");
                return;
            }

            cmbDepartments.DataSource = dtDeptTable;
            cmbDepartments.DisplayMember = dtDeptTable.DeptNameColumn.ColumnName; //for small apps can use table name directly "DeptName"
            cmbDepartments.ValueMember = dtDeptTable.DeptIDColumn.ColumnName; // for small aps can use table name directly "DeptID"

            #endregion
            //get employees and bind them to the datagrid
            Organization.EmployeesDataTable dtEmpTable = null;
            try
            {
                dtEmpTable = Utility.GetEmployees(); //Possibility of exception
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show(sqlEx.Message);
                MessageBox.Show("Application will close. Contact the Administrator on 1-888-888-8888");
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Application will close. Contact the Administrator on 1-888-888-8888");
                return;
            }
            
            dgEmployee.DataSource = dtEmpTable;
            dgEmployee.Columns["EmpID"].Visible = false;
            dgEmployee.Columns["Salary"].Visible = false;
            dgEmployee.Columns["Sales"].Visible = false;
            dgEmployee.Columns["Commision"].Visible = false;
            dgEmployee.Columns["EmployeeType"].Visible = false;
            dgEmployee.Columns["BirthDate"].Visible = false;
            dgEmployee.Columns["JoiningDate"].Visible = false;
            dgEmployee.Columns["MaritalStatus"].Visible = false;
            dgEmployee.Columns["Address1"].Visible = false;
            dgEmployee.Columns["Address2"].Visible = false;
            dgEmployee.Columns["City"].Visible = false;
            dgEmployee.Columns["State"].Visible = false;
            dgEmployee.Columns["Zip"].Visible = false;

            DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn();
            deleteColumn.HeaderText = "Use to Delete";
            deleteColumn.Text = "Delete";
            deleteColumn.Name = "deleteColumn";
            deleteColumn.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn editColumn = new DataGridViewButtonColumn();
            editColumn.HeaderText = "Live Edit";
            editColumn.Text = "Edit";
            editColumn.Name = "editColumn";
            editColumn.UseColumnTextForButtonValue = true;

            dgEmployee.Columns.Add(deleteColumn);
            dgEmployee.Columns.Add(editColumn);


            //dgEmployee.SelectionChanged += new EventHandler(DataGrid_SelectionChanged);
            //dgEmployee.SelectionChanged += DgEmployee_SelectionChanged;
            dgEmployee.CellClick += DgEmployee_CellClick;
        }

        public void reloadEmployeeData()
        {
            Organization.EmployeesDataTable dtEmpTable = null;
            try
            {
                dtEmpTable = Utility.GetEmployees(); //Possibility of exception
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show(sqlEx.Message);
                MessageBox.Show("Application will close. Contact the Administrator on 1-888-888-8888");
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Application will close. Contact the Administrator on 1-888-888-8888");
                return;
            }

            dgEmployee.DataSource = dtEmpTable;
            dgEmployee.Columns["EmpID"].Visible = false;
            dgEmployee.Columns["Salary"].Visible = false;
            dgEmployee.Columns["Sales"].Visible = false;
            dgEmployee.Columns["Commision"].Visible = false;
            dgEmployee.Columns["EmployeeType"].Visible = false;
            dgEmployee.Columns["BirthDate"].Visible = false;
            dgEmployee.Columns["JoiningDate"].Visible = false;
            dgEmployee.Columns["MaritalStatus"].Visible = false;
            dgEmployee.Columns["Address1"].Visible = false;
            dgEmployee.Columns["Address2"].Visible = false;
            dgEmployee.Columns["City"].Visible = false;
            dgEmployee.Columns["State"].Visible = false;
            dgEmployee.Columns["Zip"].Visible = false;

            dgEmployee.Columns.Remove(dgEmployee.Columns["deleteColumn"]);
            dgEmployee.Columns.Remove(dgEmployee.Columns["editColumn"]);
            DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn();
            deleteColumn.HeaderText = "Use to Delete";
            deleteColumn.Text = "Delete";
            deleteColumn.Name = "deleteColumn";
            deleteColumn.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn editColumn = new DataGridViewButtonColumn();
            editColumn.HeaderText = "Live Edit";
            editColumn.Text = "Edit";
            editColumn.Name = "editColumn";
            editColumn.UseColumnTextForButtonValue = true;

            dgEmployee.Columns.Add(deleteColumn);
            dgEmployee.Columns.Add(editColumn);
        }

        private void DgEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex == dgEmployee.RowCount - 1 || e.RowIndex== -1)
            {
                return;
            }
            if (e.ColumnIndex == -1)
            {
               
                updateSelected = true;
                updateRow = e.RowIndex;
                var yRow = dgEmployee.Rows[e.RowIndex];
                updateID = int.Parse(yRow.Cells["EmpID"].Value.ToString());
                txtFirstName.Text = yRow.Cells["FName"].Value.ToString();
                txtLastname.Text = yRow.Cells["LName"].Value.ToString();
                txtSSN.Text = yRow.Cells["SSN"].Value.ToString();
                txtAddress1.Text = yRow.Cells["Address1"].Value.ToString();
                txtAddress2.Text = yRow.Cells["Address2"].Value.ToString();
                txtCity.Text = yRow.Cells["City"].Value.ToString();
                txtZip.Text = yRow.Cells["zip"].Value.ToString();
                cmbState.SelectedItem = yRow.Cells["State"].Value.ToString();
                bool checkTemp = true;
                if (int.Parse(yRow.Cells["MaritalStatus"].Value.ToString()) == 0)
                {
                    checkTemp = false;
                }
                chkMarried.Checked = checkTemp;
                cmbDepartments.SelectedItem = yRow.Cells["DeptID"].Value.ToString();
                int typeEmp = int.Parse(yRow.Cells["EmployeeType"].Value.ToString());
                switch (typeEmp)
                {
                    case 0:
                        radioSalaried.Checked = true;
                        txtSalary.Text = yRow.Cells["Salary"].Value.ToString();
                        break;
                    case 1:
                        radioCommision.Checked = true;
                        txtComission.Text = yRow.Cells["Commision"].Value.ToString();
                        txtSales.Text = yRow.Cells["Sales"].Value.ToString();
                        break;
                    case 2:
                        radioBaseComission.Checked = true;
                        txtSalary.Text = yRow.Cells["Salary"].Value.ToString();
                        txtComission.Text = yRow.Cells["Commision"].Value.ToString();
                        txtSales.Text = yRow.Cells["Sales"].Value.ToString();
                        break;
                }
                dpBirthday.Value =(DateTime)yRow.Cells["BirthDate"].Value;
                dpJoinDate.Value = (DateTime)yRow.Cells["JoiningDate"].Value;
                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
                if (!gbDataFields.Visible)
                {
                    gbDataFields.Show();
                    btnShow.Text = "Hide Form";
                }
                return;
                
            }


            var existingCellValue = dgEmployee.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();


            if (existingCellValue.Equals("Delete"))
            {
                Utility.DeleteEmployee(e.RowIndex);
                reloadEmployeeData();
                resetFields();
                if (gbDataFields.Visible)
                {
                    gbDataFields.Hide();
                    btnShow.Text = "Add Employee";
                }
                return;
            }
            if (existingCellValue.Equals("Edit"))
            {
               
                var uRow = dgEmployee.Rows[e.RowIndex];
                var x1 = int.Parse(uRow.Cells["EmpID"].Value.ToString());
                var x3 = uRow.Cells["FName"].Value.ToString();
                var x4 = uRow.Cells["LName"].Value.ToString();
                var x5 = uRow.Cells["SSN"].Value.ToString();
                var x6 = uRow.Cells["DeptID"].Value.ToString();
                var x7 = decimal.Parse(uRow.Cells["Salary"].Value.ToString());
                var x8 = decimal.Parse(uRow.Cells["Sales"].Value.ToString()) ;
                var x9 = decimal.Parse(uRow.Cells["Commision"].Value.ToString());
                var x10 = DateTime.Parse((uRow.Cells["BirthDate"].Value.ToString()));
                var x11 = DateTime.Parse(uRow.Cells["JoiningDate"].Value.ToString());
                var x12 = int.Parse(uRow.Cells["MaritalStatus"].Value.ToString());
                var x13 = uRow.Cells["Address1"].Value.ToString();
                var x14 = uRow.Cells["Address2"].Value.ToString();
                var x15 = uRow.Cells["City"].Value.ToString();
                var x16 = uRow.Cells["State"].Value.ToString();
                var x17 = uRow.Cells["zip"].Value.ToString();
                var x18 = int.Parse(uRow.Cells["EmployeeType"].Value.ToString());
                bool x12bool = true;
                if (x12 == 0)
                {
                    x12bool = false;
                }
                Utility.UpdateEmployee(x1,x3,x4,x5,x6,x7,x8,x9,x10,x11,x12bool,x13,x14,x15,x16,x17,x18);
                reloadEmployeeData();
            }
        }

        //private void DgEmployee_SelectionChanged(object sender, EventArgs e)
        //{
        //    throw new NotImplementedException();
        //}


        private void TxtSSN_Leave(object sender, EventArgs e)
        {
            
        }

        private void TxtLastname_MouseLeave(object sender, EventArgs e)
        {
            txtLastname.Size = new Size(txtLastname.Size.Width - 10, txtLastname.Size.Height);
        }
    

        private void TxtLastname_MouseEnter(object sender, EventArgs e)
        {
            txtLastname.Size = new Size(txtLastname.Size.Width + 10, txtLastname.Size.Height);
        }
        private void BtnSubmit_MouseLeave(object sender, EventArgs e)
        {
            btnSubmit.BackColor = originalSubmitBtnColor;
            
        }

        private void BtnSubmit_MouseEnter(object sender, EventArgs e)
        {
            btnSubmit.BackColor = Color.Beige;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbState_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(cmbState.SelectedItem.ToString());
            //MessageBox.Show(cmbState.SelectedIndex.ToString());
            
        }

        private void chkMarried_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioSalaried_CheckedChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(radioSalaried.Checked.ToString());
            //MessageBox.Show(radioCommision.Checked.ToString());
            //MessageBox.Show(radioBaseComission.Checked.ToString());
            lblSalary.Visible = true;
            txtSalary.Visible = true;
            lblSales.Visible = false;
            lblCommission.Visible = false;
            txtComission.Visible = false;
            txtSales.Visible = false;
        }

        private void radioCommision_CheckedChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(radioSalaried.Checked.ToString());
            //MessageBox.Show(radioCommision.Checked.ToString());
            //MessageBox.Show(radioBaseComission.Checked.ToString());
            lblSalary.Visible = false;
            txtSalary.Visible = false;
            lblSales.Visible = true;
            lblCommission.Visible = true;
            txtComission.Visible = true;
            txtSales.Visible = true;
        }

        private void radioBaseComission_CheckedChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(radioSalaried.Checked.ToString());
            //MessageBox.Show(radioCommision.Checked.ToString());
            //MessageBox.Show(radioBaseComission.Checked.ToString());
            lblSalary.Visible = true;
            txtSalary.Visible = true;
            lblSales.Visible = true;
            lblCommission.Visible = true;
            txtComission.Visible = true;
            txtSales.Visible = true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text == string.Empty)
            {
                errorProvider1.SetError(txtFirstName, "First Name is Required");
                return;
            }
            else
            {
                errorProvider1.SetError(txtFirstName, "");
            }
            if(txtLastname.Text == string.Empty)
            {
                errorProvider2.SetError(txtLastname, "First Name is Required");
                return;
            }
            else
            {
                errorProvider2.SetError(txtLastname, "");
            }
            if(!(Regex.IsMatch(txtZip.Text, @"^\d{5}$"))){
                errorProvider4.SetError(txtZip, "Need a Valid 5 digit Zip");
                return;
            }
            else
            {
                errorProvider4.SetError(txtZip, "");
            }
            bool isSSNCorrect1 = Regex.IsMatch(txtSSN.Text, @"^\d{3}-\d{2}-\d{4}$");
            bool isSSNCorrect2 = Regex.IsMatch(txtSSN.Text, @"^\d{9}$");
            if (!isSSNCorrect1 && !isSSNCorrect2)
            {
                errorProvider3.SetError(txtSSN, "Not a valid SSN");
                return;
            }
            else
            {
                errorProvider3.SetError(txtSSN, "");
            }
            if (dpBirthday.Value >= DateTime.Today)
            {
                dpBirthday.Value = DateTime.Today.AddDays(-1);
                MessageBox.Show("Birthdate must a past date");
                return;
            }
            string employeeInformation = string.Empty;
            employeeInformation += txtFirstName.Text + " " +txtLastname.Text + "\r\n";
            employeeInformation += txtAddress1.Text + " " + txtAddress2.Text + " " + cmbState.SelectedItem.ToString() + "\r\n";
            employeeInformation += txtSSN.Text + "\r\n";
            if (txtSalary.Visible) {
                employeeInformation += "Salary : " + txtSalary.Text + "\r\n";
            }
            if (txtComission.Visible) {
                employeeInformation += "Commision Rate : " + txtComission.Text + "\r\n";
            }
            if (txtSales.Visible)
            {
                employeeInformation += "Sales : " + txtSales.Text + "\r\n";
            }
            //txtEmployeeInfo.Text = employeeInformation;

            //txtEmployeeInfo.Enabled = true;
            groupBox1.BackColor = originalGroupBoxColor;

            Class1 c1 = new Class1();

            //Write some code here
            decimal salary = 0;
            decimal commission = 0;
            decimal sales = 0;
            if(txtSalary.Text != string.Empty)
            {
                salary = decimal.Parse(txtSalary.Text);
            }
            if(txtComission.Text != string.Empty)
            {
                commission = decimal.Parse(txtComission.Text);
            }
            if(txtSales.Text != string.Empty)
            {
                sales = decimal.Parse(txtSales.Text);
            }
            Organization.DepartmentsDataTable dtDepTable = new Organization.DepartmentsDataTable();
            dtDepTable = Utility.GetDepartments();
            string deptId = dtDepTable[cmbDepartments.SelectedIndex].DeptName;
            int typeEmp = 0;
            if (radioBaseComission.Checked)
            {
                typeEmp = 2;
            }
            if (radioCommision.Checked)
            {
                typeEmp = 1;
            }
            if (updateSelected)
            {
                Utility.UpdateEmployee(updateID,txtFirstName.Text, txtLastname.Text, txtSSN.Text, deptId, salary, commission, sales,
                                    dpBirthday.Value, dpJoinDate.Value, chkMarried.Checked, txtAddress1.Text, txtAddress2.Text,
                                    txtCity.Text, cmbState.SelectedItem.ToString(), txtZip.Text, typeEmp);
            }
            else
            {
                Utility.SaveEmployee(txtFirstName.Text, txtLastname.Text, txtSSN.Text, deptId, salary, commission, sales,
                                    dpBirthday.Value, dpJoinDate.Value, chkMarried.Checked, txtAddress1.Text, txtAddress2.Text,
                                    txtCity.Text, cmbState.SelectedItem.ToString(), txtZip.Text, typeEmp);
            }

            reloadEmployeeData();

        }

        private void dpBirthday_ValueChanged(object sender, EventArgs e)
        {
            if(dpBirthday.Value >= DateTime.Today)
            {
                dpBirthday.Value = DateTime.Today.AddDays(-1);
                MessageBox.Show("Birthdate must a past date");
            }
        }

        private void btnResetSelect_Click(object sender, EventArgs e)
        {
            resetFields();
            if (gbDataFields.Visible)
            {
                gbDataFields.Hide();
                btnShow.Text = "Add Employee";
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            resetFields();
            btnAddNew.Visible = false;
            btnSubmit.Text = "Submit";
        }

        private void resetFields()
        {
            txtFirstName.Clear();
            txtLastname.Clear();
            txtSSN.Clear();
            txtAddress1.Clear();
            txtAddress2.Clear();
            txtZip.Clear();
            txtCity.Clear();
            chkMarried.Checked = false;
            txtSalary.Clear();
            txtComission.Clear();
            txtSales.Clear();
            dpBirthday.Value = DateTime.Today.AddDays(-1);
            dpJoinDate.Value = DateTime.Today.AddDays(-1);
            btnAddNew.Visible = false;
            btnSubmit.Text = "Submit";
            updateSelected = false;
            reloadEmployeeData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            reloadEmployeeData();
            DataTable searched = Utility.FindEmployees(txtSearch.Text);
            dgEmployee.DataSource = searched;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (gbDataFields.Visible)
            {
                gbDataFields.Hide();
                btnShow.Text = "Add Employee";
                resetFields();
            }
            else
            {
                gbDataFields.Show();
                btnShow.Text = "Hide Form";
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
        }

        public void reloadDepts()
        {
            Organization.DepartmentsDataTable dtDeptTable = null;

            try
            {
                dtDeptTable = Utility.GetDepartments(); //Possibility of exception
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show(sqlEx.Message);
                MessageBox.Show("Application will close. Contact the Administrator on 1-888-888-8888");
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Application will close. Contact the Administrator on 1-888-888-8888");
                return;
            }

            cmbDepartments.DataSource = dtDeptTable;
            cmbDepartments.DisplayMember = dtDeptTable.DeptNameColumn.ColumnName; //for small apps can use table name directly "DeptName"
            cmbDepartments.ValueMember = dtDeptTable.DeptIDColumn.ColumnName; // for small aps can use table name directly "DeptID"
        }
    }
}
