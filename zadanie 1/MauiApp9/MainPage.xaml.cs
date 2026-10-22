using Microsoft.UI.Xaml.Automation.Peers;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Net.NetworkInformation;

namespace MauiApp9
{
    public partial class MainPage : ContentPage
    {
        ObservableCollection<string> oc = new();
        public MainPage()
        {
            InitializeComponent();

            kolekcja.ItemsSource = oc;
        }
        public void Onclicked(object sender, EventArgs e)
        {
            string ent = dupa.Text;
            if (!string.IsNullOrWhiteSpace(ent))
            {
                oc.Add(ent);
            } else
            {
                DisplayAlert("Error", "Brak wpisanego tekstu", "OK");
            }
        }

        public void deleteLastElement(object sender, EventArgs e)
        {
            oc.RemoveAt(oc.Count - 1);
        }

        public void clearCol(object sender, EventArgs e)
        {
            oc.Clear();
        }

        
    }
}