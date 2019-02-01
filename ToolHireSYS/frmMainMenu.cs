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
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
                
        }

        private void mnuRegisterTools_Click(object sender, EventArgs e)
        {
            frmRegisterTools frmRegTools = new frmRegisterTools(this);
            this.Hide();
            frmRegTools.Show();
        }

        private void mnuUpdateTools_Click(object sender, EventArgs e)
        {
            frmUpdateTools frmUpdateTools = new frmUpdateTools(this);
            this.Hide();
            frmUpdateTools.Show();
        }

       

        private void mnuDeleteTools_Click(object sender, EventArgs e)
        {
            frmDeleteTools frmDelTools = new frmDeleteTools(this);
            this.Hide();
            frmDelTools.Show();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuRegisterCustomer_Click(object sender, EventArgs e)
        {
            frmRegisterCustomer frmRegCustomer = new frmRegisterCustomer(this);
            this.Hide();
            frmRegCustomer.Show();
        }

        private void mnuUpdateCustomer_Click(object sender, EventArgs e)
        {
            frmUpdateCustomer frmUpCustomer = new frmUpdateCustomer(this);
            this.Hide();
            frmUpCustomer.Show();
        }

        private void mnuListToolsonHire_Click(object sender, EventArgs e)
        {
            frmListTools frmListTool = new frmListTools(this);
            this.Hide();
            frmListTool.Show();
        }

        private void mnuDeleteCustomer_Click(object sender, EventArgs e)
        {
            frmDeleteCustomer frmDelCustomer = new frmDeleteCustomer(this);
            this.Hide();
            frmDelCustomer.Show();
        }

        private void mnuListCustomers_Click(object sender, EventArgs e)
        {
            frmListCustomer frmListCustomers = new frmListCustomer(this);
            this.Hide();
            frmListCustomers.Show();
        }

        private void mnuHireTools_Click(object sender, EventArgs e)
        {
            frmHireTools frmHireTool = new frmHireTools(this);
            this.Hide();
            frmHireTool.Show();
        }

        private void mnuReturnTools_Click(object sender, EventArgs e)
        {
            frmReturnTools frmReturnTool = new frmReturnTools(this);
            this.Hide();
            frmReturnTool.Show();
        }

        private void mnuLateReturns_Click(object sender, EventArgs e)
        {
            frmLateReturns frmLateReturn = new frmLateReturns(this);
            this.Hide();
            frmLateReturn.Show();
        }

        private void mnuGenerateInvoice_Click(object sender, EventArgs e)
        {
            frmGenerateInvoices frmGenerateInvoice = new frmGenerateInvoices(this);
            this.Hide();
            frmGenerateInvoice.Show();
        }

        private void mnuRecordPayment_Click(object sender, EventArgs e)
        {
            frmRecordPayment frmRecordPayments = new frmRecordPayment(this);
            this.Hide();
            frmRecordPayments.Show();
        }

        private void mnuIncomeReport_Click(object sender, EventArgs e)
        {
            frmIncomeReport frmIncomeRep = new frmIncomeReport(this);
            this.Hide();
            frmIncomeRep.Show();
        }
    }
}
