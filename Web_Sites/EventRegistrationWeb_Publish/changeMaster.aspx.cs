using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class changeMaster : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    void Page_PerInit(object sender, EventArgs e)
    {
        if (Request.UserAgent.Contains("MSIE"))
        {
            this.MasterPageFile = "~/IE.master";
        }
        else
        {
            this.MasterPageFile = "~/Default.master";
        }
    }
}