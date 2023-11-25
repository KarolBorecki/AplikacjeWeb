using WeatherApp.Client.Models.Bookshelf;
namespace WeatherApp.Converters
{
	public class BookConverter : IMultiValueConverter
    {
        // TODO: Worst code I've ever done
            public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
            {
                if (values != null && values.Length == 3)
                {
                    if (values[0] == null || values[1] == null || values[2] == null)
                        return null;
                    long idConv = Int64.Parse(values[0].ToString());
                    long authorIdConv = Int64.Parse(values[1].ToString());
                    String nameConv = values[2].ToString();


                return new Book { name = nameConv, id = idConv, authorId = authorIdConv };
                }
                return null;
            }

            public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
            {
                throw new NotImplementedException();
            }
        }
    
}

