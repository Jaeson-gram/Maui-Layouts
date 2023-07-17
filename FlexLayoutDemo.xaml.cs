namespace Layouts;

public partial class FlexLayoutDemo : ContentPage
{
	public FlexLayoutDemo()
	{
		InitializeComponent();
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new FlexLayoutDemo2());
	}
}