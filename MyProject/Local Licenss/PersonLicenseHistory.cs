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

namespace MyProject.Licenss
{
    public partial class PersonLicenseHistory : Form
    {
        int _PersonID = -1;
        public PersonLicenseHistory(string NationalNumber)
        {
            InitializeComponent();
            _PersonID = clsPerson.Find(NationalNumber).ID;
            showPersonInfo1.LoadInfo(_PersonID );
        }    
        public PersonLicenseHistory(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
            showPersonInfo1.LoadInfo(_PersonID );
        }

        private void PersonLicenseHistory_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = clsLocalLicens.GetLocalLicensByPersonID(_PersonID);
            dataGridView2.DataSource = clsInterNationalLicenes.GetInternationalLicensByPersonID(_PersonID);
        }
    }
}
