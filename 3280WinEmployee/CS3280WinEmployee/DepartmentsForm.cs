using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS3280WinEmployee
{
    public partial class DepartmentsForm : Form
    {
        bool updateSelected = false;
        int updateRow = 0;
        int updateID = 0;
        public DepartmentsForm()
        {
            InitializeComponent();
            var dtDeptTable = Utility.GetDepartments();
            dgDepartment.DataSource = dtDeptTable;
            dgDepartment.Columns["DeptID"].Visible = false;
            gpDataFields.Visible = false;

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

            dgDepartment.Columns.Add(deleteColumn);
            dgDepartment.Columns.Add(editColumn);
            dgDepartment.CellClick += DgDepartment_CellClick;

            btNew.Visible = false;
        }

        private void DgDepartment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex == dgDepartment.RowCount - 1|| e.RowIndex == -1)
            {
                return;
            }

            if (e.ColumnIndex == -1)
            {
                
                
                updateSelected = true;
                updateRow = e.RowIndex;
                var yRow = dgDepartment.Rows[e.RowIndex];
                updateID = int.Parse(yRow.Cells["DeptID"].Value.ToString());
                txtDeptName.Text = yRow.Cells["Deptname"].Value.ToString();
                txtDeptLocation.Text = yRow.Cells["Location"].Value.ToString();
                txtContactName.Text = yRow.Cells["ContactName"].Value.ToString();
                txtContactPhone.Text = yRow.Cells["PhoneNumber"].Value.ToString();
                btnSubmit.Text = "Update";
                btNew.Visible = true;
                if (!gpDataFields.Visible)
                {
                    gpDataFields.Show();
                    btnShow.Text = "Hide Form";
                }
                return;
                
                
            }

            var existingCellValue = dgDepartment.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

            if (existingCellValue.Equals("Delete"))
            {
                Utility.DeleteDepartment(e.RowIndex);
                RefreshData();
                ClearFields();
                updateSelected = false;
                btnSubmit.Text = "Submit";
                btNew.Visible = false;
                if (gpDataFields.Visible)
                {
                    gpDataFields.Hide();
                    ClearFields();
                    btnShow.Text = "Add Department";
                }
                return;
            }
            if (existingCellValue.Equals("Edit"))
            {

                var uRow = dgDepartment.Rows[e.RowIndex];
                var x1 = int.Parse(uRow.Cells["DeptID"].Value.ToString());
                var x2 = uRow.Cells["DeptName"].Value.ToString();
                var x3 = uRow.Cells["Location"].Value.ToString();
                var x4 = uRow.Cells["ContactName"].Value.ToString();
                var x5 = uRow.Cells["PhoneNumber"].Value.ToString();

                Utility.UpdateDepartment(x1, x2, x3, x4, x5);
                RefreshData();
            }
        }

        private void RefreshData()
        {
            var dtDeptTable = Utility.GetDepartments();
            dgDepartment.DataSource = dtDeptTable;
            dgDepartment.Columns["DeptID"].Visible = false;
            dgDepartment.Columns.Remove(dgDepartment.Columns["deleteColumn"]);
            dgDepartment.Columns.Remove(dgDepartment.Columns["editColumn"]);
            
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

            dgDepartment.Columns.Add(deleteColumn);
            dgDepartment.Columns.Add(editColumn);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (updateSelected)
            {
                Utility.UpdateDepartment(updateID, txtDeptName.Text, txtDeptLocation.Text, txtContactName.Text, txtContactPhone.Text);
                RefreshData();
            }
            else
            {
                Utility.SaveDepartment(txtDeptName.Text, txtDeptLocation.Text, txtContactName.Text, txtContactPhone.Text);
                RefreshData();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearFields();
            updateSelected = false;
            btnSubmit.Text = "Submit";
            btNew.Visible = false;
            RefreshData();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearFields();
            updateSelected = false;
            btnSubmit.Text = "Submit";
            btNew.Visible = false;
            RefreshData();
            if (gpDataFields.Visible)
            {
                gpDataFields.Hide();
                ClearFields();
                btnShow.Text = "Add Department";
            }

        }
        private void ClearFields()
        {
            txtSearch.Clear();
            txtDeptName.Clear();
            txtDeptLocation.Clear();
            txtContactName.Clear();
            txtContactPhone.Clear();
            updateSelected = false;
            btnSubmit.Text = "Submit";
            btNew.Visible = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            RefreshData();
            DataTable searched = Utility.FindDepartments(txtSearch.Text);
            dgDepartment.DataSource = searched;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (gpDataFields.Visible)
            {
                gpDataFields.Hide();
                ClearFields();
                btnShow.Text = "Add Department";
            }
            else
            {
                gpDataFields.Show();
                btnShow.Text = "Hide Form";
            }
        }
    }
}
