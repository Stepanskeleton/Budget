using System.Windows;
using System.Windows.Controls;

namespace proga;

public partial class gifts_and_donations : Page
{
    public gifts_and_donations()
    {
        InitializeComponent();
    }
    public double SubtotalPlane = 0;
    public double SubtotalFact = 0;
    public double SubTotalDifference = 0;
    Methods methods = new Methods();
    public static string way = "C:\\projects C#\\proga\\BdOne.db";
    public double Num1PlaneOld = 0;
    public double Num1FactOld = 0;
    public double Num1DifferenceOld= 0;
    private void Num1ChangeText(object sender, TextChangedEventArgs e)
    {
       methods.DifferenseUpdate(ref Num1Plane, ref Num1Fact, ref Num1Difference, ref Num1PlaneOld, ref Num1FactOld, ref Num1DifferenceOld, ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference,0,"Num1");
    }
    public double Num2PlaneOld = 0;
    public double Num2FactOld = 0;
    public double Num2DifferenceOld= 0;
    private void Num2ChangeText(object sender, TextChangedEventArgs e)
    {
        methods.DifferenseUpdate(ref Num2Plane, ref Num2Fact, ref Num2Difference, ref Num2PlaneOld, ref Num2FactOld, ref Num2DifferenceOld, ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference,1,"Num2");
    }
    public double Num3PlaneOld = 0;
    public double Num3FactOld = 0;
    public double Num3DifferenceOld= 0;
    private void Num3ChangeText(object sender, TextChangedEventArgs e)
    {
        methods.DifferenseUpdate(ref Num3Plane, ref Num3Fact, ref Num3Difference, ref Num3PlaneOld, ref Num3FactOld, ref Num3DifferenceOld, ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference,2,"Num3");
    }
    
    private void Gifts_and_donations_OnLoaded(object sender, RoutedEventArgs e)
    {
        methods.dbName = "gifts_and_donations";
        if (methods.db.GetEntireTable(4, out methods.data, methods.dbName))
        {
            SubtotalPlane = Convert.ToDouble(methods.data[methods.data.Count - 1][1]);
            TextBoxSubTotalPlane.Text = SubtotalPlane.ToString();
            SubtotalFact = Convert.ToDouble(methods.data[methods.data.Count - 1][2]);
            TextBoxSubTotalFact.Text = SubtotalPlane.ToString();
            SubTotalDifference = Convert.ToDouble(methods.data[methods.data.Count - 1][3]);
            TextBoxSubTotalDifference.Text = SubTotalDifference.ToString();
            methods.TextBoxAnd_OldValuesUpdate(ref Num1Plane, ref Num1Fact, ref Num1Difference, ref methods.data[0][1], ref methods.data[0][2], ref methods.data[0][3], ref Num1PlaneOld, ref Num1FactOld, ref Num1DifferenceOld);
            methods.TextBoxAnd_OldValuesUpdate(ref Num2Plane, ref Num2Fact, ref Num2Difference, ref methods.data[1][1], ref methods.data[1][2], ref methods.data[1][3], ref Num2PlaneOld, ref Num2FactOld, ref Num2DifferenceOld);
            methods.TextBoxAnd_OldValuesUpdate(ref Num3Plane, ref Num3Fact, ref Num3Difference, ref methods.data[2][1], ref methods.data[2][2], ref methods.data[2][3], ref Num3PlaneOld, ref Num3FactOld, ref Num3DifferenceOld);
        }
    }
}