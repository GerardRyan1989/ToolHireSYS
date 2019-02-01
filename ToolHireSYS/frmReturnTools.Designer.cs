namespace ToolHireSYS
{
    partial class frmReturnTools
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
            this.grpSelectTool = new System.Windows.Forms.GroupBox();
            this.btnReturnTool = new System.Windows.Forms.Button();
            this.lblToolID2 = new System.Windows.Forms.Label();
            this.txtToolID = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.grpSelectTool.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack,
            this.mnuExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(435, 24);
            this.menuStrip1.TabIndex = 25;
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
            // grpSelectTool
            // 
            this.grpSelectTool.Controls.Add(this.btnReturnTool);
            this.grpSelectTool.Controls.Add(this.lblToolID2);
            this.grpSelectTool.Controls.Add(this.txtToolID);
            this.grpSelectTool.Location = new System.Drawing.Point(23, 43);
            this.grpSelectTool.Name = "grpSelectTool";
            this.grpSelectTool.Size = new System.Drawing.Size(374, 188);
            this.grpSelectTool.TabIndex = 26;
            this.grpSelectTool.TabStop = false;
            this.grpSelectTool.Text = "Select Tool";
            // 
            // btnReturnTool
            // 
            this.btnReturnTool.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnTool.Location = new System.Drawing.Point(129, 104);
            this.btnReturnTool.Name = "btnReturnTool";
            this.btnReturnTool.Size = new System.Drawing.Size(128, 50);
            this.btnReturnTool.TabIndex = 17;
            this.btnReturnTool.Text = "Submit";
            this.btnReturnTool.UseVisualStyleBackColor = true;
            this.btnReturnTool.Click += new System.EventHandler(this.btnReturnTool_Click);
            // 
            // lblToolID2
            // 
            this.lblToolID2.AutoSize = true;
            this.lblToolID2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToolID2.Location = new System.Drawing.Point(6, 28);
            this.lblToolID2.Name = "lblToolID2";
            this.lblToolID2.Size = new System.Drawing.Size(159, 16);
            this.lblToolID2.TabIndex = 16;
            this.lblToolID2.Text = "Select Tool ID  for Return:";
            // 
            // txtToolID
            // 
            this.txtToolID.Location = new System.Drawing.Point(171, 24);
            this.txtToolID.Name = "txtToolID";
            this.txtToolID.Size = new System.Drawing.Size(54, 20);
            this.txtToolID.TabIndex = 15;
            // 
            // frmReturnTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 284);
            this.Controls.Add(this.grpSelectTool);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmReturnTools";
            this.Text = "Return Tools";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpSelectTool.ResumeLayout(false);
            this.grpSelectTool.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.GroupBox grpSelectTool;
        private System.Windows.Forms.Button btnReturnTool;
        private System.Windows.Forms.Label lblToolID2;
        private System.Windows.Forms.TextBox txtToolID;
    }
}