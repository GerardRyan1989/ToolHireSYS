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
    public partial class frmListTools : Form
    {
        private frmMainMenu parent;

        public frmListTools()
        {
            InitializeComponent();
        }

        public frmListTools(frmMainMenu frmMainMenu)
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

        private void frmListTools_Load(object sender, EventArgs e)
        {
            cboCategory.ValueMember = "CatType";
            cboCategory.DataSource = Tools.getToolCategorys().Tables["Categorys"];

            cboCategory.SelectedIndex = -1;

            cboMake.ValueMember = "MakeName";
            cboMake.DataSource = Tools.getToolMakes().Tables["Makes"];

            cboMake.SelectedIndex = -1;

            cboOrderBy.Items.Add("ToolID");
            cboOrderBy.Items.Add("Model");
            cboOrderBy.Items.Add("Description");
            cboOrderBy.Items.Add("Price");


            cboOrderIn.Items.Add("Ascending");
            cboOrderIn.Items.Add("Descending");


        }


        private void btnListTools_Click(object sender, EventArgs e)
        {
            Tools myTools = new Tools();


            grdListTool.DataSource = Tools.getTools((cboCategory.SelectedIndex + 1 ), (cboMake.SelectedIndex + 1), cboOrderBy.Text, cboOrderIn.Text).Tables["ss"];
        }
    }
}
