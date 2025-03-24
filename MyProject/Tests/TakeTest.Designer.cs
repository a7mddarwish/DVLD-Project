namespace MyProject.Tests
{
    partial class TakeTest
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
            this.ctrlSchedualedTest1 = new MyProject.Tests.ctrlSchedualedTest();
            this.SuspendLayout();
            // 
            // ctrlSchedualedTest1
            // 
            this.ctrlSchedualedTest1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlSchedualedTest1.Location = new System.Drawing.Point(12, 66);
            this.ctrlSchedualedTest1.Name = "ctrlSchedualedTest1";
            this.ctrlSchedualedTest1.Size = new System.Drawing.Size(498, 768);
            this.ctrlSchedualedTest1.TabIndex = 0;
            this.ctrlSchedualedTest1.TestType = BussnisLayer.clsTestType.enTestType.Writen;
            // 
            // TakeTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 876);
            this.Controls.Add(this.ctrlSchedualedTest1);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "TakeTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Take Test";
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlSchedualedTest ctrlSchedualedTest1;
    }
}