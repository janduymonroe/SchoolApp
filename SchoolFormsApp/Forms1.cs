using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolLibrary;

namespace SchoolFormsApp
{
    public partial class Forms1 : Form
    {
        public Forms1()
        {
            InitializeComponent();
        }

        private void BtnPushToTest_Click(object sender, EventArgs e)
        {
            var testSchool = new School
            {
                Name = txtName.Text,
                Address = txtAddress.Text,
                City = txtCity.Text,
                State = txtState.Text,
                ZIP = txtZIP.Text,
                PhoneNumber = txtPhoneNumber.Text
            };
            try
            {
                testSchool.TwitterAddress = txtTwitter.Text;
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

            MessageBox.Show(testSchool.ToString());

        }
    }
}
