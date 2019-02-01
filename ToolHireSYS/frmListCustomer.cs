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
    public partial class frmListCustomer : Form
    {
        private frmMainMenu parent;

       

        public frmListCustomer(frmMainMenu frmMainMenu)
        {
            InitializeComponent();
            this.parent = frmMainMenu;
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

        private void frmListCustomer_Load_1(object sender, EventArgs e)
        {
            cboCounty.ValueMember = "County";
            cboCounty.DataSource = Customers.getCounty().Tables["Counties"];

            cboStatus.Items.Add("Available");
            cboStatus.Items.Add("Removed");
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("List Saved Successfully");
            grpCustomerList.Visible = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Customers myCustomer = new Customers();


            grdCustomerList.DataSource = Customers.getCustomer(txtSurname.Text, cboCounty.Text, cboStatus.Text).Tables["Customer"];
            grpCustDetails.Visible = true;
        }

        
    }
}
