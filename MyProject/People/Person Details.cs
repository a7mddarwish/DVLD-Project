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
    public partial class Person_Details : Form
    {
        public Person_Details(int PersonID)
        {
            InitializeComponent();
            if (PersonID > 0)
            showPersonInfo1.LoadInfo(PersonID);
        }

        private void Person_Details_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e) => this.Close();
        

    }
}
