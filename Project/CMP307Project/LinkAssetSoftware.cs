using System;
using System.Data;
using System.Windows.Forms;
using static CMP307Project.DB;

namespace CMP307Project
{
    public partial class LinkAssetSoftware : Form
    {
        DB d = new DB();    //setting up instance of DB.cs

        User user = new User();     //setting up instance of User.cs

        public LinkAssetSoftware()
        {
            InitializeComponent();
        }

        public LinkAssetSoftware(User u)
        {
            InitializeComponent();
            user = u;       //passing through username
        }

        private void LinkAssetSoftware_Load(object sender, EventArgs e)     
        {
            if (user.username != "maxc2616")        //if not correct user logged in, return to home page
            {
                MessageBox.Show("You do not have permissions to access this");
                this.DialogResult = DialogResult.OK;
            }
            else        //if correct user logged in, fill data grids with assets and software
            {
                dataGridView1.DataSource = d.BindGrid();
                dataGridView2.DataSource = d.BindGridSoftware();
                dataGridView1.ReadOnly = true;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                dataGridView2.ReadOnly = true;
                dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;        //go back to home page
        }

        private void linkButton_Click(object sender, EventArgs e)
        {
            int rowindexasset = dataGridView1.CurrentCell.RowIndex;
            int columnindexasset = dataGridView1.Columns.Count - 1;

            string asset = dataGridView1.Rows[rowindexasset].Cells[columnindexasset].Value.ToString();      //get the ID of the asset selected


            int rowindexsoft = dataGridView2.CurrentCell.RowIndex;
            int columnindexsoft = dataGridView2.Columns.Count - 1;

            string software = dataGridView2.Rows[rowindexsoft].Cells[columnindexsoft].Value.ToString();     //get the ID of the software selected

            if ((dataGridView1.SelectedRows.Count > 0) && (dataGridView2.SelectedRows.Count > 0))       //check that both assets and software have been selected
            {

                if (d.CheckAssetSoft(asset, software))      //Check the assets and software aren't already linked
                {

                    if (d.LinkSoftAsset(asset, software))       //If not already linked, then link them
                    {
                        MessageBox.Show("You have linked these two records successfully");
                    }
                    else
                    {
                        MessageBox.Show("There was a system error. Please contact IT");
                    }
                }
                else
                {
                    MessageBox.Show("These assets and software are already linked");
                }
            }
            else
            {
                MessageBox.Show("You must select one piece of data from both tables");
            }
        }

        private void assetText_TextChanged(object sender, EventArgs e)      //Filter for assets
        {
            DataTable dt = new DataTable();
            dt = d.BindGrid();
            DataView dv = dt.DefaultView;
            dv.RowFilter = "aname LIKE '" + assetText.Text + "%'";
            dataGridView1.DataSource = dv;
        }

        private void snameText_TextChanged(object sender, EventArgs e)      //Filter for software
        {
            DataTable dt = new DataTable();
            dt = d.BindGridSoftware();
            DataView dv = dt.DefaultView;
            dv.RowFilter = "sname LIKE '" + snameText.Text + "%'";
            dataGridView2.DataSource = dv;
        }
    }
}
