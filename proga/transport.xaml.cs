using System.Windows;
using System.Windows.Controls;

namespace proga;

public partial class transport : Page
{
    public transport() =>  InitializeComponent();
    private void GraphicsUpdate() => this.DataContext = methods.GraphicUpdate();
    Methods methods = new Methods(7);
    private void CarFeeChangeText(object sender, TextChangedEventArgs e)
    {
       methods.DifferenseUpdate(ref CarFeePlane,ref CarFeeFact, ref CarFeeDifference,  ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference,0, "CarFee");
       GraphicsUpdate();
    }
    private void BusOrTaxiFeeChangeText(object sender, TextChangedEventArgs e)
    {
       methods.DifferenseUpdate( ref BusOrTaxiFeePlane, ref BusOrTaxiFeeFact, ref BusOrTaxiFeeDifference,  ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference, 1, "BusOrTaxiFee");
       GraphicsUpdate();
    }
    private void InsuranceChangeText(object sender, TextChangedEventArgs e)
    {
       methods.DifferenseUpdate(ref InsurancePlane, ref InsuranceFact, ref InsuranceDifference,  ref TextBoxSubTotalPlane,ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference,2, "Insurance");
       GraphicsUpdate();
    }
    private void LicenseChangeText(object sender, TextChangedEventArgs e)
    {
       methods.DifferenseUpdate(ref LicensePlane, ref LicenseFact, ref LicenseDifference,  ref TextBoxSubTotalPlane, ref TextBoxSubTotalPlane, ref TextBoxSubTotalDifference,3, "License");
       GraphicsUpdate();
    }
    private void FuelChangeText(object sender, TextChangedEventArgs e)
    {
       methods.DifferenseUpdate(ref FuelPlane, ref FuelFact, ref FuelDifference,  ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference,4, "Fuel");
       GraphicsUpdate();
    }
    private void ServiceChangeText(object sender, TextChangedEventArgs e)
    {
       methods.DifferenseUpdate(ref ServicePlane, ref ServiceFact, ref ServiceDifference,  ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference,5, "Service");
       GraphicsUpdate();
    }
    private void OtherChangeText(object sender, TextChangedEventArgs e)
    {
       methods.DifferenseUpdate(ref OtherPlane, ref OtherFact, ref OtherDifference,  ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference,6,"Other");
       GraphicsUpdate();
    }
    private void Transport_OnLoaded(object sender, RoutedEventArgs e)
    {
         methods.dbName = "transport";
        if (methods.db.GetEntireTable(4, out methods.data, methods.dbName))
        {
           TextBoxSubTotalPlane.Text = methods.SubtotalPlane.ToString();
           TextBoxSubTotalFact.Text = methods.SubtotalFact.ToString();
           TextBoxSubTotalDifference.Text = methods.SubTotalDifference.ToString();
            methods.TextBoxAnd_OldValuesUpdate(ref CarFeePlane, ref CarFeeFact, ref CarFeeDifference,0);
           methods.TextBoxAnd_OldValuesUpdate(ref BusOrTaxiFeePlane, ref BusOrTaxiFeeFact, ref BusOrTaxiFeeDifference, 1);
           methods.TextBoxAnd_OldValuesUpdate(ref InsurancePlane, ref InsuranceFact, ref InsuranceDifference,2);
           methods.TextBoxAnd_OldValuesUpdate(ref LicensePlane, ref LicenseFact, ref LicenseDifference, 3);
           methods.TextBoxAnd_OldValuesUpdate(ref FuelPlane, ref FuelFact, ref FuelDifference, 4);
           methods.TextBoxAnd_OldValuesUpdate(ref ServicePlane, ref ServiceFact, ref ServiceDifference, 5);
           methods.TextBoxAnd_OldValuesUpdate(ref OtherPlane, ref OtherFact, ref OtherDifference, 6);
           GraphicsUpdate();
        }
    }
}