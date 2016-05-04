using System;
using Xamarin.Forms;
using PropertyChanged;

namespace TestBindingWithGrid
{
	public class MyPage : ContentPage
	{
		public MyPage ()
		{

			StackLayout sl = new StackLayout ();
			sl.Padding = new Thickness (0, 20, 0, 0);

			Grid griglia = new Grid ();
			griglia.ColumnSpacing = 10;
			griglia.HorizontalOptions = LayoutOptions.FillAndExpand;
			griglia.VerticalOptions = LayoutOptions.FillAndExpand;
			RowDefinition rd1 = new RowDefinition ();
			rd1.Height = 80;
			rd1.BindingContext = App.Glob;
			rd1.SetBinding (RowDefinition.HeightProperty,"IsVisible", BindingMode.Default, new BoolHeightConverter());
			RowDefinition rd2 = new RowDefinition ();
			rd2.Height = 80;
			ColumnDefinition cdPosizione = new ColumnDefinition ();
			cdPosizione.Width = new GridLength (100, GridUnitType.Absolute);

			ColumnDefinition cdPallet = new ColumnDefinition ();
			cdPallet.Width = new GridLength(200, GridUnitType.Absolute);
			griglia.RowDefinitions.Add (rd1);
			griglia.RowDefinitions.Add (rd2);
			griglia.ColumnDefinitions.Add (cdPosizione);
			griglia.ColumnDefinitions.Add (cdPallet);
			App.Glob.IsVisible = true;
			Label l1 = new Label ();
			l1.Text = "LABEL1";
			l1.BindingContext = App.Glob;
			l1.SetBinding (VisualElement.IsVisibleProperty,"IsVisible");

			Label l2 = new Label ();
			l2.Text = "LABEL2";

			griglia.Children.Add(l1,0,1,0,1);
			griglia.Children.Add(l2,0,1,1,2);

			sl.Children.Add (griglia);

			Button b = new Button ();
			b.Text = "HIDE/SHOW";
			b.Clicked += (object sender, EventArgs e) => {

				App.Glob.IsVisible = !App.Glob.IsVisible;
			};

			sl.Children.Add (b);

			Content = sl;
		}
	}
}

