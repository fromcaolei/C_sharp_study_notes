using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ResultPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        /*try
        {
            DropDownList dropDownListEvents = (DropDownList)PreviousPage.FindControl("dropDownListEvents");

            string selectedEvent = dropDownListEvents.SelectedValue;

            string firstname = ((TextBox)PreviousPage.FindControl("textFirstname")).Text;

            string lastname = ((TextBox)PreviousPage.FindControl("textLastname")).Text;

            string email = ((TextBox)PreviousPage.FindControl("textEmail")).Text;

            labelResult.Text = firstname + " " + lastname + " selected the event " + selectedEvent + ".";
        }
        catch
        { 
            labelResult.Text = "The originating page must contain " + "textFirstname, textLastname, textEmail controls.";
        }*/

        try
        {
            RegistrationInformation ri = PreviousPage.RegistrationInformation;  //初始化为上一页创建的RegistrationInformation属性

            if (!PreviousPage.IsValid)
            {
                labelResult.Text = "Error in previous page.";
                return;
            }

            labelResult.Text = ri.Firstname + " " + ri.Lastname + " selected the event " + ri.SelectedEvent;
        }
        catch
        {
            labelResult.Text = "The originating page must contain " + "textFirstname, textLastname, textEmail controls";
        }
    }
}