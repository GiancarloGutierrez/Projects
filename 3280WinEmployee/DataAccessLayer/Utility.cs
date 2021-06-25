using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public static class Utility
    {
        public static Organization.DepartmentsDataTable GetDepartments() {
            try
            {
                OrganizationTableAdapters.DepartmentsTableAdapter deptAdapter = new OrganizationTableAdapters.DepartmentsTableAdapter();
                Organization.DepartmentsDataTable dtDeptTable = new Organization.DepartmentsDataTable();
                deptAdapter.Fill(dtDeptTable);

                return dtDeptTable;
            }
            catch(SqlException sqlException)
            {
                System.Diagnostics.Debug.WriteLine(sqlException.Message);
                throw sqlException;
            }
            catch(Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                throw ex;
            }
        }


        public static void SaveEmployee(string fname, string lname, string ssn, string deptID, decimal salary,
                                        decimal commissionRate, decimal sales, DateTime birthed, DateTime joined, bool married,
                                        string ad1, string ad2, string cit, string ste, string zipcode, int type)
        {
            int married2 = 0;
            if (married)
            {
                married2 = 1;
            }
            OrganizationTableAdapters.EmployeesTableAdapter empAdapter = new OrganizationTableAdapters.EmployeesTableAdapter();
            Organization.EmployeesDataTable dtEmpTable = new Organization.EmployeesDataTable();
            empAdapter.Fill(dtEmpTable);

            Organization.EmployeesRow newEmpRow = dtEmpTable.NewEmployeesRow();
            newEmpRow.DeptID = deptID;
            newEmpRow.FName = fname;
            newEmpRow.Lname = lname;
            newEmpRow.SSN = ssn;
            newEmpRow.Salary = salary;
            newEmpRow.Sales = sales;
            newEmpRow.Commision = commissionRate;
            newEmpRow.BirthDate = birthed;
            newEmpRow.JoiningDate = joined;
            newEmpRow.MaritalStatus = married2;
            newEmpRow.Address1 = ad1;
            newEmpRow.Address2 = ad2;
            newEmpRow.City = cit;
            newEmpRow.State = ste;
            newEmpRow.zip = zipcode;
            newEmpRow.EmployeeType = type;

            dtEmpTable.AddEmployeesRow(newEmpRow);

            empAdapter.Update(dtEmpTable);
        }

        public static void SaveDepartment(string name, string location, string contact, string phone)
        {
            OrganizationTableAdapters.DepartmentsTableAdapter deptAdapter = new OrganizationTableAdapters.DepartmentsTableAdapter();
            Organization.DepartmentsDataTable dtDeptTable = new Organization.DepartmentsDataTable();
            deptAdapter.Fill(dtDeptTable);

            Organization.DepartmentsRow newDeptRow = dtDeptTable.NewDepartmentsRow();
            newDeptRow.DeptName = name;
            newDeptRow.Location = location;
            newDeptRow.ContactName = contact;
            newDeptRow.PhoneNumber = phone;

            dtDeptTable.AddDepartmentsRow(newDeptRow);

            deptAdapter.Update(dtDeptTable);
        }

        public static void UpdateDepartment(int id, string dname, string location, string pname, string phone)
        {
            OrganizationTableAdapters.DepartmentsTableAdapter deptAdapter = new OrganizationTableAdapters.DepartmentsTableAdapter();
            Organization.DepartmentsDataTable dtDeptTable = new Organization.DepartmentsDataTable();
            deptAdapter.Fill(dtDeptTable);
            int row = dtDeptTable.Rows.IndexOf(
                                                dtDeptTable.Select("DeptID="+id).Single()
                                                );

            dtDeptTable[row].DeptName = dname;
            dtDeptTable[row].Location = location;
            dtDeptTable[row].ContactName = pname;
            dtDeptTable[row].PhoneNumber = phone;

            deptAdapter.Update(dtDeptTable);
        }

        public static void DeleteDepartment(int row)
        {
            OrganizationTableAdapters.DepartmentsTableAdapter deptAdapter = new OrganizationTableAdapters.DepartmentsTableAdapter();
            Organization.DepartmentsDataTable dtDeptTable = new Organization.DepartmentsDataTable();
            deptAdapter.Fill(dtDeptTable);

            dtDeptTable.Rows[row].Delete();

            deptAdapter.Update(dtDeptTable);
        }

        public static void DeleteEmployee(int row)
        {
            OrganizationTableAdapters.EmployeesTableAdapter empAdapter = new OrganizationTableAdapters.EmployeesTableAdapter();
            Organization.EmployeesDataTable dtEmpTable = new Organization.EmployeesDataTable();
            empAdapter.Fill(dtEmpTable);

            dtEmpTable.Rows[row].Delete();

            empAdapter.Update(dtEmpTable);

        }

        public static void UpdateEmployee(int id, string fname, string lname, string ssn, string dept, decimal salary, decimal sales,
                                               decimal commission, DateTime birth, DateTime join, bool msat, string ad1, string ad2,
                                               string cit, string ste, string zipcode, int type)
        {
            OrganizationTableAdapters.EmployeesTableAdapter empAdapter = new OrganizationTableAdapters.EmployeesTableAdapter();
            Organization.EmployeesDataTable dtEmpTable = new Organization.EmployeesDataTable();
            empAdapter.Fill(dtEmpTable);
            int row = dtEmpTable.Rows.IndexOf(
                                               dtEmpTable.Select("EmpID=" + id).Single()
                                                );
            int married2 = 0;
            if (msat)
            {
                married2 = 1;
            }
            dtEmpTable[row].FName = fname;
            dtEmpTable[row].Lname = lname;
            dtEmpTable[row].SSN = ssn;
            dtEmpTable[row].DeptID = dept;
            dtEmpTable[row].Salary = salary;
            dtEmpTable[row].Sales = sales;
            dtEmpTable[row].Commision = commission;
            dtEmpTable[row].BirthDate = birth;
            dtEmpTable[row].JoiningDate = join;
            dtEmpTable[row].MaritalStatus = married2;
            dtEmpTable[row].Address1 = ad1;
            dtEmpTable[row].Address2 = ad2;
            dtEmpTable[row].City = cit;
            dtEmpTable[row].State = ste;
            dtEmpTable[row].zip = zipcode;
            dtEmpTable[row].EmployeeType = type;

            empAdapter.Update(dtEmpTable);
        }

        public static Organization.EmployeesDataTable GetEmployees()
        {
            try
            {
                OrganizationTableAdapters.EmployeesTableAdapter empAdapter = new OrganizationTableAdapters.EmployeesTableAdapter();
                Organization.EmployeesDataTable dtEmpTable = new Organization.EmployeesDataTable();
                empAdapter.Fill(dtEmpTable);

                return dtEmpTable;
            }
            catch (SqlException sqlException)
            {
                System.Diagnostics.Debug.WriteLine(sqlException.Message);
                throw sqlException;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                throw ex;
            }

        }
        public static DataTable FindEmployees(string sp)
        {
           
            OrganizationTableAdapters.EmployeesTableAdapter empAdapter = new OrganizationTableAdapters.EmployeesTableAdapter();
            Organization.EmployeesDataTable dtEmpTable = new Organization.EmployeesDataTable();
            empAdapter.Fill(dtEmpTable);
            DataTable table2 = new DataTable();
            int count = (dtEmpTable.Where(r => r.FName.Contains(sp) ||
                                                         r.Lname.Contains(sp) ||
                                                         r.DeptID.Contains(sp)).Count());
            if ( count > 0)
            {
                table2 = dtEmpTable.Where(r => r.FName.Contains(sp) ||
                                                            r.Lname.Contains(sp) ||
                                                            r.DeptID.Contains(sp)
                                                          ).CopyToDataTable();
            }
            

            return table2;

        }
        public static DataTable FindDepartments(string sp)
        {
            OrganizationTableAdapters.DepartmentsTableAdapter deptAdapter = new OrganizationTableAdapters.DepartmentsTableAdapter();
            Organization.DepartmentsDataTable dtDeptTable = new Organization.DepartmentsDataTable();
            deptAdapter.Fill(dtDeptTable);
            DataTable table2 = new DataTable();
            int count = (dtDeptTable.Where(r => r.DeptName.Contains(sp) ||
                                             r.Location.Contains(sp) ||
                                             r.ContactName.Contains(sp) ||
                                             r.PhoneNumber.Contains(sp)
                                            ).Count());
            if(count > 0)
            {
                table2 = dtDeptTable.Where(r => r.DeptName.Contains(sp) ||
                                             r.Location.Contains(sp) ||
                                             r.ContactName.Contains(sp) ||
                                             r.PhoneNumber.Contains(sp)
                                            ).CopyToDataTable();
            }

            return table2;
           
        }

    }
}
