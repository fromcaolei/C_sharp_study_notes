namespace WeatherClient
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonCelsius = new System.Windows.Forms.RadioButton();
            this.radioButtonFahrenheit = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonGetWeather = new System.Windows.Forms.Button();
            this.textTemperature = new System.Windows.Forms.TextBox();
            this.textWeatherCondition = new System.Windows.Forms.TextBox();
            this.textCity = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.radioButtonCelsius);
            this.groupBox1.Controls.Add(this.radioButtonFahrenheit);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 99);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Temperature Type";
            // 
            // radioButtonCelsius
            // 
            this.radioButtonCelsius.AutoSize = true;
            this.radioButtonCelsius.Location = new System.Drawing.Point(36, 29);
            this.radioButtonCelsius.Name = "radioButtonCelsius";
            this.radioButtonCelsius.Size = new System.Drawing.Size(65, 16);
            this.radioButtonCelsius.TabIndex = 1;
            this.radioButtonCelsius.TabStop = true;
            this.radioButtonCelsius.Text = "Celsius";
            this.radioButtonCelsius.UseVisualStyleBackColor = true;
            // 
            // radioButtonFahrenheit
            // 
            this.radioButtonFahrenheit.AutoSize = true;
            this.radioButtonFahrenheit.Location = new System.Drawing.Point(36, 60);
            this.radioButtonFahrenheit.Name = "radioButtonFahrenheit";
            this.radioButtonFahrenheit.Size = new System.Drawing.Size(83, 16);
            this.radioButtonFahrenheit.TabIndex = 2;
            this.radioButtonFahrenheit.TabStop = true;
            this.radioButtonFahrenheit.Text = "Fahrenheit";
            this.radioButtonFahrenheit.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "City";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Weather Condition:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "Temperature:";
            // 
            // buttonGetWeather
            // 
            this.buttonGetWeather.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonGetWeather.Location = new System.Drawing.Point(12, 138);
            this.buttonGetWeather.Name = "buttonGetWeather";
            this.buttonGetWeather.Size = new System.Drawing.Size(87, 23);
            this.buttonGetWeather.TabIndex = 4;
            this.buttonGetWeather.Text = "Get Weather";
            this.buttonGetWeather.UseVisualStyleBackColor = true;
            this.buttonGetWeather.Click += new System.EventHandler(this.buttonGetWeather_Click);
            // 
            // textTemperature
            // 
            this.textTemperature.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textTemperature.Location = new System.Drawing.Point(216, 234);
            this.textTemperature.Name = "textTemperature";
            this.textTemperature.Size = new System.Drawing.Size(142, 21);
            this.textTemperature.TabIndex = 5;
            // 
            // textWeatherCondition
            // 
            this.textWeatherCondition.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textWeatherCondition.Location = new System.Drawing.Point(216, 188);
            this.textWeatherCondition.Name = "textWeatherCondition";
            this.textWeatherCondition.Size = new System.Drawing.Size(142, 21);
            this.textWeatherCondition.TabIndex = 6;
            // 
            // textCity
            // 
            this.textCity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textCity.Location = new System.Drawing.Point(216, 71);
            this.textCity.Name = "textCity";
            this.textCity.Size = new System.Drawing.Size(142, 21);
            this.textCity.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 282);
            this.Controls.Add(this.textCity);
            this.Controls.Add(this.textWeatherCondition);
            this.Controls.Add(this.textTemperature);
            this.Controls.Add(this.buttonGetWeather);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Weather Client";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonCelsius;
        private System.Windows.Forms.RadioButton radioButtonFahrenheit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonGetWeather;
        private System.Windows.Forms.TextBox textTemperature;
        private System.Windows.Forms.TextBox textWeatherCondition;
        private System.Windows.Forms.TextBox textCity;
    }
}

