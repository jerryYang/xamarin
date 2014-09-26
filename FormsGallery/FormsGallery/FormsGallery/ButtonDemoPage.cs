using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class ButtonDemoPage : ContentPage
    {
        Label label;
        int clickTotal = 0;

        public ButtonDemoPage()
        {
            Label header = new Label
            {
                Text = "Button",
				Font = Font.SystemFontOfSize(50, FontAttributes.Bold),
                HorizontalOptions = LayoutOptions.Center
            };

            Button buttonBold = new Button
            {
                Text = "89 / B",
				Font = Font.SystemFontOfSize(NamedSize.Large, FontAttributes.Bold),
                BorderWidth = 1,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
			buttonBold.Clicked += OnButtonClicked;


			Button button = new Button
			{
				Text = "89 / B",
				Font = Font.SystemFontOfSize(NamedSize.Large),
				BorderWidth = 1,
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.CenterAndExpand
			};
			button.Clicked += OnButtonClicked;

			Button buttonItalic = new Button
			{
				Text = "89 / B",
				Font = Font.SystemFontOfSize(NamedSize.Large, FontAttributes.Italic),
				BorderWidth = 1,
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.CenterAndExpand
			};
			buttonItalic.Clicked += OnButtonClicked;

            label = new Label
            {
                Text = "0 button clicks",
				Font = Font.SystemFontOfSize(NamedSize.Large, FontAttributes.Italic),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            // Accomodate iPhone status bar.
            this.Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);

            // Build the page.
            this.Content = new StackLayout
            {
                Children = 
                {
                    header,
                    button,
					buttonBold,
					buttonItalic,
                    label
                }
            };
        }

        void OnButtonClicked(object sender, EventArgs e)
        {
            clickTotal += 1;
            label.Text = String.Format("{0} button click{1}",
                                       clickTotal, clickTotal == 1 ? "" : "s");
        }
    }
}
