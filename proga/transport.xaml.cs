using System.Windows;
using System.Windows.Controls;

namespace proga;

public partial class transport : Page
{
    public transport()
    {
        InitializeComponent();
    }
    public double SubtotalPlane = 0;
    public double SubtotalFact = 0;
    public double SubTotalDifference = 0;
    Methods methods = new Methods();
    public static string way = "C:\\projects C#\\proga\\BdOne.db";
    public double CarFeePlaneOld = 0;
    public double CarFeeFactOld = 0;
    public double CarFeeDifferenceOld = 0;
    private void CarFeeChangeText(object sender, TextChangedEventArgs e)
    {
       methods.DifferenseUpdate(ref CarFeePlane,ref CarFeeFact, ref CarFeeDifference, ref CarFeePlaneOld, ref CarFeeFactOld, ref CarFeeDifferenceOld, ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference,0, "CarFee");
       GraphicsUpdate();
    }
    public double BusOrTaxiFeePlaneOld = 0;
    public double BusOrTaxiFeeFactOld = 0;
    public double BusOrTaxiFeeDifferenceOld= 0;
    private void BusOrTaxiFeeChangeText(object sender, TextChangedEventArgs e)
    {
       methods.DifferenseUpdate( ref BusOrTaxiFeePlane, ref BusOrTaxiFeeFact, ref BusOrTaxiFeeDifference, ref BusOrTaxiFeePlaneOld, ref BusOrTaxiFeeFactOld, ref BusOrTaxiFeeDifferenceOld, ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference, 1, "BusOrTaxiFee");
       GraphicsUpdate();
    }
    public double InsurancePlaneOld = 0;
    public double InsuranceFactOld = 0;
    public double InsuranceDifferenceOld= 0;
    private void InsuranceChangeText(object sender, TextChangedEventArgs e)
    {
       methods.DifferenseUpdate(ref InsurancePlane, ref InsuranceFact, ref InsuranceDifference, ref InsurancePlaneOld, ref InsuranceFactOld, ref InsuranceDifferenceOld, ref TextBoxSubTotalPlane,ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference,2, "Insurance");
       GraphicsUpdate();
    }
    public double LicensePlaneOld = 0;
    public double LicenseFactOld = 0;
    public double LicenseDifferenceOld= 0;
    private void LicenseChangeText(object sender, TextChangedEventArgs e)
    {
       methods.DifferenseUpdate(ref LicensePlane, ref LicenseFact, ref LicenseDifference, ref LicensePlaneOld, ref LicenseFactOld, ref LicenseDifferenceOld, ref TextBoxSubTotalPlane, ref TextBoxSubTotalPlane, ref TextBoxSubTotalDifference,3, "License");
       GraphicsUpdate();
    }
    public double FuelPlaneOld = 0;
    public double FuelFactOld = 0;
    public double FuelDifferenceOld= 0;
    private void FuelChangeText(object sender, TextChangedEventArgs e)
    {
       methods.DifferenseUpdate(ref FuelPlane, ref FuelFact, ref FuelDifference, ref FuelPlaneOld, ref FuelFactOld, ref FuelDifferenceOld, ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference,4, "Fuel");
       GraphicsUpdate();
    }
    public double ServicePlaneOld = 0;
    public double ServiceFactOld = 0;
    public double ServiceDifferenceOld= 0;
    private void ServiceChangeText(object sender, TextChangedEventArgs e)
    {
       methods.DifferenseUpdate(ref ServicePlane, ref ServiceFact, ref ServiceDifference, ref ServicePlaneOld, ref ServiceFactOld, ref ServiceDifferenceOld, ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference,5, "Service");
       GraphicsUpdate();
    }
    public double OtherPlaneOld = 0;
    public double OtherFactOld = 0;
    public double OtherDifferenceOld= 0;
    private void OtherChangeText(object sender, TextChangedEventArgs e)
    {
       methods.DifferenseUpdate(ref OtherPlane, ref OtherFact, ref OtherDifference, ref OtherPlaneOld, ref OtherFactOld, ref OtherDifferenceOld, ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference,6,"Other");
       GraphicsUpdate();
    }
    private void GraphicsUpdate()
    {
       this.DataContext = methods.GraphicUpdate();
    }
    private void Transport_OnLoaded(object sender, RoutedEventArgs e)
    {
         methods.dbName = "transport";
        if (methods.db.GetEntireTable(4, out methods.data, methods.dbName))
        {
            SubtotalPlane = Convert.ToDouble(methods.data[7][1]);
            TextBoxSubTotalPlane.Text = SubtotalPlane.ToString();
            SubtotalFact = Convert.ToDouble(methods.data[7][2]);
            TextBoxSubTotalFact.Text = SubtotalPlane.ToString();
            SubTotalDifference = Convert.ToDouble(methods.data[7][3]);
            TextBoxSubTotalDifference.Text = SubTotalDifference.ToString();
            methods.TextBoxAnd_OldValuesUpdate(ref CarFeePlane, ref CarFeeFact, ref CarFeeDifference,ref methods.data[0][1],ref methods.data[0][2],ref methods.data[0][3], ref CarFeePlaneOld, ref CarFeeFactOld, ref CarFeeDifferenceOld);
           methods.TextBoxAnd_OldValuesUpdate(ref BusOrTaxiFeePlane, ref BusOrTaxiFeeFact, ref BusOrTaxiFeeDifference, ref methods.data[1][1], ref methods.data[1][2], ref methods.data[1][3], ref BusOrTaxiFeePlaneOld, ref BusOrTaxiFeeFactOld, ref BusOrTaxiFeeDifferenceOld);
           methods.TextBoxAnd_OldValuesUpdate(ref InsurancePlane, ref InsuranceFact, ref InsuranceDifference, ref methods.data[2][1],ref methods.data[2][2],ref methods.data[2][3], ref InsurancePlaneOld, ref InsuranceFactOld, ref InsuranceDifferenceOld);
           methods.TextBoxAnd_OldValuesUpdate(ref LicensePlane, ref LicenseFact, ref LicenseDifference, ref methods.data[3][1], ref methods.data[3][2], ref methods.data[3][3], ref LicensePlaneOld, ref LicenseFactOld, ref LicenseDifferenceOld);
           methods.TextBoxAnd_OldValuesUpdate(ref FuelPlane, ref FuelFact, ref FuelDifference, ref methods.data[4][1], ref methods.data[4][2], ref methods.data[4][3], ref FuelPlaneOld, ref FuelFactOld, ref FuelDifferenceOld);
           methods.TextBoxAnd_OldValuesUpdate(ref ServicePlane, ref ServiceFact, ref ServiceDifference, ref methods.data[5][1], ref methods.data[5][2], ref methods.data[5][3], ref ServicePlaneOld, ref ServiceFactOld, ref ServiceDifferenceOld);
           methods.TextBoxAnd_OldValuesUpdate(ref OtherPlane, ref OtherFact, ref OtherDifference, ref methods.data[6][1], ref methods.data[6][2], ref methods.data[6][3], ref OtherPlaneOld, ref OtherFactOld, ref OtherDifferenceOld);
           GraphicsUpdate();
            
        }
    }
}