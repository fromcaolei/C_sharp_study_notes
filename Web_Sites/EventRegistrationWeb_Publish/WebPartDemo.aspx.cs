using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

public partial class WebPartDemo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    //将WebPartManager中支持显示的模式交由DropDownList选择，成为其选项
    protected void Page_Init(object sender, EventArgs e)
    { 
        foreach (WebPartDisplayMode mode in WebPartManager1.SupportedDisplayModes)
        {
            if (mode.IsEnabled(WebPartManager1))
            {
                DropDownListDisplayModes.Items.Add(new ListItem(mode.Name));
            }
        }
    }

    //把WebPartManager的显示模式改为在下拉列表DropDownListDisplayMode中选择的模式
    protected void DropDownListDisplayModes_SelectedIndexChanged(object sender, EventArgs e)
    {
        string selectedMode = DropDownListDisplayModes.SelectedValue;
        WebPartDisplayMode mode = WebPartManager1.SupportedDisplayModes[selectedMode];
        if (mode != null)
        {
            WebPartManager1.DisplayMode = mode;
        }
    }
}