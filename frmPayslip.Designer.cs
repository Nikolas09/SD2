namespace MDI_Payroll
{
    partial class frmPayslip
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
            this.crystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.user_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crystalReportViewer
            // 
            this.crystalReportViewer.ActiveViewIndex = -1;
            this.crystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer.Location = new System.Drawing.Point(0, 101);
            this.crystalReportViewer.Margin = new System.Windows.Forms.Padding(4);
            this.crystalReportViewer.Name = "crystalReportViewer";
            this.crystalReportViewer.Size = new System.Drawing.Size(1067, 453);
            this.crystalReportViewer.TabIndex = 0;
            this.crystalReportViewer.ToolPanelWidth = 267;
            this.crystalReportViewer.Load += new System.EventHandler(this.crystalReportViewer_Load);
            // 
            // user_ID
            // 
            this.user_ID.Location = new System.Drawing.Point(488, 52);
            this.user_ID.Name = "user_ID";
            this.user_ID.Size = new System.Drawing.Size(100, 22);
            this.user_ID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(303, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter ID";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(710, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmPayslip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.user_ID);
            this.Controls.Add(this.crystalReportViewer);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPayslip";
            this.Text = "frmPayslip";
            this.Load += new System.EventHandler(this.frmPayslip_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer;
        private System.Windows.Forms.TextBox user_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}