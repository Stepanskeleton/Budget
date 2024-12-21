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
  
    public double MedicinePlaneOld = 0;
    public double MedicineFactOld = 0;
    public double MedicineDifferenceOld = 0;

    private void MedicineChangeText(object sender, TextChangedEventArgs e)
    {
        methods.DifferenseUpdate(ref MedicinePlane, ref MedicineFact, ref MedicineDifference, ref MedicinePlaneOld,
            ref MedicineFactOld, ref MedicineDifferenceOld, ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference,0,"Medicine");
    }

    public double HairAndNailCarePlaneOld = 0;
    public double HairAndNailCareFactOld = 0;
    public double HairAndNailCareDifferenceOld = 0;

    private void HairAndNailCareChangeText(object sender, TextChangedEventArgs e)
    {
        methods.DifferenseUpdate(ref HairAndNailCarePlane, ref HairAndNailCareFact, ref HairAndNailCareDifference,
            ref HairAndNailCarePlaneOld, ref HairAndNailCareFactOld, ref HairAndNailCareDifferenceOld, ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference,1,"HairAndNailCare");
    }
    public double ClothesPlaneOld = 0;
    public double ClothesFactOld = 0;
    public double ClothesDifferenceOld = 0;

    private void ClothesChangeText(object sender, TextChangedEventArgs e)
    {
        methods.DifferenseUpdate(ref ClothesPlane, ref ClothesFact, ref ClothesDifference, ref ClothesPlaneOld, ref ClothesFactOld, ref ClothesDifferenceOld, ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference,2,"Clothes");
    }
    public double DryCleaningPlaneOld = 0;
    public double DryCleaningFactOld = 0;
    public double DryCleaningDifferenceOld = 0;

    private void DryCleaningChangeText(object sender, TextChangedEventArgs e)
    {
        methods.DifferenseUpdate(ref DryCleaningPlane, ref DryCleaningFact, ref DryCleaningDifference, ref DryCleaningPlaneOld, ref DryCleaningFactOld, ref DryCleaningDifferenceOld, ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference,3,"DryCleaning");
    }
    public double GYMPlanePlaneOld = 0;
    public double GYMPFactOld = 0;
    public double GYMDifferenceOld = 0;

    private void GYMChangeText(object sender, TextChangedEventArgs e)
    {
        methods.DifferenseUpdate(ref GYMPlane, ref GYMFact, ref GYMDifference, ref GYMPlanePlaneOld, ref GYMPFactOld, ref GYMDifferenceOld, ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference,4,"GYM");
    }
    public double OrgTaxesPlaneOld = 0;
    public double OrgTaxesFactOld = 0;
    public double OrgTaxesDifferenceOld = 0;

    private void OrgTaxesChangeText(object sender, TextChangedEventArgs e)
    {
        methods.DifferenseUpdate(ref OrgTaxesPlane, ref OrgTaxesFact, ref OrgTaxesDifference, ref OrgTaxesPlaneOld, ref OrgTaxesFactOld, ref OrgTaxesDifferenceOld, ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference,5,"OrgTaxes");
    }
    public double OtherPlaneOld = 0;
    public double OtherFactOld = 0;
    public double OtherDifferenceOld = 0;

    private void OtherChangeText(object sender, TextChangedEventArgs e)
    {
        methods.DifferenseUpdate(ref OtherPlane, ref OtherFact, ref OtherDifference, ref OtherPlaneOld, ref OtherFactOld, ref OtherDifferenceOld, ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference,6,"Other");
    }

    private void PersonalHygiene_OnLoaded(object sender, RoutedEventArgs e)
    {
        methods.dbName = "PersonalHygiene";
        if (methods.db.GetEntireTable(4, out methods.data, methods.dbName))
        {
            SubtotalPlane = Convert.ToDouble(methods.data[methods.data.Count - 1][1]);
            TextBoxSubTotalPlane.Text = SubtotalPlane.ToString();
            SubtotalFact = Convert.ToDouble(methods.data[methods.data.Count - 1][2]);
            TextBoxSubTotalFact.Text = SubtotalPlane.ToString();
            SubTotalDifference = Convert.ToDouble(methods.data[methods.data.Count - 1][3]);
            TextBoxSubTotalDifference.Text = SubTotalDifference.ToString();
            methods.TextBoxAnd_OldValuesUpdate(ref MedicinePlane, ref MedicineFact, ref MedicineDifference, ref methods.data[0][1], ref methods.data[0][2], ref methods.data[0][3], ref MedicinePlaneOld, ref MedicineFactOld, ref MedicineDifferenceOld);
            methods.TextBoxAnd_OldValuesUpdate(ref HairAndNailCarePlane, ref HairAndNailCareFact, ref HairAndNailCareDifference, ref methods.data[1][1], ref methods.data[1][2], ref methods.data[1][3], ref HairAndNailCarePlaneOld, ref HairAndNailCareFactOld, ref HairAndNailCareDifferenceOld);
            methods.TextBoxAnd_OldValuesUpdate(ref ClothesPlane, ref ClothesFact, ref ClothesDifference, ref methods.data[2][1], ref methods.data[2][2], ref methods.data[2][3], ref ClothesPlaneOld, ref ClothesFactOld, ref ClothesDifferenceOld);
            methods.TextBoxAnd_OldValuesUpdate(ref DryCleaningPlane, ref DryCleaningFact, ref DryCleaningDifference, ref methods.data[3][1], ref methods.data[3][2], ref methods.data[3][3], ref DryCleaningPlaneOld, ref DryCleaningFactOld, ref DryCleaningDifferenceOld);
            methods.TextBoxAnd_OldValuesUpdate(ref GYMPlane, ref GYMFact, ref GYMDifference, ref methods.data[4][1], ref methods.data[4][2], ref methods.data[4][3], ref GYMPlanePlaneOld, ref GYMPFactOld, ref GYMDifferenceOld);
            methods.TextBoxAnd_OldValuesUpdate(ref OrgTaxesPlane, ref OrgTaxesFact, ref OrgTaxesDifference, ref methods.data[5][1], ref methods.data[5][2], ref methods.data[5][3], ref OrgTaxesPlaneOld, ref OrgTaxesFactOld, ref OrgTaxesDifferenceOld);
            methods.TextBoxAnd_OldValuesUpdate(ref OtherPlane, ref OtherFact, ref OtherDifference, ref methods.data[6][1], ref methods.data[6][2], ref methods.data[6][3], ref OtherPlaneOld, ref OtherFactOld, ref OtherDifferenceOld);
            
        }
    }
}