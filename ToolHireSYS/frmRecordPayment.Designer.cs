namespace ToolHireSYS
{
    partial class frmRecordPayment
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
            this.txtRentID = new System.Windows.Forms.TextBox();
            this.lblRentID = new System.Windows.Forms.Label();
            this.txtCustID = new System.Windows.Forms.TextBox();
            this.lblCustID = new System.Windows.Forms.Label();
            this.txtPayment = new System.Windows.Forms.TextBox();
            this.lblPaymentAmount = new System.Windows.Forms.Label();
            this.txtCreditDebit = new System.Windows.Forms.TextBox();
            this.lblCreditDebit = new System.Windows.Forms.Label();
            this.btnConfirmPay = new System.Windows.Forms.Button();
            this.grpMakePayment = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.grpMakePayment.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack,
            this.mnuExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(436, 24);
            this.menuStrip1.TabIndex = 29;
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
            // txtRentID
            // 
            this.txtRentID.Location = new System.Drawing.Point(171, 39);
            this.txtRentID.Name = "txtRentID";
            this.txtRentID.Size = new System.Drawing.Size(121, 20);
            this.txtRentID.TabIndex = 35;
            this.txtRentID.TextChanged += new System.EventHandler(this.txtRentID_TextChanged);
            // 
            // lblRentID
            // 
            this.lblRentID.AutoSize = true;
            this.lblRentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentID.Location = new System.Drawing.Point(93, 39);
            this.lblRentID.Name = "lblRentID";
            this.lblRentID.Size = new System.Drawing.Size(72, 18);
            this.lblRentID.TabIndex = 34;
            this.lblRentID.Text = "Rental ID:";
            this.lblRentID.Click += new System.EventHandler(this.lblRentID_Click);
            // 
            // txtCustID
            // 
            this.txtCustID.Location = new System.Drawing.Point(171, 13);
            this.txtCustID.Name = "txtCustID";
            this.txtCustID.Size = new System.Drawing.Size(121, 20);
            this.txtCustID.TabIndex = 37;
            // 
            // lblCustID
            // 
            this.lblCustID.AutoSize = true;
            this.lblCustID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustID.Location = new System.Drawing.Point(69, 15);
            this.lblCustID.Name = "lblCustID";
            this.lblCustID.Size = new System.Drawing.Size(96, 18);
            this.lblCustID.TabIndex = 36;
            this.lblCustID.Text = "Customer ID:";
            // 
            // txtPayment
            // 
            this.txtPayment.Location = new System.Drawing.Point(171, 65);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.Size = new System.Drawing.Size(121, 20);
            this.txtPayment.TabIndex = 39;
            // 
            // lblPaymentAmount
            // 
            this.lblPaymentAmount.AutoSize = true;
            this.lblPaymentAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentAmount.Location = new System.Drawing.Point(40, 64);
            this.lblPaymentAmount.Name = "lblPaymentAmount";
            this.lblPaymentAmount.Size = new System.Drawing.Size(125, 18);
            this.lblPaymentAmount.TabIndex = 38;
            this.lblPaymentAmount.Text = "Payment Amount:";
            // 
            // txtCreditDebit
            // 
            this.txtCreditDebit.Location = new System.Drawing.Point(171, 94);
            this.txtCreditDebit.Name = "txtCreditDebit";
            this.txtCreditDebit.Size = new System.Drawing.Size(121, 20);
            this.txtCreditDebit.TabIndex = 41;
            // 
            // lblCreditDebit
            // 
            this.lblCreditDebit.AutoSize = true;
            this.lblCreditDebit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditDebit.Location = new System.Drawing.Point(36, 93);
            this.lblCreditDebit.Name = "lblCreditDebit";
            this.lblCreditDebit.Size = new System.Drawing.Size(129, 18);
            this.lblCreditDebit.TabIndex = 40;
            this.lblCreditDebit.Text = "Credit/Debit Card :";
            // 
            // btnConfirmPay
            // 
            this.btnConfirmPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmPay.Location = new System.Drawing.Point(171, 141);
            this.btnConfirmPay.Name = "btnConfirmPay";
            this.btnConfirmPay.Size = new System.Drawing.Size(106, 47);
            this.btnConfirmPay.TabIndex = 42;
            this.btnConfirmPay.Text = "Confirm Payment";
            this.btnConfirmPay.UseVisualStyleBackColor = true;
            this.btnConfirmPay.Click += new System.EventHandler(this.btnConfirmPay_Click);
            // 
            // grpMakePayment
            // 
            this.grpMakePayment.Controls.Add(this.btnConfirmPay);
            this.grpMakePayment.Controls.Add(this.txtCreditDebit);
            this.grpMakePayment.Controls.Add(this.lblCreditDebit);
            this.grpMakePayment.Controls.Add(this.txtPayment);
            this.grpMakePayment.Controls.Add(this.lblPaymentAmount);
            this.grpMakePayment.Controls.Add(this.txtCustID);
            this.grpMakePayment.Controls.Add(this.lblCustID);
            this.grpMakePayment.Controls.Add(this.txtRentID);
            this.grpMakePayment.Controls.Add(this.lblRentID);
            this.grpMakePayment.Location = new System.Drawing.Point(12, 37);
            this.grpMakePayment.Name = "grpMakePayment";
            this.grpMakePayment.Size = new System.Drawing.Size(370, 221);
            this.grpMakePayment.TabIndex = 43;
            this.grpMakePayment.TabStop = false;
            this.grpMakePayment.Text = "Make Payment";
            // 
            // frmRecordPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 308);
            this.Controls.Add(this.grpMakePayment);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmRecordPayment";
            this.Text = "Record Payment";
            this.Load += new System.EventHandler(this.frmRecordPayment_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpMakePayment.ResumeLayout(false);
            this.grpMakePayment.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.TextBox txtRentID;
        private System.Windows.Forms.Label lblRentID;
        private System.Windows.Forms.TextBox txtCustID;
        private System.Windows.Forms.Label lblCustID;
        private System.Windows.Forms.TextBox txtPayment;
        private System.Windows.Forms.Label lblPaymentAmount;
        private System.Windows.Forms.TextBox txtCreditDebit;
        private System.Windows.Forms.Label lblCreditDebit;
        private System.Windows.Forms.Button btnConfirmPay;
        private System.Windows.Forms.GroupBox grpMakePayment;
    }
}