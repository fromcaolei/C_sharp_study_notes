using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeatherClient.WeatherService;  //若Web服务中定义了一些需要在本代码中使用的类，需要在这里引用服务的名称空间

namespace WeatherClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGetWeather_Click(object sender, EventArgs e)
        {
            GetWeatherRequest req = new GetWeatherRequest();
            if (radioButtonCelsius.Checked)
                req.TemperatureType = TemperatureType.Celsius;
            else
                req.TemperatureType = TemperatureType.Fahrenheit;

            req.City = textCity.Text;  //以上都是为请求装填参数

            Service1 ws = new Service1();

            GetWeatherResponse resp = ws.GetWeather(req);

            textWeatherCondition.Text = resp.Condition.ToString();  //得到反馈的信息放置在文本框中
            textTemperature.Text = resp.Temperature.ToString();
        }
    }
}
