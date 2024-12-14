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
    /// <summary>
    /// 
    /// </summary>
    /// <param name="textBoxPlane"></param>
    /// <param name="textboxFact"></param>
    /// <param name="TbDifference"></param>
    /// <param name="NewPlane"></param>
    /// <param name="NewFact"></param>
    /// <param name="NewTbDifference"></param>
    /// <param name="oldPlane"></param>
    /// <param name="oldFact"></param>
    /// <param name="oldTbDifference"></param>
    public void TextBoxAnd_OldValuesUpdate(ref TextBox textBoxPlane, ref TextBox textboxFact, ref TextBox TbDifference,ref  string NewPlane,ref string NewFact, ref string NewTbDifference, ref double oldPlane, ref double oldFact, ref double oldTbDifference)
    {
        textBoxPlane.Text = NewPlane;
        textboxFact.Text = NewFact;
        TbDifference.Text = NewTbDifference;
        oldPlane = Convert.ToDouble(textBoxPlane.Text);
        oldFact = Convert.ToDouble(textboxFact.Text);
        oldTbDifference = Convert.ToDouble(TbDifference.Text);
    }
    public static string way = "C:\\projects C#\\proga\\BdOne.db";
    List<string[]> data = new List<string[]>();
    db_control db = new db_control(way);
    public double SubtotalPlane = 0;
    public double SubtotalFact = 0;
    public double SubTotalDifference = 0;
    public double MortgageOrRentText1Old = 0;
    public double MortgageOrRentText21Old = 0;
    public double MortgageOrRentText21OldDifference = 0;
    Dictionary<string, string[]> Values = new Dictionary<string, string []>();
    public void UpdateDB(string fname, string fvalue, string chname, double value)
    {
       db.UpdateFilteredValue("HomeDB", fname, fvalue, chname, value.ToString());
    }
    public void PlaneSubTotalUpdate(ref double oldValue, ref double newValue)
    
    {
        SubtotalPlane -= oldValue;
        SubtotalPlane+= newValue;
        oldValue = newValue;
        TextBoxSubTotalPlane.Text = SubtotalPlane.ToString();
        data[10][1] = SubtotalPlane.ToString();
        UpdateDB("Name","TextBoxSubTotal","Plane", SubtotalPlane);
    }
    public void FactSubTotalUpdate(ref double oldValue, ref double newValue, ref double value)
    
    {
       SubtotalFact -= oldValue;
       SubtotalFact += newValue;
       oldValue = newValue;
       TextBoxSubTotalFact.Text = SubtotalFact.ToString();
       data[10][2] = SubtotalFact.ToString();
       UpdateDB("Name","TextBoxSubTotal","Fact", SubtotalFact);
    }
    public void DifferenceSubTotalUpdate(ref double oldValue,double newValue)
    
    {
        SubTotalDifference -= oldValue;
        SubTotalDifference += newValue;
        oldValue = newValue;
        TextBoxSubTotalDifference.Text = SubTotalDifference.ToString();
        data[10][3] = SubTotalDifference.ToString();
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="tb1">Текст бокс запланированного значения</param>
    /// <param name="tb2">Текст бокс фактического значения</param>
    /// <param name="Differense">Текст бокс разницы</param>
    /// <param name="oldv">Старое значение плана</param>
    /// <param name="oldv2">Фактическое староение значение</param>
    /// <param name="oldv3">Старая разница</param>
    /// <param name="n">Номер в листе</param>
    /// <param name="Name11">Имя</param>
    public void DifferenseUpdate(ref TextBox tb1, ref TextBox tb2, ref TextBox Differense, ref double oldv, ref double oldv2, ref double oldv3, int n = 0, string Name11 = "")
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
            data[n][1] = text1.ToString();
            data[n][2] = text2.ToString();
            data[n][3] = (text1 - text2).ToString();
            UpdateDB("Name",Name11,"Plane", text1);
            UpdateDB("Name",Name11,"Fact", text2);
            UpdateDB("Name", Name11, "Difference",(text1 - text2));
            
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
          UpdateDB("Name","MortgageOrRent","Plane", text1);
          UpdateDB("Name","MortgageOrRent","Fact", text2);
          UpdateDB("Name","MortgageOrRent","Difference", (text1 - text2));
          data[0][1] = text1.ToString();
          data[0][2] = text2.ToString();
          data[0][3] = (text1 - text2).ToString();
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
            UpdateDB("Name","Telephone","Plane", text1);
            UpdateDB("Name","Telephone","Fact", text2);
            UpdateDB("Name","Telephone","Difference", (text1 - text2));
            data[1][1] = text1.ToString();
            data[1][2] = text2.ToString();
            data[1][3] = (text1 - text2).ToString();
        }
    }
    public double ElectricityPlaneOld = 0;
    public double ElectricityFactOld = 0;
    public double ElectricityDifferenceOld = 0;
    private void ElectricityChangeText(object sender, TextChangedEventArgs e)
    {
        DifferenseUpdate(ref ElectricityPlane, ref ElectricityFact, ref ElectricityDifference, ref ElectricityPlaneOld, ref ElectricityFactOld, ref ElectricityDifferenceOld,2,"Electricity");
    }
    public double GasPlaneOld = 0;
    public double GasFactOld = 0;
    public double GasDifferenceOld= 0;
    private void GasChangeText(object sender, TextChangedEventArgs e)
    {
        DifferenseUpdate(ref GasPlane, ref GasFact, ref GasDifferent, ref GasPlaneOld, ref GasFactOld, ref GasDifferenceOld,3,"Gas");
    }

   public double WaterSupplyAndSeweragePlaneOld = 0;
   public double WaterSupplyAndSewerageFactOld = 0;
   public double WaterSupplyAndSewerageDifferenceOld = 0;
    private void WaterSupplyAndSewerageChangeText(object sender, TextChangedEventArgs e)
    {
        DifferenseUpdate(ref WaterSupplyAndSeweragePlane, ref WaterSupplyAndSewerageFact, ref WaterSupplyAndSewerageDifference, ref WaterSupplyAndSeweragePlaneOld, ref WaterSupplyAndSewerageFactOld, ref WaterSupplyAndSewerageDifferenceOld,4,"WaterSupplyAndSewerage");
    }
    public double TvPlaneOld = 0;
    public double TvFactOld = 0;
    public double TvDifferenceOld = 0;
    private void TvChangeText(object sender, TextChangedEventArgs e)
    {
        DifferenseUpdate(ref TvPlane,ref TvFact,ref TvDifference,ref TvPlaneOld,ref TvFactOld,ref TvDifferenceOld,5,"Tv");
    }
    public double GarbageRemovalPlaneOld = 0;
    public double GarbageRemovalFactOld = 0;
    public double GarbageDifferenceOld = 0;
    private void GarbageRemovalChangeText(object sender, TextChangedEventArgs e)
    {
        DifferenseUpdate(ref GarbagePlane,ref GarbageFact, ref GarbageDifference, ref GarbageRemovalPlaneOld, ref GarbageRemovalFactOld, ref GarbageDifferenceOld,6,"Garbage");
    }
    public double RepairOrMaintenancePlaneOld = 0;
    public double RepairOrMaintenanceFactOld = 0;
    public double RepairOrMaintenanceDifferenceOld = 0;
    private void RepairOrMaintenanceChangeText(object sender, TextChangedEventArgs e)
    {
        DifferenseUpdate(ref RepairOrMaintenancePlane, ref RepairOrMaintenanceFact, ref RepairOrMaintenanceDifference, ref RepairOrMaintenancePlaneOld, ref RepairOrMaintenanceFactOld, ref RepairOrMaintenanceDifferenceOld,7,"RepairOrMaintenance");
    } 
    public double MaterialsPlaneOld = 0;
    public double MaterialsFactOld = 0;
    public double MaterialsDifferenceOld = 0;
    private void  MaterialsChangeText(object sender, TextChangedEventArgs e)
    {
        DifferenseUpdate(ref MaterialsPlane, ref MaterialsFact, ref MaterialsDifference, ref MaterialsPlaneOld, ref MaterialsFactOld, ref MaterialsDifferenceOld,8,"Materials");
    } 
    public double OtherInHousingPlaneOld = 0;
    public double OtherInHousingFactOld = 0;
    public double OtherInHousingDifferenceOld = 0;
    private void OtherInHousingChangeText(object sender, TextChangedEventArgs e)
    {
        DifferenseUpdate(ref OtherInHousingPlane, ref OtherInHousingFact, ref OtherInHousingDifference, ref OtherInHousingPlaneOld, ref OtherInHousingFactOld, ref OtherInHousingDifferenceOld,9,"Other");
    }

    private void Page2_OnLoaded(object sender, RoutedEventArgs e)
    {
        if (db.GetEntireTable(4, out data, "HomeDB"))
        {
            SubtotalPlane = Convert.ToDouble(data[10][1]);
            TextBoxSubTotalPlane.Text = SubtotalPlane.ToString();
            SubtotalFact = Convert.ToDouble(data[10][2]);
            TextBoxSubTotalFact.Text = SubtotalPlane.ToString();
            SubTotalDifference = Convert.ToDouble(data[10][3]);
            TextBoxSubTotalDifference.Text = SubTotalDifference.ToString();
            TextBoxAnd_OldValuesUpdate(ref MortgageOrRentPlane, ref MortgageOrRentFact, ref MortgageOrRentDifference, ref data[0][1], ref data[0][2], ref data[0][3], ref MortgageOrRentText1Old, ref MortgageOrRentText21Old, ref MortgageOrRentText21OldDifference);
            TextBoxAnd_OldValuesUpdate(ref TelephonePlane, ref TelephoneFact, ref TelephoneDifference, ref data[1][1], ref data[1][2], ref data[1][3], ref TelephonePlaneOld, ref TelephoneFactOld, ref TelephoneDifferencev);
            TextBoxAnd_OldValuesUpdate(ref ElectricityPlane, ref ElectricityFact, ref ElectricityDifference, ref data[2][1], ref data[2][2], ref data[2][3], ref ElectricityPlaneOld, ref ElectricityFactOld, ref ElectricityDifferenceOld);
            TextBoxAnd_OldValuesUpdate(ref GasPlane, ref GasFact, ref GasDifferent, ref data[3][1], ref data[3][2], ref data[3][3], ref GasPlaneOld, ref GasFactOld, ref GasDifferenceOld);
            TextBoxAnd_OldValuesUpdate(ref WaterSupplyAndSeweragePlane, ref WaterSupplyAndSewerageFact, ref WaterSupplyAndSewerageDifference, ref data[4][1], ref data[4][2], ref data[4][3], ref WaterSupplyAndSeweragePlaneOld, ref WaterSupplyAndSewerageFactOld, ref WaterSupplyAndSewerageDifferenceOld);
            TextBoxAnd_OldValuesUpdate(ref TvPlane, ref TvFact, ref TvDifference, ref data[5][1], ref data[5][2], ref data[5][3], ref TvPlaneOld, ref TvFactOld, ref TvDifferenceOld);
            TextBoxAnd_OldValuesUpdate(ref GarbagePlane, ref GarbageFact, ref GarbageDifference, ref data[6][1],ref data[6][2],ref data[6][3], ref GarbageRemovalPlaneOld, ref GarbageRemovalFactOld, ref GarbageDifferenceOld );
            TextBoxAnd_OldValuesUpdate(ref RepairOrMaintenancePlane, ref RepairOrMaintenanceFact, ref RepairOrMaintenanceDifference, ref data[7][1],ref data[7][2],ref data[7][3], ref RepairOrMaintenancePlaneOld, ref RepairOrMaintenanceFactOld, ref RepairOrMaintenanceDifferenceOld);
            TextBoxAnd_OldValuesUpdate(ref MaterialsPlane, ref MaterialsFact, ref MaterialsDifference, ref data[8][1], ref data[8][2], ref data[8][3], ref MaterialsPlaneOld, ref MaterialsFactOld, ref MaterialsDifferenceOld);
            TextBoxAnd_OldValuesUpdate(ref OtherInHousingPlane, ref OtherInHousingFact, ref OtherInHousingDifference, ref data[9][1], ref data[9][2], ref data[9][3], ref OtherInHousingPlaneOld, ref OtherInHousingFactOld, ref OtherInHousingDifferenceOld);
        }
        
    }
}