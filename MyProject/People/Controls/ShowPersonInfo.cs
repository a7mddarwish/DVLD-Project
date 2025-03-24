using BussnisLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MyProject
{
    public partial class ShowPersonInfo : UserControl
    {
        clsPerson _Person = null;
        public bool HasPerson { get => (_Person != null); }
        public int PersonID { get => (_Person.ID); }

        public clsPerson SelectedPersonInfo { get { return _Person; } }

        public ShowPersonInfo()
        {
            InitializeComponent();
            SetDefValues();


        }
        
        public void LoadInfo(int personID)
        {
            _Person  = clsPerson.Find(personID);

            if (_Person == null)
            {
                SetDefValues();
                MessageBox.Show("Person Dose not exist");
            }
            else
                SetPersonInfo(_Person);

        }
        public void LoadInfo(string NationalNumber)
        {
             _Person = clsPerson.Find(NationalNumber);

            if (_Person == null)
            {
                SetDefValues();
                MessageBox.Show("Person Dose not exist");
            }
            else
                SetPersonInfo(_Person);

        }

        private void SetPersonInfo(clsPerson Person)
        {
            LB_Name.Text =$"{Person.FirstName} {Person.SecondName} {Person.LastName}";
            LB_ID.Text = Person.ID.ToString();
            LB_Country.Text = Person.CountryInfo.Name;
            LB_DateBirth.Text = Person.DateOfBirth.ToString("dd/MM/yyyy");

            if (String.IsNullOrEmpty(Person.Email))
                LB_Email.Text = "Not avilable";
            else
            LB_Email.Text = Person.Email;

            LB_Gender.Text = Person.Gender;
            LB_NN.Text = Person.CountryInfo.ID.ToString();
            LB_Phone.Text = Person.Phone;
            LB_Adress.Text = Person.Address;

            LoadPersonImage();
        }

        private void LoadPersonImage()
        {
            if (_Person.Gender == "Male")
                    pictureBox1.Image = Image.FromFile("C:\\Users\\METRA\\Desktop\\Pics\\Def_Man.png");
                else
                pictureBox1.Image = Image.FromFile("C:\\Users\\METRA\\Desktop\\Pics\\Def_Woman.png");

            string ImagePath = _Person.ImagePath;
            if (! String.IsNullOrEmpty(ImagePath)) pictureBox1.ImageLocation = _Person.ImagePath;
          //  else MessageBox.Show("Could not find the image !");
            


        }

        private void SetDefValues()
        {
            LB_Name.Text = "[???]";
            LB_ID.Text = "[???]";
            LB_Country.Text = "[???]";
            LB_DateBirth.Text = "[???]";
            LB_Email.Text = "[???]";
            LB_Gender.Text = "[???]";
            LB_NN.Text = "[???]";
            LB_Phone.Text = "[???]";
            LB_Adress.Text = "[???]";


            pictureBox1.Image = Image.FromFile("C:\\Users\\METRA\\Desktop\\Pics\\Def_Man.png");


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_Person ==null)
            {
                MessageBox.Show("Choice Person First !", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
                return;
            }

            AddEdit_Person frm = new AddEdit_Person(_Person.ID);
            frm.ShowDialog();

            // refresh
            LoadInfo(_Person.ID);

        }

       
    }
}
