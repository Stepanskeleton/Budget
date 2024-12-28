using System.Windows;
using System.Windows.Controls;

namespace proga;

public partial class food : Page
{
    public food()
    {
        InitializeComponent();
    }
    public double SubtotalPlane = 0;
    public double SubtotalFact = 0;
    public double SubTotalDifference = 0;
    Methods methods = new Methods();
    public static string way = "C:\\projects C#\\proga\\BdOne.db";
    public double FoodsPlaneOld = 0;
    public double FoodsFactOld = 0;
    public double FoodsDifferenceOld= 0;
    private void FoodsChangeText(object sender, TextChangedEventArgs e)
    {
       methods.DifferenseUpdate(ref FoodsPlane, ref FoodsFact, ref FoodsDifference, ref FoodsPlaneOld, ref FoodsFactOld, ref FoodsDifferenceOld, ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference,0, "Foods");
       GraphicsUpdate();
    }
    public double RestaurantPlaneOld = 0;
    public double RestaurantFactOld = 0;
    public double RestaurantDifferenceOld= 0;
    private void RestaurantChangeText(object sender, TextChangedEventArgs e)
    {
       methods.DifferenseUpdate(ref RestaurantPlane, ref RestaurantFact, ref RestaurantDifference, ref RestaurantPlaneOld, ref RestaurantFactOld, ref RestaurantDifferenceOld, ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference,1, "Restaurant");
       GraphicsUpdate();
    }
    public double OtherPlaneOld = 0;
    public double OtherFactOld = 0;
    public double OtherDifferenceOld= 0;
    private void OtherChangeText(object sender, TextChangedEventArgs e)
    {
       methods.DifferenseUpdate(ref OtherPlane, ref OtherFact, ref OtherDifference, ref OtherPlaneOld, ref OtherFactOld, ref OtherDifferenceOld, ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference,3, "Other");
       GraphicsUpdate();
    }
    private void GraphicsUpdate()
    {
        this.DataContext = methods.GraphicUpdate();
    }
    private void Food_OnLoaded(object sender, RoutedEventArgs e)
    {
        methods.dbName = "food";
        if (methods.db.GetEntireTable(4, out methods.data, methods.dbName))
        {
            SubtotalPlane = Convert.ToDouble(methods.data[methods.data.Count -1][1]);
            TextBoxSubTotalPlane.Text = SubtotalPlane.ToString();
            SubtotalFact = Convert.ToDouble(methods.data[methods.data.Count - 1][2]);
            TextBoxSubTotalFact.Text = SubtotalPlane.ToString();
            SubTotalDifference = Convert.ToDouble(methods.data[methods.data.Count -1 ][3]);
            TextBoxSubTotalDifference.Text = SubTotalDifference.ToString();
            methods.TextBoxAnd_OldValuesUpdate(ref FoodsPlane, ref FoodsFact, ref FoodsDifference, ref methods.data[0][1], ref methods.data[0][2], ref methods.data[0][3], ref FoodsPlaneOld, ref FoodsFactOld, ref FoodsDifferenceOld);
            methods.TextBoxAnd_OldValuesUpdate(ref RestaurantPlane, ref RestaurantFact, ref RestaurantDifference,ref methods.data[1][1], ref methods.data[1][2], ref  methods.data[1][3], ref RestaurantPlaneOld, ref RestaurantFactOld, ref RestaurantDifferenceOld);
            methods.TextBoxAnd_OldValuesUpdate(ref OtherPlane, ref OtherFact, ref OtherDifference, ref  methods.data[2][1], ref methods.data[2][2], ref methods.data[2][3], ref OtherPlaneOld, ref OtherFactOld, ref OtherDifferenceOld);
            GraphicsUpdate();
        }
    }
}