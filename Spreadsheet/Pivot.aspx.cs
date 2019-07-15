#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
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
using Syncfusion.EJ.Export;
using Syncfusion.XlsIO;
using WebSampleBrowser.SpreadsheetASP.Model;

namespace WebSampleBrowser.SpreadsheetASP
{
    public partial class Pivot : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BindDataSource();
        }

        private void BindDataSource()
        {
            var dataSource = PivotData.GetPivotDetails.ToList();
            this.FlatSpreadsheet.Sheets.Add(new Syncfusion.JavaScript.Models.Sheet()
            {
                Datasource = dataSource
            });
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