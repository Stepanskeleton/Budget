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
   
    public double FederationsPlaneOld = 0;
    public double FederationsFactOld = 0;
    public double FederationsDifferenceOld= 0;
    private void FederationsChangeText(object sender, TextChangedEventArgs e)
    {
       DifferenseUpdate(ref FederationsPlane, ref FederationsFact, ref FederationsDifference, ref FederationsPlaneOld, ref FederationsFactOld, ref FederationsDifferenceOld);
    }
    public double StatesPlaneOld = 0;
    public double StatesFactOld = 0;
    public double StatesDifferenceOld= 0;
    private void StatesChangeText(object sender, TextChangedEventArgs e)
    {
       DifferenseUpdate(ref StatesPlane, ref StatesFact, ref StatesDifference, ref StatesPlaneOld, ref StatesFactOld, ref StatesDifferenceOld);
    }
    public double LocalPlaneOld = 0;
    public double LocalFactOld = 0;
    public double LocalDifferenceOld= 0;
    private void LocalChangeText(object sender, TextChangedEventArgs e)
    {
       DifferenseUpdate(ref LocalPlane, ref LocalFact, ref LocalDifference, ref LocalPlaneOld, ref LocalFactOld, ref LocalDifferenceOld);
    }
    public double OtherPlaneOld = 0;
    public double OtherFactOld = 0;
    public double OtherDifferenceOld= 0;
    private void OtherChangeText(object sender, TextChangedEventArgs e)
    {
       DifferenseUpdate(ref OtherPlane, ref OtherFact, ref OtherDifference, ref OtherPlaneOld, ref OtherFactOld, ref OtherDifferenceOld);
    }
}