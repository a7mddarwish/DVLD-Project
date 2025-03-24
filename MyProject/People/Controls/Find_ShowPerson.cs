using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussnisLayer;

namespace MyProject
{
    public partial class Find_ShowPerson : UserControl
    {
        public Find_ShowPerson()
        {
            InitializeComponent();
            CB_Choices.SelectedIndex =1;
        }

        public bool DisableSearch { set
            {
                if (value)
                {
                    groupBox1.Enabled = false;
                }
                else
                {
                    groupBox1.Enabled = true;
                }

            }
        }

        public bool HasPerosn { get => showPersonInfo1.HasPerson; }

        public int PersonID {
            set {
                TB_Search.Text = value.ToString();
            }
            get => showPersonInfo1.PersonID; }
        public string PersonNationalNom
        {
            set
            {
                TB_Search.Text = value.ToString();
            }
            get => showPersonInfo1.SelectedPersonInfo.NationalNom; }

        internal void LoadByID(int PersonID)
        {
            TB_Search.Text = PersonID.ToString();
            this.DisableSearch = true;
            showPersonInfo1.LoadInfo(PersonID);
        }

       
        private void Frm_GetPersonDone(clsPerson Person, int PersonID)
        {
            if (PersonID > 0)
                showPersonInfo1.LoadInfo(PersonID);
            else MessageBox.Show("Somthing goes wrong while load data");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // e.KeyChar == (char)13 to check if user press enter key (Enter key code is 13)
            if (!String.IsNullOrEmpty(TB_Search.Text) && e.KeyChar == (char)13)
            {
           //    btn_Find.Click();
            }
            if (CB_Choices.SelectedIndex == 0)
                e.Handled = !(char.IsDigit( e.KeyChar) || char.IsControl(e.KeyChar));
        }

        public void Foucs() => TB_Search.Focus();

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TB_Search.Text))
            {
                MessageBox.Show("Enter value in text box first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // 0 => search by ID , 1 => Search by National Number
            if (CB_Choices.SelectedIndex == 0)
            {
                showPersonInfo1.LoadInfo(int.Parse(TB_Search.Text));
            }
            else
            {
                showPersonInfo1.LoadInfo(TB_Search.Text);

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AddEdit_Person frm = new AddEdit_Person(-1);
            frm.GetPersonDone += Frm_GetPersonDone;
            frm.ShowDialog();
        }
    }
}
