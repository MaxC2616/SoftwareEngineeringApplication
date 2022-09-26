using System;
using System.Windows.Forms;
using static CMP307Project.DB;

namespace CMP307Project
{
    public partial class AddAsset : Form
    {
        DB d = new DB();        //set up instance of DB
        User user = new User();   //set up instance of user (to check which user is logged in)

        public AddAsset()
        {
            InitializeComponent();
        }

        public AddAsset(User u)
        {
            InitializeComponent();
            user = u;       //passes username of user logged in
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (assetName.Text == "" || assetType.Text == "" || assetDesc.Text == "" || assetModel.Text == "" || assetMFR.Text == "" ||  assetMAC.Text == "" || assetIP.Text == "" || assetLocation.Text == "" || assetWarranty.Text == "" || assetMisc.Text == "")     //checking all text boxes have been filled
            {
                MessageBox.Show("Please fill in all boxes");    
                return;
            }
            else      //If all boxes have been filled in
            {

                DateTime iDate;
                iDate = dateTimePicker1.Value;
                string datestring = iDate.ToString();   //turning the datetimepicker into a string to pass through to database

                if (d.AddDB(assetName.Text, assetType.Text, assetDesc.Text, assetModel.Text, assetMFR.Text, assetMAC.Text, assetIP.Text, assetLocation.Text, datestring, assetWarranty.Text, assetMisc.Text) == true)  //Add to database and if it was successful,
                {
                    MessageBox.Show("Record succesfully added");        //Display success and empty all text boxes
                    assetName.Text = String.Empty;
                    assetType.Text = String.Empty;
                    assetDesc.Text = String.Empty;
                    assetModel.Text = String.Empty;
                    assetMFR.Text = String.Empty;
                    assetMAC.Text = String.Empty;
                    assetIP.Text = String.Empty;
                    assetLocation.Text = String.Empty;
                    assetWarranty.Text = String.Empty;
                    assetMisc.Text = String.Empty;
                }
                else
                {
                    MessageBox.Show("Error - Record could not be added. Please input data as stated"); //Or output error
                }

            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;  //Go back to home page
        }

        private void AddAsset_Load(object sender, EventArgs e)
        {
            if (user.username != "maxc2616")    //If correct user isn't logged in, kick out of page
            {
                MessageBox.Show("You do not have permissions to access this");
                this.DialogResult = DialogResult.OK;
            }
        }

        private void assetName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
