namespace MyProject
{
    partial class ShowUserInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LB_IsActive = new System.Windows.Forms.Label();
            this.LB_UN = new System.Windows.Forms.Label();
            this.LB_UID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.showPersonInfo1 = new MyProject.ShowPersonInfo();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.LB_IsActive);
            this.groupBox1.Controls.Add(this.LB_UN);
            this.groupBox1.Controls.Add(this.LB_UID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 433);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1054, 94);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login Information";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(525, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Is Active ?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "UserName :";
            // 
            // LB_IsActive
            // 
            this.LB_IsActive.AutoSize = true;
            this.LB_IsActive.Location = new System.Drawing.Point(639, 32);
            this.LB_IsActive.Name = "LB_IsActive";
            this.LB_IsActive.Size = new System.Drawing.Size(49, 23);
            this.LB_IsActive.TabIndex = 0;
            this.LB_IsActive.Text = "[???]";
            // 
            // LB_UN
            // 
            this.LB_UN.AutoSize = true;
            this.LB_UN.Location = new System.Drawing.Point(396, 32);
            this.LB_UN.Name = "LB_UN";
            this.LB_UN.Size = new System.Drawing.Size(49, 23);
            this.LB_UN.TabIndex = 0;
            this.LB_UN.Text = "[???]";
            // 
            // LB_UID
            // 
            this.LB_UID.AutoSize = true;
            this.LB_UID.Location = new System.Drawing.Point(147, 32);
            this.LB_UID.Name = "LB_UID";
            this.LB_UID.Size = new System.Drawing.Size(49, 23);
            this.LB_UID.TabIndex = 0;
            this.LB_UID.Text = "[???]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "User ID :";
            // 
            // showPersonInfo1
            // 
            this.showPersonInfo1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPersonInfo1.Location = new System.Drawing.Point(3, 8);
            this.showPersonInfo1.Name = "showPersonInfo1";
            this.showPersonInfo1.Size = new System.Drawing.Size(1077, 410);
            this.showPersonInfo1.TabIndex = 0;
            // 
            // ShowUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.showPersonInfo1);
            this.Name = "ShowUserInfo";
            this.Size = new System.Drawing.Size(1134, 538);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ShowPersonInfo showPersonInfo1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LB_UID;
        private System.Windows.Forms.Label LB_IsActive;
        private System.Windows.Forms.Label LB_UN;
    }
}
