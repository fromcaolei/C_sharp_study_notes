using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Weather : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Random r = new Random();
        int n = r.Next(1, 3);

        switch (n)
        {
            case 1: LabelWeather.Text = "Sun"; break;
            case 2: LabelWeather.Text = "Rain"; break;
            case 3: LabelWeather.Text = "Cloudy"; break;
        }
    }
}