using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

public partial class ListEvents : System.Web.UI.UserControl, ICountry
{
    //该自定义控件的共有方法，实现外部传值定义日历和下拉菜单栏内容的功能
    public void Configure(DateTime date, params string[] countries)
    {
        DropDownListCountries.Items.Clear();

        EventCalendar.SelectedDate = date;
        ListItem[] items = new ListItem[countries.Length];
        for (int i = 0; i < countries.Length; i++)
        {
            items[i] = new ListItem(countries[i]);
        }
        DropDownListCountries.Items.AddRange(items);
    }

    //用ListEvent类实现ICountry接口，执行GetCountry()方法，给调用者返回选中的国家
    public string GetCountry()
    {
        return DropDownListCountries.SelectedItem.Value;
    }

    //Web part之间连接使用该属性返回一个接口，执行GetCountryInterface()方法就返回对ICountry接口的引用
    [ConnectionProvider("Country", "CountryProvider")]
    public ICountry GetCountryInterface()
    {
        return this;
    }

    protected void Page_Load(object sender, EventArgs e)
    {

    }
}