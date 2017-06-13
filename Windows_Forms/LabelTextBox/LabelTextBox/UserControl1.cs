using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LabelTextBox
{
    public partial class ctLabelTextbox : UserControl
    {
        //定义一个属性Position，枚举两个可能的位置
        public enum PositionEnum
        { 
            Right,
            Below
        }

        //将保存用户所选的成员字段
        private PositionEnum mPosition = PositionEnum.Right;  //位置属性，定义右侧还是下方
        private int mTextboxMargin = 0;  //定义距离
        private string mLabelText = "";

        //用event声明一个EventHandler委托来定义一个允许用户订阅的事件
        public event System.EventHandler PositionChanged;

        public ctLabelTextbox()
        {
            InitializeComponent();
        }

        //添加Position属性
        public PositionEnum Position
        {
            get
            {
                return mPosition;
            }
            set
            {
                mPosition = value;
                MoveControls();
                if (PositionChanged != null)  //引发PositionChanged事件代码
                {
                    PositionChanged(this, new EventArgs());
                }
            }
        }

        //添加TextboxMargin属性
        public int TextboxMargin
        {
            get
            {
                return mTextboxMargin;
            }
            set
            {
                mTextboxMargin = value;
                MoveControls();
            }
        }

        //添加Label属性
        public string LabelText
        {
            get
            {
                return mLabelText;
            }
            set
            {
                mLabelText = value;
                lblTextBox.Text = mLabelText;
                MoveControls();
            }
        }

        //添加TextboxText属性
        public string TextboxText
        {
            get
            {
                return txtLabelText.Text;
            }
            set
            {
                txtLabelText.Text = value;
            }
        }

        //Load事件，把该控件移动到窗体上时，初始化控件和该控件使用的所有资源
        private void ctLabelTextbox_Load(object sender, EventArgs e)
        {
            lblTextBox.Text = this.Name;
            this.Height = txtLabelText.Height > lblTextBox.Height ? txtLabelText.Height : lblTextBox.Height;
            MoveControls();
        }

        //SizeChanged事件，当改变控件大小时让控件正确地绘制自己
        private void ctLabelTextbox_SizeChanged(object sender, EventArgs e)
        {
            MoveControls();
        }

        //移动控制，设置两个控件的位置关系，用户控件的高度
        private void MoveControls()
        {
            switch (mPosition)
            { 
                case PositionEnum.Below:
                    this.txtLabelText.Top = this.lblTextBox.Bottom;
                    this.txtLabelText.Left = this.lblTextBox.Left;
                    this.txtLabelText.Width = this.Width;
                    this.Height = txtLabelText.Height + lblTextBox.Height;
                    break;
                case PositionEnum.Right:
                    txtLabelText.Top = lblTextBox.Top;
                    if (mTextboxMargin == 0)
                    {
                        int width = this.Width - lblTextBox.Width - 3;
                        txtLabelText.Left = lblTextBox.Right + 3;
                        txtLabelText.Width = width;
                    }
                    else
                    {
                        txtLabelText.Left = mTextboxMargin;
                        txtLabelText.Width = this.Width - mTextboxMargin;
                    }
                    this.Height = txtLabelText.Height > lblTextBox.Height ? txtLabelText.Height : lblTextBox.Height;
                    break;
            }
        }

        //三个按键事件，处理文本框所引发的事件
        private void ctLabelTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            OnKeyDown(e);
        }

        private void ctLabelTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnKeyPress(e);
        }

        private void ctLabelTextbox_KeyUp(object sender, KeyEventArgs e)
        {
            OnKeyUp(e);
        }
    }
}
