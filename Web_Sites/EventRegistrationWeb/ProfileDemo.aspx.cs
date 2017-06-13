using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ProfileDemo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Profile.LastVisit = DateTime.Now;
        Profile.Country = DropDownList1.SelectedItem.ToString();

        LabelLastVisit.Text = Profile.LastVisit.ToLongTimeString();
        LabelVisitCount.Text = Profile.Visits.ToString();
        LabelSelectedCountry.Text = Profile.Country;

        Profile.Visits++;

        string country = Profile.EventSelection.Country;
        string country1 = (string)HttpContext.Current.Profile["Country"];  //用于组件的个性化配置属性使用方式

    }
}