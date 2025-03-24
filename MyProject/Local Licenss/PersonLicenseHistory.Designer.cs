namespace MyProject.Licenss
{
    partial class PersonLicenseHistory
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.Tab_Local = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Tab_InterNational = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.showPersonInfo1 = new MyProject.ShowPersonInfo();
            this.groupBox1.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.Tab_Local.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Tab_InterNational.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TabControl);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(52, 396);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(914, 271);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Driver Licenes";
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.Tab_Local);
            this.TabControl.Controls.Add(this.Tab_InterNational);
            this.TabControl.Location = new System.Drawing.Point(6, 33);
            this.TabControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(902, 216);
            this.TabControl.TabIndex = 0;
            // 
            // Tab_Local
            // 
            this.Tab_Local.Controls.Add(this.dataGridView1);
            this.Tab_Local.Location = new System.Drawing.Point(4, 28);
            this.Tab_Local.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Tab_Local.Name = "Tab_Local";
            this.Tab_Local.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Tab_Local.Size = new System.Drawing.Size(947, 184);
            this.Tab_Local.TabIndex = 0;
            this.Tab_Local.Text = "Local";
            this.Tab_Local.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.Location = new System.Drawing.Point(3, 2);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(941, 182);
            this.dataGridView1.TabIndex = 1;
            // 
            // Tab_InterNational
            // 
            this.Tab_InterNational.Controls.Add(this.dataGridView2);
            this.Tab_InterNational.Location = new System.Drawing.Point(4, 28);
            this.Tab_InterNational.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Tab_InterNational.Name = "Tab_InterNational";
            this.Tab_InterNational.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Tab_InterNational.Size = new System.Drawing.Size(894, 184);
            this.Tab_InterNational.TabIndex = 1;
            this.Tab_InterNational.Text = "International";
            this.Tab_InterNational.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.ColumnHeadersHeight = 29;
            this.dataGridView2.Location = new System.Drawing.Point(8, 2);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(936, 182);
            this.dataGridView2.TabIndex = 2;
            // 
            // showPersonInfo1
            // 
            this.showPersonInfo1.Location = new System.Drawing.Point(52, 13);
            this.showPersonInfo1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.showPersonInfo1.Name = "showPersonInfo1";
            this.showPersonInfo1.Size = new System.Drawing.Size(934, 392);
            this.showPersonInfo1.TabIndex = 0;
            // 
            // PersonLicenseHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 706);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.showPersonInfo1);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PersonLicenseHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Person License History";
            this.Load += new System.EventHandler(this.PersonLicenseHistory_Load);
            this.groupBox1.ResumeLayout(false);
            this.TabControl.ResumeLayout(false);
            this.Tab_Local.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Tab_InterNational.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ShowPersonInfo showPersonInfo1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage Tab_Local;
        private System.Windows.Forms.TabPage Tab_InterNational;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}