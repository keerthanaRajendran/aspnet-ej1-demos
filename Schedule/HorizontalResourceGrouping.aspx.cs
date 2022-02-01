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

namespace WebSampleBrowser.Schedule
{
    public partial class HorizontalResourceGrouping : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<WebSampleBrowser.Schedule.multipleresource.Rooms> owner = new List<WebSampleBrowser.Schedule.multipleresource.Rooms>();
            List<WebSampleBrowser.Schedule.multipleresource.Rooms> rooms = new List<WebSampleBrowser.Schedule.multipleresource.Rooms>();
            rooms.Add(new WebSampleBrowser.Schedule.multipleresource.Rooms { text = "Room 1", id = "1", color = "#cb6bb2" });
            rooms.Add(new WebSampleBrowser.Schedule.multipleresource.Rooms { text = "Room 2", id = "2", color = "#56ca85" });

            owner.Add(new WebSampleBrowser.Schedule.multipleresource.Rooms { text = "Nancy", id = "1", groupId = "1", color = "#ffaa00" });
            owner.Add(new WebSampleBrowser.Schedule.multipleresource.Rooms { text = "Steven", id = "3", groupId = "2", color = "#f8a398" });
            owner.Add(new WebSampleBrowser.Schedule.multipleresource.Rooms { text = "Michael", id = "5", groupId = "1", color = "#7499e1" });

            Schedule1.Resources[0].ResourceSettings.DataSource = rooms;
            Schedule1.Resources[1].ResourceSettings.DataSource = owner;
        }
    }
}