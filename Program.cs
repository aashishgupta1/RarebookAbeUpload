using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UpdateAbeBook
{
    static class Program
    {
        [DllImport("ole32.dll")]
        public static extern Int32 CoWaitForMultipleHandles(Int32 dwFlags, Int32 dwTimeout, Int32 cHandles, IntPtr[] pHandles, ref Int32 lpdwindex);
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            System.Windows.Forms.Application.Run(new Form1());
        }

        public static System.Data.DataTable ReadExcel(string fileName, bool sort, string sortColumn)
        {
            string conn = string.Empty;
            string fileExt = Path.GetExtension(fileName);
            System.Data.DataTable dtexcel = new System.Data.DataTable();
            if (fileExt.CompareTo(".xls") == 0)
                conn = @"provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + fileName + ";Extended Properties='Excel 8.0;HRD=Yes;IMEX=1';"; //for below excel 2007  
            else
                conn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + fileName + ";Extended Properties='Excel 12.0;HDR=Yes;IMEX=1';"; //for above excel 2007  
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
                    
                    OleDbDataAdapter oleAdpt = new OleDbDataAdapter("select * from [" + strSheetName +  "]", con); //here we read data from sheet1  
                    ManualResetEvent manualresetevent = new ManualResetEvent(false);
                    IntPtr[] waithandles = new IntPtr[1];
                    waithandles[0] = manualresetevent.SafeWaitHandle.DangerousGetHandle();
                    int index = 0;
                    int ret = CoWaitForMultipleHandles(0, 0, waithandles.Length, waithandles, ref index);
                    oleAdpt.Fill(dtexcel); //fill excel data into dataTable  
                    if (sort)
                    {
                        dtexcel.DefaultView.Sort = sortColumn;
                    }
                }
                catch(Exception e) {
                    MessageBox.Show(e.Message);
                }
            }
            return dtexcel;
        }
        //public static System.Data.DataTable ImportExceltoDatatable(string filepath, bool sort, string sortColumn)
        //{
        //    System.Data.DataTable dt = new System.Data.DataTable(); ;
        //    if (Path.GetExtension(filepath).ToLower() == ".csv")
        //    {
        //        //dt = ImportCSV(filepath);
        //    }
        //    else
        //    {
        //        ApplicationClass ac = new ApplicationClass();

        //        Workbook wb = ac.Workbooks.Open(filepath);
        //        int iTotalWorkSheetCount = wb.Worksheets.Count;
        //        List<string> strSheetName = new List<string>();
        //        foreach (Worksheet wcs in wb.Sheets)
        //        {
        //            string strname = wcs.Name;
        //            strSheetName.Add(strname);
        //        }
        //        wb.Close();
        //        string sqlquery = "Select * From [" + strSheetName[0] + "$]";
        //        DataSet ds = new DataSet();
        //        string constring = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filepath + ";Extended Properties=\"Excel 12.0;HDR=YES;\"";
        //        if (Path.GetExtension(filepath).Equals(".xls", StringComparison.InvariantCultureIgnoreCase))
        //        {
        //            constring = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filepath + ";Extended Properties=\"Excel 8.0;HDR=YES;IMEX=1\"";
        //        }
        //        else
        //        {
        //            constring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filepath + ";Extended Properties=\"Excel 12.0;HDR=YES;IMEX=1\"";
        //        }
        //        using (OleDbConnection con = new OleDbConnection(constring + ""))
        //        {
        //            using (OleDbDataAdapter da = new OleDbDataAdapter(sqlquery, con))
        //            {
        //                da.Fill(ds);
        //                dt = ds.Tables[0];
        //            }
        //        }
        //    }
        //    if (sort)
        //    {
        //        dt.DefaultView.Sort = sortColumn;
        //    }
        //    return dt;
        //}
    }
}
