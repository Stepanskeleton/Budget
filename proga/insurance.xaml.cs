using System.Windows;
using System.Windows.Controls;

namespace proga;

public partial class insurance : Page
{
    public insurance()
    {
        InitializeComponent();
    }
    public double SubtotalPlane = 0;
    public double SubtotalFact = 0;
    public double SubTotalDifference = 0;
    Methods methods = new Methods();
    public static string way = "C:\\projects C#\\proga\\BdOne.db";
    public double HousePlaneOld = 0;
    public double HouseFactOld = 0;
    public double HouseDifferenceOld= 0;
    private void HouseChangeText(object sender, TextChangedEventArgs e)
    {
       methods.DifferenseUpdate(ref HousePlane, ref HouseFact, ref HouseDifference, ref HousePlaneOld, ref HouseFactOld, ref HouseDifferenceOld, ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference, 0, "House");
    }
    public double HealthPlaneOld = 0;
    public double HealthFactOld = 0;
    public double HealthDifferenceOld= 0;
    private void HealthChangeText(object sender, TextChangedEventArgs e)
    {
       methods.DifferenseUpdate(ref HealthPlane, ref HealthFact, ref HealthDifference, ref HealthPlaneOld, ref HealthFactOld, ref HealthDifferenceOld, ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference, 1, "Health");
    }
    public double LifePlaneOld = 0;
    public double LifeFactOld = 0;
    public double LifeDifferenceOld= 0;
    private void LifeChangeText(object sender, TextChangedEventArgs e)
    {
       methods.DifferenseUpdate(ref LifePlane, ref LifeFact, ref LifeDifference, ref LifePlaneOld, ref LifeFactOld, ref LifeDifferenceOld, ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference,2, "Life");
    }
    public double OtherPlaneOld = 0;
    public double OtherFactOld = 0;
    public double OtherDifferenceOld= 0;
    private void OtherChangeText(object sender, TextChangedEventArgs e)
    {
       methods.DifferenseUpdate(ref OtherPlane, ref OtherFact, ref OtherDifference, ref OtherPlaneOld, ref OtherFactOld, ref OtherDifferenceOld, ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference,3, "Other");
    }

    private void Insurance_OnLoaded(object sender, RoutedEventArgs e)
    {
         methods.dbName = "insurance";
        if (methods.db.GetEntireTable(4, out methods.data, methods.dbName))
        {
            SubtotalPlane = Convert.ToDouble(methods.data[methods.data.Count -1][1]);
            TextBoxSubTotalPlane.Text = SubtotalPlane.ToString();
            SubtotalFact = Convert.ToDouble(methods.data[methods.data.Count - 1][2]);
            TextBoxSubTotalFact.Text = SubtotalPlane.ToString();
            SubTotalDifference = Convert.ToDouble(methods.data[methods.data.Count -1 ][3]);
            TextBoxSubTotalDifference.Text = SubTotalDifference.ToString();
            methods.TextBoxAnd_OldValuesUpdate(ref HousePlane, ref HouseFact, ref HouseDifference, ref methods.data[0][1], ref methods.data[0][2], ref methods.data[0][3],ref HousePlaneOld,ref HouseFactOld,ref HouseDifferenceOld);
            methods.TextBoxAnd_OldValuesUpdate(ref HealthPlane, ref HealthFact, ref HealthDifference, ref methods.data[1][1], ref methods.data[1][2], ref methods.data[1][3],ref HealthPlaneOld,ref HealthFactOld,ref HealthDifferenceOld);
            methods.TextBoxAnd_OldValuesUpdate(ref LifePlane, ref LifeFact, ref LifeDifference, ref methods.data[2][1], ref methods.data[2][2], ref methods.data[2][3],ref LifePlaneOld,ref LifeFactOld,ref LifeDifferenceOld);
            methods.TextBoxAnd_OldValuesUpdate(ref OtherPlane, ref OtherFact, ref OtherDifference, ref methods.data[3][1],ref methods.data[3][2], ref methods.data[3][3],ref OtherPlaneOld,ref OtherFactOld,ref OtherDifferenceOld);
            
        }
    }
}