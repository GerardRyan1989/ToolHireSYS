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
    public partial class frmIncomeReport : Form
    {
        private frmMainMenu parent;

        public frmIncomeReport()
        {
            InitializeComponent();
        }

        public frmIncomeReport(frmMainMenu frmMainMenu)
        {
            InitializeComponent();
            this.parent = frmMainMenu;
            txtPassword.PasswordChar = '*';
        }

        private void frmIncomeReport_Load(object sender, EventArgs e)
        {
            grpSales.Visible = false;
            grpSalesReport.Visible = false;
        }

        private void dtpReturnDate_ValueChanged(object sender, EventArgs e)
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

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            grpSales.Visible = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Report Saved Successfully");
            grpSales.Visible = false;
            grpSalesReport.Visible = false;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sent to Printer");
            grpSales.Visible = false;
            grpSalesReport.Visible = false;

        }

        private void lblUserName_Click(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "123456" && txtUsername.Text == "Manager")
            {
                grpSalesReport.Visible = true;
            }
            else
            {
                MessageBox.Show("incorrect UserName or Password");
            }
        }
    }
}
