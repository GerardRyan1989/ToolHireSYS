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
    public partial class frmUpdateCustomer : Form
    {
        private frmMainMenu parent;

        public frmUpdateCustomer()
        {
            InitializeComponent();
        }

        public frmUpdateCustomer(frmMainMenu frmMainMenu)
        {
            InitializeComponent();
            this.parent = frmMainMenu;
        }

        private void frmUpdateCustomer_Load(object sender, EventArgs e)
        {
            cboCounty.ValueMember = "County";
            cboCounty.DataSource = Customers.getCounty().Tables["Counties"];


            cboTitle.ValueMember = "Title";
            cboTitle.DataSource = Customers.getTitle().Tables["Titles"];

            grpCustDetails.Visible = false;
            grpUpdateCustomer.Visible = false;
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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            grpUpdateCustomer.Visible = true;
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {

            Customers myCustomer = new Customers();
            grdCustUpdate.DataSource = Customers.getCustomer(txtSurname.Text).Tables["Customer"];
            grpCustDetails.Visible = true;
            grpUpdateCustomer.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            Customers myCustomers = new Customers();

            myCustomers.setTitle(cboTitle.Text);
            myCustomers.setForename(txtForename.Text);
            myCustomers.setSurname(txtSurname2.Text);
            myCustomers.setDOB(String.Format("{0:dd-MMM-yy}", dtpDOB.Value));
            myCustomers.setEmail(txtEmail.Text);
            myCustomers.setAddressLine1(txtAddress1.Text);
            myCustomers.setAddressLine2(txtAddress2.Text);
            myCustomers.setCounty(cboCounty.Text);
            myCustomers.setCredit(txtCreditDebit.Text);
            myCustomers.updateCustomer(Convert.ToInt16(txtCustID.Text));





           
          
            cboCounty.ResetText();
            cboTitle.ResetText();
            txtAddress1.ResetText();
            txtAddress2.ResetText();
         
            txtCustID.ResetText();
            dtpDOB.ResetText();
            txtEmail.ResetText();
            txtSurname.ResetText();
            txtForename.ResetText();
            txtSurname.ResetText();
            txtSurname2.ResetText();
            txtCreditDebit.ResetText();
        }

        private void grdCustUpdate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow CustomerData = this.grdCustUpdate.Rows[e.RowIndex];

            int custId = Convert.ToInt32(CustomerData.Cells[0].Value);

            txtCustID.Text = custId.ToString("0000");

            cboTitle.Text = CustomerData.Cells[1].Value.ToString().TrimEnd();
            txtForename.Text = CustomerData.Cells[2].Value.ToString().TrimEnd();
            txtSurname2.Text = CustomerData.Cells[3].Value.ToString().TrimEnd();
            dtpDOB.Text = CustomerData.Cells[4].Value.ToString().TrimEnd();
            txtEmail.Text = CustomerData.Cells[5].Value.ToString().TrimEnd();
            txtAddress1.Text = CustomerData.Cells[6].Value.ToString().TrimEnd();
            txtAddress2.Text = CustomerData.Cells[7].Value.ToString().TrimEnd();
            cboCounty.Text = CustomerData.Cells[8].Value.ToString().TrimEnd();
            txtCreditDebit.Text = CustomerData.Cells[10].Value.ToString().TrimEnd();


        }
    }
}
