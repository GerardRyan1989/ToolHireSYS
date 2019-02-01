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
    public partial class frmReturnTools : Form
    {
        private frmMainMenu parent;

        public frmReturnTools()
        {
            InitializeComponent();
        }

        public frmReturnTools(frmMainMenu frmMainMenu)
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

        private void btnReturnTool_Click(object sender, EventArgs e)
        {
            int toolId = Convert.ToInt16(txtToolID.Text);
            Rentals myRentals = new Rentals();
            myRentals.returnTool(toolId);
            MessageBox.Show("Tool Returned Successsfully");
            txtToolID.ResetText();
        }
    }
}
