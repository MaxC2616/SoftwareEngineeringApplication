using System;
using System.Windows.Forms;

namespace CMP307Project
{
    public partial class HomePage : Form
    {

        //Setting up all instances for every form and class
        AddAsset a = new AddAsset();
        ViewAll v = new ViewAll();
        ViewAsset c = new ViewAsset();
        Delete d = new Delete();
        EditAsset ea = new EditAsset();
        CheckNVD nvd = new CheckNVD();
        LinkAssetSoftware l = new LinkAssetSoftware();
        AddSoftware s = new AddSoftware();
        ViewLinkedSoftAsset b = new ViewLinkedSoftAsset();
        EditSoftware es = new EditSoftware();
        ViewAllSoftware vas = new ViewAllSoftware();
        ViewSoftware vs = new ViewSoftware();
        DeleteSoftware ds = new DeleteSoftware();
        Backup back = new Backup();
        User user = new User();
        CheckNVDSoftware nvds = new CheckNVDSoftware();

        public HomePage()
        {
            InitializeComponent();
        }

        public HomePage(User u)
        {
            InitializeComponent();
            user = u;    //passing through username from login
        }

        private void assetaddButton_Click(object sender, EventArgs e)   //Open Asset Add form
        {
            this.Hide();
            a = new AddAsset(user);
            a.ShowDialog();

            this.Show();
        }

        private void viewallButton_Click(object sender, EventArgs e)    //Open View All Assets form
        {
            this.Hide();
            v = new ViewAll(user);
            v.ShowDialog();

            this.Show();
        }

        private void viewcertainButton_Click(object sender, EventArgs e)    //Open View Certain Asset form
        {
            this.Hide();
            c = new ViewAsset(user);
            c.ShowDialog();

            this.Show();
        }

        private void deleteButton_Click(object sender, EventArgs e)     //Open Delete Asset form
        {
            this.Hide();
            d = new Delete(user);
            d.ShowDialog();

            this.Show();
        }

        private void editButton_Click(object sender, EventArgs e)       //Open Edit Asset form
        {
            this.Hide();
            ea = new EditAsset(user);
            ea.ShowDialog();

            this.Show();
        }

        private void checkButton_Click(object sender, EventArgs e)      //Open Check Asset NVD form
        {
            this.Hide();
            nvd = new CheckNVD(user);
            nvd.ShowDialog();

            this.Show();
        }

        private void linkButton_Click(object sender, EventArgs e)       //Open Link Asset and Software form
        {
            this.Hide();
            l = new LinkAssetSoftware(user);
            l.ShowDialog();

            this.Show();
        }

        private void addsoftButton_Click(object sender, EventArgs e)    //Open Add Software form
        {
            this.Hide();
            s = new AddSoftware(user);
            s.ShowDialog();

            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)      //Open View Linked Software and Assets form
        {
            this.Hide();
            b = new ViewLinkedSoftAsset(user);
            b.ShowDialog();

            this.Show();
        }

        private void editsoftButton_Click(object sender, EventArgs e)       //Open Edit Software form
        {
            this.Hide();
            es = new EditSoftware(user);
            es.ShowDialog();

            this.Show();
        }

        private void viewallsoftButton_Click(object sender, EventArgs e)        //Open view all software form
        {
            this.Hide();
            vas = new ViewAllSoftware(user);
            vas.ShowDialog();

            this.Show();
        }

        private void viewspecificsoftButton_Click(object sender, EventArgs e)       // Open view specific software form
        {
            this.Hide();
            vs = new ViewSoftware(user);
            vs.ShowDialog();

            this.Show();
        }

        private void deletesoftwareButton_Click(object sender, EventArgs e)     //Open delete software form
        {
            this.Hide();
            ds = new DeleteSoftware(user);
            ds.ShowDialog();

            this.Show();
        }

        private void backupButton_Click(object sender, EventArgs e)     //Open Backup form
        {
            this.Hide();
            back = new Backup(user);
            back.ShowDialog();

            this.Show();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)      //Open Check software NVD form
        {
            this.Hide();
            nvds = new CheckNVDSoftware(user);
            nvds.ShowDialog();

            this.Show();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
