using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Abrak.Converters
{
    public class WeatherConditionToBackgroundConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
              

                if(value is string weatherCondition)
                {
                          weatherCondition = weatherCondition.ToLower();
                            if (weatherCondition.Contains("clear"))
                                  return "../Resources/Images/clear.jpg";
                            if (weatherCondition.Contains("rain"))
                                  return "../Resources/Images/rain.jpg";
                            if (weatherCondition.Contains("snow"))
                                  return "../Resources/Images/snowy.jpg";
                            if (weatherCondition.Contains("overcast"))
                                  return "../Resources/Images/overcast.jpg";
                            if (weatherCondition.Contains("Thundery"))
                                  return "../Resources/Images/Thundery.jpg";
                            if (weatherCondition.Contains("cloudy"))
                                  return "../Resources/Images/cloudy.jpg";
                            if (weatherCondition.Contains("mist") || weatherCondition.Contains("fog"))
                                  return "../Resources/Images/mist.jpg";
                }

            return "../Resources/Images/default.jpg";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // No need for ConvertBack in this case
            return null;
        }
    }
}
