using System;
using Xamarin.Forms;
using PropertyChanged;
using System.Globalization;

namespace TestBindingWithGrid
{
	public class BoolHeightConverter : IValueConverter
	{
		public object Convert (
			object value,
			Type targetType,
			object parameter,
			CultureInfo culture)
		{
			if (value != null && value is bool) {
				if ((bool)value)
					return 80;
				else
					return 0;
				//return !(bool)value;
			}
			else
				return 0;

		}

		public object ConvertBack (
			object value,
			Type targetType,
			object parameter,
			CultureInfo culture)
		{
			throw new Exception ("To be implemented");
		}
	}


}

