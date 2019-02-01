namespace ToolHireSYS
{
    partial class frmHireTools
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.grpSearchTool = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cboMake = new System.Windows.Forms.ComboBox();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.lblMake = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.grpSearchCustomer = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.grpSelectCustomer = new System.Windows.Forms.GroupBox();
            this.grdCustomerSelect = new System.Windows.Forms.DataGridView();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblSelectCustomerID = new System.Windows.Forms.Label();
            this.txtCustID = new System.Windows.Forms.TextBox();
            this.grpCustomer = new System.Windows.Forms.GroupBox();
            this.grpSelectTool = new System.Windows.Forms.GroupBox();
            this.grdToolSelect = new System.Windows.Forms.DataGridView();
            this.dtpReturnDate = new System.Windows.Forms.DateTimePicker();
            this.lblNumDays = new System.Windows.Forms.Label();
            this.btnAddBasket = new System.Windows.Forms.Button();
            this.lblToolID2 = new System.Windows.Forms.Label();
            this.txtToolID = new System.Windows.Forms.TextBox();
            this.grpTool = new System.Windows.Forms.GroupBox();
            this.btnConfirmRetal = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.grpSearchTool.SuspendLayout();
            this.grpSearchCustomer.SuspendLayout();
            this.grpSelectCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomerSelect)).BeginInit();
            this.grpCustomer.SuspendLayout();
            this.grpSelectTool.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdToolSelect)).BeginInit();
            this.grpTool.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack,
            this.mnuExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1091, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuBack
            // 
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(44, 20);
            this.mnuBack.Text = "Back";
            this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(37, 20);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // grpSearchTool
            // 
            this.grpSearchTool.Controls.Add(this.btnSearch);
            this.grpSearchTool.Controls.Add(this.cboMake);
            this.grpSearchTool.Controls.Add(this.cboCategory);
            this.grpSearchTool.Controls.Add(this.lblMake);
            this.grpSearchTool.Controls.Add(this.lblCategory);
            this.grpSearchTool.Location = new System.Drawing.Point(21, 19);
            this.grpSearchTool.Name = "grpSearchTool";
            this.grpSearchTool.Size = new System.Drawing.Size(247, 136);
            this.grpSearchTool.TabIndex = 11;
            this.grpSearchTool.TabStop = false;
            this.grpSearchTool.Text = "Tool Search";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(81, 85);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(121, 31);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cboMake
            // 
            this.cboMake.FormattingEnabled = true;
            this.cboMake.Location = new System.Drawing.Point(81, 58);
            this.cboMake.Name = "cboMake";
            this.cboMake.Size = new System.Drawing.Size(121, 21);
            this.cboMake.TabIndex = 9;
            // 
            // cboCategory
            // 
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(81, 21);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(121, 21);
            this.cboCategory.TabIndex = 8;
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMake.Location = new System.Drawing.Point(26, 58);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(49, 18);
            this.lblMake.TabIndex = 7;
            this.lblMake.Text = "Make:";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(3, 24);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(72, 18);
            this.lblCategory.TabIndex = 5;
            this.lblCategory.Text = "Category:";
            // 
            // grpSearchCustomer
            // 
            this.grpSearchCustomer.Controls.Add(this.button1);
            this.grpSearchCustomer.Controls.Add(this.txtSurname);
            this.grpSearchCustomer.Controls.Add(this.lblSurname);
            this.grpSearchCustomer.Location = new System.Drawing.Point(9, 19);
            this.grpSearchCustomer.Name = "grpSearchCustomer";
            this.grpSearchCustomer.Size = new System.Drawing.Size(243, 120);
            this.grpSearchCustomer.TabIndex = 19;
            this.grpSearchCustomer.TabStop = false;
            this.grpSearchCustomer.Text = "Customer Search";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(98, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 26);
            this.button1.TabIndex = 4;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(98, 23);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(126, 20);
            this.txtSurname.TabIndex = 3;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(20, 22);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(72, 18);
            this.lblSurname.TabIndex = 1;
            this.lblSurname.Text = "Surname:";
            // 
            // grpSelectCustomer
            // 
            this.grpSelectCustomer.Controls.Add(this.grdCustomerSelect);
            this.grpSelectCustomer.Controls.Add(this.btnSubmit);
            this.grpSelectCustomer.Controls.Add(this.lblSelectCustomerID);
            this.grpSelectCustomer.Controls.Add(this.txtCustID);
            this.grpSelectCustomer.Location = new System.Drawing.Point(9, 164);
            this.grpSelectCustomer.Name = "grpSelectCustomer";
            this.grpSelectCustomer.Size = new System.Drawing.Size(457, 313);
            this.grpSelectCustomer.TabIndex = 20;
            this.grpSelectCustomer.TabStop = false;
            this.grpSelectCustomer.Text = "Select Customer";
            // 
            // grdCustomerSelect
            // 
            this.grdCustomerSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCustomerSelect.Location = new System.Drawing.Point(6, 22);
            this.grdCustomerSelect.Name = "grdCustomerSelect";
            this.grdCustomerSelect.Size = new System.Drawing.Size(447, 145);
            this.grdCustomerSelect.TabIndex = 23;
            this.grdCustomerSelect.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCustomerSelect_CellContentClick);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(177, 242);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(82, 31);
            this.btnSubmit.TabIndex = 17;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblSelectCustomerID
            // 
            this.lblSelectCustomerID.AutoSize = true;
            this.lblSelectCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectCustomerID.Location = new System.Drawing.Point(20, 184);
            this.lblSelectCustomerID.Name = "lblSelectCustomerID";
            this.lblSelectCustomerID.Size = new System.Drawing.Size(87, 16);
            this.lblSelectCustomerID.TabIndex = 16;
            this.lblSelectCustomerID.Text = "Customer ID :";
            // 
            // txtCustID
            // 
            this.txtCustID.Location = new System.Drawing.Point(113, 183);
            this.txtCustID.Name = "txtCustID";
            this.txtCustID.ReadOnly = true;
            this.txtCustID.Size = new System.Drawing.Size(54, 20);
            this.txtCustID.TabIndex = 15;
            // 
            // grpCustomer
            // 
            this.grpCustomer.Controls.Add(this.grpSelectCustomer);
            this.grpCustomer.Controls.Add(this.grpSearchCustomer);
            this.grpCustomer.Location = new System.Drawing.Point(12, 27);
            this.grpCustomer.Name = "grpCustomer";
            this.grpCustomer.Size = new System.Drawing.Size(489, 513);
            this.grpCustomer.TabIndex = 21;
            this.grpCustomer.TabStop = false;
            this.grpCustomer.Text = "Customer";
            // 
            // grpSelectTool
            // 
            this.grpSelectTool.Controls.Add(this.grdToolSelect);
            this.grpSelectTool.Controls.Add(this.dtpReturnDate);
            this.grpSelectTool.Controls.Add(this.lblNumDays);
            this.grpSelectTool.Controls.Add(this.btnAddBasket);
            this.grpSelectTool.Controls.Add(this.lblToolID2);
            this.grpSelectTool.Controls.Add(this.txtToolID);
            this.grpSelectTool.Location = new System.Drawing.Point(21, 166);
            this.grpSelectTool.Name = "grpSelectTool";
            this.grpSelectTool.Size = new System.Drawing.Size(501, 313);
            this.grpSelectTool.TabIndex = 22;
            this.grpSelectTool.TabStop = false;
            this.grpSelectTool.Text = "Select Tool";
            // 
            // grdToolSelect
            // 
            this.grdToolSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdToolSelect.Location = new System.Drawing.Point(10, 22);
            this.grdToolSelect.Name = "grdToolSelect";
            this.grdToolSelect.Size = new System.Drawing.Size(485, 145);
            this.grdToolSelect.TabIndex = 22;
            this.grdToolSelect.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdToolSelect_CellContentClick);
            // 
            // dtpReturnDate
            // 
            this.dtpReturnDate.Location = new System.Drawing.Point(268, 180);
            this.dtpReturnDate.Name = "dtpReturnDate";
            this.dtpReturnDate.Size = new System.Drawing.Size(153, 20);
            this.dtpReturnDate.TabIndex = 21;
            // 
            // lblNumDays
            // 
            this.lblNumDays.AutoSize = true;
            this.lblNumDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumDays.Location = new System.Drawing.Point(180, 183);
            this.lblNumDays.Name = "lblNumDays";
            this.lblNumDays.Size = new System.Drawing.Size(82, 16);
            this.lblNumDays.TabIndex = 20;
            this.lblNumDays.Text = "Return Date:";
            // 
            // btnAddBasket
            // 
            this.btnAddBasket.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBasket.Location = new System.Drawing.Point(173, 248);
            this.btnAddBasket.Name = "btnAddBasket";
            this.btnAddBasket.Size = new System.Drawing.Size(134, 59);
            this.btnAddBasket.TabIndex = 17;
            this.btnAddBasket.Text = "Add To Basket";
            this.btnAddBasket.UseVisualStyleBackColor = true;
            this.btnAddBasket.Click += new System.EventHandler(this.btnAddBasket_Click);
            // 
            // lblToolID2
            // 
            this.lblToolID2.AutoSize = true;
            this.lblToolID2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToolID2.Location = new System.Drawing.Point(17, 180);
            this.lblToolID2.Name = "lblToolID2";
            this.lblToolID2.Size = new System.Drawing.Size(58, 16);
            this.lblToolID2.TabIndex = 16;
            this.lblToolID2.Text = "Tool ID :";
            // 
            // txtToolID
            // 
            this.txtToolID.Location = new System.Drawing.Point(78, 179);
            this.txtToolID.Name = "txtToolID";
            this.txtToolID.ReadOnly = true;
            this.txtToolID.Size = new System.Drawing.Size(54, 20);
            this.txtToolID.TabIndex = 15;
            // 
            // grpTool
            // 
            this.grpTool.Controls.Add(this.grpSelectTool);
            this.grpTool.Controls.Add(this.grpSearchTool);
            this.grpTool.Location = new System.Drawing.Point(529, 25);
            this.grpTool.Name = "grpTool";
            this.grpTool.Size = new System.Drawing.Size(550, 515);
            this.grpTool.TabIndex = 23;
            this.grpTool.TabStop = false;
            this.grpTool.Text = "Tool";
            //
            // btnConfirmRetal
            // 
            this.btnConfirmRetal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmRetal.Location = new System.Drawing.Point(439, 575);
            this.btnConfirmRetal.Name = "btnConfirmRetal";
            this.btnConfirmRetal.Size = new System.Drawing.Size(186, 60);
            this.btnConfirmRetal.TabIndex = 24;
            this.btnConfirmRetal.Text = "Confirm Rental";
            this.btnConfirmRetal.UseVisualStyleBackColor = true;
            this.btnConfirmRetal.Click += new System.EventHandler(this.btnConfirmRetal_Click);
            // 
            // frmHireTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 726);
            this.Controls.Add(this.btnConfirmRetal);
            this.Controls.Add(this.grpTool);
            this.Controls.Add(this.grpCustomer);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmHireTools";
            this.Text = "Hire Tools";
            this.Load += new System.EventHandler(this.frmHireTools_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpSearchTool.ResumeLayout(false);
            this.grpSearchTool.PerformLayout();
            this.grpSearchCustomer.ResumeLayout(false);
            this.grpSearchCustomer.PerformLayout();
            this.grpSelectCustomer.ResumeLayout(false);
            this.grpSelectCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomerSelect)).EndInit();
            this.grpCustomer.ResumeLayout(false);
            this.grpSelectTool.ResumeLayout(false);
            this.grpSelectTool.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdToolSelect)).EndInit();
            this.grpTool.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.GroupBox grpSearchTool;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cboMake;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.GroupBox grpSearchCustomer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.GroupBox grpSelectCustomer;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblSelectCustomerID;
        private System.Windows.Forms.TextBox txtCustID;
        private System.Windows.Forms.GroupBox grpCustomer;
        private System.Windows.Forms.GroupBox grpSelectTool;
        private System.Windows.Forms.Button btnAddBasket;
        private System.Windows.Forms.Label lblToolID2;
        private System.Windows.Forms.TextBox txtToolID;
        private System.Windows.Forms.GroupBox grpTool;
        private System.Windows.Forms.Button btnConfirmRetal;
        private System.Windows.Forms.Label lblNumDays;
        private System.Windows.Forms.DataGridView grdCustomerSelect;
        private System.Windows.Forms.DataGridView grdToolSelect;
        private System.Windows.Forms.DateTimePicker dtpReturnDate;
    }
}