namespace MDI_Payroll
{
    partial class SearchEmp
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
            this.dataview = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.id_box = new System.Windows.Forms.TextBox();
            this.Search_butt = new System.Windows.Forms.Button();
            this.exit_butt = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataview)).BeginInit();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataview
            // 
            this.dataview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataview.Location = new System.Drawing.Point(51, 332);
            this.dataview.Margin = new System.Windows.Forms.Padding(4);
            this.dataview.Name = "dataview";
            this.dataview.Size = new System.Drawing.Size(989, 288);
            this.dataview.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SkyBlue;
            this.label2.Location = new System.Drawing.Point(292, 120);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "Employee ID:";
            // 
            // id_box
            // 
            this.id_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_box.Location = new System.Drawing.Point(495, 120);
            this.id_box.Margin = new System.Windows.Forms.Padding(4);
            this.id_box.Multiline = true;
            this.id_box.Name = "id_box";
            this.id_box.Size = new System.Drawing.Size(176, 38);
            this.id_box.TabIndex = 5;
            // 
            // Search_butt
            // 
            this.Search_butt.BackColor = System.Drawing.Color.Transparent;
            this.Search_butt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_butt.ForeColor = System.Drawing.Color.DarkBlue;
            this.Search_butt.Location = new System.Drawing.Point(789, 46);
            this.Search_butt.Margin = new System.Windows.Forms.Padding(4);
            this.Search_butt.Name = "Search_butt";
            this.Search_butt.Size = new System.Drawing.Size(137, 46);
            this.Search_butt.TabIndex = 7;
            this.Search_butt.Text = "Search";
            this.Search_butt.UseVisualStyleBackColor = false;
            this.Search_butt.Click += new System.EventHandler(this.Search_butt_Click);
            // 
            // exit_butt
            // 
            this.exit_butt.BackColor = System.Drawing.Color.Transparent;
            this.exit_butt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_butt.ForeColor = System.Drawing.Color.DarkBlue;
            this.exit_butt.Location = new System.Drawing.Point(789, 113);
            this.exit_butt.Margin = new System.Windows.Forms.Padding(4);
            this.exit_butt.Name = "exit_butt";
            this.exit_butt.Size = new System.Drawing.Size(137, 46);
            this.exit_butt.TabIndex = 8;
            this.exit_butt.Text = "Exit";
            this.exit_butt.UseVisualStyleBackColor = false;
            this.exit_butt.Click += new System.EventHandler(this.exit_butt_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.GroupBox1.BackgroundImage = global::MDI_Payroll.Properties.Resources.background0;
            this.GroupBox1.Controls.Add(this.Search_butt);
            this.GroupBox1.Controls.Add(this.exit_butt);
            this.GroupBox1.Controls.Add(this.label2);
            this.GroupBox1.Controls.Add(this.id_box);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.ForeColor = System.Drawing.Color.SkyBlue;
            this.GroupBox1.Location = new System.Drawing.Point(54, 148);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox1.Size = new System.Drawing.Size(986, 399);
            this.GroupBox1.TabIndex = 52;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Search Employee Record";
            // 
            // SearchEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::MDI_Payroll.Properties.Resources.background0;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1099, 681);
            this.Controls.Add(this.dataview);
            this.Controls.Add(this.GroupBox1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SearchEmp";
            this.Text = "SearchEmp";
            this.Load += new System.EventHandler(this.SearchEmp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataview)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataview;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox id_box;
        private System.Windows.Forms.Button Search_butt;
        private System.Windows.Forms.Button exit_butt;
        internal System.Windows.Forms.GroupBox GroupBox1;
    }
}