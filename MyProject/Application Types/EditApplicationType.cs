using BussnisLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProject
{
    public partial class EditApplicationType : Form
    {
        clsApplicationType App = null;
        public EditApplicationType(int AppID)
        {
            InitializeComponent();
            App = clsApplicationType.Find(AppID);
        }

        private void button2_Click(object sender, EventArgs e) => this.Close();

        private void EditApplicationType_Load(object sender, EventArgs e) => SetAppInfo();

        private void SetAppInfo()
        {
            LB_AppID.Text = App.ID.ToString();
            TB_Title.Text = App.Title;
            TB_Fees.Text = App.Fees.ToString();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            CollectData();
            if (App.Save())
                MessageBox.Show("Updated suceesfully.", "Done", MessageBoxButtons.OK);
            else
                MessageBox.Show("Sonthing goes wrong in Update process");

            this.Close();
        }

        private void CollectData()
        {
            App.Title = TB_Title.Text.Trim();
            App.Fees = Convert.ToDecimal(TB_Fees.Text.Trim());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CollectData();
            if (App.Save())
                MessageBox.Show("Updated suceesfully.", "Done", MessageBoxButtons.OK);
            else
                MessageBox.Show("Sonthing goes wrong in Update process");

            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
       => this.Close();
    }
}
