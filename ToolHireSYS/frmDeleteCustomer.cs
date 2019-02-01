using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToolHireSYS
{
    public partial class frmDeleteCustomer : Form
    {
        private frmMainMenu parent;

        public frmDeleteCustomer()
        {
            InitializeComponent();
        }

        public frmDeleteCustomer(frmMainMenu frmMainMenu)
        {
            InitializeComponent();
            this.parent = frmMainMenu;
        }

        private void frmDeleteCustomer_Load(object sender, EventArgs e)
        {

        }

         

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtCustID.ResetText();
            txtForename.ResetText();
            txtSurname.ResetText();
            MessageBox.Show("Customer deleted sucessfully.");
            
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            Customers myCustomer = new Customers();


            grdCustDelete.DataSource = Customers.getCustomer(txtSurname.Text).Tables["Customer"];
            grpCustDetails.Visible = true;
           
        }

        private void grdCustDelete_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow CustomerData = this.grdCustDelete.Rows[e.RowIndex];

            int ToolId = Convert.ToInt32(CustomerData.Cells[0].Value);

            txtCustID.Text = ToolId.ToString("0000");

            txtTitle.Text = CustomerData.Cells[1].Value.ToString();
            txtForename.Text = CustomerData.Cells[2].Value.ToString();
            txtSurname2.Text = CustomerData.Cells[3].Value.ToString();
            txtDOB.Text = CustomerData.Cells[4].Value.ToString();
            txtEmail.Text = CustomerData.Cells[5].Value.ToString();
            txtAddress1.Text = CustomerData.Cells[6].Value.ToString();
            txtAddress2.Text = CustomerData.Cells[7].Value.ToString();
            txtCounty.Text = CustomerData.Cells[8].Value.ToString();
            txtCreditDebit.Text = CustomerData.Cells[10].Value.ToString();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            Customers myCustomers = new Customers();
            myCustomers.removeCustomer(Convert.ToInt16(txtCustID.Text));

            txtCounty.ResetText();
            txtTitle.ResetText();
            txtAddress1.ResetText();
            txtAddress2.ResetText();

            txtCustID.ResetText();
            txtDOB.ResetText();
            txtEmail.ResetText();
            txtSurname.ResetText();
            txtForename.ResetText();
            txtSurname.ResetText();
            txtSurname2.ResetText();
            txtCreditDebit.ResetText();
        }
    }
}
