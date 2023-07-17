namespace Layouts;

public partial class FlexLayoutDemo2 : ContentPage
{
	public FlexLayoutDemo2()
	{
		InitializeComponent();
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new FlexLayoutDemo());
	}
}