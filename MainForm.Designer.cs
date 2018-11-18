namespace MDI_Payroll
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newEmployeeEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewEmploeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.annualLeaveReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sickLeaveReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.overtimeReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unpaidEmployeeReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salarySlipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SkyBlue;
            this.menuStrip1.ContextMenuStrip = this.contextMenuStrip1;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.databaseToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.helpToolStripMenuItem1});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.TabStop = true;
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked_1);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.Color.SkyBlue;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.DarkBlue;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click_1);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.BackColor = System.Drawing.Color.SkyBlue;
            resources.ApplyResources(this.saveToolStripMenuItem, "saveToolStripMenuItem");
            this.saveToolStripMenuItem.ForeColor = System.Drawing.Color.DarkBlue;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.SkyBlue;
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.DarkBlue;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.BackColor = System.Drawing.Color.SkyBlue;
            this.databaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.staffToolStripMenuItem,
            this.paymentOrderToolStripMenuItem});
            resources.ApplyResources(this.databaseToolStripMenuItem, "databaseToolStripMenuItem");
            this.databaseToolStripMenuItem.ForeColor = System.Drawing.Color.DarkBlue;
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            // 
            // staffToolStripMenuItem
            // 
            this.staffToolStripMenuItem.BackColor = System.Drawing.Color.SkyBlue;
            this.staffToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchEmployeeToolStripMenuItem,
            this.newEmployeeEntryToolStripMenuItem,
            this.viewEmploeesToolStripMenuItem,
            this.deleteEmployeeToolStripMenuItem});
            this.staffToolStripMenuItem.ForeColor = System.Drawing.Color.DarkBlue;
            this.staffToolStripMenuItem.Name = "staffToolStripMenuItem";
            resources.ApplyResources(this.staffToolStripMenuItem, "staffToolStripMenuItem");
            // 
            // searchEmployeeToolStripMenuItem
            // 
            this.searchEmployeeToolStripMenuItem.BackColor = System.Drawing.Color.SkyBlue;
            this.searchEmployeeToolStripMenuItem.ForeColor = System.Drawing.Color.DarkBlue;
            this.searchEmployeeToolStripMenuItem.Name = "searchEmployeeToolStripMenuItem";
            resources.ApplyResources(this.searchEmployeeToolStripMenuItem, "searchEmployeeToolStripMenuItem");
            this.searchEmployeeToolStripMenuItem.Click += new System.EventHandler(this.searchEmployeeToolStripMenuItem_Click);
            // 
            // newEmployeeEntryToolStripMenuItem
            // 
            this.newEmployeeEntryToolStripMenuItem.BackColor = System.Drawing.Color.SkyBlue;
            this.newEmployeeEntryToolStripMenuItem.ForeColor = System.Drawing.Color.DarkBlue;
            this.newEmployeeEntryToolStripMenuItem.Name = "newEmployeeEntryToolStripMenuItem";
            resources.ApplyResources(this.newEmployeeEntryToolStripMenuItem, "newEmployeeEntryToolStripMenuItem");
            this.newEmployeeEntryToolStripMenuItem.Click += new System.EventHandler(this.newEmployeeEntryToolStripMenuItem_Click);
            // 
            // viewEmploeesToolStripMenuItem
            // 
            this.viewEmploeesToolStripMenuItem.BackColor = System.Drawing.Color.SkyBlue;
            this.viewEmploeesToolStripMenuItem.ForeColor = System.Drawing.Color.DarkBlue;
            this.viewEmploeesToolStripMenuItem.Name = "viewEmploeesToolStripMenuItem";
            resources.ApplyResources(this.viewEmploeesToolStripMenuItem, "viewEmploeesToolStripMenuItem");
            this.viewEmploeesToolStripMenuItem.Click += new System.EventHandler(this.viewEmploeesToolStripMenuItem_Click);
            // 
            // deleteEmployeeToolStripMenuItem
            // 
            this.deleteEmployeeToolStripMenuItem.Name = "deleteEmployeeToolStripMenuItem";
            resources.ApplyResources(this.deleteEmployeeToolStripMenuItem, "deleteEmployeeToolStripMenuItem");
            this.deleteEmployeeToolStripMenuItem.Click += new System.EventHandler(this.deleteEmployeeToolStripMenuItem_Click);
            // 
            // paymentOrderToolStripMenuItem
            // 
            this.paymentOrderToolStripMenuItem.BackColor = System.Drawing.Color.SkyBlue;
            this.paymentOrderToolStripMenuItem.ForeColor = System.Drawing.Color.DarkBlue;
            this.paymentOrderToolStripMenuItem.Name = "paymentOrderToolStripMenuItem";
            resources.ApplyResources(this.paymentOrderToolStripMenuItem, "paymentOrderToolStripMenuItem");
            this.paymentOrderToolStripMenuItem.Click += new System.EventHandler(this.paymentOrderToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.BackColor = System.Drawing.Color.SkyBlue;
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateToolStripMenuItem,
            this.findToolStripMenuItem});
            resources.ApplyResources(this.reportsToolStripMenuItem, "reportsToolStripMenuItem");
            this.reportsToolStripMenuItem.ForeColor = System.Drawing.Color.DarkBlue;
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            // 
            // generateToolStripMenuItem
            // 
            this.generateToolStripMenuItem.BackColor = System.Drawing.Color.SkyBlue;
            this.generateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.annualLeaveReportToolStripMenuItem,
            this.sickLeaveReportToolStripMenuItem,
            this.overtimeReportToolStripMenuItem,
            this.paymentReportToolStripMenuItem,
            this.unpaidEmployeeReportToolStripMenuItem,
            this.salarySlipToolStripMenuItem});
            this.generateToolStripMenuItem.ForeColor = System.Drawing.Color.DarkBlue;
            this.generateToolStripMenuItem.Name = "generateToolStripMenuItem";
            resources.ApplyResources(this.generateToolStripMenuItem, "generateToolStripMenuItem");
            // 
            // annualLeaveReportToolStripMenuItem
            // 
            this.annualLeaveReportToolStripMenuItem.BackColor = System.Drawing.Color.SkyBlue;
            this.annualLeaveReportToolStripMenuItem.ForeColor = System.Drawing.Color.DarkBlue;
            this.annualLeaveReportToolStripMenuItem.Name = "annualLeaveReportToolStripMenuItem";
            resources.ApplyResources(this.annualLeaveReportToolStripMenuItem, "annualLeaveReportToolStripMenuItem");
            // 
            // sickLeaveReportToolStripMenuItem
            // 
            this.sickLeaveReportToolStripMenuItem.BackColor = System.Drawing.Color.SkyBlue;
            this.sickLeaveReportToolStripMenuItem.ForeColor = System.Drawing.Color.DarkBlue;
            this.sickLeaveReportToolStripMenuItem.Name = "sickLeaveReportToolStripMenuItem";
            resources.ApplyResources(this.sickLeaveReportToolStripMenuItem, "sickLeaveReportToolStripMenuItem");
            // 
            // overtimeReportToolStripMenuItem
            // 
            this.overtimeReportToolStripMenuItem.BackColor = System.Drawing.Color.SkyBlue;
            this.overtimeReportToolStripMenuItem.ForeColor = System.Drawing.Color.DarkBlue;
            this.overtimeReportToolStripMenuItem.Name = "overtimeReportToolStripMenuItem";
            resources.ApplyResources(this.overtimeReportToolStripMenuItem, "overtimeReportToolStripMenuItem");
            // 
            // paymentReportToolStripMenuItem
            // 
            this.paymentReportToolStripMenuItem.BackColor = System.Drawing.Color.SkyBlue;
            this.paymentReportToolStripMenuItem.ForeColor = System.Drawing.Color.DarkBlue;
            this.paymentReportToolStripMenuItem.Name = "paymentReportToolStripMenuItem";
            resources.ApplyResources(this.paymentReportToolStripMenuItem, "paymentReportToolStripMenuItem");
            // 
            // unpaidEmployeeReportToolStripMenuItem
            // 
            this.unpaidEmployeeReportToolStripMenuItem.BackColor = System.Drawing.Color.SkyBlue;
            this.unpaidEmployeeReportToolStripMenuItem.ForeColor = System.Drawing.Color.DarkBlue;
            this.unpaidEmployeeReportToolStripMenuItem.Name = "unpaidEmployeeReportToolStripMenuItem";
            resources.ApplyResources(this.unpaidEmployeeReportToolStripMenuItem, "unpaidEmployeeReportToolStripMenuItem");
            // 
            // salarySlipToolStripMenuItem
            // 
            this.salarySlipToolStripMenuItem.BackColor = System.Drawing.Color.SkyBlue;
            this.salarySlipToolStripMenuItem.ForeColor = System.Drawing.Color.DarkBlue;
            this.salarySlipToolStripMenuItem.Name = "salarySlipToolStripMenuItem";
            resources.ApplyResources(this.salarySlipToolStripMenuItem, "salarySlipToolStripMenuItem");
            this.salarySlipToolStripMenuItem.Click += new System.EventHandler(this.salarySlipToolStripMenuItem_Click);
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.BackColor = System.Drawing.Color.SkyBlue;
            this.findToolStripMenuItem.ForeColor = System.Drawing.Color.DarkBlue;
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            resources.ApplyResources(this.findToolStripMenuItem, "findToolStripMenuItem");
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.BackColor = System.Drawing.Color.SkyBlue;
            resources.ApplyResources(this.helpToolStripMenuItem1, "helpToolStripMenuItem1");
            this.helpToolStripMenuItem1.ForeColor = System.Drawing.Color.DarkBlue;
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MDI_Payroll.Properties.Resources.payroll_banner;
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.w_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem annualLeaveReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sickLeaveReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem overtimeReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unpaidEmployeeReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salarySlipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newEmployeeEntryToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewEmploeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteEmployeeToolStripMenuItem;
    }
}

