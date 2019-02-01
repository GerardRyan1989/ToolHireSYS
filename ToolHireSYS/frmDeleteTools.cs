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
    public partial class frmDeleteTools : Form
    {
        private frmMainMenu parent;

        public frmDeleteTools()
        {
            InitializeComponent();
        }

        public frmDeleteTools(frmMainMenu frmMainMenu)
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

        private void frmDeleteTools_Load(object sender, EventArgs e)
        {

            cboCategory.ValueMember = "CatType";
            cboCategory.DataSource = Tools.getToolCategorys().Tables["Categorys"];

            cboCategory.SelectedIndex = -1;

            cboMake.ValueMember = "MakeName";
            cboMake.DataSource = Tools.getToolMakes().Tables["Makes"];

            cboMake.SelectedIndex = -1;

            cboCategory2.ValueMember = "CatType";
            cboCategory2.DataSource = Tools.getToolCategorys().Tables["Categorys"];

            cboCategory2.SelectedIndex = -1;

            cboMake2.ValueMember = "MakeName";
            cboMake2.DataSource = Tools.getToolMakes().Tables["Makes"];

            cboMake2.SelectedIndex = -1;


        }

        

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Tools myTools = new Tools();


            grdSelectTool.DataSource = Tools.getTools(((cboCategory.SelectedIndex) + 1), ((cboMake.SelectedIndex) + 1)).Tables["getTools"];
        }

        private void grdSelectTool_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow ToolData = this.grdSelectTool.Rows[e.RowIndex];

            int ToolId = Convert.ToInt32(ToolData.Cells[0].Value);

            txtToolID.Text = ToolId.ToString("0000");

            cboCategory2.SelectedIndex = int.Parse((ToolData.Cells[1].Value.ToString())) - 1;
            cboMake2.SelectedIndex = int.Parse((ToolData.Cells[2].Value.ToString())) - 1;
            txtModel.Text = ToolData.Cells[3].Value.ToString();
            txtDescription.Text = ToolData.Cells[4].Value.ToString();
            txtPrice.Text = ToolData.Cells[5].Value.ToString();
        }

        private void btnRemoveTool_Click(object sender, EventArgs e)
        {
            Tools myTools = new Tools();

            myTools.removeTool(Convert.ToInt16(txtToolID.Text));
            MessageBox.Show(cboCategory2.Text + "," + cboMake2.Text + "," + txtModel.Text + "Successfully removed");

            cboCategory2.SelectedIndex = -1;
            cboMake2.SelectedIndex = -1;
            txtDescription.ResetText();
            txtModel.ResetText();
            txtPrice.ResetText();
            txtToolID.ResetText();
        }
    }
}
