using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CMP307Project
{
    public partial class EditSoftware : Form
    {
        //Setting up SQL and data variables
        SqlCommand sCommand;
        SqlDataAdapter sAdapter;
        SqlCommandBuilder sBuilder;
        DataSet sDs;
        DataTable sTable;

        User user = new User();         //setting up new instance of User.cs

        public EditSoftware()
        {
            InitializeComponent();
        }

        public EditSoftware(User u)
        {
            InitializeComponent();
            user = u;       //passing through the username
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;        //return to home page
        }

        private void editButton_Click(object sender, EventArgs e)       //Once the edit button is clicked
        {
            dataGridView1.ReadOnly = false;     //make the datagridview editable
            commitButton.Enabled = true;        //make the save button clickable
            backButton.Enabled = false;     //make the cancel button clickable
            cancelButton.Enabled = true;        //make the cancel button clickable
            editButton.Enabled = false;     // make the edit button unclickable
            dataGridView1.Columns["software_ID"].ReadOnly = true;       //make software_ID uneditable
        }

        private void EditSoftware_Load(object sender, EventArgs e)      //check the user is logged in
        {
            if (user.username != "maxc2616")
            {
                MessageBox.Show("You do not have permissions to access this");
                this.DialogResult = DialogResult.OK;
            }
            else    //if user is logged in correctly, run populate function
            {

                Populate();
            }
        }

        private void commitButton_Click(object sender, EventArgs e)    //on save button click
        {
            sAdapter.Update(sTable);     //update the data adapter with the changes made
            dataGridView1.ReadOnly = true;      //datagridview back to read only
            commitButton.Enabled = false;       //save button disabled
            editButton.Enabled = true;           //edit button enabled
            backButton.Enabled = true;         //back button enabled
            cancelButton.Enabled = false;      //cancel button disabled
        }

        public void Populate()
        {

            //References for code
            //Csharp.net-informations, DataGridView Database Operations
            // csharp.net-informations.com/datagridview/csharp-datagridview-database-operations.htm


            //Setup connection and query
            string connectionString = "Data Source = tolmount.abertay.ac.uk; Initial Catalog = mssql1904985; User ID = mssql1904985; Password = A4dtwaP7V3";
            string sql = "SELECT * FROM SCOTTISHGLEN.SOFTWARE";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            //Put the connection into commands and adapters
            sCommand = new SqlCommand(sql, connection);
            sAdapter = new SqlDataAdapter(sCommand);
            sBuilder = new SqlCommandBuilder(sAdapter);

            //Build new dataset and transfer assets into dataset
            sDs = new DataSet();
            sAdapter.Fill(sDs, "Software");

            //transer dataset into data table
            sTable = sDs.Tables["Software"];
            connection.Close();

            //datagridview fill with data table
            dataGridView1.DataSource = sDs.Tables["Software"];
            dataGridView1.ReadOnly = true;
            commitButton.Enabled = false;
            cancelButton.Enabled = false;
            dataGridView1.Columns["software_ID"].ReadOnly = true;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Populate();       //run populate function
            cancelButton.Enabled = false;   //disable cancel button
            commitButton.Enabled = false;   //disable commit button
            editButton.Enabled = true;  //enable edit button
            backButton.Enabled = true;   //enable back button
        }

        private void snameText_TextChanged(object sender, EventArgs e)    //Filter for software table
        {
            DataView dv = sTable.DefaultView;
            dv.RowFilter = "sname LIKE '" + snameText.Text + "%'";
            dataGridView1.DataSource = dv;
        }
    }
}
