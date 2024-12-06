using System.Windows;
using System.Windows.Controls;

namespace proga;

public partial class Page2 : Page
{
    public Page2()
    {
        InitializeComponent();
    }

    public double SubtotalPlane = 0;
    public double SubtotalFact = 0;
    public double SubTotalDifference = 0;
    public double MortgageOrRentText1Old = 0;
    public double MortgageOrRentText21Old = 0;
    public double MortgageOrRentText21OldDifference = 0;
    public void PlaneSubTotalUpdate(ref double oldValue, ref double newValue)
    
    {
        SubtotalPlane -= oldValue;
        SubtotalPlane+= newValue;
        oldValue = newValue;
        TextBoxSubTotalPlane.Text = SubtotalPlane.ToString();
    }
    public void FactSubTotalUpdate(ref double oldValue, ref double newValue, ref double value)
    
    {
       SubtotalFact -= oldValue;
       SubtotalFact += newValue;
       oldValue = newValue;
       TextBoxSubTotalFact.Text = SubtotalFact.ToString();
    }
    public void DifferenceSubTotalUpdate(ref double oldValue,double newValue)
    
    {
        SubTotalDifference -= oldValue;
        SubTotalDifference += newValue;
        oldValue = newValue;
        TextBoxSubTotalDifference.Text = SubTotalDifference.ToString();
    }
    public void DifferenseUpdate(ref TextBox tb1, ref TextBox tb2, ref TextBox Differense, ref double oldv, ref double oldv2, ref double oldv3)
    {
        bool flag = false;
        Exception? ex = null;
        double text1 = 0, text2 = 0;
        try
        {
            if (tb1.Text != null && tb2.Text != null)
            {
                
                text1 = Convert.ToDouble(tb1.Text.ToString());
                text2 = Convert.ToDouble(tb2.Text.ToString());
                flag = true;
            }
            
            
        }
        catch (Exception exception)
        {
            ex = exception;
        }

        if (flag)
        {
            Differense.Text = (text1 - text2).ToString();
            PlaneSubTotalUpdate(ref oldv,ref text1);
            FactSubTotalUpdate(ref oldv2 , ref text2,ref SubtotalFact);
            DifferenceSubTotalUpdate(ref oldv3,(text1 - text2));
        }
    }
    private void MortgageOrRentChangeText(object sender, TextChangedEventArgs e)
    {
        bool flag = false;
        Exception? ex = null;
        double text1 = 0, text2 = 0;
        try
        {
            if (MortgageOrRentPlane.Text != null && MortgageOrRentFact.Text != null)
            {
                
                text1 = Convert.ToDouble(MortgageOrRentPlane.Text.ToString());
                text2 = Convert.ToDouble(MortgageOrRentFact.Text.ToString());
                flag = true;
            }
            
            
        }
        catch (Exception exception)
        {
            ex = exception;
        }

        if (flag)
        {
           MortgageOrRentDifference.Text = (text1 - text2).ToString();
          PlaneSubTotalUpdate(ref MortgageOrRentText1Old,ref text1);
          FactSubTotalUpdate(ref MortgageOrRentText21Old , ref text2,ref SubtotalFact);
          DifferenceSubTotalUpdate(ref MortgageOrRentText21OldDifference,(text1 - text2));
        }
    }

