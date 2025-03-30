using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace Abrak.Converters;

    public class FavoriteColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (bool)value ? Brushes.Gold : Brushes.LightGray; // Gold for favorite, gray otherwise
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value.Equals(Brushes.Gold);
        }
    }

