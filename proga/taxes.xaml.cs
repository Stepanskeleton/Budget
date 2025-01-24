using System.Windows;
using System.Windows.Controls;

namespace proga;

public partial class taxes : Page
{
    public taxes() =>InitializeComponent();
    private void GraphicsUpdate() =>  this.DataContext = methods.GraphicUpdate();
    Methods methods = new Methods(4);
    private void FederationsChangeText(object sender, TextChangedEventArgs e)
    {
       methods.DifferenseUpdate(ref FederationsPlane, ref FederationsFact, ref FederationsDifference,  ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference,0, "Federations");
       GraphicsUpdate();
    }
    private void StatesChangeText(object sender, TextChangedEventArgs e)
    {
       methods.DifferenseUpdate(ref StatesPlane, ref StatesFact, ref StatesDifference,  ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference,1, "States");
       GraphicsUpdate();
    }
    private void LocalChangeText(object sender, TextChangedEventArgs e)
    {
       methods.DifferenseUpdate(ref LocalPlane, ref LocalFact, ref LocalDifference,  ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference,2, "Local");
       GraphicsUpdate();
    }
    private void OtherChangeText(object sender, TextChangedEventArgs e)
    {
       methods.DifferenseUpdate(ref OtherPlane, ref OtherFact, ref OtherDifference,  ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference,3, "Other");
       GraphicsUpdate();
    }
    private void Taxes_OnLoaded(object sender, RoutedEventArgs e)
    {
       methods.dbName = "taxes";
       if (methods.db.GetEntireTable(4, out methods.data, methods.dbName))
       {
          TextBoxSubTotalPlane.Text = methods.SubtotalPlane.ToString();
          TextBoxSubTotalFact.Text = methods.SubtotalFact.ToString();
          TextBoxSubTotalDifference.Text = methods.SubTotalDifference.ToString();
          methods.TextBoxAnd_OldValuesUpdate(ref FederationsPlane, ref FederationsFact, ref FederationsDifference,0);
          methods.TextBoxAnd_OldValuesUpdate(ref StatesPlane, ref StatesFact, ref StatesDifference,  1);
          methods.TextBoxAnd_OldValuesUpdate(ref LocalPlane, ref LocalFact, ref LocalDifference, 2);
          methods.TextBoxAnd_OldValuesUpdate(ref OtherPlane, ref OtherFact, ref OtherDifference, 3);
          GraphicsUpdate();
       }
    }
}