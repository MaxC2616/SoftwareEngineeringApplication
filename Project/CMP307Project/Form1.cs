using System;
using System.Windows.Forms;
using static CMP307Project.DB;
using static CMP307Project.User;

namespace CMP307Project
{
    public partial class Form1 : Form
    {
        DB d = new DB();        //setting up instance of DB.cs
        HomePage h = new HomePage();        //setting up instance of homepage

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)      //on login button click
        {
            if (usernameBox.Text == "" || passwordBox.Text == "")   //if textboxes have been left blank show message and return
            {
                MessageBox.Show("Please provide Username and Password");
                return;
            }    
            else      //if they're filled in
            {
                if (d.LoginDB(usernameBox.Text, passwordBox.Text) == true)  //Run DB login, if login successful,
                {
                    MessageBox.Show("You have succesfully logged in");   //Show success and open home page form
                    this.Hide();
                    User u = new User(usernameBox.Text);
                    h = new HomePage(u);
                    h.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Login Unsuccessful. Please try again");    //if login unsuccessful, show message and empty text boxes
                    usernameBox.Text = String.Empty;
                    passwordBox.Text = String.Empty;

                }    
            }
        }

        private void usernameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
