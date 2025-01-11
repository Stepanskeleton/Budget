using System.Windows;
using System.Windows.Controls;

namespace proga;

public partial class entertainment : Page
{
    public entertainment() =>  InitializeComponent();
    private void GraphicsUpdate() => this.DataContext = methods.GraphicUpdate();
    public Methods methods = new Methods(9);
    private void VideoChangeText(object sender, TextChangedEventArgs e)
    {
      methods.DifferenseUpdate(ref VideoPlane, ref VideoFact, ref VideoDifferent, ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference, 0, "Video");
      GraphicsUpdate();
    }
    private void MusicChangeText(object sender, TextChangedEventArgs e)
    {
        methods.DifferenseUpdate(ref MusicPlane, ref MusicFact, ref MusicDifferent, ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference, 1 ,"Music");
        GraphicsUpdate();
    }
    private void FilmChangeText(object sender, TextChangedEventArgs e)
    {
        methods.DifferenseUpdate(ref FilmsPlane, ref FilmFact, ref FilmsDifferent,ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference, 2 ,"Films");
        GraphicsUpdate();
    }
    private void ConcertsText(object sender, TextChangedEventArgs e)
    {
        methods.DifferenseUpdate(ref ConcertsPlane, ref ConcertsFact, ref ConcertsDifference, ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference, 3,"Concerts");
        GraphicsUpdate();
    }
    private void SportIventsText(object sender, TextChangedEventArgs e)
    {
        methods.DifferenseUpdate(ref SportsIventsPlane, ref SportsIventsFact, ref SportsIventsDifference, ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference, 4,"SportsIvents");
        GraphicsUpdate();
    }
    private void TheatreText(object sender, TextChangedEventArgs e)
    {
        methods.DifferenseUpdate(ref TheatrePlane, ref TheatreFact, ref TheatreDifferent, ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference,5,"Theatre");
        GraphicsUpdate();
    }
    private void Other1Text(object sender, TextChangedEventArgs e)
    {
        methods.DifferenseUpdate(ref Other1Plane, ref Other1Fact, ref Other1Difference, ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference, 6,"Other1");
        GraphicsUpdate();
    }
    private void Other2Text(object sender, TextChangedEventArgs e)
    {
        methods.DifferenseUpdate(ref Other2Plane, ref Other2Fact, ref Other2Difference, ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference, 7,"Other2");
        GraphicsUpdate();
    }
    private void Other3Text(object sender, TextChangedEventArgs e)
    {
        methods.DifferenseUpdate(ref Other3Plane, ref Other3Fact, ref Other3Difference, ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference,8,"Other3");
        GraphicsUpdate();
    }
    private void Entertainment_OnLoaded(object sender, RoutedEventArgs e)
    {
        methods.dbName = "entertainment";
        if (methods.db.GetEntireTable(4, out methods.data, methods.dbName))
        {
            TextBoxSubTotalPlane.Text = methods.SubtotalPlane.ToString();
            TextBoxSubTotalFact.Text = methods.SubtotalFact.ToString();
            TextBoxSubTotalDifference.Text = methods.SubTotalDifference.ToString();
            methods.TextBoxAnd_OldValuesUpdate(ref VideoPlane, ref VideoFact, ref VideoDifferent,0);
            methods.TextBoxAnd_OldValuesUpdate(ref MusicPlane, ref MusicFact, ref MusicDifferent, 1);
            methods.TextBoxAnd_OldValuesUpdate(ref FilmsPlane, ref FilmFact, ref FilmsDifferent, 2);
            methods.TextBoxAnd_OldValuesUpdate( ref ConcertsPlane, ref ConcertsFact, ref ConcertsDifference, 3);
            methods.TextBoxAnd_OldValuesUpdate(ref SportsIventsPlane, ref SportsIventsFact, ref SportsIventsDifference, 4);
            methods.TextBoxAnd_OldValuesUpdate(ref TheatrePlane, ref TheatreFact, ref TheatreDifferent, 5);
            methods.TextBoxAnd_OldValuesUpdate(ref Other1Plane, ref Other1Fact, ref Other1Difference, 6);
            methods.TextBoxAnd_OldValuesUpdate(ref Other2Plane, ref Other2Fact, ref Other2Difference, 7);
            methods.TextBoxAnd_OldValuesUpdate(ref Other3Plane, ref Other3Fact, ref Other3Difference, 8);
            GraphicsUpdate();
        }
    }
}