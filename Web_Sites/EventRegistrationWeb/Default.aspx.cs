using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    //3、在Default.aspx.cs文件中给_Default类添加RegistrationInformation类型的属性，只使用一个get（因需修改上页的属性无意义，所以不需要set），在get中先创建RegistrationInformation类对象，再使用对象中的属性成员作为中间值对其赋值Default页中需要的内容，最后return这个对象。
    public RegistrationInformation RegistrationInformation
    {
        get
        {
            RegistrationInformation ri = new RegistrationInformation();
            ri.Firstname = textFirstname.Text;
            ri.Lastname = textLastname.Text;
            ri.Email = textEmail.Text;
            ri.SelectedEvent = dropDownListEvents.SelectedValue;
            return ri;
        }
    }

    protected void buttonSubmit_Click(object sender, EventArgs e)
    {
        string selectedEvent = dropDownListEvents.SelectedValue;
        string firstname = textFirstname.Text;
        string lastname = textLastname.Text;
        string email = textEmail.Text;

        labelResult.Text = firstname + " " + lastname + " selected the event " + selectedEvent + ".";
    }
}
