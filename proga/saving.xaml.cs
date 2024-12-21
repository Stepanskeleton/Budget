using System.Windows;
using System.Windows.Controls;

namespace proga;

public partial class saving : Page
{
    public saving()
    {
        InitializeComponent();
    }
    Methods methods = new Methods();
    public static string way = "C:\\projects C#\\proga\\BdOne.db";
    public double SubtotalPlane = 0;
    public double SubtotalFact = 0;
    public double SubTotalDifference = 0;
    public double RetirementAccountPlaneOld = 0;
    public double RetirementAccountFactOld = 0;
    public double RetirementAccountDifferenceOld = 0;

    private void RetirementAccountChangeText(object sender, TextChangedEventArgs e)
    {
        methods.DifferenseUpdate(ref RetirementAccountPlane, ref RetirementAccountFact, ref RetirementAccountDifference,
            ref RetirementAccountPlaneOld, ref RetirementAccountFactOld, ref RetirementAccountDifferenceOld, ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference,0,"RetirementAccount");
    }

    public double InvestmentAccountPlaneOld = 0;
    public double InvestmentAccountFactOld = 0;
    public double InvestmentAccountDifferenceOld = 0;

    private void InvestmentAccountChangeText(object sender, TextChangedEventArgs e)
    {
        methods.DifferenseUpdate(ref InvestmentAccountPlane, ref InvestmentAccountFact, ref InvestmentAccountDifference,
            ref InvestmentAccountPlaneOld, ref InvestmentAccountFactOld, ref InvestmentAccountDifferenceOld, ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference,1,"InvestmentAccount");
        
    }
    public double OtherPlaneOld = 0;
    public double OtherFactOld = 0;
    public double OtherDifferenceOld= 0;
    private void OtherChangeText(object sender, TextChangedEventArgs e)
    {
       methods.DifferenseUpdate(ref OtherPlane, ref OtherFact, ref OtherDifference, ref OtherPlaneOld, ref OtherFactOld, ref OtherDifferenceOld, ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference,2,"Other");
    }

    private void Saving_OnLoaded(object sender, RoutedEventArgs e)
    {
        methods.dbName = "saves";
        if (methods.db.GetEntireTable(4, out methods.data, methods.dbName))
        {
            SubtotalPlane = Convert.ToDouble(methods.data[methods.data.Count - 1][1]);
            TextBoxSubTotalPlane.Text = SubtotalPlane.ToString();
            SubtotalFact = Convert.ToDouble(methods.data[methods.data.Count - 1][2]);
            TextBoxSubTotalFact.Text = SubtotalPlane.ToString();
            SubTotalDifference = Convert.ToDouble(methods.data[methods.data.Count - 1][3]);
            TextBoxSubTotalDifference.Text = SubTotalDifference.ToString();
            methods.TextBoxAnd_OldValuesUpdate(ref RetirementAccountPlane, ref RetirementAccountFact, ref RetirementAccountDifference,ref methods.data[0][1],ref methods.data[0][2],ref methods.data[0][3], ref RetirementAccountPlaneOld, ref RetirementAccountFactOld, ref RetirementAccountDifferenceOld);
            methods.TextBoxAnd_OldValuesUpdate(ref InvestmentAccountPlane, ref InvestmentAccountFact, ref InvestmentAccountDifference, ref methods.data[1][1], ref methods.data[1][2], ref methods.data[1][3], ref InvestmentAccountPlaneOld,ref InvestmentAccountFactOld, ref InvestmentAccountDifferenceOld);
            methods.TextBoxAnd_OldValuesUpdate(ref OtherPlane, ref OtherFact, ref OtherDifference, ref methods.data[2][1],ref methods.data[2][2],ref methods.data[2][3], ref OtherPlaneOld, ref OtherFactOld, ref OtherFactOld);
        }
    }
}