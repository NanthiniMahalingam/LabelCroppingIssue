namespace LabelCroppingIssue;

public partial class MainPage : ContentPage
{


	public MainPage()
	{
		InitializeComponent();
		Content = new VerticalStackLayout
		{
			WidthRequest = 350,
			Children =
			{
				new Label
				{
					BackgroundColor = Colors.Pink,
					Text="At any time, but not later than one month before the expiration date.",
					WidthRequest=100.94,
					FontSize = 16,
					AutomationId = "Label",
				}
			}
		};

	}


}

