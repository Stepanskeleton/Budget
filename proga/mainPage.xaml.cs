using System.Windows;
using System.Windows.Controls;
using  Microsoft.Data.Sqlite;
namespace proga;

public partial class mainPage : Page
{
    public mainPage()
    {
        InitializeComponent();
    }
    public string way = "C:\\projects C#\\proga\\BdOne.db";
    Methods methods = new Methods();
    bool startflag = false;
    private void PlaneIncomeUpdate(object sender, TextChangedEventArgs e)
    {
        bool flag = false;
        Exception? ex = null;
        double text1 = 0, text2 = 0;
        try
        {
            text1 = Convert.ToDouble(PlaneIncome1_tb.Text.ToString());
            text2 = Convert.ToDouble(PlaneadditionalIncome_tb.Text.ToString());
            flag = true;
        }
        catch (Exception exception)
        {
           ex = exception;
        }

        if (flag)
        {
            TotalIncome_tb.Text = (text1 + text2).ToString();
            methods.UpdateDB("Name", "Income1","Sum",(text1 + text2));
            methods.UpdateDB("Name", "Income1","Plane",text1);
            methods.UpdateDB("Name", "additionalIncome","Plane",text2);
            Text_box_Update();
        }
    }
    private void FactIncomeUpdate(object sender, TextChangedEventArgs e)
    {
        bool flag = false;
        Exception? ex = null;
        double text1 = 0, text2 = 0;
        try
        {
            text1 = Convert.ToDouble(FactIncome1_tb.Text.ToString());
            text2 = Convert.ToDouble(FactAdditionalIncome_tb.Text.ToString());
            flag = true;
            
        }
        catch (Exception exception)
        {
            ex = exception;
        }

        if (flag)
        {
            FactTotalIncome_tb.Text = (text1 + text2).ToString();
            methods.UpdateDB("Name", "additionalIncome","Sum",(text1 + text2));
            methods.UpdateDB("Name", "Income1","Fact",text1);
            methods.UpdateDB("Name", "additionalIncome","Fact",text2);
            Text_box_Update();
        }
    }
    
    private void Text_box_Update()
    {
        if (TotalIncome_tb.Text != null && TotalIncome_tb.Text !="" && FactTotalIncome_tb.Text != null && FactTotalIncome_tb.Text != "" && Difference.Text != null &&  Difference.Text != "" && PlaneIncome1_tb.Text != null && PlaneIncome1_tb.Text != "" && PlaneadditionalIncome_tb.Text != null && PlaneadditionalIncome_tb.Text != "" && FactIncome1_tb.Text != null && FactIncome1_tb.Text != "" && FactAdditionalIncome_tb != null && FactAdditionalIncome_tb.Text != "")
        {
             Exception? ex = null;
             double PlaneBalanceFromDB = 0;
             double FactBalanceFromDB = 0;
             double DifferenceFromDB = 0;
             string[] tables_name =
             {
                "credits", "entertainment", "food", "gifts_and_donations", "HomeDB", "insurance", "LegalExpenses",
                "PersonalHygiene", "pets", "saves", "taxes", "transport"
             };
             List<double> a = new List<double>();
             for (int i = 0; i < tables_name.Length; i++)
             {
                using (var connection = new SqliteConnection($"Data Source={way}"))
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
                                    a.Add(value1);
                                    a.Add(value2);
                                    a.Add(value3);
                                    // Process the value as needed
                                }

                                PlaneBalanceFromDB += a[0];
                                FactBalanceFromDB += a[1];
                                DifferenceFromDB += a[2];
                                a.Clear();
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        ex = e;
                        throw;
                    }
                }
             }
             PlannedBalance.Text = (-PlaneBalanceFromDB + Convert.ToDouble(TotalIncome_tb.Text)).ToString();
            FactBalance.Text = (-FactBalanceFromDB + Convert.ToDouble(FactTotalIncome_tb.Text)).ToString();
            Difference.Text = (Convert.ToDouble(PlannedBalance.Text) - Convert.ToDouble(FactBalance.Text)).ToString();
            GraphicUpdate();
        }
       
    }

    private void GraphicUpdate()
    {
        if (startflag == true)
        {
            List<double> values = new List<double>();
            values.Add(Convert.ToDouble( PlannedBalance.Text));
            values.Add(Convert.ToDouble(FactBalance.Text));
            values.Add(Convert.ToDouble( Difference.Text));
            this.DataContext = new ViewModelMainPage(values);
        }
        
    }
    private void MainPage_OnLoaded(object sender, RoutedEventArgs e)
    {
        methods.dbName = "Income";
        if (methods.db.GetEntireTable(4, out methods.data, methods.dbName))
        {
            PlaneIncome1_tb.Text = methods.data[0][1];
            FactIncome1_tb.Text = methods.data[0][2];
            TotalIncome_tb.Text = methods.data[0][3];
            PlaneadditionalIncome_tb.Text = methods.data[1][1];
            FactAdditionalIncome_tb.Text = methods.data[1][2];
            FactTotalIncome_tb.Text = methods.data[1][3];
            PlannedBalance.Text = methods.data[2][1];
            FactBalance.Text = methods.data[2][2];
            Difference.Text = methods.data[2][3];
            startflag = true;
            Text_box_Update();
            GraphicUpdate();
        }
    }
}