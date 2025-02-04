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

namespace WebSampleBrowser.Dialog
{
    public partial class CustomAction : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<string> actionlist = new List<string>();
            actionlist.Add("close");
            actionlist.Add("collapsible");
            actionlist.Add("maximize");
            actionlist.Add("minimize");
            actionlist.Add("pin");

            dialogIcon.ActionButtons = actionlist;
        }
    }
}