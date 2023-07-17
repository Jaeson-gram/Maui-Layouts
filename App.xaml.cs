namespace Layouts;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        //MainPage = new StackLayoutDemo();
        //MainPage = new VerticalStackLayoutDemo();
        //MainPage = new HorizontalStackLayoutDemo();
        //MainPage = new GridLayoutDemo();
        //MainPage = new AbsoluteLayoutDemo();

        MainPage = new FlexLayoutDemo();

        //Using the Horizontal or Vertical Stacklayout is better in performance than the StackLayout.
        //When you can be specific, pleas be.
    }
}
