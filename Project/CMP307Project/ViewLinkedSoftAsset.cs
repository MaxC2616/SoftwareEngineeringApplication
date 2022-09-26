using System;
using System.Data;
using System.Windows.Forms;
using static CMP307Project.DB;

namespace CMP307Project
{
    public partial class ViewLinkedSoftAsset : Form
    {
        DB d = new DB();

        User user = new User();

        public ViewLinkedSoftAsset()
        {
            InitializeComponent();
        }

        public ViewLinkedSoftAsset(User u)
        {
            InitializeComponent();
            user = u;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;        //back to home
        }

        private void viewSoftware_Click(object sender, EventArgs e)     //Fill the second datagridview with the software information that is linked to the selected asset
        {
            if ((dataGridView1.SelectedRows.Count > 0))     //checking an asset has been selected
            {
                int rowindex = dataGridView1.CurrentCell.RowIndex;
                int columnindex = dataGridView1.Columns.Count - 1;

                string asset = dataGridView1.Rows[rowindex].Cells[columnindex].Value.ToString();    //get the id of the asset selected

                dataGridView2.DataSource = d.BindGridSpecificLink(asset);   //set the data source of the second datagridview to what gets returned from the function
            }
            else
            {
                MessageBox.Show("Please select an asset first");
            }
        }

        private void ViewLinkedSoftAsset_Load(object sender, EventArgs e)
        {
            if (user.username != "maxc2616")        //checking the correct user is logged in to view this form
            {
                MessageBox.Show("You do not have permissions to access this");
                this.DialogResult = DialogResult.OK;
            }
            else        //if they are, fill datagridview 1 with asset information
            {
                dataGridView1.DataSource = d.BindGrid();
                dataGridView1.ReadOnly = true;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
        }

        private void assetText_TextChanged(object sender, EventArgs e)      //Filter for asset
        {
            DataTable dt = new DataTable();
            dt = d.BindGrid();
            DataView dv = dt.DefaultView;
            dv.RowFilter = "aname LIKE '" + assetText.Text + "%'";
            dataGridView1.DataSource = dv;
        }

        private void snameText_TextChanged(object sender, EventArgs e)      //Filter for software (once loaded)
        {
            DataTable dt = new DataTable();
            dt = d.BindGridSoftware();
            DataView dv = dt.DefaultView;
            dv.RowFilter = "sname LIKE '" + snameText.Text + "%'";
            dataGridView2.DataSource = dv;
        }
    }
}
