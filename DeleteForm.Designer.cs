namespace MDI_Payroll
{
    partial class DeleteForm
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
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Search_butt = new System.Windows.Forms.Button();
            this.exit_butt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.id_box = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.GroupBox1.BackgroundImage = global::MDI_Payroll.Properties.Resources.background0;
            this.GroupBox1.Controls.Add(this.dataGridView);
            this.GroupBox1.Controls.Add(this.button1);
            this.GroupBox1.Controls.Add(this.Search_butt);
            this.GroupBox1.Controls.Add(this.exit_butt);
            this.GroupBox1.Controls.Add(this.label2);
            this.GroupBox1.Controls.Add(this.id_box);
            this.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.ForeColor = System.Drawing.Color.SkyBlue;
            this.GroupBox1.Location = new System.Drawing.Point(0, 0);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox1.Size = new System.Drawing.Size(939, 541);
            this.GroupBox1.TabIndex = 53;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Search Employee Record";
            // 
            // Search_butt
            // 
            this.Search_butt.BackColor = System.Drawing.Color.Transparent;
            this.Search_butt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_butt.ForeColor = System.Drawing.Color.DarkBlue;
            this.Search_butt.Location = new System.Drawing.Point(747, 46);
            this.Search_butt.Margin = new System.Windows.Forms.Padding(4);
            this.Search_butt.Name = "Search_butt";
            this.Search_butt.Size = new System.Drawing.Size(137, 32);
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
            this.exit_butt.Location = new System.Drawing.Point(747, 124);
            this.exit_butt.Margin = new System.Windows.Forms.Padding(4);
            this.exit_butt.Name = "exit_butt";
            this.exit_butt.Size = new System.Drawing.Size(137, 32);
            this.exit_butt.TabIndex = 8;
            this.exit_butt.Text = "Exit";
            this.exit_butt.UseVisualStyleBackColor = false;
            this.exit_butt.Click += new System.EventHandler(this.exit_butt_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SkyBlue;
            this.label2.Location = new System.Drawing.Point(248, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "Employee ID:";
            // 
            // id_box
            // 
            this.id_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_box.Location = new System.Drawing.Point(451, 117);
            this.id_box.Margin = new System.Windows.Forms.Padding(4);
            this.id_box.Multiline = true;
            this.id_box.Name = "id_box";
            this.id_box.Size = new System.Drawing.Size(176, 38);
            this.id_box.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkBlue;
            this.button1.Location = new System.Drawing.Point(747, 86);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 32);
            this.button1.TabIndex = 9;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(41, 234);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(843, 230);
            this.dataGridView.TabIndex = 10;
            // 
            // DeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 541);
            this.Controls.Add(this.GroupBox1);
            this.IsMdiContainer = true;
            this.Name = "DeleteForm";
            this.Text = "DeleteForm";
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.Button Search_butt;
        private System.Windows.Forms.Button exit_butt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox id_box;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}