using System;
using System.Windows.Forms;
using static CMP307Project.DB;

namespace CMP307Project
{
    public partial class ViewAsset : Form
    {

        DB d = new DB();

        User user = new User();

        public ViewAsset()
        {
            InitializeComponent();
        }

        public ViewAsset(User u)
        {
            InitializeComponent();
            user = u;
        }

        private void ViewAsset_Load(object sender, EventArgs e)
        {
            
        }

        private void viewButton_Click(object sender, EventArgs e)       //Fill datagridview with asset data once ID has been inputted
        {
            if (idtextBox.Text == "")
            {
                MessageBox.Show("Please input the ID of the record you wish to view");
            }
            else
            {
                string s = idtextBox.Text;
                dataGridView1.DataSource = d.BindGridSpecific(s);
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;        //back to home
        }

        private void idtextBox_TextChanged(object sender, EventArgs e)      //making sure only numbers are inputted into text box
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(idtextBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                idtextBox.Text = idtextBox.Text.Remove(idtextBox.Text.Length - 1);
            }
        }
    }
}
