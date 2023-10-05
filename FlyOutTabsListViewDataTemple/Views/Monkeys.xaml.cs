using FlyOutTabsListViewDataTemple.Models;
using System.Collections.ObjectModel;

namespace FlyOutTabsListViewDataTemple.Views;

public partial class Monkeys : ContentPage
{
    ObservableCollection<Monkey> myMonkeys = new ObservableCollection<Monkey>();
    public ObservableCollection<Monkey> MyMonkeys { get { return myMonkeys; } }

    public Monkeys()
	{
		InitializeComponent();
		MyMonkeys.Add(new Monkey(){ Name = "Singe", Location = "Jungle", Details = "Red monkey", ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/0/03/Alouatta_seniculus.jpg" });
        MyZooMonkeys.ItemsSource = myMonkeys;

    }
}