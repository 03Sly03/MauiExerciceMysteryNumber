namespace FlyOutTabsListViewDataTemple
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public async void OnZooClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//Zoo");
        }
    }
}