using System.Windows;
using System.Windows.Controls;

namespace proga;

public partial class PersonalHygiene : Page
{
    public PersonalHygiene() => InitializeComponent();
    private void GraphicsUpdate() => this.DataContext = methods.GraphicUpdate();
    Methods methods = new Methods(7);
    private void MedicineChangeText(object sender, TextChangedEventArgs e)
    {
        methods.DifferenseUpdate(ref MedicinePlane, ref MedicineFact, ref MedicineDifference,  ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference,0,"Medicine");
        GraphicsUpdate();
    }
    
    private void HairAndNailCareChangeText(object sender, TextChangedEventArgs e)
    {
           methods.DifferenseUpdate(ref HairAndNailCarePlane, ref HairAndNailCareFact, ref HairAndNailCareDifference,
             ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference,1,"HairAndNailCare");
        GraphicsUpdate();
    }
    private void ClothesChangeText(object sender, TextChangedEventArgs e)
    {
        methods.DifferenseUpdate(ref ClothesPlane, ref ClothesFact, ref ClothesDifference,  ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference,2,"Clothes");
        GraphicsUpdate();
    }
    private void DryCleaningChangeText(object sender, TextChangedEventArgs e)
    {
        methods.DifferenseUpdate(ref DryCleaningPlane, ref DryCleaningFact, ref DryCleaningDifference,  ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference,3,"DryCleaning");
        GraphicsUpdate();
    }
    private void GYMChangeText(object sender, TextChangedEventArgs e)
    {
        methods.DifferenseUpdate(ref GYMPlane, ref GYMFact, ref GYMDifference,  ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference,4,"GYM");
        GraphicsUpdate();
    }
    private void OrgTaxesChangeText(object sender, TextChangedEventArgs e)
    {
        methods.DifferenseUpdate(ref OrgTaxesPlane, ref OrgTaxesFact, ref OrgTaxesDifference, ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference,5,"OrgTaxes");
        GraphicsUpdate();
    }
    private void OtherChangeText(object sender, TextChangedEventArgs e)
    {
        methods.DifferenseUpdate(ref OtherPlane, ref OtherFact, ref OtherDifference,  ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference,6,"Other");
        GraphicsUpdate();
    }
    private void PersonalHygiene_OnLoaded(object sender, RoutedEventArgs e)
    {
        methods.dbName = "PersonalHygiene";
        if (methods.db.GetEntireTable(4, out methods.data, methods.dbName))
        {
            TextBoxSubTotalPlane.Text = methods.SubtotalPlane.ToString();
            TextBoxSubTotalFact.Text = methods.SubtotalFact.ToString();
            TextBoxSubTotalDifference.Text = methods.SubTotalDifference.ToString();
            methods.TextBoxAnd_OldValuesUpdate(ref MedicinePlane, ref MedicineFact, ref MedicineDifference,0);
            methods.TextBoxAnd_OldValuesUpdate(ref HairAndNailCarePlane, ref HairAndNailCareFact, ref HairAndNailCareDifference, 1);
            methods.TextBoxAnd_OldValuesUpdate(ref ClothesPlane, ref ClothesFact, ref ClothesDifference, 2);
            methods.TextBoxAnd_OldValuesUpdate(ref DryCleaningPlane, ref DryCleaningFact, ref DryCleaningDifference, 3);
            methods.TextBoxAnd_OldValuesUpdate(ref GYMPlane, ref GYMFact, ref GYMDifference, 4);
            methods.TextBoxAnd_OldValuesUpdate(ref OrgTaxesPlane, ref OrgTaxesFact, ref OrgTaxesDifference, 5);
            methods.TextBoxAnd_OldValuesUpdate(ref OtherPlane, ref OtherFact, ref OtherDifference, 6);
            GraphicsUpdate();
        }
    }
}