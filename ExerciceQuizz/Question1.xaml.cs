using ExerciceQuizz.ViewModels;

namespace ExerciceQuizz;

public partial class Question1 : ContentPage
{
	public Question1()
	{
		InitializeComponent();
        BindingContext = new QuestionViewModel(DisplayAlert);
        if (IsGoodAnswer.Text == "True")
            Navigation.PushAsync(new Question2());
    }
    //public async void OnPushAnswerClicked(object sender, EventArgs e)
    //{
    //    if (Answer.Text != "" || Answer.Text != null)
    //    {
    //        if (Answer.Text.ToLower() == "les goonies")
    //        {
    //            await DisplayAlert("Alert", "C'est la bonne réponse", "Question Suivante");
    //            await Navigation.PushAsync(new Question2());
    //        }
    //        else
    //        {
    //            await DisplayAlert("Alert", "C'est pas la bonne réponse", "Ok");
    //            await Navigation.PopToRootAsync();
    //        }
    //    }
    //}
}