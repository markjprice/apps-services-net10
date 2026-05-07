using Avalonia.Data.Converters; // To use IValueConverter.
using Avalonia.Media.Imaging; // To use Bitmap.
using Avalonia.Platform; // To use AssetLoader.
using System; // To use Uri and Type.
using System.Globalization; // To use CultureInfo.

namespace Northwind.DesktopApp.ViewModels
{
    internal class CategoryIdToBitmapConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
                if (value == null)

                    return new Bitmap(AssetLoader.Open(new Uri($"avares://Northwind.DesktopApp/Assets/categories-small.jpeg")));

                var categoryId = (int)value;

                return new Bitmap(AssetLoader.Open(new Uri($"avares://Northwind.DesktopApp/Assets/category{categoryId}-small.jpeg")));
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
