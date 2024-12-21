using System.Windows;
using System.Windows.Controls;

namespace proga;

public partial class Pets : Page
{
    public Pets()
    {
        InitializeComponent();
    }
    public double SubtotalPlane = 0;
    public double SubtotalFact = 0;
    public double SubTotalDifference = 0;
    Methods methods = new Methods();
    public static string way = "C:\\projects C#\\proga\\BdOne.db";
    public double FoodPlaneOld = 0;
    public double FoodFactOld = 0;
    public double FoodDifferenceOld= 0;
    private void FoodChangeText(object sender, TextChangedEventArgs e)
    {
       methods.DifferenseUpdate(ref FoodPlane, ref FoodFact, ref FoodDifference, ref FoodPlaneOld, ref FoodFactOld, ref FoodDifferenceOld, ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference,0, "Food");
    }
    public double MedicinePlaneOld = 0;
    public double MedicineFactOld = 0;
    public double MedicineDifferenceOld= 0;
    private void MedicineChangeText(object sender, TextChangedEventArgs e)
    {
       methods.DifferenseUpdate(ref MedicinePlane, ref MedicineFact, ref MedicineDifference, ref MedicinePlaneOld, ref MedicineFactOld, ref MedicineDifferenceOld, ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference,1, "Medicine");
    }
    public double CarePlaneOld = 0;
    public double CareFactOld = 0;
    public double CareDifferenceOld= 0;
    private void CareChangeText(object sender, TextChangedEventArgs e)
    {
       methods.DifferenseUpdate(ref CarePlane, ref CareFact, ref CareDifference, ref CarePlaneOld, ref CareFactOld, ref CareDifferenceOld, ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference,2, "Care");
    }
    public double ToysPlaneOld = 0;
    public double ToysFactOld = 0;
    public double ToysDifferenceOld= 0;
    private void ToysChangeText(object sender, TextChangedEventArgs e)
    {
       methods.DifferenseUpdate(ref ToysPlane, ref ToysFact, ref ToysDifference, ref ToysPlaneOld, ref ToysFactOld, ref ToysDifferenceOld, ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference,3, "Toys");
    }
    public double OtherPlaneOld = 0;
    public double OtherFactOld = 0;
    public double OtherDifferenceOld= 0;
    private void OtherChangeText(object sender, TextChangedEventArgs e)
    {
       methods.DifferenseUpdate(ref OtherPlane, ref OtherFact, ref OtherDifference, ref OtherPlaneOld, ref OtherFactOld, ref OtherDifferenceOld, ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference,3, "Other");
    }

    private void Pets_OnLoaded(object sender, RoutedEventArgs e)
    {
       methods.dbName = "pets";
       if (methods.db.GetEntireTable(4, out methods.data, methods.dbName))
       {
          SubtotalPlane = Convert.ToDouble(methods.data[methods.data.Count - 1][1]);
          TextBoxSubTotalPlane.Text = SubtotalPlane.ToString();
          SubtotalFact = Convert.ToDouble(methods.data[methods.data.Count - 1][2]);
          TextBoxSubTotalFact.Text = SubtotalPlane.ToString();
          SubTotalDifference = Convert.ToDouble(methods.data[methods.data.Count - 1][3]);
          TextBoxSubTotalDifference.Text = SubTotalDifference.ToString();
          methods.TextBoxAnd_OldValuesUpdate(ref FoodPlane, ref FoodFact, ref FoodDifference, ref methods.data[0][1], ref methods.data[0][2],ref methods.data[0][3], ref FoodPlaneOld, ref FoodFactOld, ref FoodDifferenceOld);
          methods.TextBoxAnd_OldValuesUpdate(ref MedicinePlane, ref MedicineFact, ref MedicineDifference, ref methods.data[1][1], ref methods.data[1][2], ref methods.data[1][3], ref MedicinePlaneOld, ref MedicineFactOld, ref MedicineDifferenceOld);
          methods.TextBoxAnd_OldValuesUpdate(ref CarePlane, ref CareFact, ref CareDifference, ref methods.data[2][1], ref methods.data[2][2], ref methods.data[2][3], ref CarePlaneOld, ref CareFactOld, ref CareDifferenceOld );
          methods.TextBoxAnd_OldValuesUpdate(ref ToysPlane, ref ToysFact, ref ToysDifference, ref methods.data[3][1], ref methods.data[3][2], ref methods.data[3][3], ref ToysPlaneOld, ref ToysFactOld, ref ToysDifferenceOld);
          methods.TextBoxAnd_OldValuesUpdate(ref OtherPlane, ref OtherFact, ref OtherDifference, ref methods.data[4][1], ref methods.data[4][2], ref methods.data[4][3], ref OtherPlaneOld, ref OtherFactOld, ref OtherDifferenceOld);
       }
    }
}