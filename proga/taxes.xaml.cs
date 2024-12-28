using System.Windows;
using System.Windows.Controls;

namespace proga;

public partial class taxes : Page
{
    public taxes()
    {
        InitializeComponent();
    }
    public double SubtotalPlane = 0;
    public double SubtotalFact = 0;
    public double SubTotalDifference = 0;
    Methods methods = new Methods();
    public static string way = "C:\\projects C#\\proga\\BdOne.db";
    public double FederationsPlaneOld = 0;
    public double FederationsFactOld = 0;
    public double FederationsDifferenceOld= 0;
    private void FederationsChangeText(object sender, TextChangedEventArgs e)
    {
       methods.DifferenseUpdate(ref FederationsPlane, ref FederationsFact, ref FederationsDifference, ref FederationsPlaneOld, ref FederationsFactOld, ref FederationsDifferenceOld, ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference,0, "Federations");
       GraphicsUpdate();
    }
    public double StatesPlaneOld = 0;
    public double StatesFactOld = 0;
    public double StatesDifferenceOld= 0;
    private void StatesChangeText(object sender, TextChangedEventArgs e)
    {
       methods.DifferenseUpdate(ref StatesPlane, ref StatesFact, ref StatesDifference, ref StatesPlaneOld, ref StatesFactOld, ref StatesDifferenceOld, ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference,1, "States");
       GraphicsUpdate();
    }
    public double LocalPlaneOld = 0;
    public double LocalFactOld = 0;
    public double LocalDifferenceOld= 0;
    private void LocalChangeText(object sender, TextChangedEventArgs e)
    {
       methods.DifferenseUpdate(ref LocalPlane, ref LocalFact, ref LocalDifference, ref LocalPlaneOld, ref LocalFactOld, ref LocalDifferenceOld, ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference,2, "Local");
       GraphicsUpdate();
    }
    public double OtherPlaneOld = 0;
    public double OtherFactOld = 0;
    public double OtherDifferenceOld= 0;
    private void OtherChangeText(object sender, TextChangedEventArgs e)
    {
       methods.DifferenseUpdate(ref OtherPlane, ref OtherFact, ref OtherDifference, ref OtherPlaneOld, ref OtherFactOld, ref OtherDifferenceOld, ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference,3, "Other");
       GraphicsUpdate();
    }
    private void GraphicsUpdate()
    {
       this.DataContext = methods.GraphicUpdate();
    }
    private void Taxes_OnLoaded(object sender, RoutedEventArgs e)
    {
       methods.dbName = "taxes";
       if (methods.db.GetEntireTable(4, out methods.data, methods.dbName))
       {
          SubtotalPlane = Convert.ToDouble(methods.data[methods.data.Count - 1][1]);
          TextBoxSubTotalPlane.Text = SubtotalPlane.ToString();
          SubtotalFact = Convert.ToDouble(methods.data[methods.data.Count - 1][2]);
          TextBoxSubTotalFact.Text = SubtotalPlane.ToString();
          SubTotalDifference = Convert.ToDouble(methods.data[methods.data.Count - 1][3]);
          TextBoxSubTotalDifference.Text = SubTotalDifference.ToString();
          methods.TextBoxAnd_OldValuesUpdate(ref FederationsPlane, ref FederationsFact, ref FederationsDifference, ref methods.data[0][1], ref methods.data[0][2], ref methods.data[0][3], ref FederationsPlaneOld, ref FederationsFactOld, ref FederationsDifferenceOld);
          methods.TextBoxAnd_OldValuesUpdate(ref StatesPlane, ref StatesFact, ref StatesDifference, ref methods.data[1][1], ref methods.data[1][2], ref methods.data[1][3], ref StatesPlaneOld, ref StatesFactOld, ref StatesDifferenceOld);
          methods.TextBoxAnd_OldValuesUpdate(ref LocalPlane, ref LocalFact, ref LocalDifference, ref methods.data[2][1], ref methods.data[2][2], ref methods.data[2][3], ref LocalPlaneOld, ref LocalFactOld, ref LocalDifferenceOld);
          methods.TextBoxAnd_OldValuesUpdate(ref OtherPlane, ref OtherFact, ref OtherDifference, ref methods.data[3][1], ref methods.data[3][2], ref methods.data[3][3], ref OtherPlaneOld, ref OtherFactOld, ref OtherDifferenceOld);
          GraphicsUpdate();
       }
    }
}