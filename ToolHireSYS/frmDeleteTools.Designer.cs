namespace ToolHireSYS
{
    partial class frmDeleteTools
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
            this.grpSearchTool = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cboMake = new System.Windows.Forms.ComboBox();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.lblMake = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.grpSelectTool = new System.Windows.Forms.GroupBox();
            this.grpRemoveTool = new System.Windows.Forms.GroupBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtToolID = new System.Windows.Forms.TextBox();
            this.lblToolID = new System.Windows.Forms.Label();
            this.btnRemoveTool = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblMake2 = new System.Windows.Forms.Label();
            this.lblCategory2 = new System.Windows.Forms.Label();
            this.grdSelectTool = new System.Windows.Forms.DataGridView();
            this.cboCategory2 = new System.Windows.Forms.ComboBox();
            this.cboMake2 = new System.Windows.Forms.ComboBox();
            this.grpSearchTool.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.grpSelectTool.SuspendLayout();
            this.grpRemoveTool.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSelectTool)).BeginInit();
            this.SuspendLayout();
            // 
            // grpSearchTool
            // 
            this.grpSearchTool.Controls.Add(this.btnSearch);
            this.grpSearchTool.Controls.Add(this.cboMake);
            this.grpSearchTool.Controls.Add(this.cboCategory);
            this.grpSearchTool.Controls.Add(this.lblMake);
            this.grpSearchTool.Controls.Add(this.lblCategory);
            this.grpSearchTool.Location = new System.Drawing.Point(12, 27);
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
            this.btnSearch.Size = new System.Drawing.Size(82, 31);
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack,
            this.mnuExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(744, 24);
            this.menuStrip1.TabIndex = 12;
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
            this.grpSelectTool.Controls.Add(this.grpRemoveTool);
            this.grpSelectTool.Controls.Add(this.grdSelectTool);
            this.grpSelectTool.Location = new System.Drawing.Point(265, 27);
            this.grpSelectTool.Name = "grpSelectTool";
            this.grpSelectTool.Size = new System.Drawing.Size(467, 487);
            this.grpSelectTool.TabIndex = 13;
            this.grpSelectTool.TabStop = false;
            this.grpSelectTool.Text = "Select Tool ";
            // 
            // grpRemoveTool
            // 
            this.grpRemoveTool.Controls.Add(this.cboMake2);
            this.grpRemoveTool.Controls.Add(this.cboCategory2);
            this.grpRemoveTool.Controls.Add(this.txtDescription);
            this.grpRemoveTool.Controls.Add(this.lblDescription);
            this.grpRemoveTool.Controls.Add(this.txtToolID);
            this.grpRemoveTool.Controls.Add(this.lblToolID);
            this.grpRemoveTool.Controls.Add(this.btnRemoveTool);
            this.grpRemoveTool.Controls.Add(this.txtPrice);
            this.grpRemoveTool.Controls.Add(this.lblPrice);
            this.grpRemoveTool.Controls.Add(this.txtModel);
            this.grpRemoveTool.Controls.Add(this.lblModel);
            this.grpRemoveTool.Controls.Add(this.lblMake2);
            this.grpRemoveTool.Controls.Add(this.lblCategory2);
            this.grpRemoveTool.Location = new System.Drawing.Point(40, 187);
            this.grpRemoveTool.Name = "grpRemoveTool";
            this.grpRemoveTool.Size = new System.Drawing.Size(364, 294);
            this.grpRemoveTool.TabIndex = 20;
            this.grpRemoveTool.TabStop = false;
            this.grpRemoveTool.Text = "Remove Tool";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(137, 151);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(121, 20);
            this.txtDescription.TabIndex = 15;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(43, 151);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(87, 18);
            this.lblDescription.TabIndex = 14;
            this.lblDescription.Text = "Description:";
            // 
            // txtToolID
            // 
            this.txtToolID.Location = new System.Drawing.Point(137, 31);
            this.txtToolID.Name = "txtToolID";
            this.txtToolID.ReadOnly = true;
            this.txtToolID.Size = new System.Drawing.Size(121, 20);
            this.txtToolID.TabIndex = 13;
            // 
            // lblToolID
            // 
            this.lblToolID.AutoSize = true;
            this.lblToolID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToolID.Location = new System.Drawing.Point(71, 33);
            this.lblToolID.Name = "lblToolID";
            this.lblToolID.Size = new System.Drawing.Size(60, 18);
            this.lblToolID.TabIndex = 12;
            this.lblToolID.Text = "Tool ID:";
            // 
            // btnRemoveTool
            // 
            this.btnRemoveTool.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveTool.Location = new System.Drawing.Point(111, 222);
            this.btnRemoveTool.Name = "btnRemoveTool";
            this.btnRemoveTool.Size = new System.Drawing.Size(146, 44);
            this.btnRemoveTool.TabIndex = 11;
            this.btnRemoveTool.Text = "Remove Selected Tool";
            this.btnRemoveTool.UseVisualStyleBackColor = true;
            this.btnRemoveTool.Click += new System.EventHandler(this.btnRemoveTool_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(136, 177);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(121, 20);
            this.txtPrice.TabIndex = 10;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(84, 179);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(46, 18);
            this.lblPrice.TabIndex = 9;
            this.lblPrice.Text = "Price:";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(136, 118);
            this.txtModel.Name = "txtModel";
            this.txtModel.ReadOnly = true;
            this.txtModel.Size = new System.Drawing.Size(121, 20);
            this.txtModel.TabIndex = 8;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModel.Location = new System.Drawing.Point(82, 120);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(53, 18);
            this.lblModel.TabIndex = 7;
            this.lblModel.Text = "Model:";
            // 
            // lblMake2
            // 
            this.lblMake2.AutoSize = true;
            this.lblMake2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMake2.Location = new System.Drawing.Point(82, 90);
            this.lblMake2.Name = "lblMake2";
            this.lblMake2.Size = new System.Drawing.Size(49, 18);
            this.lblMake2.TabIndex = 6;
            this.lblMake2.Text = "Make:";
            // 
            // lblCategory2
            // 
            this.lblCategory2.AutoSize = true;
            this.lblCategory2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory2.Location = new System.Drawing.Point(59, 62);
            this.lblCategory2.Name = "lblCategory2";
            this.lblCategory2.Size = new System.Drawing.Size(72, 18);
            this.lblCategory2.TabIndex = 4;
            this.lblCategory2.Text = "Category:";
            // 
            // grdSelectTool
            // 
            this.grdSelectTool.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSelectTool.Location = new System.Drawing.Point(6, 32);
            this.grdSelectTool.Name = "grdSelectTool";
            this.grdSelectTool.Size = new System.Drawing.Size(455, 125);
            this.grdSelectTool.TabIndex = 0;
            this.grdSelectTool.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdSelectTool_CellContentClick);
            // 
            // cboCategory2
            // 
            this.cboCategory2.FormattingEnabled = true;
            this.cboCategory2.Location = new System.Drawing.Point(137, 63);
            this.cboCategory2.Name = "cboCategory2";
            this.cboCategory2.Size = new System.Drawing.Size(120, 21);
            this.cboCategory2.TabIndex = 16;
            // 
            // cboMake2
            // 
            this.cboMake2.FormattingEnabled = true;
            this.cboMake2.Location = new System.Drawing.Point(137, 91);
            this.cboMake2.Name = "cboMake2";
            this.cboMake2.Size = new System.Drawing.Size(120, 21);
            this.cboMake2.TabIndex = 17;
            // 
            // frmDeleteTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 526);
            this.Controls.Add(this.grpSelectTool);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.grpSearchTool);
            this.Name = "frmDeleteTools";
            this.Text = "Delete Tools";
            this.Load += new System.EventHandler(this.frmDeleteTools_Load);
            this.grpSearchTool.ResumeLayout(false);
            this.grpSearchTool.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpSelectTool.ResumeLayout(false);
            this.grpRemoveTool.ResumeLayout(false);
            this.grpRemoveTool.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSelectTool)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSearchTool;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cboMake;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.GroupBox grpSelectTool;
        private System.Windows.Forms.DataGridView grdSelectTool;
        private System.Windows.Forms.GroupBox grpRemoveTool;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtToolID;
        private System.Windows.Forms.Label lblToolID;
        private System.Windows.Forms.Button btnRemoveTool;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblMake2;
        private System.Windows.Forms.Label lblCategory2;
        private System.Windows.Forms.ComboBox cboMake2;
        private System.Windows.Forms.ComboBox cboCategory2;
    }
}