using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjectC
{
    public partial class EmployeeFORM : Form
    {
        public EmployeeFORM()
        {
            InitializeComponent();
        }

        private void EmployeeFORM_Load(object sender, EventArgs e)
        {

        }

        private void txtEmpName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);

        }

        private void txtEmpPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnEmpCreate_Click(object sender, EventArgs e)
        {
            addEmployee addEmp = new addEmployee();
            addEmp.Show();
        }

        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEmployee.SelectedCells.Count > 0)
            {
                txtUserID.Text = dgvEmployee.SelectedCells[0].Value.ToString();
                txtUserName.Text = dgvEmployee.SelectedCells[1].Value.ToString();
                txtUserPass.Text = dgvEmployee.SelectedCells[2].Value.ToString();
                cbUserType.SelectedValue = dgvEmployee.SelectedCells[4].Value.ToString();
                cbUserStatus.SelectedValue = dgvEmployee.SelectedCells[3].Value.ToString();
            }
        }
    }
}
