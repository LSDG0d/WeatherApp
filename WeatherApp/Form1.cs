using System;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace WeatherApp
{
    public partial class MainForm : Form
    {
        // Ключ API для OpenWeatherMap
        private const string ApiKey = "ff88341c4cf15808a85ef21762d0845f";

        // URL для получения данных о текущей погоде
        private const string ApiUrl = "https://api.openweathermap.org/data/2.5/weather";

        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Получаем название города из текстового поля
            string city = CityTextBox.Text;
            if (string.IsNullOrEmpty(city))
            {
                MessageBox.Show("Введите название города");
                return;
            }

            // Формируем URL для запроса к OpenWeatherMap API
            string apiUrl = $"{ApiUrl}?q={city}&units=metric&appid={ApiKey}";

            try
            {
                // Отправляем запрос и получаем ответ
                string response = MakeApiRequest(apiUrl);

                // Парсим ответ для получения данных о погоде
                WeatherData weatherData = ParseWeatherData(response);

                // Выводим информацию о погоде в Label
                TemperatureLabel.Text = "Температура: " + weatherData.Temperature.ToString();
                DescriptionLabel.Text = "Описание: " + weatherData.Description.ToString();
                WindSpeedLabel.Text = "Скорость ветра: " + weatherData.WindSpeed.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        // Метод для отправки HTTP-запроса и получения ответа в виде строки
        private string MakeApiRequest(string apiUrl)
        {
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(apiUrl);
            using (HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse())
            using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
            {
                return streamReader.ReadToEnd();
            }
        }

        // Метод для парсинга JSON-данных о погоде
        private WeatherData ParseWeatherData(string json)
        {
            var data = JObject.Parse(json);
            double temperature = data["main"]["temp"].Value<double>();
            string description = data["weather"][0]["description"].Value<string>();
            double windSpeed = data["wind"]["speed"].Value<double>();

            return new WeatherData
            {
                Temperature = temperature,
                Description = description,
                WindSpeed = windSpeed
            };
        }
    }

    // Класс для хранения данных о погоде
    public class WeatherData
    {
        public double Temperature { get; set; }
        public string Description { get; set; }
        public double WindSpeed { get; set; }
    }
}
