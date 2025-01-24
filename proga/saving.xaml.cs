using System.Windows;
using System.Windows.Controls;

namespace proga;

public partial class saving : Page
{
    public saving() => InitializeComponent();
    private void GraphicsUpdate() => this.DataContext = methods.GraphicUpdate();
    Methods methods = new Methods(3);
    private void RetirementAccountChangeText(object sender, TextChangedEventArgs e)
    {
        methods.DifferenseUpdate(ref RetirementAccountPlane, ref RetirementAccountFact, ref RetirementAccountDifference,
             ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference,0,"RetirementAccount");
        GraphicsUpdate();
    }
    private void InvestmentAccountChangeText(object sender, TextChangedEventArgs e)
    {
        methods.DifferenseUpdate(ref InvestmentAccountPlane, ref InvestmentAccountFact, ref InvestmentAccountDifference,
             ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference,1,"InvestmentAccount");
        GraphicsUpdate();
    }
    private void OtherChangeText(object sender, TextChangedEventArgs e)
    {
       methods.DifferenseUpdate(ref OtherPlane, ref OtherFact, ref OtherDifference,  ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference,2,"Other");
       GraphicsUpdate();
    }
    private void Saving_OnLoaded(object sender, RoutedEventArgs e)
    {
        methods.dbName = "saves";
        if (methods.db.GetEntireTable(4, out methods.data, methods.dbName))
        {
            TextBoxSubTotalPlane.Text = methods.SubtotalPlane.ToString();
            TextBoxSubTotalFact.Text = methods.SubtotalFact.ToString();
            TextBoxSubTotalDifference.Text = methods.SubTotalDifference.ToString();
            methods.TextBoxAnd_OldValuesUpdate(ref RetirementAccountPlane, ref RetirementAccountFact, ref RetirementAccountDifference,0);
            methods.TextBoxAnd_OldValuesUpdate(ref InvestmentAccountPlane, ref InvestmentAccountFact, ref InvestmentAccountDifference, 1);
            methods.TextBoxAnd_OldValuesUpdate(ref OtherPlane, ref OtherFact, ref OtherDifference, 2);
            GraphicsUpdate();
        }
    }
}