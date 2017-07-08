using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Media.Animation;

namespace FirstProgram
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void toggleButton_Click(object sender, RoutedEventArgs e)
        {
            //是一个路由事件
            Storyboard spinStoryboard = Resources["Spin"] as Storyboard;  //首先获得Storyboard对象的一个引用，该对象定义了动画。包含在Windows对象的Resources属性中定义Key="Spin"的Storyboard元素
            if (spinStoryboard != null)
            {
                if (spinStoryboard.GetIsPaused(this))  //判断当前动画是否暂停
                {
                    spinStoryboard.Resume(this);  //这些方法都需要包含“故事板”的对象引用。通过this给故事板传送对窗口的引用
                }
                else
                {
                    spinStoryboard.Pause(this);
                }
            }
        }
    }
}
