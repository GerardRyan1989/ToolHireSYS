using System;
using System.Collections;
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

    

    public partial class frmHireTools : Form
    {
        Rentals myRentals = new Rentals();
        double cost = 0;
        private frmMainMenu parent;
        ArrayList ToolList = new ArrayList();
        ArrayList dueReturn = new ArrayList();
        int i = 0;

        public frmHireTools()
        {
            InitializeComponent();
           
        }

        public frmHireTools(frmMainMenu frmMainMenu)
        {
            InitializeComponent();
            this.parent = frmMainMenu;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
           // grpTool.Visible = true;
           // grpSearchTool.Visible = true;
            MessageBox.Show("Cutomer Successfully Selected");
            
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

        private void frmHireTools_Load(object sender, EventArgs e)
        {
           // grpSelectCustomer.Visible = false;
           // grpSelectTool.Visible = false;
            //grpTool.Visible = false;
           // btnConfirmRetal.Visible = false;
            cboCategory.ValueMember = "CatType";
            cboCategory.DataSource = Tools.getToolCategorys().Tables["Categorys"];

            cboCategory.SelectedIndex = -1;

            cboMake.ValueMember = "MakeName";
            cboMake.DataSource = Tools.getToolMakes().Tables["Makes"];

            cboMake.SelectedIndex = -1;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Customers myCustomer = new Customers();


            grdCustomerSelect.DataSource = Customers.getCustomer(txtSurname.Text).Tables["Customer"];
           // grpSelectCustomer.Visible = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            Tools myTools = new Tools();
            grdToolSelect.DataSource = Tools.getTools(((cboCategory.SelectedIndex) + 1), ((cboMake.SelectedIndex) + 1)).Tables["getTools"];
            // grpSelectTool.Visible = true;
            

        }

        private void btnAddBasket_Click(object sender, EventArgs e)
        {
            string dueReturnDate = dtpReturnDate.Text;
            int ToolID = (Convert.ToInt16(txtToolID.Text));
            ToolList.Insert(i, ToolID);
            dueReturn.Insert(i, dueReturnDate);
            cost += (Tools.getPrice(ToolID));

            MessageBox.Show("ToolID:" +ToolID +" was sucessfully added into basket");
           // btnConfirmRetal.Visible = true;
            cboCategory.ResetText();
            cboMake.ResetText();
            txtToolID.ResetText();
            dtpReturnDate.ResetText();
            i++;
        }

        private void btnConfirmRetal_Click(object sender, EventArgs e)
        {
            myRentals.setStatus('U');
            myRentals.setRentalID(Rentals.nextRentID());
            myRentals.setCustID(Convert.ToInt16(txtCustID.Text));
            myRentals.setCost(cost);


            myRentals.addToRentals();
            myRentals.addToRentalItems(ToolList, dueReturn);
           

            MessageBox.Show("Tools succcessfully Rented");
            //grpSelectCustomer.Visible = false;
            //grpSelectTool.Visible = false;
           // grpTool.Visible = false;
           // btnConfirmRetal.Visible = false;
            cboCategory.ResetText();
            cboMake.ResetText();
           //txtCustID.ResetText();
           
            txtSurname.ResetText();
            txtToolID.ResetText();
            cboCategory.ResetText();
            cboMake.ResetText();
            i = 0;
            cost = 0;
           
            dueReturn.Clear();
            ToolList.Clear(); 
            
          }

       
        private void grdCustomerSelect_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow CustomerData = this.grdCustomerSelect.Rows[e.RowIndex];

            int CustId = Convert.ToInt32(CustomerData.Cells[0].Value);

            txtCustID.Text = CustId.ToString("0000");

           
           
        }

        private void grdToolSelect_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow ToolData = this.grdToolSelect.Rows[e.RowIndex];

            int ToolId = Convert.ToInt32(ToolData.Cells[0].Value);

            txtToolID.Text = ToolId.ToString("0000");
        }
    }

       
}
 
