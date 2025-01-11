using System.Windows;
using System.Windows.Controls;

namespace proga;

public partial class insurance : Page
{
    public insurance() => InitializeComponent();
    private void GraphicsUpdate() => this.DataContext = methods.GraphicUpdate();
    Methods methods = new Methods(4);
    public static string way = "C:\\projects C#\\proga\\BdOne.db";
    private void HouseChangeText(object sender, TextChangedEventArgs e)
    {
       methods.DifferenseUpdate(ref HousePlane, ref HouseFact, ref HouseDifference, ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference, 0, "House");
       GraphicsUpdate();
    }
    private void HealthChangeText(object sender, TextChangedEventArgs e)
    {
       methods.DifferenseUpdate(ref HealthPlane, ref HealthFact, ref HealthDifference,  ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference, 1, "Health");
       GraphicsUpdate();
    }
    private void LifeChangeText(object sender, TextChangedEventArgs e)
    {
       methods.DifferenseUpdate(ref LifePlane, ref LifeFact, ref LifeDifference,  ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference,2, "Life");
       GraphicsUpdate();
    }
    private void OtherChangeText(object sender, TextChangedEventArgs e)
    {
       methods.DifferenseUpdate(ref OtherPlane, ref OtherFact, ref OtherDifference,  ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference,3, "Other");
       GraphicsUpdate();
    }
    private void Insurance_OnLoaded(object sender, RoutedEventArgs e)
    {
         methods.dbName = "insurance";
        if (methods.db.GetEntireTable(4, out methods.data, methods.dbName))
        {
            TextBoxSubTotalPlane.Text = methods.SubtotalPlane.ToString();
            TextBoxSubTotalFact.Text = methods.SubtotalFact.ToString();
            TextBoxSubTotalDifference.Text = methods.SubTotalDifference.ToString();
            methods.TextBoxAnd_OldValuesUpdate(ref HousePlane, ref HouseFact, ref HouseDifference, 0);
            methods.TextBoxAnd_OldValuesUpdate(ref HealthPlane, ref HealthFact, ref HealthDifference, 1);
            methods.TextBoxAnd_OldValuesUpdate(ref LifePlane, ref LifeFact, ref LifeDifference, 2);
            methods.TextBoxAnd_OldValuesUpdate(ref OtherPlane, ref OtherFact, ref OtherDifference,3);
            GraphicsUpdate();
        }
    }
}