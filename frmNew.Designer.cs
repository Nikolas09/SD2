namespace MDI_Payroll
{
    partial class frmNew
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
            this.ReportSalaryTest1 = new MDI_Payroll.ReportSalaryTest();
            this.label1 = new System.Windows.Forms.Label();
            this.user_txt = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.crystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.ReportSalaryTest2 = new MDI_Payroll.ReportSalaryTest();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // user_txt
            // 
            this.user_txt.Location = new System.Drawing.Point(203, 0);
            this.user_txt.Name = "user_txt";
            this.user_txt.Size = new System.Drawing.Size(100, 22);
            this.user_txt.TabIndex = 1;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(417, 0);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 2;
            this.submit.Text = "button1";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // crystalReportViewer
            // 
            this.crystalReportViewer.ActiveViewIndex = -1;
            this.crystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer.Location = new System.Drawing.Point(2, 67);
            this.crystalReportViewer.Name = "crystalReportViewer";
            this.crystalReportViewer.Size = new System.Drawing.Size(1065, 400);
            this.crystalReportViewer.TabIndex = 3;
            // 
            // frmNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.crystalReportViewer);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.user_txt);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNew";
            this.Text = "frmNew";
            this.Load += new System.EventHandler(this.frmNew_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ReportSalaryTest ReportSalaryTest1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox user_txt;
        private System.Windows.Forms.Button submit;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer;
        private ReportSalaryTest ReportSalaryTest2;
    }
}