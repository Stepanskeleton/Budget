using System.Windows;
using System.Windows.Controls;

namespace proga;

public partial class PersonalHygiene : Page
{
    public PersonalHygiene()
    {
        InitializeComponent();
    }

    public double SubtotalPlane = 0;
    public double SubtotalFact = 0;
    public double SubTotalDifference = 0;
    Methods methods = new Methods();
    public static string way = "C:\\projects C#\\proga\\BdOne.db";
    public void PlaneSubTotalUpdate(ref double oldValue, ref double newValue)

    {
        SubtotalPlane -= oldValue;
        SubtotalPlane += newValue;
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

    public void DifferenceSubTotalUpdate(ref double oldValue, double newValue)

    {
        SubTotalDifference -= oldValue;
        SubTotalDifference += newValue;
        oldValue = newValue;
        TextBoxSubTotalDifference.Text = SubTotalDifference.ToString();
    }

    public void DifferenseUpdate(ref TextBox tb1, ref TextBox tb2, ref TextBox Differense, ref double oldv,
        ref double oldv2, ref double oldv3)
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
            PlaneSubTotalUpdate(ref oldv, ref text1);
            FactSubTotalUpdate(ref oldv2, ref text2, ref SubtotalFact);
            DifferenceSubTotalUpdate(ref oldv3, (text1 - text2));
        }
    }

    public double PlaneOld = 0;
    public double FactOld = 0;
    public double DifferenceOld = 0;

    private void ChangeText(object sender, TextChangedEventArgs e)
    {

    }

    public double MedicinePlaneOld = 0;
    public double MedicineFactOld = 0;
    public double MedicineDifferenceOld = 0;

    private void MedicineChangeText(object sender, TextChangedEventArgs e)
    {
        DifferenseUpdate(ref MedicinePlane, ref MedicineFact, ref MedicineDifference, ref MedicinePlaneOld,
            ref MedicineFactOld, ref MedicineDifferenceOld);
    }

    public double HairAndNailCarePlaneOld = 0;
    public double HairAndNailCareFactOld = 0;
    public double HairAndNailCareDifferenceOld = 0;

    private void HairAndNailCareChangeText(object sender, TextChangedEventArgs e)
    {
        DifferenseUpdate(ref HairAndNailCarePlane, ref HairAndNailCareFact, ref HairAndNailCareDifference,
            ref HairAndNailCarePlaneOld, ref HairAndNailCareFactOld, ref HairAndNailCareDifferenceOld);
    }
    public double ClothesPlaneOld = 0;
    public double ClothesFactOld = 0;
    public double ClothesDifferenceOld = 0;

    private void ClothesChangeText(object sender, TextChangedEventArgs e)
    {
        DifferenseUpdate(ref ClothesPlane, ref ClothesFact, ref ClothesDifference, ref ClothesPlaneOld, ref ClothesFactOld, ref ClothesDifferenceOld);
    }
    public double DryCleaningPlaneOld = 0;
    public double DryCleaningFactOld = 0;
    public double DryCleaningDifferenceOld = 0;

    private void DryCleaningChangeText(object sender, TextChangedEventArgs e)
    {
        DifferenseUpdate(ref DryCleaningPlane, ref DryCleaningFact, ref DryCleaningDifference, ref DryCleaningPlaneOld, ref DryCleaningFactOld, ref DryCleaningDifferenceOld);
    }
    public double GYMPlanePlaneOld = 0;
    public double GYMPFactOld = 0;
    public double GYMDifferenceOld = 0;

    private void GYMChangeText(object sender, TextChangedEventArgs e)
    {
        DifferenseUpdate(ref GYMPlane, ref GYMFact, ref GYMDifference, ref GYMPlanePlaneOld, ref GYMPFactOld, ref GYMDifferenceOld);
    }
    public double OrgTaxesPlaneOld = 0;
    public double OrgTaxesFactOld = 0;
    public double OrgTaxesDifferenceOld = 0;

    private void OrgTaxesChangeText(object sender, TextChangedEventArgs e)
    {
        DifferenseUpdate(ref OrgTaxesPlane, ref OrgTaxesFact, ref OrgTaxesDifference, ref OrgTaxesPlaneOld, ref OrgTaxesFactOld, ref OrgTaxesDifferenceOld);
    }
    public double OtherPlaneOld = 0;
    public double OtherFactOld = 0;
    public double OtherDifferenceOld = 0;

    private void OtherChangeText(object sender, TextChangedEventArgs e)
    {
        DifferenseUpdate(ref OtherPlane, ref OtherFact, ref OtherDifference, ref OtherPlaneOld, ref OtherFactOld, ref OtherDifferenceOld);
    }

    private void PersonalHygiene_OnLoaded(object sender, RoutedEventArgs e)
    {
        methods.dbName = "gifts_and_donations";
        if (methods.db.GetEntireTable(4, out methods.data, methods.dbName))
        {
            SubtotalPlane = Convert.ToDouble(methods.data[methods.data.Count - 1][1]);
            TextBoxSubTotalPlane.Text = SubtotalPlane.ToString();
            SubtotalFact = Convert.ToDouble(methods.data[methods.data.Count - 1][2]);
            TextBoxSubTotalFact.Text = SubtotalPlane.ToString();
            SubTotalDifference = Convert.ToDouble(methods.data[methods.data.Count - 1][3]);
            TextBoxSubTotalDifference.Text = SubTotalDifference.ToString();
         
        }
    }
}