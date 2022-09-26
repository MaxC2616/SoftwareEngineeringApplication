using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace CMP307Project
{
    public partial class Backup : Form
    {
        private string connString = "Data Source = tolmount.abertay.ac.uk; Initial Catalog = mssql1904985; User ID = mssql1904985; Password = A4dtwaP7V3";   //setup of connection string
        SqlConnection conn;

        User user = new User();     //passing through username

        public Backup()
        {
            InitializeComponent();
        }

        public Backup(User u)
        {
            InitializeComponent();
            user = u;       //passing through username
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
                FolderBrowserDialog dlg = new FolderBrowserDialog();        //Folder dialog to choose where you want to store the backup
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = dlg.SelectedPath;
                    backupButton.Enabled = true;
                }
            
        }

        private void backupButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))    //checking that a folder has been chosen
            {
                MessageBox.Show("You have not selected a path for the file to be saved at");
            }
            else           //if folder has been chosen
            {

                conn = new SqlConnection(connString);       //Setting up SQL variables and connection
                conn.Open();
                string query = "SELECT * FROM SCOTTISHGLEN.ASSETS";         //Select all from assets to backup
                SqlCommand command = new SqlCommand(query);

                command.Connection = conn;

                SqlDataReader data = command.ExecuteReader();

                try       //try statement to catch any errors
                {
                    StreamWriter sw = new StreamWriter(textBox1.Text + "//assetbackup.txt");    //Stream writer to write the data to (with file save path)
                    
                    while (data.Read())     //Writing all the data retrieved to the file
                    {
                        sw.WriteLine("Asset Name: " + data[0] + "");
                        sw.WriteLine("Asset Type: " + data[1] + "");
                        sw.WriteLine("Asset Description: " + data[2] + "");
                        sw.WriteLine("Asset Model: " + data[3] + "");
                        sw.WriteLine("Asset Manufacturer: " + data[4] + "");
                        sw.WriteLine("Asset MAC Address: " + data[5] + "");
                        sw.WriteLine("Asset IP Address: " + data[6] + "");
                        sw.WriteLine("Asset Location: " + data[7] + "");
                        sw.WriteLine("Asset Purchase Date: " + data[8] + "");
                        sw.WriteLine("Asset Warranty: " + data[9] + "");
                        sw.WriteLine("Asset Misc Info: " + data[10] + "");
                        sw.WriteLine("Asset ID: " + data[11] + ""); 
                        sw.WriteLine("");
                    }
                    sw.Close();
                    MessageBox.Show("Backup created succesfully. It is stored at " + textBox1.Text + " in the file named - assetbackup.txt");
                }
                catch (Exception exception)
                {
                    Console.WriteLine("Exception: " + exception.Message);
                }
            }
        }

        private void browseRestoreButton_Click(object sender, EventArgs e)
        {
        }

        private void restoreButton_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;        //back to home page
        }

        private void Backup_Load(object sender, EventArgs e)        //checking user logged in is correct
        {
            if (user.username != "maxc2616")
            {
                MessageBox.Show("You do not have permissions to access this");
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
