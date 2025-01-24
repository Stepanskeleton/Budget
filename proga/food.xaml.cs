using System.Windows;
using System.Windows.Controls;

namespace proga;

public partial class food : Page
{
    public food() => InitializeComponent();
    private void GraphicsUpdate() => this.DataContext = methods.GraphicUpdate();
    Methods methods = new Methods(3);
    private void FoodsChangeText(object sender, TextChangedEventArgs e)
    {
       methods.DifferenseUpdate(ref FoodsPlane, ref FoodsFact, ref FoodsDifference, ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference,0, "Foods");
       GraphicsUpdate();
    }
    private void RestaurantChangeText(object sender, TextChangedEventArgs e)
    {
       methods.DifferenseUpdate(ref RestaurantPlane, ref RestaurantFact, ref RestaurantDifference, ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference,1, "Restaurant");
       GraphicsUpdate();
    }
    private void OtherChangeText(object sender, TextChangedEventArgs e)
    {
       methods.DifferenseUpdate(ref OtherPlane, ref OtherFact, ref OtherDifference,  ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference,2, "Other");
       GraphicsUpdate();
    }
    private void Food_OnLoaded(object sender, RoutedEventArgs e)
    {
        methods.dbName = "food";
        if (methods.db.GetEntireTable(4, out methods.data, methods.dbName))
        {
            TextBoxSubTotalPlane.Text = methods.SubtotalPlane.ToString();
            TextBoxSubTotalFact.Text = methods.SubtotalFact.ToString();
            TextBoxSubTotalDifference.Text = methods.SubTotalDifference.ToString();
            methods.TextBoxAnd_OldValuesUpdate(ref FoodsPlane, ref FoodsFact, ref FoodsDifference, 0);
            methods.TextBoxAnd_OldValuesUpdate(ref RestaurantPlane, ref RestaurantFact, ref RestaurantDifference,1);
            methods.TextBoxAnd_OldValuesUpdate(ref OtherPlane, ref OtherFact, ref OtherDifference, 2);
            GraphicsUpdate();
        }
    }
}