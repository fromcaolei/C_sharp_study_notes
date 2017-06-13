<%@ Application Language="C#" %>

<script runat="server">

    void Application_Start(object sender, EventArgs e) 
    {
        // 在应用程序启动时运行的代码
        Application["userCount"] = 0;  //不在此处初始化其他方法中无法正常使用,Application创建的变量值 更换 浏览器之后不会消失
    }
    
    void Application_End(object sender, EventArgs e) 
    {
        //  在应用程序关闭时运行的代码

    }
        
    void Application_Error(object sender, EventArgs e) 
    { 
        // 在出现未处理的错误时运行的代码

    }

    void Session_Start(object sender, EventArgs e) 
    {
        // 在新会话启动时运行的代码
        Session["mydata"] = 0;  //不在此处初始化其他方法中无法正常使用,Session创建的变量值 关闭 浏览器之后不会消失，保存20分钟

        Application.Lock();  //改变应用程序变量，须用Lock()方法锁定，改变值后，还需调用Unlock()方法解锁。否则就会出现线程问题，因为多个客户可以同时访问一个应用程序变量。在此期间不应读取文件或数据库中的数据，否则会其他用户就必须等到数据访问完成之后才能操作
        Application["userCount"] = (int)Application["userCount"] + 1;
        Application.UnLock();
    }

    void Session_End(object sender, EventArgs e) 
    {
        // 在会话结束时运行的代码。 
        // 注意: 只有在 Web.config 文件中的 sessionstate 模式设置为 InProc 时，才会引发 Session_End 事件。
        // 如果会话模式设置为 StateServer 
        // 或 SQLServer，则不会引发该事件。

    }

    void Profile_MigrateAnonymous(object sender, ProfileMigrateEventArgs e)
    { 
        if (Profile.Country == null)
        {
            Profile.Country = Profile.GetProfile(e.AnonymousID).Country;  //GetProfile函数可以通过匿名用户ID访问用户的个性化配置，匿名用户ID在变成授权用户后，通过e参数传值将用户ID传出去
        }
    }
       
</script>
