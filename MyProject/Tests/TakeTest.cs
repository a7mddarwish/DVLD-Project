using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProject.Tests
{
    public partial class TakeTest : Form
    {
        public TakeTest(int testAppointmentID)
        {
            InitializeComponent();
            ctrlSchedualedTest1.LoadInfo(testAppointmentID);
        }

        private void button1_Click(object sender, EventArgs e) => this.Close();

        
    }
}
