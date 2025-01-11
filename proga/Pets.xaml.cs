using System.Windows;
using System.Windows.Controls;

namespace proga;

public partial class Pets : Page
{
    public Pets() => InitializeComponent();
    private void GraphicsUpdate() => this.DataContext = methods.GraphicUpdate();
    Methods methods = new Methods(5);
    public static string way = "C:\\projects C#\\proga\\BdOne.db";
    private void FoodChangeText(object sender, TextChangedEventArgs e)
    {
       methods.DifferenseUpdate(ref FoodPlane, ref FoodFact, ref FoodDifference,  ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference,0, "Food");
       GraphicsUpdate();
    }
    private void MedicineChangeText(object sender, TextChangedEventArgs e)
    {
       methods.DifferenseUpdate(ref MedicinePlane, ref MedicineFact, ref MedicineDifference,  ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference,1, "Medicine");
       GraphicsUpdate();
    }
    private void CareChangeText(object sender, TextChangedEventArgs e)
    {
       methods.DifferenseUpdate(ref CarePlane, ref CareFact, ref CareDifference, ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference,2, "Care");
       GraphicsUpdate();
    }
    private void ToysChangeText(object sender, TextChangedEventArgs e)
    {
       methods.DifferenseUpdate(ref ToysPlane, ref ToysFact, ref ToysDifference,  ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference,3, "Toys");
       GraphicsUpdate();
    }
    private void OtherChangeText(object sender, TextChangedEventArgs e)
    {
       methods.DifferenseUpdate(ref OtherPlane, ref OtherFact, ref OtherDifference, ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference,4, "Other");
       GraphicsUpdate();
    }
    private void Pets_OnLoaded(object sender, RoutedEventArgs e)
    {
       methods.dbName = "pets";
       if (methods.db.GetEntireTable(4, out methods.data, methods.dbName))
       {
          TextBoxSubTotalPlane.Text = methods.SubtotalPlane.ToString();
          TextBoxSubTotalFact.Text = methods.SubtotalFact.ToString();
          TextBoxSubTotalDifference.Text = methods.SubTotalDifference.ToString();
          methods.TextBoxAnd_OldValuesUpdate(ref FoodPlane, ref FoodFact, ref FoodDifference,0);
          methods.TextBoxAnd_OldValuesUpdate(ref MedicinePlane, ref MedicineFact, ref MedicineDifference, 1);
          methods.TextBoxAnd_OldValuesUpdate(ref CarePlane, ref CareFact, ref CareDifference, 2);
          methods.TextBoxAnd_OldValuesUpdate(ref ToysPlane, ref ToysFact, ref ToysDifference, 3);
          methods.TextBoxAnd_OldValuesUpdate(ref OtherPlane, ref OtherFact, ref OtherDifference, 4);
          GraphicsUpdate();
       }
    }
}