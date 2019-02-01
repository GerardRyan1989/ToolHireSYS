namespace ToolHireSYS
{
    partial class frmLateReturns
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
            this.btnListLateReturns = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.grpLateReturns = new System.Windows.Forms.GroupBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.grdLateReturns = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.grpLateReturns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdLateReturns)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListLateReturns
            // 
            this.btnListLateReturns.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListLateReturns.Location = new System.Drawing.Point(199, 67);
            this.btnListLateReturns.Name = "btnListLateReturns";
            this.btnListLateReturns.Size = new System.Drawing.Size(161, 49);
            this.btnListLateReturns.TabIndex = 0;
            this.btnListLateReturns.Text = "List Late Returns";
            this.btnListLateReturns.UseVisualStyleBackColor = true;
            this.btnListLateReturns.Click += new System.EventHandler(this.btnListLateReturns_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack,
            this.mnuExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(612, 24);
            this.menuStrip1.TabIndex = 3;
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
            // grpLateReturns
            // 
            this.grpLateReturns.Controls.Add(this.grdLateReturns);
            this.grpLateReturns.Controls.Add(this.btnPrint);
            this.grpLateReturns.Location = new System.Drawing.Point(16, 122);
            this.grpLateReturns.Name = "grpLateReturns";
            this.grpLateReturns.Size = new System.Drawing.Size(584, 331);
            this.grpLateReturns.TabIndex = 22;
            this.grpLateReturns.TabStop = false;
            this.grpLateReturns.Text = "Late Returns";
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(223, 265);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(121, 44);
            this.btnPrint.TabIndex = 45;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // grdLateReturns
            // 
            this.grdLateReturns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdLateReturns.Location = new System.Drawing.Point(6, 19);
            this.grdLateReturns.Name = "grdLateReturns";
            this.grdLateReturns.Size = new System.Drawing.Size(572, 240);
            this.grdLateReturns.TabIndex = 46;
            // 
            // frmLateReturns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 488);
            this.Controls.Add(this.grpLateReturns);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnListLateReturns);
            this.Name = "frmLateReturns";
            this.Text = "Late Returns";
            this.Load += new System.EventHandler(this.frmLateReturns_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpLateReturns.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdLateReturns)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListLateReturns;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.GroupBox grpLateReturns;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridView grdLateReturns;
    }
}