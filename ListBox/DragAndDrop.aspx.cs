﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebSampleBrowser.ListBox
{
    public partial class DragAndDrop : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Languages> language = new List<Languages>();
            language.Add(new Languages("ActionScript"));
            language.Add(new Languages("Basic"));
            language.Add(new Languages("C"));
            language.Add(new Languages("C++"));
            language.Add(new Languages("C#"));
            language.Add(new Languages("dBase"));
            language.Add(new Languages("Delphi"));
            language.Add(new Languages("ESPOL"));
            language.Add(new Languages("F#"));
            language.Add(new Languages("FoxPro"));
            language.Add(new Languages("Java"));
            language.Add(new Languages("j#"));
            language.Add(new Languages("Lisp"));
            language.Add(new Languages("Logo"));
            language.Add(new Languages("PHP"));
            this.dragContainer.DataSource = language;
        }
    }
}