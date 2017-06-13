using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Caching;

public partial class Practice1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //ViewState
        ViewState["mydata"] = "my data";
        string mydata = (string)ViewState["mydata"];

        //cookie
        string myval = "myval";
        HttpCookie cookie = new HttpCookie("mycookie");  //创建新cookie
        cookie.Values.Add("afds", myval);  //给cookie添加内容
        Response.Cookies.Add(cookie);  //将cookie发送给服务器
        cookie.Expires = DateTime.Now.AddMonths(3);  //设置cookie有效期为三个月

        HttpCookie cookie2 = Request.Cookies["mycookie"];  //服务器端读取接收到的cookie内容所使用的代码
        myval = cookie2.Values["mystate"];
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        //Session
        int val = (int)Session["mydata"];
        Label1.Text = val.ToString();
        val += 4;
        Session["mydata"] = val;

        //Application
        Label2.Text = Application["userCount"].ToString();

        //Cache
        string myobj = "";
        Cache.Add("mycache", myobj, null, DateTime.MaxValue, TimeSpan.FromMinutes(10), CacheItemPriority.Normal, null);

        
    }
}