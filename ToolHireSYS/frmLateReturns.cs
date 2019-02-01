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
    public partial class frmLateReturns : Form
    {
        private frmMainMenu parent;

        public frmLateReturns()
        {
            InitializeComponent();
        }

        public frmLateReturns(frmMainMenu frmMainMenu)
        {
            InitializeComponent();
            this.parent = frmMainMenu;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
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

        private void frmLateReturns_Load(object sender, EventArgs e)
        {
            
        }

        private void btnListLateReturns_Click(object sender, EventArgs e)
        {
            grdLateReturns.DataSource = Rentals.getLateReturns().Tables["lateReturns"];
            grpLateReturns.Visible = true;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sent to printer");
            grpLateReturns.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("List Saved SuccessFully");
            grpLateReturns.Visible = false;
        }
    }
}
