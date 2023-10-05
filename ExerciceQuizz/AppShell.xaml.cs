namespace ExerciceQuizz
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
        }

        public async void OnHelpClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Page d'aide", "Bah y'a pas d'aide", "Retour");
        }
    }
}