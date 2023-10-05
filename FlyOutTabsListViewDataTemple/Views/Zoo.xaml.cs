namespace FlyOutTabsListViewDataTemple.Views;

public partial class Zoo : ContentPage
{
	public Zoo()
	{
		InitializeComponent();
	}

	public async void OnMonkeysClicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new Monkeys());
	}
}