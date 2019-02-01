namespace ToolHireSYS
{
    partial class frmRegisterCustomer
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
            this.cboTitle = new System.Windows.Forms.ComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblForename = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lbladdress1 = new System.Windows.Forms.Label();
            this.lblAddress2 = new System.Windows.Forms.Label();
            this.lblCounty = new System.Windows.Forms.Label();
            this.lblCreditDebit = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtForename = new System.Windows.Forms.TextBox();
            this.txtAddress1 = new System.Windows.Forms.TextBox();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.txtCreditDebit = new System.Windows.Forms.TextBox();
            this.cboCounty = new System.Windows.Forms.ComboBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.grpRegisterCustomer = new System.Windows.Forms.GroupBox();
            this.lblDebitCredit = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1.SuspendLayout();
            this.grpRegisterCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack,
            this.mnuExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(404, 24);
            this.menuStrip1.TabIndex = 0;
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
            // cboTitle
            // 
            this.cboTitle.FormattingEnabled = true;
            this.cboTitle.Location = new System.Drawing.Point(138, 9);
            this.cboTitle.Name = "cboTitle";
            this.cboTitle.Size = new System.Drawing.Size(121, 21);
            this.cboTitle.TabIndex = 1;
            this.cboTitle.SelectedIndexChanged += new System.EventHandler(this.cboTitle_SelectedIndexChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(84, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(39, 18);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Title:";
            // 
            // lblForename
            // 
            this.lblForename.AutoSize = true;
            this.lblForename.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForename.Location = new System.Drawing.Point(46, 47);
            this.lblForename.Name = "lblForename";
            this.lblForename.Size = new System.Drawing.Size(80, 18);
            this.lblForename.TabIndex = 3;
            this.lblForename.Text = "Forename:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(51, 81);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(72, 18);
            this.lblSurname.TabIndex = 4;
            this.lblSurname.Text = "Surname:";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.Location = new System.Drawing.Point(70, 112);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(53, 18);
            this.lblDOB.TabIndex = 5;
            this.lblDOB.Text = "D.O.B:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(74, 140);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(49, 18);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email:";
            // 
            // lbladdress1
            // 
            this.lbladdress1.AutoSize = true;
            this.lbladdress1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdress1.Location = new System.Drawing.Point(14, 171);
            this.lbladdress1.Name = "lbladdress1";
            this.lbladdress1.Size = new System.Drawing.Size(109, 18);
            this.lbladdress1.TabIndex = 7;
            this.lbladdress1.Text = "Address Line 1:";
            // 
            // lblAddress2
            // 
            this.lblAddress2.AutoSize = true;
            this.lblAddress2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress2.Location = new System.Drawing.Point(14, 199);
            this.lblAddress2.Name = "lblAddress2";
            this.lblAddress2.Size = new System.Drawing.Size(109, 18);
            this.lblAddress2.TabIndex = 8;
            this.lblAddress2.Text = "Address Line 2:";
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounty.Location = new System.Drawing.Point(64, 228);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(59, 18);
            this.lblCounty.TabIndex = 10;
            this.lblCounty.Text = "County:";
            // 
            // lblCreditDebit
            // 
            this.lblCreditDebit.AutoSize = true;
            this.lblCreditDebit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditDebit.Location = new System.Drawing.Point(12, 340);
            this.lblCreditDebit.Name = "lblCreditDebit";
            this.lblCreditDebit.Size = new System.Drawing.Size(125, 18);
            this.lblCreditDebit.TabIndex = 12;
            this.lblCreditDebit.Text = "Credit/Debit Card:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(138, 140);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(121, 20);
            this.txtEmail.TabIndex = 13;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(138, 81);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(121, 20);
            this.txtSurname.TabIndex = 15;
            // 
            // txtForename
            // 
            this.txtForename.Location = new System.Drawing.Point(138, 45);
            this.txtForename.Name = "txtForename";
            this.txtForename.Size = new System.Drawing.Size(121, 20);
            this.txtForename.TabIndex = 16;
            // 
            // txtAddress1
            // 
            this.txtAddress1.Location = new System.Drawing.Point(138, 171);
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(121, 20);
            this.txtAddress1.TabIndex = 17;
            // 
            // txtAddress2
            // 
            this.txtAddress2.Location = new System.Drawing.Point(138, 200);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(121, 20);
            this.txtAddress2.TabIndex = 19;
            // 
            // txtCreditDebit
            // 
            this.txtCreditDebit.Location = new System.Drawing.Point(138, 260);
            this.txtCreditDebit.Name = "txtCreditDebit";
            this.txtCreditDebit.Size = new System.Drawing.Size(121, 20);
            this.txtCreditDebit.TabIndex = 20;
            // 
            // cboCounty
            // 
            this.cboCounty.FormattingEnabled = true;
            this.cboCounty.Location = new System.Drawing.Point(138, 225);
            this.cboCounty.Name = "cboCounty";
            this.cboCounty.Size = new System.Drawing.Size(121, 21);
            this.cboCounty.TabIndex = 21;
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(152, 375);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(121, 50);
            this.btnRegister.TabIndex = 22;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // grpRegisterCustomer
            // 
            this.grpRegisterCustomer.Controls.Add(this.dtpDOB);
            this.grpRegisterCustomer.Controls.Add(this.lblDebitCredit);
            this.grpRegisterCustomer.Controls.Add(this.cboCounty);
            this.grpRegisterCustomer.Controls.Add(this.txtCreditDebit);
            this.grpRegisterCustomer.Controls.Add(this.txtAddress2);
            this.grpRegisterCustomer.Controls.Add(this.txtAddress1);
            this.grpRegisterCustomer.Controls.Add(this.txtForename);
            this.grpRegisterCustomer.Controls.Add(this.txtSurname);
            this.grpRegisterCustomer.Controls.Add(this.txtEmail);
            this.grpRegisterCustomer.Controls.Add(this.lblCounty);
            this.grpRegisterCustomer.Controls.Add(this.lblAddress2);
            this.grpRegisterCustomer.Controls.Add(this.lbladdress1);
            this.grpRegisterCustomer.Controls.Add(this.lblEmail);
            this.grpRegisterCustomer.Controls.Add(this.lblDOB);
            this.grpRegisterCustomer.Controls.Add(this.lblSurname);
            this.grpRegisterCustomer.Controls.Add(this.lblForename);
            this.grpRegisterCustomer.Controls.Add(this.lblTitle);
            this.grpRegisterCustomer.Controls.Add(this.cboTitle);
            this.grpRegisterCustomer.Location = new System.Drawing.Point(14, 37);
            this.grpRegisterCustomer.Name = "grpRegisterCustomer";
            this.grpRegisterCustomer.Size = new System.Drawing.Size(357, 332);
            this.grpRegisterCustomer.TabIndex = 23;
            this.grpRegisterCustomer.TabStop = false;
            this.grpRegisterCustomer.Text = "Register Customer";
            // 
            // lblDebitCredit
            // 
            this.lblDebitCredit.AutoSize = true;
            this.lblDebitCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDebitCredit.Location = new System.Drawing.Point(7, 260);
            this.lblDebitCredit.Name = "lblDebitCredit";
            this.lblDebitCredit.Size = new System.Drawing.Size(125, 18);
            this.lblDebitCredit.TabIndex = 22;
            this.lblDebitCredit.Text = "Credit/Debit Card:";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(138, 110);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(121, 20);
            this.dtpDOB.TabIndex = 23;
            // 
            // frmRegisterCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 443);
            this.Controls.Add(this.grpRegisterCustomer);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lblCreditDebit);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmRegisterCustomer";
            this.Text = "Register Customer";
            this.Load += new System.EventHandler(this.frmRegisterCustomer_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpRegisterCustomer.ResumeLayout(false);
            this.grpRegisterCustomer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ComboBox cboTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblForename;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lbladdress1;
        private System.Windows.Forms.Label lblAddress2;
        private System.Windows.Forms.Label lblCounty;
        private System.Windows.Forms.Label lblCreditDebit;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.TextBox txtAddress1;
        private System.Windows.Forms.TextBox txtAddress2;
        private System.Windows.Forms.TextBox txtCreditDebit;
        private System.Windows.Forms.ComboBox cboCounty;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.GroupBox grpRegisterCustomer;
        private System.Windows.Forms.Label lblDebitCredit;
        private System.Windows.Forms.DateTimePicker dtpDOB;
    }
}