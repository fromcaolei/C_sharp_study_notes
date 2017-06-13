using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServiceSample
{
    /// <summary>
    /// Service1 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://www.wrox.com/webservices")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消对下行的注释。
    // [System.Web.Script.Services.ScriptService]
    public class Service1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string ReverseString(string message)
        {
            char[] arr = message.ToCharArray();
            Array.Reverse(arr);
            message = new string(arr);
            System.Threading.Thread.Sleep(3000);
            return message;
        }

        [WebMethod]
        public GetWeatherResponse GetWeather(GetWeatherRequest req)
        {
            GetWeatherResponse resp = new GetWeatherResponse();
            Random r = new Random();
            int celslus = r.Next(-20, 50);

            if (req.TemperatureType == TemperatureType.Celsius)
                resp.Temperature = celslus;
            else
                resp.Temperature = (212 - 32) / 100 * celslus + 32;

            if (req.City == "Redmond")
                resp.Condition = TemparatureCondition.Rainy;
            else
                resp.Condition = (TemparatureCondition)r.Next(0, 3);

            return resp;
        }
    }

    public enum TemperatureType
    { 
        Fahrenheit,
        Celsius
    }

    public enum TemparatureCondition
    { 
        Rainy,
        Sunny,
        Cloudy,
        Thunderstorm
    }

    public class GetWeatherRequest
    {
        public string City;
        public TemperatureType TemperatureType;
    }

    public class GetWeatherResponse
    {
        public TemparatureCondition Condition;
        public int Temperature;
    }
}
