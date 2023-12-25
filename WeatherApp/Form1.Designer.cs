
namespace WeatherApp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.TemperatureLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.WindSpeedLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(316, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Подтвердить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите город:";
            // 
            // CityTextBox
            // 
            this.CityTextBox.Location = new System.Drawing.Point(156, 44);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(154, 30);
            this.CityTextBox.TabIndex = 2;
            // 
            // TemperatureLabel
            // 
            this.TemperatureLabel.AutoSize = true;
            this.TemperatureLabel.Location = new System.Drawing.Point(12, 150);
            this.TemperatureLabel.Name = "TemperatureLabel";
            this.TemperatureLabel.Size = new System.Drawing.Size(163, 22);
            this.TemperatureLabel.TabIndex = 3;
            this.TemperatureLabel.Text = "Температура: N/A";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(12, 172);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(140, 22);
            this.DescriptionLabel.TabIndex = 4;
            this.DescriptionLabel.Text = "Описание: N/A";
            // 
            // WindSpeedLabel
            // 
            this.WindSpeedLabel.AutoSize = true;
            this.WindSpeedLabel.Location = new System.Drawing.Point(12, 194);
            this.WindSpeedLabel.Name = "WindSpeedLabel";
            this.WindSpeedLabel.Size = new System.Drawing.Size(185, 22);
            this.WindSpeedLabel.TabIndex = 5;
            this.WindSpeedLabel.Text = "Скорость ветра: N/A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "Результат:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 548);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.WindSpeedLabel);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.TemperatureLabel);
            this.Controls.Add(this.CityTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "WeatherApp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CityTextBox;
        private System.Windows.Forms.Label TemperatureLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label WindSpeedLabel;
        private System.Windows.Forms.Label label5;
    }
}

