using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace proga;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        
    }
    double plane_mounth_income = 0, additional_income = 0, total_income = 0;
    
    private void MainPage_OnClick(object sender, RoutedEventArgs e)
    {
        Frame1.Source = new Uri("mainPage.xaml", UriKind.Relative);
    }

    private void Home_OnClick(object sender, RoutedEventArgs e)
    { 
        Frame1.Source = new Uri("Page2.xaml", UriKind.Relative);
    }

    private void Entertainment_OnClick(object sender, RoutedEventArgs e)
    {
        Frame1.Source = new Uri("entertainment.xaml", UriKind.Relative);
    }

    private void Transport_OnClick(object sender, RoutedEventArgs e)
    {
        Frame1.Source = new Uri("transport.xaml", UriKind.Relative);
    }

    private void Credit_OnClick(object sender, RoutedEventArgs e)
    {
        Frame1.Source = new Uri("credits.xaml", UriKind.Relative);
    }

    private void Insurance_OnClick(object sender, RoutedEventArgs e)
    {
        Frame1.Source = new Uri("insurance.xaml", UriKind.Relative);
    }

    private void Food_OnClick(object sender, RoutedEventArgs e)
    {
        Frame1.Source = new Uri("food.xaml", UriKind.Relative);
    }

    private void Pets_OnClick(object sender, RoutedEventArgs e)
    {
        Frame1.Source = new Uri("Pets.xaml", UriKind.Relative);
    }

    private void Taxes_OnClick(object sender, RoutedEventArgs e)
    {
        Frame1.Source = new Uri("taxes.xaml", UriKind.Relative);
    }

    private void SavingsAndInvestments_OnClick(object sender, RoutedEventArgs e)
    {
        Frame1.Source = new Uri("saving.xaml", UriKind.Relative);
    }

    private void GiftsAndDonations_OnClick(object sender, RoutedEventArgs e)
    {
        Frame1.Source = new Uri("gifts_and_donations.xaml", UriKind.Relative);
    }

    private void PersonalHygieneItems_OnClick(object sender, RoutedEventArgs e)
    {
        Frame1.Source = new Uri("PersonalHygiene.xaml", UriKind.Relative);
    }

    private void LegalExpenses_OnClick(object sender, RoutedEventArgs e)
    {
        Frame1.Source = new Uri("LegalExpenses.xaml", UriKind.Relative);
        
    }

    private void Spendingbycategory_OnClick(object sender, RoutedEventArgs e)
    {
        Frame1.Source = new Uri("Spendingbycategory.xaml", UriKind.Relative);
    }
}