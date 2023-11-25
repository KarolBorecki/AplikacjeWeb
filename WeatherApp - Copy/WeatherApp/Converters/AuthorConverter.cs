using WeatherApp.Client.Models.Bookshelf;
namespace WeatherApp.Converters
{
	public class AuthorConverter : IMultiValueConverter
    {
        // TODO: Worst code I've ever done
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
            {
                if (values != null && values.Length == 2)
                {
                    if (values[0] == null || values[1] == null)
                        return null;
                    long idConv = Int64.Parse(values[0].ToString());
                    String nameConv = values[1].ToString();

                    return new Author { name = nameConv, id = idConv };
                }
                return null;
            }

            public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
            {
                throw new NotImplementedException();
            }
        }
    
}

