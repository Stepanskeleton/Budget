using System.Windows;
using System.Windows.Controls;

namespace proga;

public partial class gifts_and_donations : Page
{
    public gifts_and_donations() => InitializeComponent();
    private void GraphicsUpdate() => this.DataContext = methods.GraphicUpdate();
    Methods methods = new Methods(3);
    private void Num1ChangeText(object sender, TextChangedEventArgs e)
    {
       methods.DifferenseUpdate(ref Num1Plane, ref Num1Fact, ref Num1Difference, ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference,0,"Num1");
       GraphicsUpdate();
    }
    private void Num2ChangeText(object sender, TextChangedEventArgs e)
    {
        methods.DifferenseUpdate(ref Num2Plane, ref Num2Fact, ref Num2Difference,  ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference,1,"Num2");
        GraphicsUpdate();
    }
    private void Num3ChangeText(object sender, TextChangedEventArgs e)
    {
        methods.DifferenseUpdate(ref Num3Plane, ref Num3Fact, ref Num3Difference,  ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference,2,"Num3");
        GraphicsUpdate();
    }
    private void Gifts_and_donations_OnLoaded(object sender, RoutedEventArgs e)
    {
        methods.dbName = "gifts_and_donations";
        if (methods.db.GetEntireTable(4, out methods.data, methods.dbName))
        {
            TextBoxSubTotalPlane.Text = methods.SubtotalPlane.ToString();
            TextBoxSubTotalFact.Text = methods.SubtotalFact.ToString();
            TextBoxSubTotalDifference.Text = methods.SubTotalDifference.ToString();
            methods.TextBoxAnd_OldValuesUpdate(ref Num1Plane, ref Num1Fact, ref Num1Difference,0);
            methods.TextBoxAnd_OldValuesUpdate(ref Num2Plane, ref Num2Fact, ref Num2Difference, 1);
            methods.TextBoxAnd_OldValuesUpdate(ref Num3Plane, ref Num3Fact, ref Num3Difference,2);
            GraphicsUpdate();
        }
    }
}