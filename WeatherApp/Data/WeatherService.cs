using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using WeatherApp.Models;

namespace WeatherApp.Data
{
    public class WeatherService
    {
        internal static void ReplaceStringFormat(ref string lat, ref string lon)
        {
            int dotIndex = lat.IndexOf('.');
            lat = lat.Substring(0, dotIndex + 3);
            dotIndex = lon.IndexOf(".");
            lon = lon.Substring(0, dotIndex + 3);
        }
        internal static void ReplaceStringFormat(ref string doubleString)
        {
            int dotIndex = doubleString.IndexOf('.');
            doubleString = doubleString.Substring(0, dotIndex);
        }
        public static async Task GetWeatherForecast(string name, string country, int? CityId)
        {
            string geocodeUrl = $"https://nominatim.openstreetmap.org/search?q={name},{country}&format=xml";
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("User-Agent", "WeatherApp/0.1 (https://github.com/LSDG0d/WeatherApp/)");
                HttpResponseMessage response = await client.GetAsync(geocodeUrl);
                if (response.IsSuccessStatusCode)
                {
                    string geocodeXml = await response.Content.ReadAsStringAsync();
                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.LoadXml(geocodeXml);
                    XmlNodeList nodeList = xmlDoc.SelectNodes("//place");
                    if (nodeList.Count > 0)
                    {
                        XmlNode firstPlaceNode = nodeList[0];
                        string lat = Convert.ToString(firstPlaceNode.Attributes["lat"].Value);
                        string lon = Convert.ToString(firstPlaceNode.Attributes["lon"].Value);
                        ReplaceStringFormat(ref lat, ref lon);
                        HttpResponseMessage forecastResponse = await client.GetAsync($"https://api.met.no/weatherapi/locationforecast/2.0/classic?lat={lat}&lon={lon}");
                        if (forecastResponse.IsSuccessStatusCode)
                        {
                            string forecastXml = await forecastResponse.Content.ReadAsStringAsync();
                            List<Forecast> forecasts = ParseForecastXml(forecastXml, CityId);
                            foreach(Forecast forecast in forecasts)
                            {
                                SqliteDataAccess.SaveForecast(forecast);
                            }
                        }
                        else
                        {
                            MessageBox.Show($"Не удалось получить данные. Код статуса: {forecastResponse.StatusCode}");
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Не удалось получить данные. Код статуса: {response.StatusCode}");
                    }
                }
            }
        }

        private static List<Forecast> ParseForecastXml(string forecastXml, int? CityId)
        {
            List<Forecast> forecasts = new List<Forecast>();
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(forecastXml);
            XmlNodeList timeNodes = xmlDoc.SelectNodes("//time");
            if (timeNodes != null && timeNodes.Count > 0)
            {
                foreach (XmlNode timeNode in timeNodes)
                {
                    string from = timeNode.Attributes["from"].Value;
                    string to = timeNode.Attributes["to"].Value;
                    XmlNode temperatureNode = timeNode.SelectSingleNode("location/temperature");
                    int? temperature = null;
                    if (temperatureNode != null)
                    {
                        string temperatureValue = (temperatureNode.Attributes["value"].Value);
                        ReplaceStringFormat(ref temperatureValue);
                        temperature = int.Parse(temperatureValue);
                    }
                    XmlNode pressureNode = timeNode.SelectSingleNode("location/pressure");
                    int? pressure = null;
                    if (pressureNode != null)
                    {
                        string pressureValue = pressureNode.Attributes["value"].Value;
                        ReplaceStringFormat(ref pressureValue);
                        pressure = int.Parse(pressureValue);
                    }
                    Forecast forecast = new Forecast();
                    forecast.DateFrom = from;
                    forecast.DateTo = to;
                    forecast.Temperature = temperature;
                    forecast.Pressure = pressure;
                    forecast.Cityid = CityId;
                    forecasts.Add(forecast);
                }
                return forecasts;
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }
}
