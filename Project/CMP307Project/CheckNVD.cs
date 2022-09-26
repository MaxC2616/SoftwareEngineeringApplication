using System;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static CMP307Project.NVD;
using static CMP307Project.DB;

namespace CMP307Project
{
    public partial class CheckNVD : Form
    {
        NVD n = new NVD();      //setting up instance of NVD.cs in order to check the NVD
        DB d = new DB();        //setting up instance of DB.cs to do DB operations

        User user = new User();     //setting up instance of User.cs to pass through who is logged in

        public bool low { get; set; }

        public bool medium { get; set; }

        public bool high { get; set; }

        public bool critical { get; set; }

        public int resultsperpage { get; set; }

        public string isselected { get; set; }

        public CheckNVD()
        {
            InitializeComponent();
        }

        public CheckNVD(User u)     //passing through user who is logged in
        {
            InitializeComponent();
            user = u;
        }

        private void CheckNVD_Load(object sender, EventArgs e)
        {
            if (user.username != "maxc2616")        //Checking who is logged in has access
            {
                MessageBox.Show("You do not have permissions to access this");
                this.DialogResult = DialogResult.OK;
            }
            else         //If logged in is correct, fill the first data grid with the asset data
            {
                dataGridView2.DataSource = d.BindGrid();
                dataGridView2.ReadOnly = true;      //Read only 
                dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect; //When a record is clicked, the whole row is selected
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;        //back to home page
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            if (low == true)        //if low button was the last clicked (active), set isselected to LOW
            {
                isselected = "LOW";
            }
            else if (medium == true)        //if medium button was the last clicked (active), set isselected to MEDIUM
            {
                isselected = "MEDIUM";
            }
            else if (high == true)      //if high button was the last clicked (active), set isselected to HIGH
            {
                isselected = "HIGH";
            }
            else if (critical == true)      //if critical button was the last clicked (active), set isselected to CRITICAL
            {
                isselected = "CRITICAL";
            }
            else          //If none have been selected, output message and return
            {
                MessageBox.Show("Please select a level of severity to search from");
                return;
            }


            if (String.IsNullOrEmpty(resultsperpageTextbox.Text))   //if nothing has been put in text box, just default to 20 pages
            {
                resultsperpage = 20;
            }
            else if (Int32.Parse(resultsperpageTextbox.Text) > 100 || Int32.Parse(resultsperpageTextbox.Text) <= 0)     //if input is outwith the "normal" parameters, error and return
            {
                MessageBox.Show("Please enter a valid input between 1 and 100");
                return;
            }
            else       //if correct input, set that value to resultsperpage variable
            {
                resultsperpage = Int32.Parse(resultsperpageTextbox.Text);
            }



            if ((dataGridView2.SelectedRows.Count > 0))     //checking that an asset has been selected
            {

                int rowindex = dataGridView2.CurrentCell.RowIndex;      //Getting the row number
                int columnindex = dataGridView2.Columns.Count - 12;     //Getting the asset name location from column

                string asset = dataGridView2.Rows[rowindex].Cells[columnindex].Value.ToString();        //putting the row and column values together to get the selected asset name, and converting the value to a string

                dataGridView1.DataSource = n.Search(asset, isselected, resultsperpage);     //setting the data source for the dataGridView to the outcome of our NVD Search function (see NVD.cs). Passing through variables

                if (dataGridView1.Rows.Count == 0)      //if nothing gets returned from the function (table is empty) output that there was nothing returned
                {
                    MessageBox.Show("There were no vulnerabilities found for this asset at this severity level");
                }
                else        //if something returned, state table has been updated
                {
                    MessageBox.Show("Vulnerabilities table updated");
                }
            }
            else        //if asset not selected, message to tell user to pick one
            {
                MessageBox.Show("Please select an asset");
            }
                        
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void assetText_TextChanged(object sender, EventArgs e)     //Filtering the datagridview to change based on what is in the text box
        {
            DataTable dt = new DataTable();
            dt = d.BindGrid();
            DataView dv = dt.DefaultView;
            dv.RowFilter = "aname LIKE '" + assetText.Text + "%'";
            dataGridView2.DataSource = dv;
        }

        private void lowButton_Click(object sender, EventArgs e)
        {
           
        }

        private void copyButton_Click(object sender, EventArgs e)       //Copy the selected rows in the vulnerabilities table to the clipboard of the user to send to IT
        {
            if (this.dataGridView1.SelectedRows.Count > 0)      //Checking rows have been selected
            {
                StringBuilder ClipboardBuillder = new StringBuilder();
                foreach (DataGridViewRow Row in dataGridView1.SelectedRows)
                {
                    foreach (DataGridViewColumn Column in dataGridView1.Columns)
                    {
                        ClipboardBuillder.Append(Row.Cells[Column.Index].FormattedValue.ToString() + "  ");
                    }
                    ClipboardBuillder.AppendLine();
                }

                Clipboard.SetText(ClipboardBuillder.ToString());

            }
        }

        private void lowButton_Click_1(object sender, EventArgs e)      //when low button clicked, turn all others to false and low to true
        {
            low = true;
            medium = false;
            high = false;
            critical = false;
            lowButton.BackColor = Color.Green;
            mediumButton.BackColor = Color.FromArgb(50, 50, 52);
            highButton.BackColor = Color.FromArgb(50, 50, 52);
            criticalButton.BackColor = Color.FromArgb(50, 50, 52);
        }

        private void mediumButton_Click(object sender, EventArgs e)     //when medium button clicked, turn all others to false and medium to true
        {
            low = false;
            medium = true;
            high = false;
            critical = false;
            mediumButton.BackColor = Color.Green;
            lowButton.BackColor = Color.FromArgb(50, 50, 52);
            highButton.BackColor = Color.FromArgb(50, 50, 52);
            criticalButton.BackColor = Color.FromArgb(50, 50, 52);
        }

        private void highButton_Click(object sender, EventArgs e)       //when high button clicked, turn all others to false and high to true
        {
            low = false;
            medium = false;
            high = true;
            critical = false;
            highButton.BackColor = Color.Green;
            lowButton.BackColor = Color.FromArgb(50, 50, 52);
            mediumButton.BackColor = Color.FromArgb(50, 50, 52);
            criticalButton.BackColor = Color.FromArgb(50, 50, 52);
        }

        private void criticalButton_Click(object sender, EventArgs e)       //when critical button clicked, turn all others to false and critical to true
        {
            low = false;
            medium = false;
            high = false;
            critical = true;
            criticalButton.BackColor = Color.Green;
            lowButton.BackColor = Color.FromArgb(50, 50, 52);
            mediumButton.BackColor = Color.FromArgb(50, 50, 52);
            highButton.BackColor = Color.FromArgb(50, 50, 52);
        }

        private void resultsperpageTextbox_TextChanged(object sender, EventArgs e)      //Making sure that only numbers can be put into resultsperpage textbox
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(resultsperpageTextbox.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                resultsperpageTextbox.Text = resultsperpageTextbox.Text.Remove(resultsperpageTextbox.Text.Length - 1);
            }
        }
    }
}
