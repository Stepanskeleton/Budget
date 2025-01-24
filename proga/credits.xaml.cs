using System.Windows;
using System.Windows.Controls;

namespace proga;

public partial class credits : Page
{
    public credits() => InitializeComponent();
    private void GraphicsUpdate() => this.DataContext = methods.GraphicUpdate();
    Methods methods = new Methods(6);
    private void PersonalExpensesChangeText(object sender, TextChangedEventArgs e)
    {
       methods.DifferenseUpdate(ref PersonalExpensesPlane, ref PersonalExpensesFact, ref PersonalExpensesDifference,  ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference, 0, "PersonalExpenses");
       GraphicsUpdate();
    }
    private void ForStudyChangeText(object sender, TextChangedEventArgs e)
    {
       methods.DifferenseUpdate(ref ForStudyPlane, ref ForStudyFact, ref ForStudyDifference,  ref TextBoxSubTotalPlane,ref TextBoxSubTotalFact,ref TextBoxSubTotalDifference, 1, "ForStudy");
       GraphicsUpdate();
    }
    private void CreditCard1ChangeText(object sender, TextChangedEventArgs e)
    {
       methods.DifferenseUpdate(ref CreditCard1Plane,ref CreditCard1Fact, ref CreditCard1Difference,ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference, 2, "CreditCard1");
       GraphicsUpdate();
    }
    private void CreditCard2ChangeText(object sender, TextChangedEventArgs e)
    {
        methods.DifferenseUpdate(ref CreditCard2Plane,ref CreditCard2Fact, ref CreditCard2Difference, ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference, 3, "CreditCard2");
        GraphicsUpdate();
    }
    private void CreditCard3ChangeText(object sender, TextChangedEventArgs e)
    {
        methods.DifferenseUpdate(ref CreditCard3Plane,ref CreditCard3Fact, ref CreditCard3Difference,  ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference, 4, "CreditCard3");
        GraphicsUpdate();
    }
    private void OtherChangeText(object sender, TextChangedEventArgs e)
    {
        methods.DifferenseUpdate(ref OtherPlane,ref OtherFact, ref OtherDifference, ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference, 5, "Other");
        GraphicsUpdate();
    }
    private void Credits_OnLoaded(object sender, RoutedEventArgs e)
    {
        methods.dbName = "credits";
        if (methods.db.GetEntireTable(4, out methods.data, methods.dbName))
        { 
            TextBoxSubTotalPlane.Text = methods.SubtotalPlane.ToString();
            TextBoxSubTotalFact.Text = methods.SubtotalFact.ToString();
            TextBoxSubTotalDifference.Text = methods.SubTotalDifference.ToString();
        methods.TextBoxAnd_OldValuesUpdate(ref PersonalExpensesPlane, ref PersonalExpensesFact, ref PersonalExpensesDifference, 0);
        methods.TextBoxAnd_OldValuesUpdate(ref ForStudyPlane, ref ForStudyFact, ref ForStudyDifference,1);
        methods.TextBoxAnd_OldValuesUpdate(ref CreditCard1Plane, ref CreditCard1Fact, ref CreditCard1Difference,2);
        methods.TextBoxAnd_OldValuesUpdate(ref CreditCard2Plane, ref CreditCard2Fact, ref CreditCard2Difference, 3);
        methods.TextBoxAnd_OldValuesUpdate(ref CreditCard3Plane, ref CreditCard3Fact, ref CreditCard3Difference, 4);
        methods.TextBoxAnd_OldValuesUpdate(ref OtherPlane, ref OtherFact, ref OtherDifference, 5);
        GraphicsUpdate();
        }
    }
}