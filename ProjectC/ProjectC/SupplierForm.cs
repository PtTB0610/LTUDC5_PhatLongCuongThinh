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
    public partial class SupplierForm : Form
    {
        public SupplierForm()
        {
            InitializeComponent();
        }

        private void SupplierForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'electronicSupermarketDataSet.SUPPLIER' table. You can move, or remove it, as needed.
            this.sUPPLIERTableAdapter.Fill(this.electronicSupermarketDataSet.SUPPLIER);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
