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
    public partial class MainForm : Form
    {
        Form1 empForm;
        DepartmentsForm deptForm;
        public MainForm()
        {
            InitializeComponent();
            empForm = new Form1();
            deptForm = new DepartmentsForm();

            empForm.MdiParent = this;
            deptForm.MdiParent = this;

            empForm.Show();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            empForm.Show();
            empForm.reloadDepts();
            deptForm.Hide();
        }

        private void departmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deptForm.Show();
            empForm.Hide();
        }
    }
}
