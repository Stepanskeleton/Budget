using System.Windows;
using System.Windows.Controls;
namespace proga;
public partial class LegalExpenses : Page
{
    public LegalExpenses()
    {
        InitializeComponent();
    }
    Methods methods = new Methods(4);
    private void AdvocateChangeText(object sender, TextChangedEventArgs e)
    {
       methods.DifferenseUpdate(ref AdvocatePlane, ref AdvocateFact, ref AdvocateDifference,  ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference,0,"Advocate");
       GraphicsUpdate();
    }
    private void AlimonyChangeText(object sender, TextChangedEventArgs e)
    {
       methods.DifferenseUpdate(ref AlimonyPlane, ref AlimonyFact, ref AlimonyDifference,  ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference,1, "Alimony");
       GraphicsUpdate();
    }
    private void TaxesChangeText(object sender, TextChangedEventArgs e)
    {
       methods.DifferenseUpdate(ref TaxesPlane, ref TaxesFact, ref TaxesDifference, ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TaxesDifference,2, "Taxes");
       GraphicsUpdate();
    }
    private void OtherChangeText(object sender, TextChangedEventArgs e)
    {
       methods.DifferenseUpdate(ref OtherPlane, ref OtherFact, ref OtherDifference, ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference,3, "Other");
       GraphicsUpdate();
    }
    private void GraphicsUpdate()
    {
        this.DataContext = methods.GraphicUpdate();
    }
    private void LegalExpenses_OnLoaded(object sender, RoutedEventArgs e)
    {
        methods.dbName = "LegalExpenses";
        if (methods.db.GetEntireTable(4, out methods.data, methods.dbName))
        {
            TextBoxSubTotalPlane.Text = methods.SubtotalPlane.ToString();
            TextBoxSubTotalFact.Text = methods.SubtotalFact.ToString();
            TextBoxSubTotalDifference.Text = methods.SubTotalDifference.ToString();
            methods.TextBoxAnd_OldValuesUpdate(ref AdvocatePlane, ref AdvocateFact, ref AdvocateDifference, 0);
            methods.TextBoxAnd_OldValuesUpdate(ref AlimonyPlane, ref AlimonyFact, ref AlimonyDifference, 1);
            methods.TextBoxAnd_OldValuesUpdate(ref TaxesPlane, ref TaxesFact, ref TaxesDifference, 2);
            methods.TextBoxAnd_OldValuesUpdate(ref OtherPlane, ref OtherFact, ref OtherDifference,3);
            GraphicsUpdate();
        }
    }
}