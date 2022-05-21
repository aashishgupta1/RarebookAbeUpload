using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace UpdateAbeBook
{
    public partial class Form1 : Form
    {
        string strUploadFile = "";
        public string xmlStart = "<?xml version=\"1.0\" encoding=\"ISO-8859-1\"?><inventoryUpdateRequest version=\"1.0\"><action name=\"bookupdate\"><username>GYANBOOK</username><password>c3e77de2c52f4b979cb6</password></action><AbebookList>";
        public string xmlDataLatest = "<Abebook><transactionType>update</transactionType>" +
            "<vendorBookID>{0}</vendorBookID>" +
            "<author>{1}</author>" +
            "<price currency=\"USD\">{2}</price>" +
            "<title>{3}</title>" +
            "<description>{4}</description>" +
        "<quantity amount=\"{5}\"></quantity>" +
        "<binding type=\"{10}\">{6}</binding>" +
        "<bookCondition>{7}</bookCondition>" + 
        "<publisher>{8}</publisher>"+
        "<publishYear>{9}</publishYear>";
        public string xmlData2 = "<Abebook><transactionType>update</transactionType><vendorBookID>{0}</vendorBookID><author>{1}</author><price currency=\"USD\">{2}</price></Abebook>";
        public string xmlImage = @"<pictureURL>{0}</pictureURL>";
        public string xmlEnd = "</AbebookList></inventoryUpdateRequest>";
        public string[] imageURL = new string[] {
            "https://www.gyanbooks.com/books/pics/lb1.jpg",
            "https://www.gyanbooks.com/books/pics/lb2.jpg",
            "https://www.gyanbooks.com/books/pics/lb3.jpg",
            "https://www.gyanbooks.com/books/pics/lb4.jpg",
            "https://www.gyanbooks.com/books/pics/lb5.jpg" };
        int maxCount = 100;
        public Form1()
        {
            InitializeComponent();
            //ReadResponse("");
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            strUploadFile = openFileDialog1.FileName;
            txtUpload.Text = strUploadFile;
            //Logs.StoreActivityLogsInDB(LogType.BrowseFile, GlobalData.iUserID, "Browsed File : " + strUploadFile, System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name, System.Reflection.MethodBase.GetCurrentMethod().Name);
        }

        public void ReadExcel()
        {   
            string conn = string.Empty;
            string fileExt = Path.GetExtension(strUploadFile);
            System.Data.DataTable dtexcel = new System.Data.DataTable();
            if (fileExt.CompareTo(".xls") == 0)
                conn = @"provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + strUploadFile + ";Extended Properties='Excel 8.0;HRD=Yes;IMEX=1';"; //for below excel 2007  
            else
                conn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + strUploadFile + ";Extended Properties='Excel 12.0;HDR=Yes;IMEX=1';"; //for above excel 2007  
            using (OleDbConnection con = new OleDbConnection(conn))
            {
                try
                {
                    con.Open();
                    System.Data.DataTable dtSheet = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                    string strSheetName = string.Empty;
                    int iSheetCount = 0;
                    while (string.IsNullOrEmpty(strSheetName))
                    {
                        strSheetName = Convert.ToString(dtSheet.Rows[iSheetCount]["TABLE_NAME"]);
                        if (!strSheetName.EndsWith("$"))
                        {
                            strSheetName = string.Empty;
                        }
                        iSheetCount++;
                    }

                    OleDbDataAdapter oleAdpt = new OleDbDataAdapter("select * from [" + strSheetName + "]", con); //here we read data from sheet1  
                    
                    oleAdpt.Fill(dtexcel); //fill excel data into dataTable  
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            ProcessFile(dtexcel);
            Cursor.Current = Cursors.Default;
            btnImport.Enabled = true;
        }

        private void ProcessFile(DataTable dt)
        {
            try
            {
                DateTime dtStart = DateTime.Now;
                int iFileCount = 0;
                int iStartCount = 0;
                if (dt.Rows.Count > 0)
                {
                    for (int iResultCount = 0; iResultCount < dt.Rows.Count;)
                    {
                        string sPersonalNo = "";
                        int iCount = 0;
                        string sBodyRequest = string.Empty;
                        while (iCount < maxCount)
                        {
                            if (iResultCount < dt.Rows.Count)
                            {
                                if (!string.IsNullOrEmpty(Convert.ToString(dt.Rows[iResultCount][1])))
                                {
                                    sBodyRequest += string.Format(xmlDataLatest, dt.Rows[iResultCount]["PersonalNo"],
                                        dt.Rows[iResultCount]["creator"],
                                        dt.Rows[iResultCount]["Price"],
                                        dt.Rows[iResultCount]["Title"],
                                        dt.Rows[iResultCount]["Description"],
                                        dt.Rows[iResultCount]["Quantity"],
                                        dt.Rows[iResultCount]["bindingType"],
                                        dt.Rows[iResultCount]["bookCondition"],
                                        dt.Rows[iResultCount]["publisher"],
                                        dt.Rows[iResultCount]["publishYear"],
                                        dt.Rows[iResultCount]["Type"]);
                                }
                                else
                                {
                                    sBodyRequest += string.Format(xmlDataLatest,
                                        dt.Rows[iResultCount]["PersonalNo"],
                                        "Anonymous",
                                        dt.Rows[iResultCount]["Price"],
                                        dt.Rows[iResultCount]["Title"],
                                        dt.Rows[iResultCount]["Description"],
                                        dt.Rows[iResultCount]["Quantity"],
                                        dt.Rows[iResultCount]["bindingType"],
                                        dt.Rows[iResultCount]["bookCondition"],
                                        dt.Rows[iResultCount]["publisher"],
                                        dt.Rows[iResultCount]["publishYear"],
                                        dt.Rows[iResultCount]["Type"]);
                                }
                                sPersonalNo += dt.Rows[iResultCount]["PersonalNo"] + ",";
                                sBodyRequest = chkIsbn.Checked ? sBodyRequest + "<isbn>" + dt.Rows[iResultCount]["ISBN"] + "</isbn>" : sBodyRequest;
                                if (chkIncludeImage.Checked)
                                {
                                    sBodyRequest += "<pictureList>";
                                    int iImageCount = 1;
                                    foreach (string imagePath in imageURL)
                                    {
                                        if (chkDefault.Checked)
                                        {
                                            sBodyRequest += string.Format(xmlImage, imagePath);
                                        }
                                        else
                                        {
                                            sBodyRequest += string.Format(xmlImage, txtImageURL.Text + "/" + dt.Rows[iResultCount]["ImageLink" + iImageCount]);
                                        }
                                        iImageCount++;
                                    }
                                    sBodyRequest += "</pictureList>";
                                }
                                sBodyRequest += "</Abebook>";
                                if (iStartCount == 0)
                                {
                                    iStartCount++;
                                    DialogResult drResult = MessageBox.Show(sBodyRequest, "Request Data", MessageBoxButtons.YesNo);
                                    if (drResult != System.Windows.Forms.DialogResult.Yes)
                                    {
                                        return;
                                    }
                                }

                                iResultCount++;
                            }
                            else
                                break;
                            iCount++;
                        }
                        DateTime dtStartTime = DateTime.Now;


                        string sFinalRequest = xmlStart + sBodyRequest + xmlEnd;
                        sFinalRequest = sFinalRequest.Replace("&", "&amp;");
                        string sFileName = Path.Combine(Application.StartupPath, "Logs", Path.GetFileNameWithoutExtension(strUploadFile) + iFileCount + ".csv");

                        
                        try
                        {
                            string sResult = postXMLData(sFinalRequest);
                            // Logs.StoreActivityLogsInDB("UpdateAbeBook", GlobalData.iUserID, "Updated Personal No : " + sPersonalNo + " Response : " + sResult, "UpdateAbeBook", "btnImport_Click");
                            using (StreamWriter sw = new StreamWriter(sFileName, true))
                            {
                                sw.WriteLine(dtStartTime.ToString() + " : Request :" + sFinalRequest + "##" + iResultCount + " \n ## " + DateTime.Now.ToString() + " API Response :" + sResult);
                                sw.Close();
                            }
                            FileInfo fi = new FileInfo(sFileName);
                            if (fi.Length > 100000000)
                            {
                                iFileCount++;
                            }


                            if (!string.IsNullOrEmpty(sResult))
                            {
                                using (StreamWriter sw = new StreamWriter(Path.Combine(Application.StartupPath, "Logs", Path.GetFileNameWithoutExtension(strUploadFile) + ".csv"), true))
                                {
                                    sw.WriteLine(dtStartTime.ToString() + "Personal No: " + sPersonalNo);
                                    sw.Close();
                                }
                                List<string> errorList = ReadResponse(sResult);
                                if (errorList.Count > 0)
                                {
                                    MessageBox.Show("Error in updating below records over abebooks : \n" + string.Join(";", errorList));
                                }
                            }
                            else
                            {
                                using (StreamWriter sw = new StreamWriter(Path.Combine(Application.StartupPath, "Logs", Path.GetFileNameWithoutExtension(strUploadFile) + "_blank.csv"), true))
                                {
                                    sw.WriteLine(dtStartTime.ToString() + "Personal No: " + sPersonalNo);
                                    sw.Close();
                                }
                            }
                        }
                        catch(Exception ex)
                        {
                            using (StreamWriter sw = new StreamWriter(Path.Combine(Application.StartupPath, "Logs", Path.GetFileNameWithoutExtension(strUploadFile) + "_Error.csv"), true))
                            {
                                sw.WriteLine(dtStartTime.ToString() + "Personal No: " + sPersonalNo);
                                sw.Close();
                            }
                            using (StreamWriter swError = new StreamWriter(Path.Combine(Application.StartupPath, "Logs", Path.GetFileNameWithoutExtension(strUploadFile) + ".log"), true))
                            {
                                swError.WriteLine(DateTime.Now.ToString("dd:MM:yyyy hh:mm:ss") + "--" + " Message --" + ex.Message);
                                swError.WriteLine(DateTime.Now.ToString("dd:MM:yyyy hh:mm:ss") + "--" + " Stack Trace --" + ex.StackTrace);
                            }
                        }
                        Thread.Sleep(1000);
                    }
                }
                DateTime dtEnd = DateTime.Now;
                MessageBox.Show("Done successfully \n" +
                    "With Start Time : "+ dtStart.ToString("hh:mm:ss") +
                    "\n and End Time : " + dtEnd.ToString("hh:mm:ss") +
                    "\n and Total Time in minutes: " + dtEnd.Subtract(dtStart).Minutes 
                    );
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured. Please check the logs.");
                using (StreamWriter sw = new StreamWriter(Path.Combine(Application.StartupPath, "Logs", Path.GetFileNameWithoutExtension(strUploadFile) + ".log"), true))
                {
                    sw.WriteLine(DateTime.Now.ToString("dd:MM:yyyy hh:mm:ss") + "--" + " Message --" + ex.Message);
                    sw.WriteLine(DateTime.Now.ToString("dd:MM:yyyy hh:mm:ss") + "--" + " Stack Trace --" + ex.StackTrace);
                }
            }
        }
        private void btnImport_Click(object sender, EventArgs e)
        {
            try
            {
                //DataTable dt = ReadExcel(strUploadFile, false, string.Empty);
                Cursor.Current = Cursors.WaitCursor;
                Thread t = new Thread(new ThreadStart(ReadExcel));
                t.SetApartmentState(ApartmentState.STA);
                t.Start();
                btnImport.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured. Please check the logs.");
                using (StreamWriter sw = new StreamWriter(Path.Combine(Application.StartupPath, "Logs", Path.GetFileNameWithoutExtension(strUploadFile) + ".log"), true))
                {
                    sw.WriteLine(DateTime.Now.ToString("dd:MM:yyyy hh:mm:ss") + "--" + " Message --" + ex.Message);
                    sw.WriteLine(DateTime.Now.ToString("dd:MM:yyyy hh:mm:ss") + "--" + " Stack Trace --" + ex.StackTrace);
                }
            }
        }
        private List<string> ReadResponse(string response)
        {
            List<string> errorList = new List<string>();
            try
            {
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.LoadXml(response);
                XmlNodeList xmlNodeList = xmlDocument.SelectNodes("inventoryUpdateResponse/AbebookList/Abebook");
                for (int i = 0; i < xmlNodeList.Count; i++)
                {
                    XmlNode xmlNode = xmlNodeList[i];
                    XmlNode statusNode = xmlNode.SelectSingleNode("code");
                    if (statusNode.InnerText != "600")
                    {
                        XmlNode personalNoNode = xmlNode.SelectSingleNode("vendorBookID");
                        errorList.Add(personalNoNode.InnerText);
                    }
                }
                
            }
            catch(Exception e)
            {
                MessageBox.Show("Error in reading response.\n" + e.Message);
            }
            return errorList;
        }
        public static string postXMLData(string requestXml)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 |
                                       SecurityProtocolType.Tls11 |
                                       SecurityProtocolType.Tls |
                                       SecurityProtocolType.Ssl3;
            ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
            ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;
            HttpClient client = new HttpClient();
            StringContent sContent = new StringContent(requestXml,
                                                Encoding.UTF8,
                                                "text/xml");//CONTENT-TYPE header
            HttpResponseMessage responseMessage = client.PostAsync(new Uri("https://inventoryupdate.abebooks.com:10027"), sContent).GetAwaiter().GetResult();
            string strVal = "";
            if (responseMessage.IsSuccessStatusCode)
            {
                strVal = responseMessage.Content.ReadAsStringAsync().Result;
            }

            return strVal;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string allowedMacAddress = "5CF3FCB2B999";
            String firstMacAddress = NetworkInterface
                                    .GetAllNetworkInterfaces()
                                    .Where(nic => nic.OperationalStatus == OperationalStatus.Up && nic.NetworkInterfaceType != NetworkInterfaceType.Loopback)
                                    .Select(nic => nic.GetPhysicalAddress().ToString())
                                    .FirstOrDefault();
            if(allowedMacAddress != firstMacAddress)
            {
                MessageBox.Show($"This software can not run on this system. It can be run only on server.\n {firstMacAddress}");
                Close();
            }
        }
    }
}
