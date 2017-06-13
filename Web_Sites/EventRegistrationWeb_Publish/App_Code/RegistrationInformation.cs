using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
///在App_Code目录下定义，用于Defual页面Submit按钮进行页面传值使用的属性传递中间桥梁
/// </summary>
public class RegistrationInformation
{
    //2、在RegistrationInformation.cs的类中添加一些属性，和Default页里想要使用到的属性一一对应起来。（get、set）
    private string firstname;
    public string Firstname
    {
        get { return firstname; }
        set { firstname = value; }
    }

    private string lastname;
    public string Lastname
    {
        get { return lastname; }
        set { lastname = value; }
    }

    private string email;
    public string Email
    {
        get { return email; }
        set { email = value; }
    }

    private string selectedEvent;
    public string SelectedEvent
    {
        get { return selectedEvent; }
        set { selectedEvent = value; }
    }

	public RegistrationInformation()
	{
		//
		//TODO: 在此处添加构造函数逻辑
		//
	}
}