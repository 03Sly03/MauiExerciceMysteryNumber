namespace ExerciceQuizz;

public partial class MainQuizz : ContentPage
{
	public MainQuizz()
	{
		InitializeComponent();
	}

	public async void OnPushBeginClicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new Question1());
	}
}