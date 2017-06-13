using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

public partial class Country : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    //Web part之间连接使用该属性标记消费者方法，SetCountry方法接收ICountry接口，用于调用GetCountry方法，接收来自提供者的数据
    [ConnectionConsumer("Country", "CountryConsumer")]
    public void SetCountry(ICountry provider)
    {
        string country = provider.GetCountry();
        if (!string.IsNullOrEmpty(country))
        {
            LabelCountry.Text = country;
        }
    }
}