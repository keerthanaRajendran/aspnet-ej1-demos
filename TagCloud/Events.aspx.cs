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

namespace WebSampleBrowser.TagCloud
{
    public partial class Events : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {       
             
        }

        protected void tagEvents_Click(object sender, Syncfusion.JavaScript.Web.TagCloudEventArgs e)
        {
            this.EventLog.InnerHtml = string.Format("{0}{1}{2}{3}", "\n TagCloud Item ", e.Value, " has been <span class='eventTitle'> clicked</span>. \r\n <br> \r\n", this.EventLog.InnerHtml);
        }

        protected void Clear_Click(object Sender, Syncfusion.JavaScript.Web.ButtonEventArgs e)
        {
            this.EventLog.InnerHtml = string.Empty;
        }
    }
    
}