using System.Windows;
using System.Windows.Controls;

namespace proga;

public partial class LegalExpenses : Page
{
    public LegalExpenses()
    {
        InitializeComponent();
    }
    public double SubtotalPlane = 0;
    public double SubtotalFact = 0;
    public double SubTotalDifference = 0;
    Methods methods = new Methods();
    public static string way = "C:\\projects C#\\proga\\BdOne.db";
   
    public double AdvocatePlaneOld = 0;
    public double AdvocateFactOld = 0;
    public double AdvocateDifferenceOld= 0;
    private void AdvocateChangeText(object sender, TextChangedEventArgs e)
    {
       methods.DifferenseUpdate(ref AdvocatePlane, ref AdvocateFact, ref AdvocateDifference, ref AdvocatePlaneOld, ref AdvocateFactOld, ref AdvocateDifferenceOld, ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference,0,"Advocate");
    }
    public double AlimonyPlaneOld = 0;
    public double AlimonyFactOld = 0;
    public double AlimonyDifferenceOld= 0;
    private void AlimonyChangeText(object sender, TextChangedEventArgs e)
    {
       methods.DifferenseUpdate(ref AlimonyPlane, ref AlimonyFact, ref AlimonyDifference, ref AlimonyPlaneOld, ref AlimonyFactOld, ref AlimonyDifferenceOld, ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference,1, "Alimony");
    }
    public double TaxesPlaneOld = 0;
    public double TaxesFactOld = 0;
    public double TaxesDifferenceOld= 0;
    private void TaxesChangeText(object sender, TextChangedEventArgs e)
    {
       methods.DifferenseUpdate(ref TaxesPlane, ref TaxesFact, ref TaxesDifference, ref TaxesPlaneOld, ref TaxesFactOld, ref TaxesDifferenceOld, ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TaxesDifference,2, "Taxes");
    }
    public double OtherPlaneOld = 0;
    public double OtherFactOld = 0;
    public double OtherDifferenceOld= 0;
    private void OtherChangeText(object sender, TextChangedEventArgs e)
    {
       methods.DifferenseUpdate(ref OtherPlane, ref OtherFact, ref OtherDifference, ref OtherPlaneOld, ref OtherFactOld, ref OtherDifferenceOld, ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference,3, "Other");
    }

    private void LegalExpenses_OnLoaded(object sender, RoutedEventArgs e)
    {
        methods.dbName = "LegalExpenses";
        if (methods.db.GetEntireTable(4, out methods.data, methods.dbName))
        {
            SubtotalPlane = Convert.ToDouble(methods.data[methods.data.Count - 1][1]);
            TextBoxSubTotalPlane.Text = SubtotalPlane.ToString();
            SubtotalFact = Convert.ToDouble(methods.data[methods.data.Count - 1][2]);
            TextBoxSubTotalFact.Text = SubtotalPlane.ToString();
            SubTotalDifference = Convert.ToDouble(methods.data[methods.data.Count - 1][3]);
            TextBoxSubTotalDifference.Text = SubTotalDifference.ToString();
            methods.TextBoxAnd_OldValuesUpdate(ref AdvocatePlane, ref AdvocateFact, ref AdvocateDifference, ref methods.data[0][1], ref methods.data[0][2], ref methods.data[0][3], ref AdvocatePlaneOld, ref AdvocateFactOld, ref AdvocateDifferenceOld);
            methods.TextBoxAnd_OldValuesUpdate(ref AlimonyPlane, ref AlimonyFact, ref AlimonyDifference, ref methods.data[1][1], ref methods.data[1][2], ref methods.data[1][3], ref AlimonyPlaneOld, ref AlimonyFactOld, ref AlimonyDifferenceOld);
            methods.TextBoxAnd_OldValuesUpdate(ref TaxesPlane, ref TaxesFact, ref TaxesDifference, ref methods.data[2][1], ref methods.data[2][2], ref methods.data[2][3], ref TaxesPlaneOld, ref TaxesFactOld, ref TaxesDifferenceOld);
            methods.TextBoxAnd_OldValuesUpdate(ref OtherPlane, ref OtherFact, ref OtherDifference, ref methods.data[3][1], ref methods.data[3][2], ref methods.data[3][3], ref OtherPlaneOld, ref OtherFactOld, ref OtherDifferenceOld);
        }
    }
}