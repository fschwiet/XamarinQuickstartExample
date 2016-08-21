using System;

using Xamarin.Forms;

namespace QuickstartExample
{
	public class MainPage : ContentPage
	{
		public MainPage()
		{
			Padding = new Thickness(20);
			Device.OnPlatform(() => this.Padding = new Thickness(20, 40, 20, 20));

			var phoneNumberTextEntry = new Entry
			{
				Text = "1-855-XAMARIN"
			};

			var translateButton = new Button { Text = "Translate" };
			translateButton.Clicked += (sender, e) => { };

			var callButton = new Button { Text = "Call", IsEnabled = false };
			callButton.Clicked += (sender, e) => { };

			Content = new StackLayout
			{
				VerticalOptions = new LayoutOptions(LayoutAlignment.Fill, true),
				HorizontalOptions = new LayoutOptions(LayoutAlignment.Fill, true),
				Orientation = StackOrientation.Vertical,
				Spacing = 15,
				Children = {
					new Label { Text = "Enter a phoneword:" },
					phoneNumberTextEntry,
					translateButton,
					callButton

				}
			};
		}
	}
}


