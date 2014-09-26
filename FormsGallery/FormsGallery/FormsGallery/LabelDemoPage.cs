using System;
using Xamarin.Forms;

namespace FormsGallery
{
    class LabelDemoPage : ContentPage
    {
        public LabelDemoPage()
        {
            Label header = new Label
            {
                Text = "Label",
                Font = Font.BoldSystemFontOfSize(50),
                HorizontalOptions = LayoutOptions.Center

            };

            Label labelLB = new Label
            {
                Text =
                    "Xamarin.Forms is a cross-platform natively ",
				Font = Font.SystemFontOfSize(NamedSize.Large, FontAttributes.Bold),
                VerticalOptions = LayoutOptions.CenterAndExpand,
					TextColor = Color.Red
            };

			Label labelLI = new Label
			{
				Text =
					"Xamarin.Forms is a cross-platform natively ",
				Font = Font.SystemFontOfSize(NamedSize.Large, FontAttributes.Italic),
				VerticalOptions = LayoutOptions.CenterAndExpand,
				TextColor = Color.Blue
			};

			Label label = new Label
			{
				Text =
					"Xamarin.Forms is a cross-platform natively ",
				Font = Font.SystemFontOfSize(NamedSize.Large),
				VerticalOptions = LayoutOptions.CenterAndExpand,
				TextColor = Color.Yellow
			};

			Label labelM = new Label
			{
				Text =
					"Xamarin.Forms is a cross-platform natively ",
				Font = Font.SystemFontOfSize(NamedSize.Medium),
				VerticalOptions = LayoutOptions.CenterAndExpand,
				TextColor = Color.Gray
			};

			Label labelS = new Label
			{
				Text =
					"Xamarin.Forms is a cross-platform natively ",
				Font = Font.SystemFontOfSize(NamedSize.Small),
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
					labelLB,
					labelLI,
                    label,
					labelM,
					labelS
                }
            };
        }
    }
}
