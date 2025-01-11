using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace proga;

public partial class Page2 : Page
{
    public Page2() => InitializeComponent();
    public Methods methods = new Methods(10);
    private void MortgageOrRentChangeText(object sender, TextChangedEventArgs e)
    {
        methods.DifferenseUpdate(ref MortgageOrRentPlane, ref MortgageOrRentFact, ref MortgageOrRentDifference,  ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference,0, "MortgageOrRent");
        GraphicsUpdate();
    }
    private void TelephoneChangeText(object sender, TextChangedEventArgs e)
    {
        methods.DifferenseUpdate(ref TelephonePlane, ref TelephoneFact, ref TelephoneDifference,  ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference,1,"Telephone");
        GraphicsUpdate();
    }
    private void ElectricityChangeText(object sender, TextChangedEventArgs e)
    {
        methods.DifferenseUpdate(ref ElectricityPlane, ref ElectricityFact, ref ElectricityDifference, ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference,2,"Electricity");
        GraphicsUpdate();
    }
    private void GasChangeText(object sender, TextChangedEventArgs e)
    {
        methods.DifferenseUpdate(ref GasPlane, ref GasFact, ref GasDifferent, ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference,3,"Gas");
        GraphicsUpdate();
    }
    private void WaterSupplyAndSewerageChangeText(object sender, TextChangedEventArgs e)
    {
        methods.DifferenseUpdate(ref WaterSupplyAndSeweragePlane, ref WaterSupplyAndSewerageFact, ref WaterSupplyAndSewerageDifference,ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference,4,"WaterSupplyAndSewerage");
        GraphicsUpdate();
    }
    private void TvChangeText(object sender, TextChangedEventArgs e)
    {
        methods.DifferenseUpdate(ref TvPlane,ref TvFact,ref TvDifference,ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference,5,"Tv");
        GraphicsUpdate();
    }
    private void GarbageRemovalChangeText(object sender, TextChangedEventArgs e)
    {
        methods.DifferenseUpdate(ref GarbagePlane,ref GarbageFact, ref GarbageDifference, ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference,6,"Garbage");
        GraphicsUpdate();
    }
    private void RepairOrMaintenanceChangeText(object sender, TextChangedEventArgs e)
    {
        methods.DifferenseUpdate(ref RepairOrMaintenancePlane, ref RepairOrMaintenanceFact, ref RepairOrMaintenanceDifference, ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference,7,"RepairOrMaintenance");
        GraphicsUpdate();
    } 
    private void  MaterialsChangeText(object sender, TextChangedEventArgs e)
    {
        methods.DifferenseUpdate(ref MaterialsPlane, ref MaterialsFact, ref MaterialsDifference,ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference,8,"Materials");
        GraphicsUpdate();
    } 
    private void OtherInHousingChangeText(object sender, TextChangedEventArgs e)
    {
        methods.DifferenseUpdate(ref OtherInHousingPlane, ref OtherInHousingFact, ref OtherInHousingDifference, ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference,9,"Other");
        GraphicsUpdate();
    }
    private void GraphicsUpdate() =>  this.DataContext = methods.GraphicUpdate();
    private void Page2_OnLoaded(object sender, RoutedEventArgs e)
    {
        methods.dbName = "HomeDB";
        if (methods.db.GetEntireTable(4, out methods.data, methods.dbName))
        {
            TextBoxSubTotalPlane.Text = methods.SubtotalPlane.ToString();
            TextBoxSubTotalFact.Text = methods.SubtotalFact.ToString();
            TextBoxSubTotalDifference.Text = methods.SubTotalDifference.ToString();
            methods.TextBoxAnd_OldValuesUpdate(ref MortgageOrRentPlane, ref MortgageOrRentFact, ref MortgageOrRentDifference,0);
            methods.TextBoxAnd_OldValuesUpdate(ref TelephonePlane, ref TelephoneFact, ref TelephoneDifference,1);
            methods.TextBoxAnd_OldValuesUpdate(ref ElectricityPlane, ref ElectricityFact, ref ElectricityDifference, 2);
            methods.TextBoxAnd_OldValuesUpdate(ref GasPlane, ref GasFact, ref GasDifferent,3);
            methods.TextBoxAnd_OldValuesUpdate(ref WaterSupplyAndSeweragePlane, ref WaterSupplyAndSewerageFact, ref WaterSupplyAndSewerageDifference,4);
            methods.TextBoxAnd_OldValuesUpdate(ref TvPlane, ref TvFact, ref TvDifference, 5);
            methods.TextBoxAnd_OldValuesUpdate(ref GarbagePlane, ref GarbageFact, ref GarbageDifference,6);
            methods.TextBoxAnd_OldValuesUpdate(ref RepairOrMaintenancePlane, ref RepairOrMaintenanceFact, ref RepairOrMaintenanceDifference,7);
            methods.TextBoxAnd_OldValuesUpdate(ref MaterialsPlane, ref MaterialsFact, ref MaterialsDifference, 8);
            methods.TextBoxAnd_OldValuesUpdate(ref OtherInHousingPlane, ref OtherInHousingFact, ref OtherInHousingDifference, 9);
            GraphicsUpdate();
        }
    }
}