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
    public partial class frmRegisterCustomer : Form
    {
        private frmMainMenu parent;

        public frmRegisterCustomer()
        {
            InitializeComponent();
        }

        public frmRegisterCustomer(frmMainMenu frmMainMenu)
        {
            InitializeComponent();
            this.parent = frmMainMenu;
        }

        private void cboTitle_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //validate data


            //assign customer ID

            //assign status


            //save data in Customer Table
            Customers myCustomers = new Customers();
            myCustomers.setCustID(Customers.nextCustID());
            myCustomers.setTitle(cboTitle.Text);
            myCustomers.setForename(txtForename.Text);
            myCustomers.setSurname(txtSurname.Text);
            myCustomers.setDOB(String.Format("{0:dd-MMM-yy}", dtpDOB.Value));
            myCustomers.setEmail(txtEmail.Text);
            myCustomers.setAddressLine1(txtAddress1.Text);
            myCustomers.setAddressLine2(txtAddress2.Text);
            myCustomers.setCounty(cboCounty.Text);
            myCustomers.setCredit(txtCreditDebit.Text);

            //insert Customer Details
            myCustomers.regCustomer();


            //Display confirmation message
            MessageBox.Show("Customer " + cboTitle.Text +" " + txtForename.Text + " " + txtSurname.Text +" Registered", "Confirmation",
               MessageBoxButtons.OK, MessageBoxIcon.Information);

            //reset UI
            cboCounty.ResetText();
            cboTitle.ResetText();
            txtAddress1.ResetText();
            txtAddress2.ResetText();
            dtpDOB.ResetText();
            txtEmail.ResetText();
            txtForename.ResetText();
            txtSurname.ResetText();
            txtCreditDebit.ResetText();
        }

        private void frmRegisterCustomer_Load(object sender, EventArgs e)
        {
            cboCounty.ValueMember = "County";
            cboCounty.DataSource = Customers.getCounty().Tables["Counties"];

            cboTitle.ValueMember = "Title";
            cboTitle.DataSource = Customers.getTitle().Tables["Titles"];
        }
    }
}
