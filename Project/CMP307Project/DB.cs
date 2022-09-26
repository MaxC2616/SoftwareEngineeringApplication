using System;
using System.Data.SqlClient;
using System.Data;

namespace CMP307Project
{
    class DB
    {
        //Setting up connection info
        private string connString = "Data Source = tolmount.abertay.ac.uk; Initial Catalog = mssql1904985; User ID = mssql1904985; Password = redundant";
        SqlConnection conn;

        public bool LoginDB(string username, string password)       //Function for logging in
        {
            conn = new SqlConnection(connString);
            conn.Open();
            string query = "SELECT * FROM SCOTTISHGLEN.ADMINISTRATION WHERE ausername = '" + username + "' AND apassword ='" + password + "'";      //Select where username and password = inputted results
            SqlCommand command = new SqlCommand(query);

            command.Connection = conn;

            SqlDataReader data = command.ExecuteReader();

            while (data.Read())
            {
                if (data[0].ToString() == username)
                {
                    if (data[1].ToString() == password)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
                
            }
            return false;
        }

        public bool CheckAssetSoft(string asset, string software)       //Function to check whether a record already exists in AssetSoftware table
        {
            try
            {
                conn = new SqlConnection(connString);
                conn.Open();
                string query = "SELECT * FROM SCOTTISHGLEN.ASSETSOFTWARE WHERE asset_id = '" + asset + "' OR software_ID = '" + software + "'";
                SqlCommand command = new SqlCommand(query, conn);

                command.Connection = conn;

                SqlDataReader data = command.ExecuteReader();

                while (data.Read())
                {
                    if (data[0].ToString() == asset)
                    {

                        if (data[1].ToString() == software)
                        {
                            return false;
                        }

                    }
                    

                }
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }


        //Function to add a record to the Asset database
        public bool AddDB(string name, string type, string desc, string model, string mfr, string mac, string ip, string location, string purchase, string warranty, string misc)
        {
            try
            {
                conn = new SqlConnection(connString);
                conn.Open();
                string query = "INSERT INTO SCOTTISHGLEN.ASSETS (aname, atype, adesc, amodel, amfr, amac, aip, alocation, apurchdate, awarranty, amisc) VALUES ('" + name + "', '" + type + "', '" + desc + "', '" + model + "', '" + mfr + "', '" + mac + "', '" + ip + "', '" + location + "', '" + purchase + "', '" + warranty + "', '" + misc + "')";
                SqlCommand command = new SqlCommand(query, conn);

                int n = command.ExecuteNonQuery();

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }


        //Function to add record to the Software database
        public bool AddSoftDB(string name, string type, string desc, string version, string dev, string license, string key, string purchase, string misc)
        {
            try
            {
                conn = new SqlConnection(connString);
                conn.Open();
                string query = "INSERT INTO SCOTTISHGLEN.SOFTWARE (sname, stype, sdesc, sversion, sdeveloper, slicense, slicensekey, spurchdate, smisc) VALUES ('" + name + "', '" + type + "', '" + desc + "', '" + version + "', '" + dev + "', '" + license + "', '" + key + "', '" + purchase + "', '" + misc + "')";
                SqlCommand command = new SqlCommand(query, conn);

                int n = command.ExecuteNonQuery();

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }


        //Function for linking Software and assets
        public bool LinkSoftAsset(string asset, string software)
        {
            try
            {
                conn = new SqlConnection(connString);
                conn.Open();
                string query = "INSERT INTO SCOTTISHGLEN.ASSETSOFTWARE (asset_id, software_ID) VALUES ('" + asset + "', '" + software + "')";
                SqlCommand command = new SqlCommand(query, conn);

                int n = command.ExecuteNonQuery();

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }



        //Reference for BindGrid functions below
        //Mudassar Khan, MK 2019, Retrieve data from Database in Windows Forms Application using C# and VB.Net
        //     aspsnippets.com/Articles/Retrieve-data-from-Database-in-Windows-Forms-Application-using-C-and-VBNet.aspx





        //Function for binding a specific asset from the assets table to a dataGridView
        public DataTable BindGridSpecific(string s)
        { 
                using (SqlConnection con = new SqlConnection(connString))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM SCOTTISHGLEN.ASSETS WHERE asset_id = '" + s + "'", con))
                    {
                        cmd.CommandType = CommandType.Text;
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                return dt;
                            }
                        }
                    }
                } 
        }


        //Function for binding a specific software from the software table to a dataGridView
        public DataTable BindGridSpecificSoft(string s)
        {
            using (SqlConnection con = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM SCOTTISHGLEN.SOFTWARE WHERE software_ID = '" + s + "'", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
        }


        //Function for binding relevant linked software and assets to a dataGridView
        public DataTable BindGridSpecificLink(string s)
        {
                using (SqlConnection con = new SqlConnection(connString))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM SCOTTISHGLEN.SOFTWARE WHERE software_ID IN (SELECT software_ID FROM SCOTTISHGLEN.ASSETSOFTWARE WHERE asset_id = '" + s + "')", con))
                    {
                        cmd.CommandType = CommandType.Text;
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                return dt;
                            }
                        }
                    }
                }
        }


        //Function for binding all assets to a dataGridView
        public DataTable BindGrid()
        {
            using (SqlConnection con = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM SCOTTISHGLEN.ASSETS", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
        }


        //Function for binding all software to a dataGridView
        public DataTable BindGridSoftware()
        {
            using (SqlConnection con = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM SCOTTISHGLEN.SOFTWARE", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
        }

    }
}
