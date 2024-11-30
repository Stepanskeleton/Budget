using System.Windows;
using System.Windows.Controls;

namespace proga;

public partial class mainPage : Page
{
    public mainPage()
    {
        InitializeComponent();
    }


    
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
        }
    }

    private void Text_box_Update()
    {
        
    }
}