namespace ExerciceQuizz;

public partial class Question2 : ContentPage
{
	public Question2()
	{
		InitializeComponent();
	}

    public async void OnPushAnswerClicked(object sender, EventArgs e)
    {
        if (Answer.Text.ToLower() == "terminator 2")
        {
            await DisplayAlert("Alert", "C'est la bonne r�ponse", "Question Suivante");
            //await Navigation.PushAsync(new Question2());
        }
        else
        {
            await DisplayAlert("Alert", "C'est pas la bonne r�ponse", "Ok");
            await Navigation.PopToRootAsync();
        }
    }

}