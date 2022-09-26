using System;
using System.Data;
using System.Windows.Forms;
using static CMP307Project.DB;
using System.Data.SqlClient;

namespace CMP307Project
{
    public partial class DeleteSoftware : Form
    {
        DB d = new DB();        //setting up instance of DB.cs

        //Setting up SQL variables and Data variables
        SqlCommand sCommand;
        SqlDataAdapter sAdapter;
        SqlCommandBuilder sBuilder;
        DataSet sDs;
        DataTable sTable;

        User user = new User();     //setting up instance of User.cs

        public DeleteSoftware()
        {
            InitializeComponent();
        }

        public DeleteSoftware(User u)
        {
            InitializeComponent();
            user = u;   //passing through username
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;        //back to homepage
        }

        private void deleteButton_Click(object sender, EventArgs e)         //Get current selected row and remove from the dataGridView
        {
            if ((dataGridView1.SelectedRows.Count > 0))
            {
                if (MessageBox.Show("Do you want to delete this row?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
               
                    dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);       //Remove from the Data Grid
                    sAdapter.Update(sTable);         //Update the database with what we have now in our Data Grid

                }
            }
        }

        private void DeleteSoftware_Load(object sender, EventArgs e)
        {
            if (user.username != "maxc2616")        //Checking the user logged in can access this form
            {
                MessageBox.Show("You do not have permissions to access this");
                this.DialogResult = DialogResult.OK;
            }
            else       //If they can, fill a data table with assets and display
            {

                //References for code
                //Csharp.net-informations, DataGridView Database Operations
                // csharp.net-informations.com/datagridview/csharp-datagridview-database-operations.htm

                string connectionString = "Data Source = tolmount.abertay.ac.uk; Initial Catalog = mssql1904985; User ID = mssql1904985; Password = A4dtwaP7V3";
                string sql = "SELECT * FROM SCOTTISHGLEN.SOFTWARE";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                sCommand = new SqlCommand(sql, connection);
                sAdapter = new SqlDataAdapter(sCommand);
                sBuilder = new SqlCommandBuilder(sAdapter);
                sDs = new DataSet();
                sAdapter.Fill(sDs, "Assets");
                sTable = sDs.Tables["Assets"];
                connection.Close();
                dataGridView1.DataSource = sDs.Tables["Assets"];
                dataGridView1.ReadOnly = true;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
        }

        private void snameText_TextChanged(object sender, EventArgs e)          //Filtering for software
        {
            DataView dv = sTable.DefaultView;
            dv.RowFilter = "sname LIKE '" + snameText.Text + "%'";
            dataGridView1.DataSource = dv;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
