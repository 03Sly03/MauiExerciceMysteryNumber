namespace MauiDemo01;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell(); // AppShell -> Fournit une interface ulitlisateur de base ainsi que le nécessaire pour la navigation.
	}
}
