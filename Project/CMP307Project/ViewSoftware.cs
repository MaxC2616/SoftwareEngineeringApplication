using System;
using System.Windows.Forms;
using static CMP307Project.DB;

namespace CMP307Project
{
    public partial class ViewSoftware : Form
    {
        DB d = new DB();

        User user = new User();

        public ViewSoftware()
        {
            InitializeComponent();
        }

        public ViewSoftware(User u)
        {
            InitializeComponent();
            user = u;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;        //back to home
        }

        private void viewButton_Click(object sender, EventArgs e)       //Fill datagridview with asset data once ID has been inputted
        {
            if (softID.Text == "")
            {
                MessageBox.Show("Please input the ID of the record you wish to view");
            }
            else
            {
                string s = softID.Text;
                dataGridView1.DataSource = d.BindGridSpecificSoft(s);
            }
        }

        private void softID_TextChanged(object sender, EventArgs e)         //making sure only numbers are inputted into text box
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(softID.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                softID.Text = softID.Text.Remove(softID.Text.Length - 1);
            }
        }

        private void ViewSoftware_Load(object sender, EventArgs e)
        {
            
        }
    }
}
