using System;
using System.Data;
using System.Windows.Forms;
using static CMP307Project.DB;

namespace CMP307Project
{
    public partial class ViewAll : Form
    {

        DB d = new DB();

        User user = new User();

        public ViewAll()
        {
            InitializeComponent();
        }

        public ViewAll(User u)
        {
            InitializeComponent();
            user = u;
        }

        private void ViewAll_Load(object sender, EventArgs e)       //Fill the datagridView with assets 
        {
            

                dataGridView1.DataSource = d.BindGrid();
            
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;        //back to home page
        }

        private void assetText_TextChanged(object sender, EventArgs e)      //Filter for assets
        {
            DataTable dt = new DataTable();
            dt = d.BindGrid();
            DataView dv = dt.DefaultView;
            dv.RowFilter = "aname LIKE '" + assetText.Text + "%'";
            dataGridView1.DataSource = dv;
        }
    }
}
