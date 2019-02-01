namespace ToolHireSYS
{
    partial class frmListTools
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
            this.btnPrint = new System.Windows.Forms.Button();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblMake = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.cboMake = new System.Windows.Forms.ComboBox();
            this.grdListTool = new System.Windows.Forms.DataGridView();
            this.grpListTools = new System.Windows.Forms.GroupBox();
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.cboOrderIn = new System.Windows.Forms.ComboBox();
            this.lblOrderIn = new System.Windows.Forms.Label();
            this.cboOrderBy = new System.Windows.Forms.ComboBox();
            this.lblSortBy = new System.Windows.Forms.Label();
            this.btnListTools = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListTool)).BeginInit();
            this.grpListTools.SuspendLayout();
            this.grpDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack,
            this.mnuExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(802, 24);
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
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(342, 429);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(121, 44);
            this.btnPrint.TabIndex = 24;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(27, 19);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(75, 16);
            this.lblCategory.TabIndex = 25;
            this.lblCategory.Text = "Category:";
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMake.Location = new System.Drawing.Point(215, 20);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(50, 16);
            this.lblMake.TabIndex = 26;
            this.lblMake.Text = "Make:";
            // 
            // cboCategory
            // 
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(108, 19);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(92, 21);
            this.cboCategory.TabIndex = 27;
            // 
            // cboMake
            // 
            this.cboMake.FormattingEnabled = true;
            this.cboMake.Location = new System.Drawing.Point(273, 19);
            this.cboMake.Name = "cboMake";
            this.cboMake.Size = new System.Drawing.Size(93, 21);
            this.cboMake.TabIndex = 28;
            // 
            // grdListTool
            // 
            this.grdListTool.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdListTool.Location = new System.Drawing.Point(19, 162);
            this.grdListTool.Name = "grdListTool";
            this.grdListTool.Size = new System.Drawing.Size(735, 249);
            this.grdListTool.TabIndex = 29;
            // 
            // grpListTools
            // 
            this.grpListTools.Controls.Add(this.grpDetails);
            this.grpListTools.Controls.Add(this.btnPrint);
            this.grpListTools.Controls.Add(this.grdListTool);
            this.grpListTools.Location = new System.Drawing.Point(12, 27);
            this.grpListTools.Name = "grpListTools";
            this.grpListTools.Size = new System.Drawing.Size(778, 489);
            this.grpListTools.TabIndex = 30;
            this.grpListTools.TabStop = false;
            this.grpListTools.Text = "List Tools:";
            // 
            // grpDetails
            // 
            this.grpDetails.Controls.Add(this.cboOrderIn);
            this.grpDetails.Controls.Add(this.lblOrderIn);
            this.grpDetails.Controls.Add(this.lblMake);
            this.grpDetails.Controls.Add(this.btnListTools);
            this.grpDetails.Controls.Add(this.cboCategory);
            this.grpDetails.Controls.Add(this.lblCategory);
            this.grpDetails.Controls.Add(this.cboOrderBy);
            this.grpDetails.Controls.Add(this.cboMake);
            this.grpDetails.Controls.Add(this.lblSortBy);
            this.grpDetails.Location = new System.Drawing.Point(19, 19);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Size = new System.Drawing.Size(735, 125);
            this.grpDetails.TabIndex = 33;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "Details:";
            // 
            // cboOrderIn
            // 
            this.cboOrderIn.FormattingEnabled = true;
            this.cboOrderIn.Location = new System.Drawing.Point(617, 20);
            this.cboOrderIn.Name = "cboOrderIn";
            this.cboOrderIn.Size = new System.Drawing.Size(93, 21);
            this.cboOrderIn.TabIndex = 34;
            // 
            // lblOrderIn
            // 
            this.lblOrderIn.AutoSize = true;
            this.lblOrderIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderIn.Location = new System.Drawing.Point(549, 20);
            this.lblOrderIn.Name = "lblOrderIn";
            this.lblOrderIn.Size = new System.Drawing.Size(67, 16);
            this.lblOrderIn.TabIndex = 33;
            this.lblOrderIn.Text = "Order In:";
            // 
            // cboOrderBy
            // 
            this.cboOrderBy.FormattingEnabled = true;
            this.cboOrderBy.Location = new System.Drawing.Point(450, 20);
            this.cboOrderBy.Name = "cboOrderBy";
            this.cboOrderBy.Size = new System.Drawing.Size(93, 21);
            this.cboOrderBy.TabIndex = 31;
            // 
            // lblSortBy
            // 
            this.lblSortBy.AutoSize = true;
            this.lblSortBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortBy.Location = new System.Drawing.Point(382, 20);
            this.lblSortBy.Name = "lblSortBy";
            this.lblSortBy.Size = new System.Drawing.Size(73, 16);
            this.lblSortBy.TabIndex = 30;
            this.lblSortBy.Text = "Order By:";
            
            // 
            // btnListTools
            // 
            this.btnListTools.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListTools.Location = new System.Drawing.Point(273, 64);
            this.btnListTools.Name = "btnListTools";
            this.btnListTools.Size = new System.Drawing.Size(121, 44);
            this.btnListTools.TabIndex = 32;
            this.btnListTools.Text = "List Tools";
            this.btnListTools.UseVisualStyleBackColor = true;
            this.btnListTools.Click += new System.EventHandler(this.btnListTools_Click);
            // 
            // frmListTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 528);
            this.Controls.Add(this.grpListTools);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmListTools";
            this.Text = "List Tools";
            this.Load += new System.EventHandler(this.frmListTools_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListTool)).EndInit();
            this.grpListTools.ResumeLayout(false);
            this.grpDetails.ResumeLayout(false);
            this.grpDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.ComboBox cboMake;
        private System.Windows.Forms.DataGridView grdListTool;
        private System.Windows.Forms.GroupBox grpListTools;
        private System.Windows.Forms.ComboBox cboOrderBy;
        private System.Windows.Forms.Label lblSortBy;
        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.ComboBox cboOrderIn;
        private System.Windows.Forms.Label lblOrderIn;
        private System.Windows.Forms.Button btnListTools;
    }
}