    public double TelephonePlaneOld = 0;
    public double TelephoneFactOld = 0;
    public double TelephoneDifferencev = 0;
    private void TelephoneChangeText(object sender, TextChangedEventArgs e)
    {
        bool flag = false;
        Exception? ex = null;
        double text1 = 0, text2 = 0;
        try
        {
            if (MortgageOrRentPlane.Text != null && MortgageOrRentFact.Text != null)
            {
                
                text1 = Convert.ToDouble(TelephonePlane.Text.ToString());
                text2 = Convert.ToDouble(TelephoneFact.Text.ToString());
                flag = true;
            }
            
            
        }
        catch (Exception exception)
        {
            ex = exception;
        }

        if (flag)
        {
            TelephoneDifference.Text = (text1 - text2).ToString();
            PlaneSubTotalUpdate(ref TelephonePlaneOld,ref text1);
            FactSubTotalUpdate(ref TelephoneFactOld , ref text2,ref SubtotalFact);
            DifferenceSubTotalUpdate(ref TelephoneDifferencev,(text1 - text2));
        }
    }
    public double ElectricityPlaneOld = 0;
    public double ElectricityFactOld = 0;
    public double ElectricityDifferenceOld = 0;
    private void ElectricityChangeText(object sender, TextChangedEventArgs e)
    {
        DifferenseUpdate(ref ElectricityPlane, ref ElectricityFact, ref ElectricityDifference, ref ElectricityPlaneOld, ref ElectricityFactOld, ref ElectricityDifferenceOld);
    }
    public double GasPlaneOld = 0;
    public double GasFactOld = 0;
    public double GasDifferenceOld= 0;
    private void GasChangeText(object sender, TextChangedEventArgs e)
    {
        DifferenseUpdate(ref GasPlane, ref GasFact, ref GasDifferent, ref GasPlaneOld, ref GasFactOld, ref GasDifferenceOld);
    }

   public double WaterSupplyAndSeweragePlaneOld = 0;
   public double WaterSupplyAndSewerageFactOld = 0;
   public double WaterSupplyAndSewerageDifferenceOld = 0;
    private void WaterSupplyAndSewerageChangeText(object sender, TextChangedEventArgs e)
    {
        DifferenseUpdate(ref WaterSupplyAndSeweragePlane, ref WaterSupplyAndSewerageFact, ref WaterSupplyAndSewerageDifference, ref WaterSupplyAndSeweragePlaneOld, ref WaterSupplyAndSewerageFactOld, ref WaterSupplyAndSewerageDifferenceOld);
    }
    public double TvPlaneOld = 0;
    public double TvFactOld = 0;
    public double TvDifferenceOld = 0;
    private void TvChangeText(object sender, TextChangedEventArgs e)
    {
        DifferenseUpdate(ref TvPlane,ref TvFact,ref TvDifference,ref TvPlaneOld,ref TvFactOld,ref TvDifferenceOld);
    }
    public double GarbageRemovalPlaneOld = 0;
    public double GarbageRemovalFactOld = 0;
    public double GarbageDifferenceOld = 0;
    private void GarbageRemovalChangeText(object sender, TextChangedEventArgs e)
    {
        DifferenseUpdate(ref GarbagePlane,ref GarbageFact, ref GarbageDifference, ref GarbageRemovalPlaneOld, ref GarbageRemovalFactOld, ref GarbageDifferenceOld);
    }
    public double RepairOrMaintenancePlaneOld = 0;
    public double RepairOrMaintenanceFactOld = 0;
    public double RepairOrMaintenanceDifferenceOld = 0;
    private void RepairOrMaintenanceChangeText(object sender, TextChangedEventArgs e)
    {
        DifferenseUpdate(ref RepairOrMaintenancePlane, ref RepairOrMaintenanceFact, ref RepairOrMaintenanceDifference, ref RepairOrMaintenancePlaneOld, ref RepairOrMaintenanceFactOld, ref RepairOrMaintenanceDifferenceOld);
    } 
    public double MaterialsPlaneOld = 0;
    public double MaterialsFactOld = 0;
    public double MaterialsDifferenceOld = 0;
    private void  MaterialsChangeText(object sender, TextChangedEventArgs e)
    {
        DifferenseUpdate(ref MaterialsPlane, ref MaterialsFact, ref MaterialsDifference, ref MaterialsPlaneOld, ref MaterialsFactOld, ref MaterialsDifferenceOld);
    } 
    public double OtherInHousingPlaneOld = 0;
    public double OtherInHousingFactOld = 0;
    public double OtherInHousingDifferenceOld = 0;
    private void OtherInHousingChangeText(object sender, TextChangedEventArgs e)
    {
        DifferenseUpdate(ref OtherInHousingPlane, ref OtherInHousingFact, ref OtherInHousingDifference, ref OtherInHousingPlaneOld, ref OtherInHousingFactOld, ref OtherInHousingDifferenceOld);
    } 
}