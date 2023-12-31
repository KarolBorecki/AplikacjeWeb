﻿using System.Globalization;

namespace WeatherApp.Client.Converters
{
    internal class TemperatureToDisplayConverter : IValueConverter
    {
        private const  string _tempCode = "°C";
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is int || value is double)
                return $"{value}{_tempCode}";

            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {

            string temperatureString = value as string;
            if (temperatureString != null && int.TryParse(temperatureString.Replace(_tempCode, ""),out int temperature))
                return temperature;

            return value;
        }
    }
}
