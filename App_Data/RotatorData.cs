using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.ComponentModel;
using System.Web.Script.Serialization;

[Serializable]
public class RotatorData
{

    public RotatorData(string _caption, string _url)
    {
        this.Caption = _caption;
        this.Url = _url;
        
    }
    public RotatorData()
    {

    }

    [Browsable(true)]
    public string Caption
    {
        get;
        set;
    }

    [Browsable(true)]
    public string Url
    {
        get;
        set;
    }


    public List<RotatorData> GetRotatorItems()
    {
        List<RotatorData> data = new List<RotatorData>();
        data.Add(new RotatorData("Beautiful Bird", "../Content/images/rotator/bird.jpg"));
        data.Add(new RotatorData("Colorful Night", "../Content/images/rotator/night.jpg"));
        data.Add(new RotatorData("Technology", "../Content/images/rotator/tablet.jpg"));
        data.Add(new RotatorData("Nature", "../Content/images/rotator/nature.jpg"));
        data.Add(new RotatorData("Snow Fall", "../Content/images/rotator/snowfall.jpg"));
        data.Add(new RotatorData("Credit Card", "../Content/images/rotator/card.jpg"));
        return data;
    }
}