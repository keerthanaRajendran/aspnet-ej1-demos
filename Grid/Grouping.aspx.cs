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

namespace WebSampleBrowser.Grid
{
    public partial class gridGrouping : System.Web.UI.Page
    {
        List<Orders> order = new List<Orders>();
        protected void Page_Load(object sender, EventArgs e)
        {
            BindDataSource();
        }

        private void BindDataSource()
        {
            int code = 10000;
            for (int i = 1; i < 10; i++)
            {
                order.Add(new Orders(code + 1, "OCEAN", "Buenos Aires","Argentiana", i + 4,false, new DateTime(1991, 05, 15)));
                order.Add(new Orders(code + 2, "ERNSH", "Graz","Austria", i + 5,true, new DateTime(1990, 04, 04)));
                order.Add(new Orders(code + 3, "PICCO","Salzbarg","Austria", i + 3,true, new DateTime(1957, 11, 30)));
                order.Add(new Orders(code + 4, "RICAR","Rio de janerio","Brazil", i + 2,false, new DateTime(1930, 10, 22)));
                order.Add(new Orders(code + 5, "QUEEN", "Sao paulo","Brazil", i + 1,true, new DateTime(1953, 02, 18)));
                code += 5;
            }
            this.OrdersGrid.DataSource = order;
            this.OrdersGrid.DataBind();
        }

        [Serializable]
        public class Orders
        {
            public Orders()
            {

            }
            public Orders(long OrderId, string CustomerId, string ShipCity, string ShipCountry, int EmployeeId, bool Verified, DateTime OrderDate)
            {
                this.OrderID = OrderId;
                this.CustomerID = CustomerId;
                this.ShipCity = ShipCity;
                this.ShipCountry = ShipCountry;
                this.EmployeeID = EmployeeId;
                this.Verified = Verified;
                this.OrderDate = OrderDate;
            }
            public long OrderID { get; set; }
            public string CustomerID { get; set; }
            public string ShipCity { get; set; }
            public string ShipCountry { get; set; }
            public int EmployeeID { get; set; }
            public bool Verified { get; set; }
            public DateTime OrderDate { get; set; }
        }
    }
}