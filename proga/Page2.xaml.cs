using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace proga;

public partial class Page2 : Page
{
    public Page2()
    {
        InitializeComponent();
        
    }
    public ViewModel ViewModelPage2;
    public Methods methods = new Methods();
    public static string way = "C:\\projects C#\\proga\\BdOne.db";
    public double SubtotalPlane = 0;
    public double SubtotalFact = 0;
    public double SubTotalDifference = 0;
    public double MortgageOrRentText1Old = 0;
    public double MortgageOrRentText21Old = 0;
    public double MortgageOrRentText21OldDifference = 0;
    private void MortgageOrRentChangeText(object sender, TextChangedEventArgs e)
    {
        methods.DifferenseUpdate(ref MortgageOrRentPlane, ref MortgageOrRentFact, ref MortgageOrRentDifference, ref MortgageOrRentText1Old, ref MortgageOrRentText21Old, ref MortgageOrRentText21OldDifference, ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference,0, "MortgageOrRent");
        GraphicsUpdate();
    }
    public double TelephonePlaneOld = 0;
    public double TelephoneFactOld = 0;
    public double TelephoneDifferencev = 0;
    private void TelephoneChangeText(object sender, TextChangedEventArgs e)
    {
        methods.DifferenseUpdate(ref TelephonePlane, ref TelephoneFact, ref TelephoneDifference, ref TelephonePlaneOld, ref TelephoneFactOld, ref TelephoneDifferencev, ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference,1,"Telephone");
        GraphicsUpdate();
    }

    public double ElectricityPlaneOld = 0;
    public double ElectricityFactOld = 0;
    public double ElectricityDifferenceOld = 0;
    private void ElectricityChangeText(object sender, TextChangedEventArgs e)
    {
        methods.DifferenseUpdate(ref ElectricityPlane, ref ElectricityFact, ref ElectricityDifference, ref ElectricityPlaneOld, ref ElectricityFactOld, ref ElectricityDifferenceOld,ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference,2,"Electricity");
        GraphicsUpdate();
    }
    public double GasPlaneOld = 0;
    public double GasFactOld = 0;
    public double GasDifferenceOld= 0;
    private void GasChangeText(object sender, TextChangedEventArgs e)
    {
        methods.DifferenseUpdate(ref GasPlane, ref GasFact, ref GasDifferent, ref GasPlaneOld, ref GasFactOld, ref GasDifferenceOld,ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference,3,"Gas");
        GraphicsUpdate();
    }

   public double WaterSupplyAndSeweragePlaneOld = 0;
   public double WaterSupplyAndSewerageFactOld = 0;
   public double WaterSupplyAndSewerageDifferenceOld = 0;
    private void WaterSupplyAndSewerageChangeText(object sender, TextChangedEventArgs e)
    {
        methods.DifferenseUpdate(ref WaterSupplyAndSeweragePlane, ref WaterSupplyAndSewerageFact, ref WaterSupplyAndSewerageDifference, ref WaterSupplyAndSeweragePlaneOld, ref WaterSupplyAndSewerageFactOld, ref WaterSupplyAndSewerageDifferenceOld,ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference,4,"WaterSupplyAndSewerage");
        GraphicsUpdate();
    }
    public double TvPlaneOld = 0;
    public double TvFactOld = 0;
    public double TvDifferenceOld = 0;
    private void TvChangeText(object sender, TextChangedEventArgs e)
    {
        methods.DifferenseUpdate(ref TvPlane,ref TvFact,ref TvDifference,ref TvPlaneOld,ref TvFactOld,ref TvDifferenceOld,ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference,5,"Tv");
        GraphicsUpdate();
    }
    public double GarbageRemovalPlaneOld = 0;
    public double GarbageRemovalFactOld = 0;
    public double GarbageDifferenceOld = 0;
    private void GarbageRemovalChangeText(object sender, TextChangedEventArgs e)
    {
        methods.DifferenseUpdate(ref GarbagePlane,ref GarbageFact, ref GarbageDifference, ref GarbageRemovalPlaneOld, ref GarbageRemovalFactOld, ref GarbageDifferenceOld,ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference,6,"Garbage");
        GraphicsUpdate();
    }
    public double RepairOrMaintenancePlaneOld = 0;
    public double RepairOrMaintenanceFactOld = 0;
    public double RepairOrMaintenanceDifferenceOld = 0;
    private void RepairOrMaintenanceChangeText(object sender, TextChangedEventArgs e)
    {
        methods.DifferenseUpdate(ref RepairOrMaintenancePlane, ref RepairOrMaintenanceFact, ref RepairOrMaintenanceDifference, ref RepairOrMaintenancePlaneOld, ref RepairOrMaintenanceFactOld, ref RepairOrMaintenanceDifferenceOld,ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference,7,"RepairOrMaintenance");
        GraphicsUpdate();
    } 
    public double MaterialsPlaneOld = 0;
    public double MaterialsFactOld = 0;
    public double MaterialsDifferenceOld = 0;
    private void  MaterialsChangeText(object sender, TextChangedEventArgs e)
    {
        methods.DifferenseUpdate(ref MaterialsPlane, ref MaterialsFact, ref MaterialsDifference, ref MaterialsPlaneOld, ref MaterialsFactOld, ref MaterialsDifferenceOld,ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference,8,"Materials");
        GraphicsUpdate();
    } 
    public double OtherInHousingPlaneOld = 0;
    public double OtherInHousingFactOld = 0;
    public double OtherInHousingDifferenceOld = 0;
    private void OtherInHousingChangeText(object sender, TextChangedEventArgs e)
    {
        methods.DifferenseUpdate(ref OtherInHousingPlane, ref OtherInHousingFact, ref OtherInHousingDifference, ref OtherInHousingPlaneOld, ref OtherInHousingFactOld, ref OtherInHousingDifferenceOld,ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference,9,"Other");
        GraphicsUpdate();
    }

