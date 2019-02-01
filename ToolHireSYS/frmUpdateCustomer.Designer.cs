namespace ToolHireSYS
{
    partial class frmUpdateCustomer
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
            this.grpSearchCustomer = new System.Windows.Forms.GroupBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.btnsearch = new System.Windows.Forms.Button();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpCustDetails = new System.Windows.Forms.GroupBox();
            this.grdCustUpdate = new System.Windows.Forms.DataGridView();
            this.grpUpdateCustomer = new System.Windows.Forms.GroupBox();
            this.txtCustID = new System.Windows.Forms.TextBox();
            this.lblCustID = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblDebitCredit = new System.Windows.Forms.Label();
            this.cboCounty = new System.Windows.Forms.ComboBox();
            this.txtCreditDebit = new System.Windows.Forms.TextBox();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.txtAddress1 = new System.Windows.Forms.TextBox();
            this.txtForename = new System.Windows.Forms.TextBox();
            this.txtSurname2 = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblCounty = new System.Windows.Forms.Label();
            this.lblAddress2 = new System.Windows.Forms.Label();
            this.lbladdress1 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cboTitle = new System.Windows.Forms.ComboBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.grpSearchCustomer.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.grpCustDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustUpdate)).BeginInit();
            this.grpUpdateCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSearchCustomer
            // 
            this.grpSearchCustomer.Controls.Add(this.lblSurname);
            this.grpSearchCustomer.Controls.Add(this.btnsearch);
            this.grpSearchCustomer.Controls.Add(this.txtSurname);
            this.grpSearchCustomer.Location = new System.Drawing.Point(12, 32);
            this.grpSearchCustomer.Name = "grpSearchCustomer";
            this.grpSearchCustomer.Size = new System.Drawing.Size(243, 105);
            this.grpSearchCustomer.TabIndex = 7;
            this.grpSearchCustomer.TabStop = false;
            this.grpSearchCustomer.Text = "Customer Search";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(12, 16);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(72, 18);
            this.lblSurname.TabIndex = 5;
            this.lblSurname.Text = "Surname:";
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(98, 45);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(126, 26);
            this.btnsearch.TabIndex = 4;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(98, 19);
            this.txtSurname.MaxLength = 20;
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(126, 20);
            this.txtSurname.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(985, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // grpCustDetails
            // 
            this.grpCustDetails.Controls.Add(this.grdCustUpdate);
            this.grpCustDetails.Controls.Add(this.grpUpdateCustomer);
            this.grpCustDetails.Location = new System.Drawing.Point(277, 32);
            this.grpCustDetails.Name = "grpCustDetails";
            this.grpCustDetails.Size = new System.Drawing.Size(696, 665);
            this.grpCustDetails.TabIndex = 35;
            this.grpCustDetails.TabStop = false;
            this.grpCustDetails.Text = "Customer Details:";
            // 
            // grdCustUpdate
            // 
            this.grdCustUpdate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCustUpdate.Location = new System.Drawing.Point(16, 19);
            this.grdCustUpdate.Name = "grdCustUpdate";
            this.grdCustUpdate.Size = new System.Drawing.Size(655, 221);
            this.grdCustUpdate.TabIndex = 25;
            this.grdCustUpdate.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCustUpdate_CellContentClick);
            // 
            // grpUpdateCustomer
            // 
            this.grpUpdateCustomer.Controls.Add(this.dtpDOB);
            this.grpUpdateCustomer.Controls.Add(this.txtCustID);
            this.grpUpdateCustomer.Controls.Add(this.lblCustID);
            this.grpUpdateCustomer.Controls.Add(this.btnUpdate);
            this.grpUpdateCustomer.Controls.Add(this.lblDebitCredit);
            this.grpUpdateCustomer.Controls.Add(this.cboCounty);
            this.grpUpdateCustomer.Controls.Add(this.txtCreditDebit);
            this.grpUpdateCustomer.Controls.Add(this.txtAddress2);
            this.grpUpdateCustomer.Controls.Add(this.txtAddress1);
            this.grpUpdateCustomer.Controls.Add(this.txtForename);
            this.grpUpdateCustomer.Controls.Add(this.txtSurname2);
            this.grpUpdateCustomer.Controls.Add(this.txtEmail);
            this.grpUpdateCustomer.Controls.Add(this.lblCounty);
            this.grpUpdateCustomer.Controls.Add(this.lblAddress2);
            this.grpUpdateCustomer.Controls.Add(this.lbladdress1);
            this.grpUpdateCustomer.Controls.Add(this.lblEmail);
            this.grpUpdateCustomer.Controls.Add(this.lblDOB);
            this.grpUpdateCustomer.Controls.Add(this.label1);
            this.grpUpdateCustomer.Controls.Add(this.label2);
            this.grpUpdateCustomer.Controls.Add(this.lblTitle);
            this.grpUpdateCustomer.Controls.Add(this.cboTitle);
            this.grpUpdateCustomer.Location = new System.Drawing.Point(305, 259);
            this.grpUpdateCustomer.Name = "grpUpdateCustomer";
            this.grpUpdateCustomer.Size = new System.Drawing.Size(357, 390);
            this.grpUpdateCustomer.TabIndex = 24;
            this.grpUpdateCustomer.TabStop = false;
            this.grpUpdateCustomer.Text = "UpdateCustomer";
            // 
            // txtCustID
            // 
            this.txtCustID.Location = new System.Drawing.Point(196, 19);
            this.txtCustID.Name = "txtCustID";
            this.txtCustID.ReadOnly = true;
            this.txtCustID.Size = new System.Drawing.Size(121, 20);
            this.txtCustID.TabIndex = 36;
            // 
            // lblCustID
            // 
            this.lblCustID.AutoSize = true;
            this.lblCustID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustID.Location = new System.Drawing.Point(85, 19);
            this.lblCustID.Name = "lblCustID";
            this.lblCustID.Size = new System.Drawing.Size(96, 18);
            this.lblCustID.TabIndex = 35;
            this.lblCustID.Text = "Customer ID:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(162, 333);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(155, 40);
            this.btnUpdate.TabIndex = 34;
            this.btnUpdate.Text = "Update Customer";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblDebitCredit
            // 
            this.lblDebitCredit.AutoSize = true;
            this.lblDebitCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDebitCredit.Location = new System.Drawing.Point(65, 298);
            this.lblDebitCredit.Name = "lblDebitCredit";
            this.lblDebitCredit.Size = new System.Drawing.Size(125, 18);
            this.lblDebitCredit.TabIndex = 22;
            this.lblDebitCredit.Text = "Credit/Debit Card:";
            // 
            // cboCounty
            // 
            this.cboCounty.FormattingEnabled = true;
            this.cboCounty.Location = new System.Drawing.Point(196, 271);
            this.cboCounty.Name = "cboCounty";
            this.cboCounty.Size = new System.Drawing.Size(121, 21);
            this.cboCounty.TabIndex = 21;
            // 
            // txtCreditDebit
            // 
            this.txtCreditDebit.Location = new System.Drawing.Point(196, 298);
            this.txtCreditDebit.Name = "txtCreditDebit";
            this.txtCreditDebit.Size = new System.Drawing.Size(121, 20);
            this.txtCreditDebit.TabIndex = 20;
            // 
            // txtAddress2
            // 
            this.txtAddress2.Location = new System.Drawing.Point(196, 239);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(121, 20);
            this.txtAddress2.TabIndex = 19;
            // 
            // txtAddress1
            // 
            this.txtAddress1.Location = new System.Drawing.Point(196, 210);
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(121, 20);
            this.txtAddress1.TabIndex = 17;
            // 
            // txtForename
            // 
            this.txtForename.Location = new System.Drawing.Point(196, 84);
            this.txtForename.Name = "txtForename";
            this.txtForename.Size = new System.Drawing.Size(121, 20);
            this.txtForename.TabIndex = 16;
            // 
            // txtSurname2
            // 
            this.txtSurname2.Location = new System.Drawing.Point(196, 120);
            this.txtSurname2.Name = "txtSurname2";
            this.txtSurname2.Size = new System.Drawing.Size(121, 20);
            this.txtSurname2.TabIndex = 15;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(196, 179);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(121, 20);
            this.txtEmail.TabIndex = 13;
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounty.Location = new System.Drawing.Point(122, 274);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(59, 18);
            this.lblCounty.TabIndex = 10;
            this.lblCounty.Text = "County:";
            // 
            // lblAddress2
            // 
            this.lblAddress2.AutoSize = true;
            this.lblAddress2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress2.Location = new System.Drawing.Point(72, 238);
            this.lblAddress2.Name = "lblAddress2";
            this.lblAddress2.Size = new System.Drawing.Size(109, 18);
            this.lblAddress2.TabIndex = 8;
            this.lblAddress2.Text = "Address Line 2:";
            // 
            // lbladdress1
            // 
            this.lbladdress1.AutoSize = true;
            this.lbladdress1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdress1.Location = new System.Drawing.Point(72, 210);
            this.lbladdress1.Name = "lbladdress1";
            this.lbladdress1.Size = new System.Drawing.Size(109, 18);
            this.lbladdress1.TabIndex = 7;
            this.lbladdress1.Text = "Address Line 1:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(132, 179);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(49, 18);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email:";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.Location = new System.Drawing.Point(128, 151);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(53, 18);
            this.lblDOB.TabIndex = 5;
            this.lblDOB.Text = "D.O.B:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Surname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(104, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Forename:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(142, 51);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(39, 18);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Title:";
            // 
            // cboTitle
            // 
            this.cboTitle.FormattingEnabled = true;
            this.cboTitle.Location = new System.Drawing.Point(196, 48);
            this.cboTitle.Name = "cboTitle";
            this.cboTitle.Size = new System.Drawing.Size(121, 21);
            this.cboTitle.TabIndex = 1;
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(196, 153);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(121, 20);
            this.dtpDOB.TabIndex = 37;
            // 
            // frmUpdateCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 710);
            this.Controls.Add(this.grpCustDetails);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.grpSearchCustomer);
            this.Name = "frmUpdateCustomer";
            this.Text = "Update Customer";
            this.Load += new System.EventHandler(this.frmUpdateCustomer_Load);
            this.grpSearchCustomer.ResumeLayout(false);
            this.grpSearchCustomer.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpCustDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCustUpdate)).EndInit();
            this.grpUpdateCustomer.ResumeLayout(false);
            this.grpUpdateCustomer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSearchCustomer;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpCustDetails;
        private System.Windows.Forms.DataGridView grdCustUpdate;
        private System.Windows.Forms.GroupBox grpUpdateCustomer;
        private System.Windows.Forms.TextBox txtCustID;
        private System.Windows.Forms.Label lblCustID;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblDebitCredit;
        private System.Windows.Forms.ComboBox cboCounty;
        private System.Windows.Forms.TextBox txtCreditDebit;
        private System.Windows.Forms.TextBox txtAddress2;
        private System.Windows.Forms.TextBox txtAddress1;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.TextBox txtSurname2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblCounty;
        private System.Windows.Forms.Label lblAddress2;
        private System.Windows.Forms.Label lbladdress1;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cboTitle;
        private System.Windows.Forms.DateTimePicker dtpDOB;
    }
}