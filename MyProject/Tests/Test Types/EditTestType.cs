using BussnisLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProject
{
    public partial class EditTestInfo : Form
    {
        clsTestType Test = null;
        public EditTestInfo(int TestID)
        {
            InitializeComponent();
            Test = clsTestType.Find(TestID);
        }

       

        private void button2_Click(object sender, EventArgs e) => this.Close();

        private void EditTestInfo_Load(object sender, EventArgs e) => SetTestInfo();

        private void SetTestInfo()
        {
            LB_ID.Text = Test.ID.ToString();
            TB_Title.Text = Test.Title.ToString();
            TB_Decription.Text = Test.Description.ToString();
            TB_Fees.Text = Test.Fees.ToString();

            TB_Fees.SelectAll();
        }

        private void CollectDate()
        {
            Test.Title = TB_Title.Text.Trim();
            Test.Description = TB_Decription.Text.Trim();
            Test.Fees = Convert.ToDecimal(TB_Fees.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CollectDate();
            if (Test.UpdateInfo())
            {
                MessageBox.Show("Updated sucssefully.", "Done", MessageBoxButtons.OK);
                this.Close();
            }
            else MessageBox.Show("محفظش");
        }
    }
}