    private void GraphicsUpdate()
    {
        ViewModelPage2 = new ViewModel(methods.Planevalues, methods.Factvalues);
        this.DataContext = ViewModelPage2;
    }
    private void Page2_OnLoaded(object sender, RoutedEventArgs e)
    {
        methods.dbName = "HomeDB";
        if (methods.db.GetEntireTable(4, out methods.data, methods.dbName))
        {
            SubtotalPlane = Convert.ToDouble(methods.data[methods.data.Count -1][1]);
            TextBoxSubTotalPlane.Text = SubtotalPlane.ToString();
            SubtotalFact = Convert.ToDouble(methods.data[methods.data.Count - 1][2]);
            TextBoxSubTotalFact.Text = SubtotalPlane.ToString();
            SubTotalDifference = Convert.ToDouble(methods.data[methods.data.Count -1 ][3]);
            TextBoxSubTotalDifference.Text = SubTotalDifference.ToString();
            methods.TextBoxAnd_OldValuesUpdate(ref MortgageOrRentPlane, ref MortgageOrRentFact, ref MortgageOrRentDifference, ref methods.data[0][1], ref methods.data[0][2], ref methods.data[0][3], ref MortgageOrRentText1Old, ref MortgageOrRentText21Old, ref MortgageOrRentText21OldDifference);
            methods.TextBoxAnd_OldValuesUpdate(ref TelephonePlane, ref TelephoneFact, ref TelephoneDifference, ref methods.data[1][1], ref methods.data[1][2], ref methods.data[1][3], ref TelephonePlaneOld, ref TelephoneFactOld, ref TelephoneDifferencev);
            methods.TextBoxAnd_OldValuesUpdate(ref ElectricityPlane, ref ElectricityFact, ref ElectricityDifference, ref methods.data[2][1], ref methods.data[2][2], ref methods.data[2][3], ref ElectricityPlaneOld, ref ElectricityFactOld, ref ElectricityDifferenceOld);
            methods.TextBoxAnd_OldValuesUpdate(ref GasPlane, ref GasFact, ref GasDifferent, ref methods.data[3][1], ref methods.data[3][2], ref methods.data[3][3], ref GasPlaneOld, ref GasFactOld, ref GasDifferenceOld);
            methods.TextBoxAnd_OldValuesUpdate(ref WaterSupplyAndSeweragePlane, ref WaterSupplyAndSewerageFact, ref WaterSupplyAndSewerageDifference, ref methods.data[4][1], ref methods.data[4][2], ref methods.data[4][3], ref WaterSupplyAndSeweragePlaneOld, ref WaterSupplyAndSewerageFactOld, ref WaterSupplyAndSewerageDifferenceOld);
            methods.TextBoxAnd_OldValuesUpdate(ref TvPlane, ref TvFact, ref TvDifference, ref methods.data[5][1], ref methods.data[5][2], ref methods.data[5][3], ref TvPlaneOld, ref TvFactOld, ref TvDifferenceOld);
            methods.TextBoxAnd_OldValuesUpdate(ref GarbagePlane, ref GarbageFact, ref GarbageDifference, ref methods.data[6][1],ref methods.data[6][2],ref methods.data[6][3], ref GarbageRemovalPlaneOld, ref GarbageRemovalFactOld, ref GarbageDifferenceOld );
            methods.TextBoxAnd_OldValuesUpdate(ref RepairOrMaintenancePlane, ref RepairOrMaintenanceFact, ref RepairOrMaintenanceDifference, ref methods.data[7][1],ref methods.data[7][2],ref methods.data[7][3], ref RepairOrMaintenancePlaneOld, ref RepairOrMaintenanceFactOld, ref RepairOrMaintenanceDifferenceOld);
            methods.TextBoxAnd_OldValuesUpdate(ref MaterialsPlane, ref MaterialsFact, ref MaterialsDifference, ref methods.data[8][1], ref methods.data[8][2], ref methods.data[8][3], ref MaterialsPlaneOld, ref MaterialsFactOld, ref MaterialsDifferenceOld);
            methods.TextBoxAnd_OldValuesUpdate(ref OtherInHousingPlane, ref OtherInHousingFact, ref OtherInHousingDifference, ref methods.data[9][1], ref methods.data[9][2], ref methods.data[9][3], ref OtherInHousingPlaneOld, ref OtherInHousingFactOld, ref OtherInHousingDifferenceOld);
            GraphicsUpdate();
        }
    }
}