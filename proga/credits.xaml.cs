using System.Windows.Controls;

namespace proga;

public partial class credits : Page
{
    public credits()
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
    public double PersonalExpensesPlaneOld = 0;
    public double PersonalExpensesFactOld = 0;
    public double PersonalExpensesDifferenceOld= 0;
    private void PersonalExpensesChangeText(object sender, TextChangedEventArgs e)
    {
       DifferenseUpdate(ref PersonalExpensesPlane, ref PersonalExpensesFact, ref PersonalExpensesDifference, ref PersonalExpensesPlaneOld, ref PersonalExpensesFactOld, ref PersonalExpensesDifferenceOld);
    }
    public double ForStudyPlaneOld = 0;
    public double ForStudyFactOld = 0;
    public double ForStudyDifferenceOld= 0;
    private void ForStudyChangeText(object sender, TextChangedEventArgs e)
    {
       DifferenseUpdate(ref ForStudyPlane, ref ForStudyFact, ref ForStudyDifference, ref ForStudyPlaneOld, ref ForStudyFactOld, ref ForStudyDifferenceOld);
    }
    public double CreditCard1PlaneOld = 0;
    public double CreditCard1FactOld = 0;
    public double CreditCard1DifferenceOld= 0;
    private void CreditCard1ChangeText(object sender, TextChangedEventArgs e)
    {
       DifferenseUpdate(ref CreditCard1Plane,ref CreditCard1Fact, ref CreditCard1Difference, ref CreditCard1PlaneOld, ref CreditCard1FactOld, ref CreditCard1DifferenceOld);
    }
    public double CreditCard2PlaneOld = 0;
    public double CreditCard2FactOld = 0;
    public double CreditCard2DifferenceOld= 0;
    private void CreditCard2ChangeText(object sender, TextChangedEventArgs e)
    {
        DifferenseUpdate(ref CreditCard2Plane,ref CreditCard2Fact, ref CreditCard2Difference, ref CreditCard2PlaneOld, ref CreditCard2FactOld, ref CreditCard2DifferenceOld);
    }
    public double CreditCard3PlaneOld = 0;
    public double CreditCard3FactOld = 0;
    public double CreditCard3DifferenceOld= 0;
    private void CreditCard3ChangeText(object sender, TextChangedEventArgs e)
    {
        DifferenseUpdate(ref CreditCard3Plane,ref CreditCard3Fact, ref CreditCard3Difference, ref CreditCard3PlaneOld, ref CreditCard3FactOld, ref CreditCard3DifferenceOld);
    }
    public double OtherPlaneOld = 0;
    public double OtherFactOld = 0;
    public double OtherDifferenceOld= 0;
    private void OtherChangeText(object sender, TextChangedEventArgs e)
    {
        DifferenseUpdate(ref OtherPlane,ref OtherFact, ref OtherDifference, ref OtherPlaneOld, ref OtherFactOld, ref OtherDifferenceOld);
    }
}