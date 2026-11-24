namespace AIWeather.Models {
    public class WeatherData {
        public CurrentData? current { get; set; }

        public DailyData? daily { get; set; }
    }

    public class CurrentData {
        public double temperature_2m { get; set; }

        public double relative_humidity_2m { get; set; }

        public double wind_speed_10m { get; set; }

        public int weather_code { get; set; }
    }

    public class DailyData {
        public string[]? time { get; set; }

        public double[]? temperature_2m_max { get; set; }

        public double[]? temperature_2m_min { get; set; }

        public int[]? weather_code { get; set; }

        public int[]? precipitation_probability_max { get; set; }
    }
}
