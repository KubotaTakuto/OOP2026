using System.Windows;
using AIWeather.Services;
using System.Globalization;

namespace AIWeather {
    public partial class MainWindow : Window {
        private readonly WeatherService _weatherService = new();
        private double _latitude = 35.6895;
        private double _longitude = 139.6917;

        public MainWindow() {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }

        private async void MainWindow_Loaded(object sender, RoutedEventArgs e) {
            var weather = await _weatherService.GetWeatherAsync(_latitude, _longitude);

            if (weather?.current != null) {
                TemperatureText.Text =
                    $"気温：{weather.current.temperature_2m:F1} ℃";

                WeatherText.Text =
                    $"天気：{GetWeatherDescription(weather.current.weather_code)}";

                HumidityText.Text =
                    $"湿度：{weather.current.relative_humidity_2m:F0} %";

                WindText.Text =
                    $"風速：{weather.current.wind_speed_10m:F1} m/s";

                ForecastList.Items.Clear();

                if (weather.daily?.time != null) {
                    for (int i = 0; i < weather.daily.time.Length; i++) {
                        ForecastList.Items.Add(
                            $"{FormatDate(weather.daily.time[i])}\n" +
                            $"天気：{GetWeatherDescription(weather.daily.weather_code[i])}\n" +
                            $"最高：{weather.daily.temperature_2m_max[i]:F1}℃\n" +
                            $"最低：{weather.daily.temperature_2m_min[i]:F1}℃\n" +
                            $"降水確率：{weather.daily.precipitation_probability_max[i]}%\n"
);
                    }
                }
            } else {
                TemperatureText.Text =
                    "天気情報の取得に失敗しました";
            }
        }

        private string GetWeatherDescription(int code) {
            return code switch {
                0 => "☀ 快晴",
                1 => "🌤 晴れ",
                2 => "⛅ 一部曇り",
                3 => "☁ 曇り",
                45 or 48 => "🌫 霧",
                51 or 53 or 55 => "🌦 霧雨",
                61 or 63 or 65 => "🌧 雨",
                71 or 73 or 75 => "❄ 雪",
                80 or 81 or 82 => "🌦 にわか雨",
                95 => "⛈ 雷雨",
                _ => "❓ 不明"
            };
        }

        private async void CityComboBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e) {
            if (CityComboBox.SelectedItem is not System.Windows.Controls.ComboBoxItem item)
                return;

            switch (item.Content.ToString()) {
                case "東京":
                    _latitude = 35.6895;
                    _longitude = 139.6917;
                    break;

                case "大阪":
                    _latitude = 34.6937;
                    _longitude = 135.5023;
                    break;

                case "名古屋":
                    _latitude = 35.1815;
                    _longitude = 136.9066;
                    break;

                case "福岡":
                    _latitude = 33.5902;
                    _longitude = 130.4017;
                    break;

                case "札幌":
                    _latitude = 43.0618;
                    _longitude = 141.3545;
                    break;
            }

            MainWindow_Loaded(this, new RoutedEventArgs());
        }

        private string FormatDate(string dateString) {
            DateTime date = DateTime.Parse(dateString);

            string[] week =
            {
        "日","月","火","水","木","金","土"
    };

            return $"{date.Month}/{date.Day}({week[(int)date.DayOfWeek]})";
        }
    }
}
