using System;
using System.Data;
using System.Windows.Forms;
using static CMP307Project.DB;


namespace CMP307Project
{
    public partial class ViewAllSoftware : Form
    {
        DB d = new DB();

        User user = new User();

        public ViewAllSoftware()
        {
            InitializeComponent();
        }

        public ViewAllSoftware(User u)
        {
            InitializeComponent();
            user = u;
        }

        private void ViewAllSoftware_Load(object sender, EventArgs e)       //Fill datagridview with software
        {
                        
                dataGridView1.DataSource = d.BindGridSoftware();
            
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;        //back to home page
        }

        private void softText_TextChanged(object sender, EventArgs e)       //Filter for software
        {
            DataTable dt = new DataTable();
            dt = d.BindGridSoftware();
            DataView dv = dt.DefaultView;
            dv.RowFilter = "sname LIKE '" + softText.Text + "%'";
            dataGridView1.DataSource = dv;
        }
    }
}
