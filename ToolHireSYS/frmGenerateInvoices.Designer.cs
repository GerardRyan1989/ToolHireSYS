namespace ToolHireSYS
{
    partial class frmGenerateInvoices
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
            this.lblRentalID = new System.Windows.Forms.Label();
            this.lblCustID = new System.Windows.Forms.Label();
            this.txtCustID = new System.Windows.Forms.TextBox();
            this.txtRentalID = new System.Windows.Forms.TextBox();
            this.btnGenerateInvoice = new System.Windows.Forms.Button();
            this.grpGenerateInvoice = new System.Windows.Forms.GroupBox();
            this.lstInvoice = new System.Windows.Forms.ListBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpPrintSave = new System.Windows.Forms.GroupBox();
            this.lblCustID2 = new System.Windows.Forms.Label();
            this.lblCustomername = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblToolDetails = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.grpGenerateInvoice.SuspendLayout();
            this.grpPrintSave.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack,
            this.mnuExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(568, 24);
            this.menuStrip1.TabIndex = 11;
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
            // lblRentalID
            // 
            this.lblRentalID.AutoSize = true;
            this.lblRentalID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentalID.Location = new System.Drawing.Point(24, 58);
            this.lblRentalID.Name = "lblRentalID";
            this.lblRentalID.Size = new System.Drawing.Size(100, 16);
            this.lblRentalID.TabIndex = 24;
            this.lblRentalID.Text = "Enter Rental ID:";
            // 
            // lblCustID
            // 
            this.lblCustID.AutoSize = true;
            this.lblCustID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustID.Location = new System.Drawing.Point(6, 27);
            this.lblCustID.Name = "lblCustID";
            this.lblCustID.Size = new System.Drawing.Size(118, 16);
            this.lblCustID.TabIndex = 25;
            this.lblCustID.Text = "Enter Customer ID:";
            // 
            // txtCustID
            // 
            this.txtCustID.Location = new System.Drawing.Point(144, 27);
            this.txtCustID.Name = "txtCustID";
            this.txtCustID.Size = new System.Drawing.Size(100, 20);
            this.txtCustID.TabIndex = 26;
            // 
            // txtRentalID
            // 
            this.txtRentalID.Location = new System.Drawing.Point(144, 58);
            this.txtRentalID.Name = "txtRentalID";
            this.txtRentalID.Size = new System.Drawing.Size(100, 20);
            this.txtRentalID.TabIndex = 27;
            // 
            // btnGenerateInvoice
            // 
            this.btnGenerateInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateInvoice.Location = new System.Drawing.Point(65, 96);
            this.btnGenerateInvoice.Name = "btnGenerateInvoice";
            this.btnGenerateInvoice.Size = new System.Drawing.Size(162, 44);
            this.btnGenerateInvoice.TabIndex = 28;
            this.btnGenerateInvoice.Text = "Generate Invoice";
            this.btnGenerateInvoice.UseVisualStyleBackColor = true;
            this.btnGenerateInvoice.Click += new System.EventHandler(this.btnGenerateInvoice_Click);
            // 
            // grpGenerateInvoice
            // 
            this.grpGenerateInvoice.Controls.Add(this.btnGenerateInvoice);
            this.grpGenerateInvoice.Controls.Add(this.txtRentalID);
            this.grpGenerateInvoice.Controls.Add(this.txtCustID);
            this.grpGenerateInvoice.Controls.Add(this.lblCustID);
            this.grpGenerateInvoice.Controls.Add(this.lblRentalID);
            this.grpGenerateInvoice.Location = new System.Drawing.Point(15, 39);
            this.grpGenerateInvoice.Name = "grpGenerateInvoice";
            this.grpGenerateInvoice.Size = new System.Drawing.Size(303, 157);
            this.grpGenerateInvoice.TabIndex = 29;
            this.grpGenerateInvoice.TabStop = false;
            this.grpGenerateInvoice.Text = "Invoice Details";
            // 
            // lstInvoice
            // 
            this.lstInvoice.FormattingEnabled = true;
            this.lstInvoice.Location = new System.Drawing.Point(18, 74);
            this.lstInvoice.Name = "lstInvoice";
            this.lstInvoice.Size = new System.Drawing.Size(492, 95);
            this.lstInvoice.TabIndex = 30;
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(132, 181);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(112, 44);
            this.btnPrint.TabIndex = 31;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(250, 181);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 44);
            this.btnSave.TabIndex = 32;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // grpPrintSave
            // 
            this.grpPrintSave.Controls.Add(this.lblCost);
            this.grpPrintSave.Controls.Add(this.lblDate);
            this.grpPrintSave.Controls.Add(this.lblToolDetails);
            this.grpPrintSave.Controls.Add(this.lblCustomername);
            this.grpPrintSave.Controls.Add(this.lblCustID2);
            this.grpPrintSave.Controls.Add(this.btnSave);
            this.grpPrintSave.Controls.Add(this.btnPrint);
            this.grpPrintSave.Controls.Add(this.lstInvoice);
            this.grpPrintSave.Location = new System.Drawing.Point(15, 211);
            this.grpPrintSave.Name = "grpPrintSave";
            this.grpPrintSave.Size = new System.Drawing.Size(541, 232);
            this.grpPrintSave.TabIndex = 33;
            this.grpPrintSave.TabStop = false;
            this.grpPrintSave.Text = "Print/Save";
            // 
            // lblCustID2
            // 
            this.lblCustID2.AutoSize = true;
            this.lblCustID2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustID2.Location = new System.Drawing.Point(15, 55);
            this.lblCustID2.Name = "lblCustID2";
            this.lblCustID2.Size = new System.Drawing.Size(92, 16);
            this.lblCustID2.TabIndex = 33;
            this.lblCustID2.Text = "Customer ID";
            // 
            // lblCustomername
            // 
            this.lblCustomername.AutoSize = true;
            this.lblCustomername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomername.Location = new System.Drawing.Point(113, 55);
            this.lblCustomername.Name = "lblCustomername";
            this.lblCustomername.Size = new System.Drawing.Size(118, 16);
            this.lblCustomername.TabIndex = 34;
            this.lblCustomername.Text = "Customer Name";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(365, 55);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(41, 16);
            this.lblDate.TabIndex = 36;
            this.lblDate.Text = "Date";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.Location = new System.Drawing.Point(450, 55);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(39, 16);
            this.lblCost.TabIndex = 37;
            this.lblCost.Text = "Cost";
            // 
            // lblToolDetails
            // 
            this.lblToolDetails.AutoSize = true;
            this.lblToolDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToolDetails.Location = new System.Drawing.Point(247, 55);
            this.lblToolDetails.Name = "lblToolDetails";
            this.lblToolDetails.Size = new System.Drawing.Size(93, 16);
            this.lblToolDetails.TabIndex = 35;
            this.lblToolDetails.Text = "Tool Details";
            // 
            // frmGenerateInvoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 448);
            this.Controls.Add(this.grpPrintSave);
            this.Controls.Add(this.grpGenerateInvoice);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmGenerateInvoices";
            this.Text = "Generate Invoices";
            this.Load += new System.EventHandler(this.frmGenerateInvoices_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpGenerateInvoice.ResumeLayout(false);
            this.grpGenerateInvoice.PerformLayout();
            this.grpPrintSave.ResumeLayout(false);
            this.grpPrintSave.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.Label lblRentalID;
        private System.Windows.Forms.Label lblCustID;
        private System.Windows.Forms.TextBox txtCustID;
        private System.Windows.Forms.TextBox txtRentalID;
        private System.Windows.Forms.Button btnGenerateInvoice;
        private System.Windows.Forms.GroupBox grpGenerateInvoice;
        private System.Windows.Forms.ListBox lstInvoice;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox grpPrintSave;
        private System.Windows.Forms.Label lblCustID2;
        private System.Windows.Forms.Label lblCustomername;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblToolDetails;
    }
}