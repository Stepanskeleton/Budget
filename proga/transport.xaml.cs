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
    public double PlaneOld = 0;
    public double FactOld = 0;
    public double DifferenceOld= 0;
    private void ChangeText(object sender, TextChangedEventArgs e)
    {
       
    }
    public double CarFeePlaneOld = 0;
    public double CarFeeFactOld = 0;
    public double CarFeeDifferenceOld = 0;
    private void CarFeeChangeText(object sender, TextChangedEventArgs e)
    {
       DifferenseUpdate(ref CarFeePlane,ref CarFeeFact, ref CarFeeDifference, ref CarFeePlaneOld, ref CarFeeFactOld, ref CarFeeDifferenceOld);
    }
    public double BusOrTaxiFeePlaneOld = 0;
    public double BusOrTaxiFeeFactOld = 0;
    public double BusOrTaxiFeeDifferenceOld= 0;
    private void BusOrTaxiFeeChangeText(object sender, TextChangedEventArgs e)
    {
       DifferenseUpdate( ref BusOrTaxiFeePlane, ref BusOrTaxiFeeFact, ref BusOrTaxiFeeDifference, ref BusOrTaxiFeePlaneOld, ref BusOrTaxiFeeFactOld, ref BusOrTaxiFeeDifferenceOld);
    }
    public double InsurancePlaneOld = 0;
    public double InsuranceFactOld = 0;
    public double InsuranceDifferenceOld= 0;
    private void InsuranceChangeText(object sender, TextChangedEventArgs e)
    {
       DifferenseUpdate(ref InsurancePlane, ref InsuranceFact, ref InsuranceDifference, ref InsurancePlaneOld, ref InsuranceFactOld, ref InsuranceDifferenceOld);
    }
    public double LicensePlaneOld = 0;
    public double LicenseFactOld = 0;
    public double LicenseDifferenceOld= 0;
    private void LicenseChangeText(object sender, TextChangedEventArgs e)
    {
       DifferenseUpdate(ref LicensePlane, ref LicenseFact, ref LicenseDifference, ref LicensePlaneOld, ref LicenseFactOld, ref LicenseDifferenceOld);
    }
    public double FuelPlaneOld = 0;
    public double FuelFactOld = 0;
    public double FuelDifferenceOld= 0;
    private void FuelChangeText(object sender, TextChangedEventArgs e)
    {
       DifferenseUpdate(ref FuelPlane, ref FuelFact, ref FuelDifference, ref FuelPlaneOld, ref FuelFactOld, ref FuelDifferenceOld);
    }
    public double ServicePlaneOld = 0;
    public double ServiceFactOld = 0;
    public double ServiceDifferenceOld= 0;
    private void ServiceChangeText(object sender, TextChangedEventArgs e)
    {
       DifferenseUpdate(ref ServicePlane, ref ServiceFact, ref ServiceDifference, ref ServicePlaneOld, ref ServiceFactOld, ref ServiceDifferenceOld);
    }
    public double OtherPlaneOld = 0;
    public double OtherFactOld = 0;
    public double OtherDifferenceOld= 0;
    private void OtherChangeText(object sender, TextChangedEventArgs e)
    {
       DifferenseUpdate(ref OtherPlane, ref OtherFact, ref OtherDifference, ref OtherPlaneOld, ref OtherFactOld, ref OtherDifferenceOld);
    }
}