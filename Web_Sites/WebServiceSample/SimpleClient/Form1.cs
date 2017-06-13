using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SimpleClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void WebServiceResult(object sender, WebServiceSample.ReverseStringCompletedEventArgs e)
        {
            textBox2.Text = e.Result;
        }

        //正常调用web服务
        /*private void button1_Click(object sender, EventArgs e)
        {
            WebServiceSample.Service1 ws = new WebServiceSample.Service1();
            textBox2.Text = ws.ReverseString(textBox1.Text);  //直接调用web服务提供的方法
        }*/

        //异步调用web服务
        private void button1_Click(object sender, EventArgs e)
        {
            WebServiceSample.Service1 ws = new WebServiceSample.Service1();
            ws.ReverseStringCompleted += WebServiceResult;  //先委托一个事件处理函数可以在完成Web服务方法时被调用
            ws.ReverseStringAsync(textBox1.Text);  //这里只需要给ReverseStringAsync函数将字符串传递进去，结果由上一步委托事件来处理
        }
    }
}
