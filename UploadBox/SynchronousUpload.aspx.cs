﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Syncfusion.JavaScript.Web;
using Syncfusion.JavaScript.Models;

namespace WebSampleBrowser.UploadBox
{
    public partial class SynchronousUpload : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void post_Click(object Sender, Syncfusion.JavaScript.Web.ButtonEventArgs e)
        {
            string targetFolder = HttpContext.Current.Server.MapPath("uploadfiles");
            if (!Directory.Exists(targetFolder))
            {
                Directory.CreateDirectory(targetFolder);
            }

            if (SyncUpload.HasFiles)
            {               
                for (int i = 0; i < SyncUpload.PostedFiles.Count; i++)
                {
                    
                    string fileName = SyncUpload.PostedFiles[i].FileName;
                    int indx = fileName.LastIndexOf("\\");
                    if (indx > -1)
                    {
                        fileName = fileName.Substring(indx + 1);
                    }
                    //SyncUpload.PostedFiles[i].SaveAs(targetFolder + "\\" + fileName);
                    status.Text = "Successfully Uploaded";
                }
            }       
        }
    }
}