using System;
using System.Windows.Forms;
using static CMP307Project.DB;

namespace CMP307Project
{
    public partial class AddSoftware : Form
    {

        DB d = new DB();        //set up instance of DB

        User user = new User();     //set up instance of user (to check which user is logged in)

        public AddSoftware()
        {
            InitializeComponent();
        }

        public AddSoftware(User u)
        {
            InitializeComponent();
            user = u;           //passes username of user logged in
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;        //back to home page
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (softName.Text == "" || softType.Text == "" || softDesc.Text == "" || softVersion.Text == "" || softDev.Text == "" || softLicense.Text == "" || softKey.Text == "" || softMisc.Text == "")    //checking all text boxes have been filled
            {
                MessageBox.Show("Please fill in all boxes");
                return;
            }
            else                     //If all boxes have been filled in
            {

                DateTime iDate;
                iDate = dateTimePicker1.Value;
                string datestring = iDate.ToString();               //turning the datetimepicker into a string to pass through to database

                if (d.AddSoftDB(softName.Text, softType.Text, softDesc.Text, softVersion.Text, softDev.Text, softLicense.Text, softKey.Text, datestring, softMisc.Text) == true)    //Add to database and if it was successful,
                {
                    MessageBox.Show("Record succesfully added");        //Display success and empty all text boxes
                    softName.Text = String.Empty;
                    softType.Text = String.Empty;
                    softDesc.Text = String.Empty;
                    softVersion.Text = String.Empty;
                    softDev.Text = String.Empty;
                    softLicense.Text = String.Empty;
                    softKey.Text = String.Empty;
                    softMisc.Text = String.Empty;

                }
                else
                {
                    MessageBox.Show("Record could not be added. Please try again");         //Or output error
                }

            }
        }

        private void AddSoftware_Load(object sender, EventArgs e)
        {
            if (user.username != "maxc2616")        //If correct user isn't logged in, kick out of page
            {
                MessageBox.Show("You do not have permissions to access this");
                this.DialogResult = DialogResult.OK;
            }


        }
    }
}
