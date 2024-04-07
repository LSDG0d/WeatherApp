using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using System.Xml;
using Newtonsoft.Json.Linq;
using WeatherApp.Data;
using WeatherApp.Models;

namespace WeatherApp
{
    public partial class MainForm : Form
    {
        List<Cities> cities = new List<Cities>();
        List<Forecast> forecasts = new List<Forecast>();
        private void LoadCitiesInList()
        {
            dataGridViewCities.Rows.Clear();
            cities = SqliteDataAccess.LoadCities();
            foreach (Cities city in cities)
            {
                dataGridViewCities.Rows.Add(city.id, city.Name, city.Country);
            }
        }
        private void LoadForecastInList()
        {
            dataGridViewForecast.Rows.Clear();
            forecasts = SqliteDataAccess.LoadForecast();
            foreach (Forecast forecast in forecasts)
            {
                dataGridViewForecast.Rows.Add(forecast.id, forecast.Cityid, forecast.DateFrom, forecast.DateTo, forecast.Temperature, forecast.Pressure);
            }
        }
        public MainForm()
        {
            InitializeComponent();
            LoadCitiesInList();
            LoadForecastInList();
            LoadCitiesInCombobox();
        }

        private void LoadCitiesInCombobox()
        {
            comboBoxCities.Items.Clear();
            foreach (Cities city in cities)
            {
                comboBoxCities.Items.Add(city.Name);
            }
            if (comboBoxCities.Items.Count > 0)
            {
                comboBoxCities.SelectedIndex = 0;
            }
        }
        private void buttonUpdateCities_Click(object sender, EventArgs e)
        {
            dataGridViewCities.Rows.Clear();
            LoadCitiesInList();
        }
        private async void buttonGetWeather_Click(object sender, EventArgs e)
        {
            string cityName = comboBoxCities.SelectedItem.ToString();
            Cities selectedCity = cities.FirstOrDefault(city => city.Name == cityName);
            if (selectedCity != null)
            {
                await WeatherService.GetWeatherForecast(selectedCity.Name, selectedCity.Country, selectedCity.id);
            }
            else
            {
                MessageBox.Show("Для ввода локации можете использовать первую панель.");
            }
            LoadForecastInList();
        }

        private void buttonUpdateForecast_Click(object sender, EventArgs e)
        {
            dataGridViewForecast.Rows.Clear();
            LoadForecastInList();
        }

        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            Cities city = new Cities();
            city.Name = textBoxNameCity.Text;
            city.Country = textBoxCountryCity.Text;
            SqliteDataAccess.SaveCities(city);
            LoadCitiesInList();
            LoadCitiesInCombobox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqliteDataAccess.DeleteForecastAll();
            dataGridViewForecast.Rows.Clear();
            forecasts.Clear();
            LoadForecastInList();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string searchDate = dateTimePickerSearchDate.Value.ToString("yyyy-MM-ddT") + dateTimePickerSearchTime.Text.ToString() + "Z";
            string cityName = comboBoxCities.SelectedItem.ToString();
            Cities selectedCity = cities.FirstOrDefault(city => city.Name == cityName);
            dataGridViewForecast.Rows.Clear();
            if (selectedCity != null && searchDate != null)
            {
                var searchResults = forecasts.Where(forecast => forecast.Cityid == selectedCity.id &&
                                                         forecast.DateFrom == searchDate &&
                                                         forecast.DateTo == searchDate).ToList();
                if (searchResults.Count > 0)
                {
                    foreach(var forecast in searchResults)
                    {
                        dataGridViewForecast.Rows.Add(forecast.id, forecast.Cityid, forecast.DateFrom, forecast.DateTo, forecast.Temperature, forecast.Pressure);
                    }
                }
                else
                {
                    MessageBox.Show("Результатов не найдено. Воспользуйтесь кнопкой Get");
                }
            }
        }

    }
}
