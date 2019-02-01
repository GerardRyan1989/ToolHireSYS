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
    public partial class frmUpdateTools : Form
    {
        private frmMainMenu parent;

        public frmUpdateTools()
        {
            InitializeComponent();
        }

        public frmUpdateTools(frmMainMenu frmMainMenu)
        {
            InitializeComponent();
            this.parent = frmMainMenu;
        }

        private void frmUpdateTools_Load(object sender, EventArgs e)
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

        

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void btnSearch_Click(object sender, EventArgs e)
        {

            Tools myTools = new Tools();
            grdSearchTool.DataSource = Tools.getTools(((cboCategory.SelectedIndex) + 1), ((cboMake.SelectedIndex) + 1)).Tables["getTools"];

        }

        

        private void btnUpdateTool_Click(object sender, EventArgs e)
        {
            Tools myTools = new Tools();

            myTools.setCategory((cboCategory2.SelectedIndex)+1);
            myTools.setManufacturer((cboMake2.SelectedIndex)+1);
            myTools.setModel(txtModel.Text);
            myTools.setDescription(txtDescription.Text);
            double price = Convert.ToDouble(txtPrice.Text);
            myTools.setPrice(price);

            myTools.updateTool(Convert.ToInt16(txtToolID.Text));
            MessageBox.Show("Tool updated successfully");
            txtToolID.ResetText();
            cboCategory.SelectedIndex = -1;
            cboCategory2.SelectedIndex = -1;
            cboMake.SelectedIndex = -1;
            cboMake2.ResetText();
            txtDescription.ResetText();
            txtModel.ResetText();
            txtPrice.ResetText();
           
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
            
        }

        

        private void grdSearchTool_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow ToolData = this.grdSearchTool.Rows[e.RowIndex];

            int ToolId = Convert.ToInt32(ToolData.Cells[0].Value);

            txtToolID.Text = ToolId.ToString("0000");

            cboCategory2.SelectedIndex = int.Parse((ToolData.Cells[1].Value.ToString())) -1;
            cboMake2.SelectedIndex = int.Parse((ToolData.Cells[2].Value.ToString())) - 1;
            txtModel.Text = ToolData.Cells[3].Value.ToString();
            txtDescription.Text = ToolData.Cells[4].Value.ToString();
            txtPrice.Text = ToolData.Cells[5].Value.ToString();

        }

       
    }
}
