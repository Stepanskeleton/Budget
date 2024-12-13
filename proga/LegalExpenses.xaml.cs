using System.Windows.Controls;

namespace proga;

public partial class LegalExpenses : Page
{
    public LegalExpenses()
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
    public double AdvocatePlaneOld = 0;
    public double AdvocateFactOld = 0;
    public double AdvocateDifferenceOld= 0;
    private void AdvocateChangeText(object sender, TextChangedEventArgs e)
    {
       DifferenseUpdate(ref AdvocatePlane, ref AdvocateFact, ref AdvocateDifference, ref AdvocatePlaneOld, ref AdvocateFactOld, ref AdvocateDifferenceOld);
    }
    public double AlimonyPlaneOld = 0;
    public double AlimonyFactOld = 0;
    public double AlimonyDifferenceOld= 0;
    private void AlimonyChangeText(object sender, TextChangedEventArgs e)
    {
       DifferenseUpdate(ref AlimonyPlane, ref AlimonyFact, ref AlimonyDifference, ref AlimonyPlaneOld, ref AlimonyFactOld, ref AlimonyDifferenceOld);
    }
    public double TaxesPlaneOld = 0;
    public double TaxesFactOld = 0;
    public double TaxesDifferenceOld= 0;
    private void TaxesChangeText(object sender, TextChangedEventArgs e)
    {
       DifferenseUpdate(ref TaxesPlane, ref TaxesFact, ref TaxesDifference, ref TaxesPlaneOld, ref TaxesFactOld, ref TaxesDifferenceOld);
    }
    public double OtherPlaneOld = 0;
    public double OtherFactOld = 0;
    public double OtherDifferenceOld= 0;
    private void OtherChangeText(object sender, TextChangedEventArgs e)
    {
       DifferenseUpdate(ref OtherPlane, ref OtherFact, ref OtherDifference, ref OtherPlaneOld, ref OtherFactOld, ref OtherDifferenceOld);
    }
}