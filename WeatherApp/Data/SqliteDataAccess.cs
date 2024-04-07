using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Models;

namespace WeatherApp
{
    internal class SqliteDataAccess
    {
        public static List<Cities> LoadCities()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Cities>("select * from Cities", new DynamicParameters());
                return output.ToList();
            }
        }
        public static void SaveCities(Cities cities)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Cities (Name, Country) values (@Name, @Country)", cities);
            }
        }
        public static void DeleteForecastAll()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("delete from Forecast");
            }
        }
        public static List<Forecast> LoadForecast()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Forecast>("select * from Forecast", new DynamicParameters());
                return output.ToList();
            }
        }
        public static void SaveForecast(Forecast forecast)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Forecast (Cityid, DateFrom, DateTo, Temperature, Pressure) values (@Cityid, @DateFrom, @DateTo, @Temperature, @Pressure)", forecast);
            }
        }
        public static string LoadConnectionString(string id = "DefaultConnection")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
