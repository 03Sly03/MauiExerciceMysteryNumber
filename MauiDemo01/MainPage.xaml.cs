namespace MauiDemo01;

public partial class MainPage : ContentPage
{
    int coup;
    int nbmystere;

    public MainPage()
    {
        InitializeComponent();
        InitializeGame();
    }

    private void IsTheMysteryNumber(object sender, EventArgs e)
    {
        if (PlayBtn.Text == "Jouer")
        {
            MoreOrLess.IsVisible = false;
            coup++;
            int nbchoix = int.Parse(NbChoice.Text);
            if (nbchoix == nbmystere)
            {
                WinOrLooseText($"Vous avez gagnez ! Vous avez trouvé en {coup} coup(s)");
            }
            else if (coup > 4)
            {
                WinOrLooseText("Oh nooon ! Vous avez perdu !");
            }
            else if (nbchoix > nbmystere)
            {
                MoreOrLess.IsVisible = true;
                MoreOrLess.Text = $"le nombre mystère est plus petit. Il vous reste {5 - coup} coups";
            }
            else if (nbchoix < nbmystere)
            {
                MoreOrLess.IsVisible = true;
                MoreOrLess.Text = $"le nombre mystère est plus grand. Il vous reste {5 - coup} coups";
            }
        }
        else
        {
            InitializeGame();
        }
        NbChoice.Text = "";
    }

    private void InitializeGame()
    {
        coup = 0;
        nbmystere = new Random().Next(1, 51);
        NbToFind.Text = "Le nombre mystère à trouver est : " + nbmystere.ToString();
        NbChoice.IsEnabled = true;
        Congratulation.IsVisible = false;
        MoreOrLess.IsVisible = false;
        PlayBtn.Text = "Jouer";
        NbChoice.Text = "";
    }

    private void WinOrLooseText(string text)
    {
        NbChoice.IsEnabled = false;
        MoreOrLess.Text = "";
        MoreOrLess.IsVisible = false;
        Congratulation.IsVisible = true;
        Congratulation.Text = text;
        PlayBtn.Text = "Rejouer";
    }
}

