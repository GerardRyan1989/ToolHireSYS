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
    public partial class frmRegisterTools : Form
    {
        private frmMainMenu parent;

        public frmRegisterTools()
        {
            InitializeComponent();
        }

        public frmRegisterTools(frmMainMenu frmMainMenu)
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

        private void frmRegisterTools_Load(object sender, EventArgs e)
        {
            cboCategory.ValueMember = "CatType";
            cboCategory.DataSource = Tools.getToolCategorys().Tables["Categorys"];

            cboCategory.SelectedIndex = -1;

            cboManufacturer.ValueMember = "MakeName";
            cboManufacturer.DataSource = Tools.getToolMakes().Tables["Makes"];

            cboManufacturer.SelectedIndex = -1;

        }

        private void btnRegisterTool_Click(object sender, EventArgs e)
        {
            
       
            //validate data


            //assign customer ID

            //assign status


            //save data in Customer Table
            Tools myTools = new Tools();
            myTools.setToolID(Tools.nextToolID());
            myTools.setCategory((cboCategory.SelectedIndex)+1);
            myTools.setManufacturer((cboManufacturer.SelectedIndex)+1);
            myTools.setModel(txtModel.Text);
            myTools.setDescription(txtDescription.Text);
            
            Validation validation = new Validation();
            if(validation.ValidateTool(myTools, txtPrice.Text) == true)
            {
                double price = Convert.ToDouble(txtPrice.Text);
                myTools.setPrice(price);
                myTools.regTool();
                //Display confirmation message
                MessageBox.Show("Tool " + cboCategory.Text + " " + cboManufacturer.Text + " " + txtModel.Text + " Registered", "Confirmation",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);

                //reset UI
                cboCategory.SelectedIndex = -1;
                cboCategory.ResetText();
                cboManufacturer.ResetText();
                txtModel.ResetText();
                txtPrice.ResetText();
                txtDescription.ResetText();
            }
            else
            {
                MessageBox.Show(validation.getErrorrMessage(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
           


           

           
           
        }

        

        
    }
}
