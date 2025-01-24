using System.Windows;
using System.Windows.Controls;
using  Microsoft.Data.Sqlite;
namespace proga;

public partial class Spendingbycategory : Page
{
    public Spendingbycategory() =>  InitializeComponent();
    
    Methods methods = new Methods();
    private void Spendingbycategory_OnLoaded(object sender, RoutedEventArgs e)
    {
        Exception? ex = null;
        //string[] tables_name =
       // {
            //, , , , , , ,
            //, ,,,
        //};
        string[] tables_name =
        {
            "HomeDB", "entertainment", "transport", "credits", "insurance", "food", "pets", "taxes", "saves",
            "gifts_and_donations", "PersonalHygiene", "LegalExpenses"
        };
        List<double[]> a = new List<double[]>();
        for (int i = 0; i < tables_name.Length; i++)
        {
            using (var connection = new SqliteConnection($"Data Source={Methods.way}"))
            {
                connection.Open();
                var row_command = $"SELECT * FROM {tables_name[i]} WHERE Name == 'TextBoxSubTotal'";
                var command = new SqliteCommand(row_command, connection);
                try
                {
                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                var value1 = Convert.ToDouble(reader.GetValue(1));
                                var value2 = Convert.ToDouble(reader.GetValue(2));
                                var value3 = Convert.ToDouble(reader.GetValue(3));
                                a.Add(new double[] { value1, value2, value3 });
                                // Process the value as needed
                            }
                            //a.Clear();
                        }
                    }
                }
                catch (Exception exception)
                {
                    ex = exception;
                    throw;
                }
            }
        }
        HomePlane.Text = a[0][0].ToString();
        HomeFact.Text = a[0][1].ToString();
        HomeDifference.Text = a[0][2].ToString();
        EntertainmentPlane.Text = a[1][0].ToString();
        EntertainmentFact.Text = a[1][1].ToString();
        EntertainmentDifference.Text = a[1][2].ToString();
        TransportPlane.Text = a[2][0].ToString();
        TransportFact.Text = a[2][1].ToString();
        TransportDifference.Text = a[2][2].ToString();
        CreditsPlane.Text = a[3][0].ToString();
        CreditsFact.Text = a[3][1].ToString();
        CreditsDifference.Text = a[3][2].ToString();
        InsurancePlane.Text = a[4][0].ToString();
        InsuranceFact.Text = a[4][1].ToString();
        InsuranceDifference.Text = a[4][2].ToString();
        FoodPlane.Text = a[5][0].ToString();
        FoodFact.Text = a[5][1].ToString();
        FoodDifference.Text = a[5][2].ToString();
        PetsPlane.Text = a[6][0].ToString();
        PetsFact.Text = a[6][1].ToString();
        PetsDifference.Text = a[6][2].ToString();
        TaxesPlane.Text = a[7][0].ToString();
        TaxesFact.Text = a[7][1].ToString();
        TaxesDifference.Text = a[7][2].ToString();
        SavingPlane.Text = a[8][0].ToString();
        SavingFact.Text = a[8][1].ToString();
        SavingDifference.Text = a[8][2].ToString();
        GiftsPlane.Text = a[9][0].ToString();
        GiftsFact.Text = a[9][1].ToString();
        GiftsDifference.Text = a[9][2].ToString();
        PersonalHygienePlane.Text = a[10][0].ToString();
        PersonalHygieneFact.Text = a[10][1].ToString();
        PersonalHygieneDifference.Text = a[10][2].ToString();
        LegalExperensesPlane.Text = a[11][0].ToString();
        LegalExperensesFact.Text = a[11][1].ToString();
        LegalExperensesDifference.Text = a[11][2].ToString();
        string[] Names = { "Жильё","Развлечения","Транспорт","Кредиты","Страхование","Еда","Питомцы","Налоги","Сбережения","Подарки","Гигиена","Юридические расходы" };
        List<double> values = new List<double>();
        for (int i = 0; i < a.Count; i++)
        {
            values.Add(a[i][1]);
        }
        this.DataContext = new ViewModelMainPage(values, Names);
    }
}