using System;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Data;
using System.Windows.Forms;

//    !!!API KEY!!!
//    131f57b3-243b-4ad0-9879-021470fb1b49


namespace CMP307Project
{

    public class NVD
    {
        //Setting up variables for NVD retrieval
        public string CVE_ID { get; set; }
        public string problem_value { get; set; }
        public string ourl { get; set; }
        public string description_value { get; set; }
        public string attackVector { get; set; }
        public string attackComplexity { get; set; }
        public string privilegesRequired { get; set; }
        public string userInteraction { get; set; }
        public string confidentialityImpact { get; set; }
        public string integrityImpact { get; set; }
        public float baseScore { get; set; }
        public string baseSeverity { get; set; }
        public string lastDate { get; set; }


        //Function for searching the NVD, that returns as a BindingSource to be put into a datagridview in the CheckNVD forms
        public BindingSource Search(string asset, string isselected, int results)
        {
            DataTable nvdTable = new DataTable("NVD");
            DataColumn dtColumn;
            DataRow myDataRow;

            //Adding all the necessary columns to the data table that the data will be stored in

            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(string);
            dtColumn.ColumnName = "CVE_ID";
            dtColumn.Caption = "CVE ID";
            dtColumn.ReadOnly = true;
            dtColumn.Unique = true;
            nvdTable.Columns.Add(dtColumn);

            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(String);
            dtColumn.ColumnName = "problem_value";
            dtColumn.Caption = "Problem Value";
            dtColumn.AutoIncrement = false;
            dtColumn.ReadOnly = false;
            dtColumn.Unique = false;
            nvdTable.Columns.Add(dtColumn);

            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(String);
            dtColumn.ColumnName = "ourl";
            dtColumn.Caption = "Reference URL";
            dtColumn.ReadOnly = false;
            dtColumn.Unique = false;
            nvdTable.Columns.Add(dtColumn);

            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(String);
            dtColumn.ColumnName = "description_value";
            dtColumn.Caption = "Description Value";
            dtColumn.ReadOnly = false;
            dtColumn.Unique = false;
            nvdTable.Columns.Add(dtColumn);

            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(String);
            dtColumn.ColumnName = "attackVector";
            dtColumn.Caption = "Attack Vector";
            dtColumn.ReadOnly = false;
            dtColumn.Unique = false;
            nvdTable.Columns.Add(dtColumn);

            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(String);
            dtColumn.ColumnName = "attackComplexity";
            dtColumn.Caption = "Attack Complexity";
            dtColumn.ReadOnly = false;
            dtColumn.Unique = false;
            nvdTable.Columns.Add(dtColumn);

            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(String);
            dtColumn.ColumnName = "privilegesRequired";
            dtColumn.Caption = "Privileges Required";
            dtColumn.ReadOnly = false;
            dtColumn.Unique = false;
            nvdTable.Columns.Add(dtColumn);

            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(String);
            dtColumn.ColumnName = "userInteraction";
            dtColumn.Caption = "User Interaction";
            dtColumn.ReadOnly = false;
            dtColumn.Unique = false;
            nvdTable.Columns.Add(dtColumn);

            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(String);
            dtColumn.ColumnName = "confidentialityImpact";
            dtColumn.Caption = "Confidentiality Impact";
            dtColumn.ReadOnly = false;
            dtColumn.Unique = false;
            nvdTable.Columns.Add(dtColumn);

            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(String);
            dtColumn.ColumnName = "integrityImpact";
            dtColumn.Caption = "Integrity Impact";
            dtColumn.ReadOnly = false;
            dtColumn.Unique = false;
            nvdTable.Columns.Add(dtColumn);

            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(float);
            dtColumn.ColumnName = "baseScore";
            dtColumn.Caption = "Base Score";
            dtColumn.ReadOnly = false;
            dtColumn.Unique = false;
            nvdTable.Columns.Add(dtColumn);

            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(String);
            dtColumn.ColumnName = "baseSeverity";
            dtColumn.Caption = "Base Severity";
            dtColumn.ReadOnly = false;
            dtColumn.Unique = false;
            nvdTable.Columns.Add(dtColumn);

            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(String);
            dtColumn.ColumnName = "lastDate";
            dtColumn.Caption = "Date Last Updated";
            dtColumn.ReadOnly = false;
            dtColumn.Unique = false;
            nvdTable.Columns.Add(dtColumn);

            // Make id column the primary key column.
            DataColumn[] PrimaryKeyColumns = new DataColumn[1];
            PrimaryKeyColumns[0] = nvdTable.Columns["CVE_ID"];
            nvdTable.PrimaryKey = PrimaryKeyColumns;

            DataSet dtSet = new DataSet();

            dtSet.Tables.Add(nvdTable);


            //URL of the NVD. Parameters passed from Check NVD get put into URL to search for specific things
            string url;
            url = "https://services.nvd.nist.gov/rest/json/cves/1.0/?apiKey=131f57b3-243b-4ad0-9879-021470fb1b49&cvssV3Severity=" + isselected + "&keyword=" + asset + "&resultsPerPage=" + results + "";


            try
            {
                //Setting up required code for Web API retrieval
                WebRequest wrGETURL;
                wrGETURL = WebRequest.Create(url);

                Stream objStream;
                objStream = wrGETURL.GetResponse().GetResponseStream();


                StreamReader reader = new StreamReader(objStream);
                string text = reader.ReadToEnd();

                JObject result = JObject.Parse(text); // parse response as JObject
                JArray dataToStore = (JArray)result["result"]["CVE_Items"]; // assign data to JArray

                // iterate over elements
                foreach (var dataEntry in dataToStore)
                {

                    // store data values             

                    CVE_ID = dataEntry["cve"]["CVE_data_meta"]["ID"].ToString();
                    problem_value = dataEntry["cve"]["problemtype"]["problemtype_data"][0]["description"][0]["value"].ToString();
                    ourl = dataEntry["cve"]["references"]["reference_data"][0]["url"].ToString();
                    description_value = dataEntry["cve"]["description"]["description_data"][0]["value"].ToString();
                    attackVector = dataEntry["impact"]["baseMetricV3"]["cvssV3"]["attackVector"].ToString();
                    attackComplexity = dataEntry["impact"]["baseMetricV3"]["cvssV3"]["attackComplexity"].ToString();
                    privilegesRequired = dataEntry["impact"]["baseMetricV3"]["cvssV3"]["privilegesRequired"].ToString();
                    userInteraction = dataEntry["impact"]["baseMetricV3"]["cvssV3"]["userInteraction"].ToString();
                    confidentialityImpact = dataEntry["impact"]["baseMetricV3"]["cvssV3"]["confidentialityImpact"].ToString();
                    integrityImpact = dataEntry["impact"]["baseMetricV3"]["cvssV3"]["integrityImpact"].ToString();
                    baseScore = float.Parse(dataEntry["impact"]["baseMetricV3"]["cvssV3"]["baseScore"].ToString());
                    baseSeverity = dataEntry["impact"]["baseMetricV3"]["cvssV3"]["baseSeverity"].ToString();
                    lastDate = dataEntry["lastModifiedDate"].ToString();


                    // add data values to new row in data table

                    myDataRow = nvdTable.NewRow();
                    myDataRow["CVE_ID"] = CVE_ID;
                    myDataRow["problem_value"] = problem_value;
                    myDataRow["ourl"] = ourl;
                    myDataRow["description_value"] = description_value;
                    myDataRow["attackVector"] = attackVector;
                    myDataRow["attackComplexity"] = attackComplexity;
                    myDataRow["privilegesRequired"] = privilegesRequired;
                    myDataRow["userInteraction"] = userInteraction;
                    myDataRow["confidentialityImpact"] = confidentialityImpact;
                    myDataRow["integrityImpact"] = integrityImpact;
                    myDataRow["baseScore"] = baseScore;
                    myDataRow["baseSeverity"] = baseSeverity;
                    myDataRow["lastDate"] = lastDate;
                    nvdTable.Rows.Add(myDataRow);

                }

                BindingSource bs = new BindingSource();
                bs.DataSource = dtSet.Tables["NVD"];

                return bs;
            }
            catch (WebException ex)
            {
                if (ex.Status == WebExceptionStatus.ProtocolError)
                {
                    var response = ex.Response as HttpWebResponse;
                    if (response != null)
                    {
                        MessageBox.Show("HTTP Status Code: " + (int)response.StatusCode);
                        BindingSource bad = new BindingSource();
                        return bad;
                    }
                    else
                    {
                        BindingSource bad = new BindingSource();
                        return bad;
                    }
                }
                else
                {
                    BindingSource bad = new BindingSource();
                    return bad;
                }
            }


        }

    }

}

