namespace ToolHireSYS
{
    partial class frmListCustomer
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
            this.grpCustomerList = new System.Windows.Forms.GroupBox();
            this.grpCustDetails = new System.Windows.Forms.GroupBox();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cboCounty = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.grdCustomerList = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.grpCustomerList.SuspendLayout();
            this.grpCustDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomerList)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack,
            this.mnuExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(817, 24);
            this.menuStrip1.TabIndex = 9;
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
            // grpCustomerList
            // 
            this.grpCustomerList.Controls.Add(this.grpCustDetails);
            this.grpCustomerList.Controls.Add(this.grdCustomerList);
            this.grpCustomerList.Location = new System.Drawing.Point(12, 27);
            this.grpCustomerList.Name = "grpCustomerList";
            this.grpCustomerList.Size = new System.Drawing.Size(793, 445);
            this.grpCustomerList.TabIndex = 42;
            this.grpCustomerList.TabStop = false;
            this.grpCustomerList.Text = "List Customers";
            // 
            // grpCustDetails
            // 
            this.grpCustDetails.Controls.Add(this.cboStatus);
            this.grpCustDetails.Controls.Add(this.lblStatus);
            this.grpCustDetails.Controls.Add(this.btnSearch);
            this.grpCustDetails.Controls.Add(this.cboCounty);
            this.grpCustDetails.Controls.Add(this.label1);
            this.grpCustDetails.Controls.Add(this.txtSurname);
            this.grpCustDetails.Controls.Add(this.lblSurname);
            this.grpCustDetails.Location = new System.Drawing.Point(6, 19);
            this.grpCustDetails.Name = "grpCustDetails";
            this.grpCustDetails.Size = new System.Drawing.Size(781, 133);
            this.grpCustDetails.TabIndex = 1;
            this.grpCustDetails.TabStop = false;
            this.grpCustDetails.Text = "Details";
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(488, 33);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(121, 21);
            this.cboStatus.TabIndex = 12;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(428, 33);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(54, 18);
            this.lblStatus.TabIndex = 11;
            this.lblStatus.Text = "Status:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(308, 76);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(129, 39);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cboCounty
            // 
            this.cboCounty.FormattingEnabled = true;
            this.cboCounty.Location = new System.Drawing.Point(285, 34);
            this.cboCounty.Name = "cboCounty";
            this.cboCounty.Size = new System.Drawing.Size(121, 21);
            this.cboCounty.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "County:";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(93, 34);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(121, 20);
            this.txtSurname.TabIndex = 7;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(15, 36);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(72, 18);
            this.lblSurname.TabIndex = 6;
            this.lblSurname.Text = "Surname:";
            // 
            // grdCustomerList
            // 
            this.grdCustomerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCustomerList.Location = new System.Drawing.Point(6, 196);
            this.grdCustomerList.Name = "grdCustomerList";
            this.grdCustomerList.Size = new System.Drawing.Size(781, 209);
            this.grdCustomerList.TabIndex = 0;
            // 
            // frmListCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 470);
            this.Controls.Add(this.grpCustomerList);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmListCustomer";
            this.Text = "List Customers";
            this.Load += new System.EventHandler(this.frmListCustomer_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpCustomerList.ResumeLayout(false);
            this.grpCustDetails.ResumeLayout(false);
            this.grpCustDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomerList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.GroupBox grpCustomerList;
        private System.Windows.Forms.DataGridView grdCustomerList;
        private System.Windows.Forms.GroupBox grpCustDetails;
        private System.Windows.Forms.ComboBox cboCounty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label lblStatus;
    }
}