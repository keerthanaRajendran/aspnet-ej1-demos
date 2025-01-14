#region Copyright Syncfusion Inc. 2001-2022.
// Copyright Syncfusion Inc. 2001-2022. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebSampleBrowser.SpreadsheetASP.Model;
using Syncfusion.EJ.Export;
using Syncfusion.XlsIO;

namespace WebSampleBrowser.SpreadsheetASP
{
    public partial class ImportExport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BindDataSource();
        }

        private void BindDataSource()
        {
            int code = 10000;
            List<Orders> order = new List<Orders>();

            for (int i = 1; i <= 2; i++)
            {
                order.Add(new Orders(code + 1, "TOMSP", i + 0, "Münster", "Toms Spezialitäten", "Germany"));
                order.Add(new Orders(code + 2, "HANAR", i + 2, "Rio de Janeiro", "Hanari Carnes", "Brazil"));
                order.Add(new Orders(code + 3, "VICTE", i + 1, "Lyon", "Victuailles en stock", "France"));
                order.Add(new Orders(code + 4, "VINET", i + 3, "Reims", "Vins et alcools Chevalier", "France"));
                order.Add(new Orders(code + 5, "SUPRD", i + 4, "Charleroi", "Suprêmes délices", "Belgium"));
                code += 5;
            }
            this.FlatSpreadsheet.Sheets[0].RangeSetting[0].Datasource = order;            
        }

        [Serializable]
        public class Orders
        {
            public Orders()
            {

            }
            public Orders(long OrderId, string CustomerId, int EmployeeId, string ShipCity, string ShipName, string ShipCountry)
            {
                this.OrderID = OrderId;
                this.CustomerID = CustomerId;
                this.EmployeeID = EmployeeId;
                this.ShipName = ShipName;
                this.ShipCity = ShipCity;
                this.ShipCountry = ShipCountry;
            }
            public long OrderID { get; set; }
            public string CustomerID { get; set; }
            public int EmployeeID { get; set; }
            public string ShipCity { get; set; }
            public string ShipName { get; set; }
            public string ShipCountry { get; set; }
        }
        protected void Spreadsheet_ServerExcelExporting(object sender, Syncfusion.JavaScript.Web.SpreadsheetEventArgs e)
        {
            var args = e.Arguments;
            string password = args["password"].ToString();
            string sheetModel = args["sheetModel"].ToString();
            string sheetData = args["sheetData"].ToString();
            string fileName = args["fileName"].ToString();
			
            if (!string.IsNullOrEmpty(password))
               
                Spreadsheet.Save(sheetModel, sheetData, fileName, ExportFormat.XLSX, ExcelVersion.Excel2013, password);
            else
                Spreadsheet.Save(sheetModel, sheetData, fileName, ExportFormat.XLSX, ExcelVersion.Excel2013);
        }

        protected void Spreadsheet_ServerCsvExporting(object sender, Syncfusion.JavaScript.Web.SpreadsheetEventArgs e)
        {
            var args = e.Arguments;
            Spreadsheet.Save(args["sheetModel"].ToString(), args["sheetData"].ToString(), args["fileName"].ToString(), ExportFormat.CSV);
        }

        protected void Spreadsheet_ServerPdfExporting(object sender, Syncfusion.JavaScript.Web.SpreadsheetEventArgs e)
        {
            var args = e.Arguments;
            Spreadsheet.Save(args["sheetModel"].ToString(), args["sheetData"].ToString(), args["fileName"].ToString(), ExportFormat.PDF);
        }
    }
}