using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TextBoxTest
{
    public partial class TextBoxTest : Form
    {
        public TextBoxTest()
        {
            InitializeComponent();
            this.buttonOK.Enabled = false;

            this.textBoxAddress.Tag = false;  //感觉是用tag作为一个恢复button标志位被使用
            this.textBoxAge.Tag = false;
            this.textBoxName.Tag = false;
            //this.textBoxOccupation.Tag = true;  //因为空着本来就是对的

            this.textBoxName.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxEmpty_Validating);
            this.textBoxAddress.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxEmpty_Validating);
            this.textBoxAge.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxEmpty_Validating);
            //this.textBoxOccupation.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxOccupation_Validating);

            this.textBoxName.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textBoxAddress.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textBoxAge.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            //this.textBoxOccupation.TextChanged += new System.EventHandler(this.textBox_TextChanged);
        }

        private void textBoxEmpty_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text.Length == 0)
            {
                tb.BackColor = Color.Red;
                tb.Tag = false;
            }
            else
            {
                tb.BackColor = System.Drawing.SystemColors.Window;
                tb.Tag = true;
            }
            ValidateOK();
        }

        private void textBoxOccupation_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text.CompareTo("Programmer") == 0 || tb.Text.Length == 0)
            {
                tb.Tag = true;
                tb.BackColor = System.Drawing.SystemColors.Window;
            }
            else
            {
                tb.Tag = false;
                tb.BackColor = Color.Red;
            }
            ValidateOK();
        }

        private void textBoxAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar >  57) && e.KeyChar != 8)  //跳过ASCII为8的退格键
                e.Handled = true;  //告诉控件不应对字符进行任何操作
        }

        private void textBox_TextChanged(object sender, System.EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            /*if (tb.Text.Length == 0 && tb != textBoxOccupation)
            {
                tb.Tag = false;
                tb.BackColor = Color.Red;
            }
            else if (tb == textBoxOccupation && (tb.Text.Length != 0 && tb.Text.CompareTo("Programmer") != 0))*/
            if (tb.Text.Length == 0)
            {
                tb.Tag = false;  //注意这里不让变为红色
            }
            else
            {
                tb.Tag = true;
                tb.BackColor = SystemColors.Window;
            }
            ValidateOK();
        }

        private void ValidateOK()
        {
            this.buttonOK.Enabled = ((bool)(this.textBoxAddress.Tag) && (bool)(this.textBoxAge.Tag) && (bool)(this.textBoxName.Tag));  // && (bool)(this.textBoxOccupation.Tag)
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            string output;
            output = "Name: " + this.textBoxName.Text + "\r\n";
            output += "Address: " + this.textBoxAddress.Text + "\r\n";
            //output += "Occupation: " + this.textBoxOccupation.Text + "\r\n";
            output += "Occupation: " + (string)(this.checkBoxProgrammer.Checked ? "Programmer" : "Not a programmer") + "\r\n";
            output += "Sex: " + (string)(this.radioButtonFemale.Checked ? "Female" : "Male") + "\r\n";
            output += "Age: " + this.textBoxAge.Text;
            this.textBoxOutput.Text = output;
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            string output;
            output = "Name = Your name\r\n";
            output += "Adress = Your adderss\r\n";
            //output += "Occupation = Only allowed valve is 'Programmer'\r\n";
            output += "Programmer = Check 'Programmer' if you are a programmer\r\n";
            output += "Sex = Choose your sex\r\n";
            output += "Age = Your age";
            this.textBoxOutput.Text = output;
        }
    }
}
