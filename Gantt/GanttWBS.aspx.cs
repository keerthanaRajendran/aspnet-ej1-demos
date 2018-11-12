﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Syncfusion.JavaScript.Web;

namespace WebSampleBrowser.Gantt
{
    public partial class GanttWBS : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var DataSource = this.GetDataSource();
            this.GanttControlWBS.DataSource = DataSource;
            this.GanttControlWBS.DataBind();
        }
        #region Create DataSource for Gantt control
        public List<BusinessObject> GetDataSource()
        {
            List<BusinessObject> list = new List<BusinessObject>();
            list.Add(new BusinessObject()
            {
                Id = 1,
                Name = "Parent Task 1",
                StartDate = "02/27/2017",
                EndDate = "03/03/2017",
                PercentDone = "40",
                Children = (new List<BusinessObject>()
                    {
                        new BusinessObject()
                        {
                            Id = 2,
                            Name = "Child Task 1",
                            StartDate = "02/27/2017",
                            EndDate="03/03/2017",
                            PercentDone = "40",
                        },
                        new BusinessObject()
                        {
                            Id = 3,
                            Name = "Child Task 2",
                            StartDate = "02/27/2017",
                            EndDate="03/03/2017",
                            PercentDone = "40"
                        },
                        new BusinessObject()
                        {
                            Id = 4,
                            Name = "Child Task 3",
                            StartDate = "02/27/2017",
                            EndDate="03/03/2017",
                            Duration = 5,
                            PercentDone = "40"
                        },
                        new BusinessObject()
                        {
                            Id = 5,
                            Name = "Child Task 4",
                            StartDate = "02/23/2014",
                            Duration = 0,
                            PercentDone = "40",
                            Predecessor = "3FS,4FS"
                        }
                    })

            });

            list.Add(new BusinessObject()
            {
                Id = 6,
                Name = "Parent Task 2",
                StartDate = "03/06/2017",
                EndDate = "03/10/2017",
                PercentDone = "40",
                Children = (new List<BusinessObject>()
                    {
                        new BusinessObject()
                        {
                            Id = 7,
                            Name = "Child Task 1",
                            StartDate = "03/06/2017",
                            EndDate = "03/10/2017",
                            PercentDone = "40",
                        },
                        new BusinessObject()
                        {
                            Id = 8,
                            Name = "Child Task 2",
                            StartDate = "03/06/2017",
                            EndDate = "03/10/2017",
                            PercentDone = "40",
                            Predecessor = "7FS"
                        },
                        new BusinessObject()
                        {
                            Id = 9,
                            Name = "Child Task 3",
                            StartDate = "03/06/2017",
                            EndDate = "03/10/2017",
                            PercentDone = "40",
                            Predecessor = "8FS"
                        },
                         new BusinessObject()
                        {
                            Id = 10,
                            Name = "Child Task 4",
                            StartDate = "03/06/2017",
                            PercentDone = "40",
                            Predecessor = "9FS"
                        }
                    })

            });
            list.Add(new BusinessObject()
            {
                Id = 11,
                Name = "Parent Task 3",
                StartDate = "03/13/2017",
                EndDate = "03/17/2017",
                PercentDone = "40",

                Children = (new List<BusinessObject>()
                    {
                        new BusinessObject()
                        {

                            Id = 12,
                            Name = "Child Task 1",
                            StartDate = "03/13/2017",
                            EndDate = "03/17/2017",
                            Duration = 5,
                            PercentDone = "40"
                        },
                        new BusinessObject()
                        {
                            Id = 13,
                            Name = "Child Task 2",
                            StartDate = "03/13/2017",
                            EndDate = "03/17/2017",
                            PercentDone = "40",
                        },
                        new BusinessObject()
                        {
                            Id = 14,
                            Name = "Child Task 3",
                            StartDate = "03/13/2017",
                            EndDate = "03/17/2017",
                            PercentDone = "40"
                        },
                         new BusinessObject()
                        {
                            Id = 15,
                            Name = "Child Task 3",
                            StartDate = "03/13/2017",
                            EndDate = "03/17/2017",
                            PercentDone = "40",
                            Predecessor = "12FS,13FS,14FS"
                        }
                    })

            });

            return list;
        }
        #endregion
        #region BusinessObject Creation
        public class BusinessObject
        {
            public string StartDate { get; set; }
            public string EndDate { get; set; }
            public int Id { get; set; }
            public string Name { get; set; }
            public int Duration { get; set; }
            public string PercentDone { get; set; }
            public List<object> ResourceID { get; set; }
            public List<BusinessObject> Children { get; set; }
            public string Predecessor { get; set; }

        }
        #endregion
    }
}