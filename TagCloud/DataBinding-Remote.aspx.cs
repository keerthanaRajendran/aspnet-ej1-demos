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
using Syncfusion.JavaScript.Web;

namespace WebSampleBrowser.TagCloud
{
    public partial class DataBinding_Remote : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
         
            this.TagCloud1.Query = "ej.Query().from('Orders').take(10)";
           this.TagCloud1.TagCloudFields.Frequency = "EmployeeID";
           this.TagCloud1.TagCloudFields.Text = "CustomerID";
        }
    }
}