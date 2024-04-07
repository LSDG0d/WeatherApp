
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBoxCountryCity = new System.Windows.Forms.TextBox();
            this.textBoxNameCity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddNew = new System.Windows.Forms.Button();
            this.buttonUpdateCities = new System.Windows.Forms.Button();
            this.dataGridViewCities = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dateTimePickerSearchDate = new System.Windows.Forms.DateTimePicker();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonGetWeather = new System.Windows.Forms.Button();
            this.comboBoxCities = new System.Windows.Forms.ComboBox();
            this.buttonUpdateForecast = new System.Windows.Forms.Button();
            this.dataGridViewForecast = new System.Windows.Forms.DataGridView();
            this.ColumnId_Forecast = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCityId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDateFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDateTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTemperature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPressure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePickerSearchTime = new System.Windows.Forms.DateTimePicker();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCities)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewForecast)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(883, 417);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBoxCountryCity);
            this.tabPage1.Controls.Add(this.textBoxNameCity);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.buttonAddNew);
            this.tabPage1.Controls.Add(this.buttonUpdateCities);
            this.tabPage1.Controls.Add(this.dataGridViewCities);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(875, 385);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cities";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBoxCountryCity
            // 
            this.textBoxCountryCity.Location = new System.Drawing.Point(74, 286);
            this.textBoxCountryCity.Name = "textBoxCountryCity";
            this.textBoxCountryCity.Size = new System.Drawing.Size(175, 26);
            this.textBoxCountryCity.TabIndex = 6;
            // 
            // textBoxNameCity
            // 
            this.textBoxNameCity.Location = new System.Drawing.Point(74, 254);
            this.textBoxNameCity.Name = "textBoxNameCity";
            this.textBoxNameCity.Size = new System.Drawing.Size(175, 26);
            this.textBoxNameCity.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Country:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name:";
            // 
            // buttonAddNew
            // 
            this.buttonAddNew.Location = new System.Drawing.Point(139, 318);
            this.buttonAddNew.Name = "buttonAddNew";
            this.buttonAddNew.Size = new System.Drawing.Size(110, 50);
            this.buttonAddNew.TabIndex = 2;
            this.buttonAddNew.Text = "Add new";
            this.buttonAddNew.UseVisualStyleBackColor = true;
            this.buttonAddNew.Click += new System.EventHandler(this.buttonAddNew_Click);
            // 
            // buttonUpdateCities
            // 
            this.buttonUpdateCities.Location = new System.Drawing.Point(14, 318);
            this.buttonUpdateCities.Name = "buttonUpdateCities";
            this.buttonUpdateCities.Size = new System.Drawing.Size(110, 50);
            this.buttonUpdateCities.TabIndex = 1;
            this.buttonUpdateCities.Text = "Update";
            this.buttonUpdateCities.UseVisualStyleBackColor = true;
            this.buttonUpdateCities.Click += new System.EventHandler(this.buttonUpdateCities_Click);
            // 
            // dataGridViewCities
            // 
            this.dataGridViewCities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCities.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnName,
            this.ColumnCountry});
            this.dataGridViewCities.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewCities.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewCities.Name = "dataGridViewCities";
            this.dataGridViewCities.RowHeadersWidth = 51;
            this.dataGridViewCities.RowTemplate.Height = 24;
            this.dataGridViewCities.Size = new System.Drawing.Size(869, 245);
            this.dataGridViewCities.TabIndex = 0;
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "id";
            this.ColumnId.MinimumWidth = 6;
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            this.ColumnId.Width = 125;
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Name";
            this.ColumnName.MinimumWidth = 6;
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            this.ColumnName.Width = 125;
            // 
            // ColumnCountry
            // 
            this.ColumnCountry.HeaderText = "Country";
            this.ColumnCountry.MinimumWidth = 6;
            this.ColumnCountry.Name = "ColumnCountry";
            this.ColumnCountry.ReadOnly = true;
            this.ColumnCountry.Width = 125;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dateTimePickerSearchTime);
            this.tabPage2.Controls.Add(this.dateTimePickerSearchDate);
            this.tabPage2.Controls.Add(this.buttonSearch);
            this.tabPage2.Controls.Add(this.buttonDelete);
            this.tabPage2.Controls.Add(this.buttonGetWeather);
            this.tabPage2.Controls.Add(this.comboBoxCities);
            this.tabPage2.Controls.Add(this.buttonUpdateForecast);
            this.tabPage2.Controls.Add(this.dataGridViewForecast);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(875, 385);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Forecast";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerSearchDate
            // 
            this.dateTimePickerSearchDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerSearchDate.Location = new System.Drawing.Point(240, 287);
            this.dateTimePickerSearchDate.Name = "dateTimePickerSearchDate";
            this.dateTimePickerSearchDate.Size = new System.Drawing.Size(175, 26);
            this.dateTimePickerSearchDate.TabIndex = 7;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(124, 310);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(110, 50);
            this.buttonSearch.TabIndex = 6;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(8, 310);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(110, 50);
            this.buttonDelete.TabIndex = 5;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonGetWeather
            // 
            this.buttonGetWeather.Location = new System.Drawing.Point(124, 254);
            this.buttonGetWeather.Name = "buttonGetWeather";
            this.buttonGetWeather.Size = new System.Drawing.Size(110, 50);
            this.buttonGetWeather.TabIndex = 4;
            this.buttonGetWeather.Text = "Get";
            this.buttonGetWeather.UseVisualStyleBackColor = true;
            this.buttonGetWeather.Click += new System.EventHandler(this.buttonGetWeather_Click);
            // 
            // comboBoxCities
            // 
            this.comboBoxCities.FormattingEnabled = true;
            this.comboBoxCities.Location = new System.Drawing.Point(240, 254);
            this.comboBoxCities.Name = "comboBoxCities";
            this.comboBoxCities.Size = new System.Drawing.Size(175, 27);
            this.comboBoxCities.TabIndex = 3;
            // 
            // buttonUpdateForecast
            // 
            this.buttonUpdateForecast.Location = new System.Drawing.Point(8, 254);
            this.buttonUpdateForecast.Name = "buttonUpdateForecast";
            this.buttonUpdateForecast.Size = new System.Drawing.Size(110, 50);
            this.buttonUpdateForecast.TabIndex = 2;
            this.buttonUpdateForecast.Text = "Update";
            this.buttonUpdateForecast.UseVisualStyleBackColor = true;
            this.buttonUpdateForecast.Click += new System.EventHandler(this.buttonUpdateForecast_Click);
            // 
            // dataGridViewForecast
            // 
            this.dataGridViewForecast.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewForecast.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId_Forecast,
            this.ColumnCityId,
            this.ColumnDateFrom,
            this.ColumnDateTo,
            this.ColumnTemperature,
            this.ColumnPressure});
            this.dataGridViewForecast.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewForecast.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewForecast.Name = "dataGridViewForecast";
            this.dataGridViewForecast.RowHeadersWidth = 51;
            this.dataGridViewForecast.RowTemplate.Height = 24;
            this.dataGridViewForecast.Size = new System.Drawing.Size(869, 245);
            this.dataGridViewForecast.TabIndex = 1;
            // 
            // ColumnId_Forecast
            // 
            this.ColumnId_Forecast.HeaderText = "id";
            this.ColumnId_Forecast.MinimumWidth = 6;
            this.ColumnId_Forecast.Name = "ColumnId_Forecast";
            this.ColumnId_Forecast.ReadOnly = true;
            this.ColumnId_Forecast.Width = 125;
            // 
            // ColumnCityId
            // 
            this.ColumnCityId.HeaderText = "CityId";
            this.ColumnCityId.MinimumWidth = 6;
            this.ColumnCityId.Name = "ColumnCityId";
            this.ColumnCityId.ReadOnly = true;
            this.ColumnCityId.Width = 125;
            // 
            // ColumnDateFrom
            // 
            this.ColumnDateFrom.HeaderText = "DateFrom";
            this.ColumnDateFrom.MinimumWidth = 6;
            this.ColumnDateFrom.Name = "ColumnDateFrom";
            this.ColumnDateFrom.ReadOnly = true;
            this.ColumnDateFrom.Width = 125;
            // 
            // ColumnDateTo
            // 
            this.ColumnDateTo.HeaderText = "DateTo";
            this.ColumnDateTo.MinimumWidth = 6;
            this.ColumnDateTo.Name = "ColumnDateTo";
            this.ColumnDateTo.ReadOnly = true;
            this.ColumnDateTo.Width = 125;
            // 
            // ColumnTemperature
            // 
            this.ColumnTemperature.HeaderText = "Temperature";
            this.ColumnTemperature.MinimumWidth = 6;
            this.ColumnTemperature.Name = "ColumnTemperature";
            this.ColumnTemperature.ReadOnly = true;
            this.ColumnTemperature.Width = 125;
            // 
            // ColumnPressure
            // 
            this.ColumnPressure.HeaderText = "Pressure";
            this.ColumnPressure.MinimumWidth = 6;
            this.ColumnPressure.Name = "ColumnPressure";
            this.ColumnPressure.ReadOnly = true;
            this.ColumnPressure.Width = 125;
            // 
            // dateTimePickerSearchTime
            // 
            this.dateTimePickerSearchTime.CustomFormat = "HH:00:00";
            this.dateTimePickerSearchTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerSearchTime.Location = new System.Drawing.Point(240, 320);
            this.dateTimePickerSearchTime.Name = "dateTimePickerSearchTime";
            this.dateTimePickerSearchTime.ShowUpDown = true;
            this.dateTimePickerSearchTime.Size = new System.Drawing.Size(175, 26);
            this.dateTimePickerSearchTime.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 417);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "WeatherApp";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCities)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewForecast)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridViewCities;
        private System.Windows.Forms.DataGridView dataGridViewForecast;
        private System.Windows.Forms.Button buttonUpdateCities;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId_Forecast;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCityId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDateFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDateTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTemperature;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPressure;
        private System.Windows.Forms.Button buttonUpdateForecast;
        private System.Windows.Forms.ComboBox comboBoxCities;
        private System.Windows.Forms.Button buttonGetWeather;
        private System.Windows.Forms.Button buttonAddNew;
        private System.Windows.Forms.TextBox textBoxCountryCity;
        private System.Windows.Forms.TextBox textBoxNameCity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.DateTimePicker dateTimePickerSearchDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerSearchTime;
    }
}

