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
    public partial class frmGenerateInvoices : Form
    {
        private frmMainMenu parent;

        public frmGenerateInvoices()
        {
            InitializeComponent();
        }

        public frmGenerateInvoices(frmMainMenu frmMainMenu)
        {
            InitializeComponent();
            this.parent = frmMainMenu;
        }

        private void lblReturnDate_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Invoice Saved Successfully");
            grpPrintSave.Visible = false;
            txtCustID.ResetText();
            txtRentalID.ResetText();
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

        private void frmGenerateInvoices_Load(object sender, EventArgs e)
        {
            grpPrintSave.Visible = false;
            lstInvoice.Items.Add("\t1 \tGerard Ryan\t\t Makita r200\t 06/12/2016 \t€100.00");
        }

        private void btnGenerateInvoice_Click(object sender, EventArgs e)
        {
            grpPrintSave.Visible = true;
            
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sent to Printer");
            grpPrintSave.Visible = false;
            txtCustID.ResetText();
            txtRentalID.ResetText();
        }
    }
}
