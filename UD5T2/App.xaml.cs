namespace UD5T2;
using UD5T2.MVVM.Views;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new BMIView();
	}
}
