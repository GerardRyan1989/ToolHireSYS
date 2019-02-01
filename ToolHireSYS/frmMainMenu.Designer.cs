using System;

namespace ToolHireSYS
{
    partial class frmMainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnuMainMenu = new System.Windows.Forms.MenuStrip();
            this.mnuTools = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRegisterTools = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdateTools = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDeleteTools = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuListToolsonHire = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCustomers = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRegisterCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdateCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDeleteCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuListCustomers = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRentals = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHireTools = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReturnTools = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLateReturns = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFinance = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGenerateInvoice = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRecordPayment = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuIncomeReport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblToolHireSys = new System.Windows.Forms.Label();
            this.mnuMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMainMenu
            // 
            this.mnuMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTools,
            this.mnuCustomers,
            this.mnuRentals,
            this.mnuFinance,
            this.mnuExit});
            this.mnuMainMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMainMenu.Name = "mnuMainMenu";
            this.mnuMainMenu.Size = new System.Drawing.Size(384, 24);
            this.mnuMainMenu.TabIndex = 0;
            this.mnuMainMenu.Text = "Main Menu";
            // 
            // mnuTools
            // 
            this.mnuTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRegisterTools,
            this.mnuUpdateTools,
            this.mnuDeleteTools,
            this.mnuListToolsonHire});
            this.mnuTools.Name = "mnuTools";
            this.mnuTools.Size = new System.Drawing.Size(48, 20);
            this.mnuTools.Text = "Tools";
            this.mnuTools.Click += new System.EventHandler(this.mnuTools_Click);
            // 
            // mnuRegisterTools
            // 
            this.mnuRegisterTools.Name = "mnuRegisterTools";
            this.mnuRegisterTools.Size = new System.Drawing.Size(148, 22);
            this.mnuRegisterTools.Text = "Register Tools";
            this.mnuRegisterTools.Click += new System.EventHandler(this.mnuRegisterTools_Click);
            // 
            // mnuUpdateTools
            // 
            this.mnuUpdateTools.Name = "mnuUpdateTools";
            this.mnuUpdateTools.Size = new System.Drawing.Size(148, 22);
            this.mnuUpdateTools.Text = "Update Tools";
            this.mnuUpdateTools.Click += new System.EventHandler(this.mnuUpdateTools_Click);
            // 
            // mnuDeleteTools
            // 
            this.mnuDeleteTools.Name = "mnuDeleteTools";
            this.mnuDeleteTools.Size = new System.Drawing.Size(148, 22);
            this.mnuDeleteTools.Text = "Delete Tools";
            this.mnuDeleteTools.Click += new System.EventHandler(this.mnuDeleteTools_Click);
            // 
            // mnuListToolsonHire
            // 
            this.mnuListToolsonHire.Name = "mnuListToolsonHire";
            this.mnuListToolsonHire.Size = new System.Drawing.Size(148, 22);
            this.mnuListToolsonHire.Text = "List All Tools";
            this.mnuListToolsonHire.Click += new System.EventHandler(this.mnuListToolsonHire_Click);
            // 
            // mnuCustomers
            // 
            this.mnuCustomers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRegisterCustomer,
            this.mnuUpdateCustomer,
            this.mnuDeleteCustomer,
            this.mnuListCustomers});
            this.mnuCustomers.Name = "mnuCustomers";
            this.mnuCustomers.Size = new System.Drawing.Size(76, 20);
            this.mnuCustomers.Text = "Customers";
            // 
            // mnuRegisterCustomer
            // 
            this.mnuRegisterCustomer.Name = "mnuRegisterCustomer";
            this.mnuRegisterCustomer.Size = new System.Drawing.Size(205, 22);
            this.mnuRegisterCustomer.Text = "Register Customer";
            this.mnuRegisterCustomer.Click += new System.EventHandler(this.mnuRegisterCustomer_Click);
            // 
            // mnuUpdateCustomer
            // 
            this.mnuUpdateCustomer.Name = "mnuUpdateCustomer";
            this.mnuUpdateCustomer.Size = new System.Drawing.Size(205, 22);
            this.mnuUpdateCustomer.Text = "Update Customer Details";
            this.mnuUpdateCustomer.Click += new System.EventHandler(this.mnuUpdateCustomer_Click);
            // 
            // mnuDeleteCustomer
            // 
            this.mnuDeleteCustomer.Name = "mnuDeleteCustomer";
            this.mnuDeleteCustomer.Size = new System.Drawing.Size(205, 22);
            this.mnuDeleteCustomer.Text = "Delete Customer Details";
            this.mnuDeleteCustomer.Click += new System.EventHandler(this.mnuDeleteCustomer_Click);
            // 
            // mnuListCustomers
            // 
            this.mnuListCustomers.Name = "mnuListCustomers";
            this.mnuListCustomers.Size = new System.Drawing.Size(205, 22);
            this.mnuListCustomers.Text = "List Customers";
            this.mnuListCustomers.Click += new System.EventHandler(this.mnuListCustomers_Click);
            // 
            // mnuRentals
            // 
            this.mnuRentals.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHireTools,
            this.mnuReturnTools,
            this.mnuLateReturns});
            this.mnuRentals.Name = "mnuRentals";
            this.mnuRentals.Size = new System.Drawing.Size(57, 20);
            this.mnuRentals.Text = "Rentals";
            // 
            // mnuHireTools
            // 
            this.mnuHireTools.Name = "mnuHireTools";
            this.mnuHireTools.Size = new System.Drawing.Size(139, 22);
            this.mnuHireTools.Text = "Hire Tools";
            this.mnuHireTools.Click += new System.EventHandler(this.mnuHireTools_Click);
            // 
            // mnuReturnTools
            // 
            this.mnuReturnTools.Name = "mnuReturnTools";
            this.mnuReturnTools.Size = new System.Drawing.Size(139, 22);
            this.mnuReturnTools.Text = "ReturnTools";
            this.mnuReturnTools.Click += new System.EventHandler(this.mnuReturnTools_Click);
            // 
            // mnuLateReturns
            // 
            this.mnuLateReturns.Name = "mnuLateReturns";
            this.mnuLateReturns.Size = new System.Drawing.Size(139, 22);
            this.mnuLateReturns.Text = "Late Returns";
            this.mnuLateReturns.Click += new System.EventHandler(this.mnuLateReturns_Click);
            // 
            // mnuFinance
            // 
            this.mnuFinance.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuGenerateInvoice,
            this.mnuRecordPayment,
            this.mnuIncomeReport});
            this.mnuFinance.Name = "mnuFinance";
            this.mnuFinance.Size = new System.Drawing.Size(60, 20);
            this.mnuFinance.Text = "Finance";
            // 
            // mnuGenerateInvoice
            // 
            this.mnuGenerateInvoice.Name = "mnuGenerateInvoice";
            this.mnuGenerateInvoice.Size = new System.Drawing.Size(167, 22);
            this.mnuGenerateInvoice.Text = "Generate Invoices";
            this.mnuGenerateInvoice.Click += new System.EventHandler(this.mnuGenerateInvoice_Click);
            // 
            // mnuRecordPayment
            // 
            this.mnuRecordPayment.Name = "mnuRecordPayment";
            this.mnuRecordPayment.Size = new System.Drawing.Size(167, 22);
            this.mnuRecordPayment.Text = "Record Payment";
            this.mnuRecordPayment.Click += new System.EventHandler(this.mnuRecordPayment_Click);
            // 
            // mnuIncomeReport
            // 
            this.mnuIncomeReport.Name = "mnuIncomeReport";
            this.mnuIncomeReport.Size = new System.Drawing.Size(167, 22);
            this.mnuIncomeReport.Text = "Income Report";
            this.mnuIncomeReport.Click += new System.EventHandler(this.mnuIncomeReport_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(37, 20);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // lblToolHireSys
            // 
            this.lblToolHireSys.AutoSize = true;
            this.lblToolHireSys.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToolHireSys.Location = new System.Drawing.Point(89, 111);
            this.lblToolHireSys.Name = "lblToolHireSys";
            this.lblToolHireSys.Size = new System.Drawing.Size(174, 31);
            this.lblToolHireSys.TabIndex = 1;
            this.lblToolHireSys.Text = "ToolHireSys";
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.lblToolHireSys);
            this.Controls.Add(this.mnuMainMenu);
            this.MainMenuStrip = this.mnuMainMenu;
            this.Name = "frmMainMenu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.mnuMainMenu.ResumeLayout(false);
            this.mnuMainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void mnuTools_Click(object sender, EventArgs e)
        {
           
        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuTools;
        private System.Windows.Forms.ToolStripMenuItem mnuRegisterTools;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateTools;
        private System.Windows.Forms.ToolStripMenuItem mnuDeleteTools;
        private System.Windows.Forms.ToolStripMenuItem mnuListToolsonHire;
        private System.Windows.Forms.ToolStripMenuItem mnuCustomers;
        private System.Windows.Forms.ToolStripMenuItem mnuRegisterCustomer;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateCustomer;
        private System.Windows.Forms.ToolStripMenuItem mnuDeleteCustomer;
        private System.Windows.Forms.ToolStripMenuItem mnuListCustomers;
        private System.Windows.Forms.ToolStripMenuItem mnuRentals;
        private System.Windows.Forms.ToolStripMenuItem mnuHireTools;
        private System.Windows.Forms.ToolStripMenuItem mnuReturnTools;
        private System.Windows.Forms.ToolStripMenuItem mnuLateReturns;
        private System.Windows.Forms.ToolStripMenuItem mnuFinance;
        private System.Windows.Forms.ToolStripMenuItem mnuGenerateInvoice;
        private System.Windows.Forms.ToolStripMenuItem mnuRecordPayment;
        private System.Windows.Forms.ToolStripMenuItem mnuIncomeReport;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.Label lblToolHireSys;
    }
}

