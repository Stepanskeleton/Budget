using System.Windows;
using System.Windows.Controls;

namespace proga;

public partial class credits : Page
{
    public credits()
    {
        InitializeComponent();
    }
    public double SubtotalPlane = 0;
    public double SubtotalFact = 0;
    public double SubTotalDifference = 0;
    Methods methods = new Methods();
    public static string way = "C:\\projects C#\\proga\\BdOne.db";
    public double PersonalExpensesPlaneOld = 0;
    public double PersonalExpensesFactOld = 0;
    public double PersonalExpensesDifferenceOld= 0;
    private void PersonalExpensesChangeText(object sender, TextChangedEventArgs e)
    {
       methods.DifferenseUpdate(ref PersonalExpensesPlane, ref PersonalExpensesFact, ref PersonalExpensesDifference, ref PersonalExpensesPlaneOld, ref PersonalExpensesFactOld, ref PersonalExpensesDifferenceOld, ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference, 0, "PersonalExpenses");
       GraphicsUpdate();
    }
    public double ForStudyPlaneOld = 0;
    public double ForStudyFactOld = 0;
    public double ForStudyDifferenceOld= 0;
    private void ForStudyChangeText(object sender, TextChangedEventArgs e)
    {
       methods.DifferenseUpdate(ref ForStudyPlane, ref ForStudyFact, ref ForStudyDifference, ref ForStudyPlaneOld, ref ForStudyFactOld, ref ForStudyDifferenceOld, ref TextBoxSubTotalPlane,ref TextBoxSubTotalFact,ref TextBoxSubTotalDifference, 1, "ForStudy");
       GraphicsUpdate();
    }
    public double CreditCard1PlaneOld = 0;
    public double CreditCard1FactOld = 0;
    public double CreditCard1DifferenceOld= 0;
    private void CreditCard1ChangeText(object sender, TextChangedEventArgs e)
    {
       methods.DifferenseUpdate(ref CreditCard1Plane,ref CreditCard1Fact, ref CreditCard1Difference, ref CreditCard1PlaneOld, ref CreditCard1FactOld, ref CreditCard1DifferenceOld,ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference, 2, "CreditCard1");
       GraphicsUpdate();
    }
    public double CreditCard2PlaneOld = 0;
    public double CreditCard2FactOld = 0;
    public double CreditCard2DifferenceOld= 0;
    private void CreditCard2ChangeText(object sender, TextChangedEventArgs e)
    {
        methods.DifferenseUpdate(ref CreditCard2Plane,ref CreditCard2Fact, ref CreditCard2Difference, ref CreditCard2PlaneOld, ref CreditCard2FactOld, ref CreditCard2DifferenceOld, ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference, 3, "CreditCard2");
        GraphicsUpdate();
    }
    public double CreditCard3PlaneOld = 0;
    public double CreditCard3FactOld = 0;
    public double CreditCard3DifferenceOld= 0;
    private void CreditCard3ChangeText(object sender, TextChangedEventArgs e)
    {
        methods.DifferenseUpdate(ref CreditCard3Plane,ref CreditCard3Fact, ref CreditCard3Difference, ref CreditCard3PlaneOld, ref CreditCard3FactOld, ref CreditCard3DifferenceOld, ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference, 4, "CreditCard3");
        GraphicsUpdate();
    }
    public double OtherPlaneOld = 0;
    public double OtherFactOld = 0;
    public double OtherDifferenceOld= 0;
    private void OtherChangeText(object sender, TextChangedEventArgs e)
    {
        methods.DifferenseUpdate(ref OtherPlane,ref OtherFact, ref OtherDifference, ref OtherPlaneOld, ref OtherFactOld, ref OtherDifferenceOld, ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference, 5, "Other");
        GraphicsUpdate();
    }
    private void GraphicsUpdate()
    {
        this.DataContext = methods.GraphicUpdate();
    }
    private void Credits_OnLoaded(object sender, RoutedEventArgs e)
    {
        methods.dbName = "credits";
        if (methods.db.GetEntireTable(4, out methods.data, methods.dbName))
        {
            SubtotalPlane = Convert.ToDouble(methods.data[methods.data.Count -1][1]);
        TextBoxSubTotalPlane.Text = SubtotalPlane.ToString();
        SubtotalFact = Convert.ToDouble(methods.data[methods.data.Count - 1][2]);
        TextBoxSubTotalFact.Text = SubtotalPlane.ToString();
        SubTotalDifference = Convert.ToDouble(methods.data[methods.data.Count -1 ][3]);
        TextBoxSubTotalDifference.Text = SubTotalDifference.ToString();
        methods.TextBoxAnd_OldValuesUpdate(ref PersonalExpensesPlane, ref PersonalExpensesFact, ref PersonalExpensesDifference, ref methods.data[0][1], ref methods. data[0][2], ref methods.data[0][3], ref PersonalExpensesPlaneOld, ref PersonalExpensesFactOld, ref PersonalExpensesDifferenceOld);
        methods.TextBoxAnd_OldValuesUpdate(ref ForStudyPlane, ref ForStudyFact, ref ForStudyDifference, ref methods.data[1][1], ref methods.data[1][2], ref methods.data[1][3], ref ForStudyPlaneOld, ref ForStudyFactOld, ref ForStudyDifferenceOld);
        methods.TextBoxAnd_OldValuesUpdate(ref CreditCard1Plane, ref CreditCard1Fact, ref CreditCard1Difference, ref methods.data[2][1], ref methods.data[2][2], ref methods.data[2][3], ref CreditCard1PlaneOld, ref CreditCard1FactOld, ref CreditCard1DifferenceOld);
        methods.TextBoxAnd_OldValuesUpdate(ref CreditCard2Plane, ref CreditCard2Fact, ref CreditCard2Difference, ref methods.data[3][1], ref methods.data[3][2], ref methods.data[3][3], ref CreditCard2PlaneOld, ref CreditCard2FactOld, ref CreditCard2DifferenceOld);
        methods.TextBoxAnd_OldValuesUpdate(ref CreditCard3Plane, ref CreditCard3Fact, ref CreditCard3Difference, ref methods.data[4][1], ref methods.data[4][2], ref methods.data[4][3], ref CreditCard3PlaneOld, ref CreditCard3FactOld, ref CreditCard3DifferenceOld);
        methods.TextBoxAnd_OldValuesUpdate(ref OtherPlane, ref OtherFact, ref OtherDifference, ref methods.data[5][1], ref methods.data[5][2], ref methods.data[5][3], ref OtherPlaneOld, ref OtherFactOld, ref OtherDifferenceOld);
        GraphicsUpdate();
        }

        
    }
}