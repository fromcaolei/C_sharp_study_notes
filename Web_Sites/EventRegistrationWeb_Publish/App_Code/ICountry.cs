using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
///在App_Code目录下定义，用于创建Web part之间的连接
/// </summary>
public interface ICountry
{
    string GetCountry();
}