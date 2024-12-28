using System.Windows;
using System.Windows.Controls;

namespace proga;

public partial class entertainment : Page
{
    public entertainment()
    {
        InitializeComponent();
    }
    public static string way = "C:\\projects C#\\proga\\BdOne.db";
    public double SubtotalPlane = 0;
    public double SubtotalFact = 0;
    public double SubTotalDifference = 0;
    public ViewModel ViewModelPage2;
    public Methods methods = new Methods();
    
    public double VideoPlaneOld = 0;
    public double VideoFactOld = 0;
    public double VideoDifferenceOld= 0;
    private void VideoChangeText(object sender, TextChangedEventArgs e)
    {
      methods.DifferenseUpdate(ref VideoPlane, ref VideoFact, ref VideoDifferent, ref VideoPlaneOld, ref VideoFactOld, ref VideoDifferenceOld,ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference, 0, "Video");
      GraphicsUpdate();
    }
    public double MusicPlaneOld = 0;
    public double MusicFactOld = 0;
    public double MusicDifferenceOld= 0;
    private void MusicChangeText(object sender, TextChangedEventArgs e)
    {
        methods.DifferenseUpdate(ref MusicPlane, ref MusicFact, ref MusicDifferent, ref MusicPlaneOld, ref MusicFactOld, ref MusicDifferenceOld,ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference, 1 ,"Music");
        GraphicsUpdate();
    }
    public double FilmPlaneOld = 0;
    public double FilmFactOld = 0;
    public double FilmDifferenceOld= 0;
    private void FilmChangeText(object sender, TextChangedEventArgs e)
    {
        methods.DifferenseUpdate(ref FilmsPlane, ref FilmFact, ref FilmsDifferent, ref FilmPlaneOld, ref FilmFactOld, ref FilmDifferenceOld,ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference, 2 ,"Films");
        GraphicsUpdate();
    }
    public double  ConcertsPlaneOld = 0;
    public double  ConcertsFactOld = 0;
    public double  ConcertsDifferenceOld= 0;
    private void ConcertsText(object sender, TextChangedEventArgs e)
    {
        methods.DifferenseUpdate(ref ConcertsPlane, ref ConcertsFact, ref ConcertsDifference, ref  ConcertsPlaneOld, ref ConcertsFactOld, ref ConcertsDifferenceOld,ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference, 3,"Concerts");
        GraphicsUpdate();
    }
    public double SportIventsPlaneOld = 0;
    public double  SportIventsFactOld = 0;
    public double SportIventsDifferenceOld= 0;
    private void SportIventsText(object sender, TextChangedEventArgs e)
    {
        methods.DifferenseUpdate(ref SportsIventsPlane, ref SportsIventsFact, ref SportsIventsDifference, ref  SportIventsPlaneOld, ref SportIventsFactOld, ref SportIventsDifferenceOld,ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference, 4,"SportsIvents");
        GraphicsUpdate();
        
    }
    public double TheatrePlaneOld = 0;
    public double  TheatreFactOld = 0;
    public double TheatreDifferenceOld= 0;
    private void TheatreText(object sender, TextChangedEventArgs e)
    {
        methods.DifferenseUpdate(ref TheatrePlane, ref TheatreFact, ref TheatreDifferent, ref  TheatrePlaneOld, ref TheatreFactOld, ref TheatreDifferenceOld,ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference,5,"Theatre");
        GraphicsUpdate();
    }
    public double Other1PlaneOld = 0;
    public double  Other1FactOld = 0;
    public double Other1DifferenceOld= 0;
    private void Other1Text(object sender, TextChangedEventArgs e)
    {
        methods.DifferenseUpdate(ref Other1Plane, ref Other1Fact, ref Other1Difference, ref  Other1PlaneOld, ref Other1FactOld, ref Other1DifferenceOld,ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference, 6,"Other1");
        GraphicsUpdate();
    }
    public double Other2PlaneOld = 0;
    public double  Other2FactOld = 0;
    public double Other2DifferenceOld= 0;
    private void Other2Text(object sender, TextChangedEventArgs e)
    {
        methods.DifferenseUpdate(ref Other2Plane, ref Other2Fact, ref Other2Difference, ref  Other2PlaneOld, ref Other2FactOld, ref Other2DifferenceOld,ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference, 7,"Other2");
        GraphicsUpdate();
    }
    public double Other3PlaneOld = 0;
    public double  Other3FactOld = 0;
    public double Other3DifferenceOld= 0;
    private void Other3Text(object sender, TextChangedEventArgs e)
    {
        methods.DifferenseUpdate(ref Other3Plane, ref Other3Fact, ref Other3Difference, ref  Other3PlaneOld, ref Other3FactOld, ref Other3DifferenceOld,ref TextBoxSubTotalPlane, ref TextBoxSubTotalFact, ref TextBoxSubTotalDifference,8,"Other3");
        GraphicsUpdate();
    }
    private void GraphicsUpdate()
    {
        this.DataContext = methods.GraphicUpdate();
    }
    private void Entertainment_OnLoaded(object sender, RoutedEventArgs e)
    {
        methods.dbName = "entertainment";
        if (methods.db.GetEntireTable(4, out methods.data, methods.dbName))
        {
            SubtotalPlane = Convert.ToDouble(methods.data[methods.data.Count -1][1]);
            TextBoxSubTotalPlane.Text = SubtotalPlane.ToString();
            SubtotalFact = Convert.ToDouble(methods.data[methods.data.Count - 1][2]);
            TextBoxSubTotalFact.Text = SubtotalPlane.ToString();
            SubTotalDifference = Convert.ToDouble(methods.data[methods.data.Count -1 ][3]);
            TextBoxSubTotalDifference.Text = SubTotalDifference.ToString();
            methods.TextBoxAnd_OldValuesUpdate(ref VideoPlane, ref VideoFact, ref VideoDifferent, ref methods.data[0][1], ref  methods.data[0][2], ref  methods.data[0][3], ref VideoPlaneOld,ref VideoFactOld,ref VideoDifferenceOld);
            methods.TextBoxAnd_OldValuesUpdate(ref MusicPlane, ref MusicFact, ref MusicDifferent, ref  methods.data[1][1], ref  methods.data[1][2], ref  methods.data[1][3], ref MusicPlaneOld,ref MusicFactOld,ref MusicDifferenceOld);
            methods.TextBoxAnd_OldValuesUpdate(ref FilmsPlane, ref FilmFact, ref FilmsDifferent, ref  methods.data[2][1], ref  methods.data[2][2], ref  methods.data[2][3], ref FilmPlaneOld,ref FilmFactOld,ref FilmDifferenceOld);
            methods.TextBoxAnd_OldValuesUpdate( ref ConcertsPlane, ref ConcertsFact, ref ConcertsDifference, ref  methods.data[3][1], ref  methods.data[3][2], ref  methods.data[3][3],  ref ConcertsPlaneOld,ref ConcertsFactOld,ref ConcertsDifferenceOld);
            methods.TextBoxAnd_OldValuesUpdate(ref SportsIventsPlane, ref SportsIventsFact, ref SportsIventsDifference, ref  methods.data[4][1], ref  methods.data[4][2], ref  methods.data[4][3], ref SportIventsPlaneOld, ref SportIventsFactOld,ref SportIventsDifferenceOld);
            methods.TextBoxAnd_OldValuesUpdate(ref TheatrePlane, ref TheatreFact, ref TheatreDifferent, ref  methods.data[5][1],ref  methods.data[5][2],ref  methods.data[5][3], ref TheatrePlaneOld, ref TheatreFactOld,ref TheatreDifferenceOld);
            methods.TextBoxAnd_OldValuesUpdate(ref Other1Plane, ref Other1Fact, ref Other1Difference, ref  methods.data[6][1], ref  methods.data[6][2], ref  methods.data[6][3], ref Other1PlaneOld, ref Other1FactOld, ref Other1DifferenceOld);
            methods.TextBoxAnd_OldValuesUpdate(ref Other2Plane, ref Other2Fact, ref Other2Difference, ref  methods.data[7][1], ref  methods.data[7][2], ref  methods.data[7][3], ref Other2PlaneOld, ref Other2FactOld, ref Other2DifferenceOld);
            methods.TextBoxAnd_OldValuesUpdate(ref Other3Plane, ref Other3Fact, ref Other3Difference, ref  methods.data[8][1], ref  methods.data[8][2], ref  methods.data[8][3], ref Other3PlaneOld, ref Other3FactOld, ref Other3DifferenceOld);
            GraphicsUpdate();
        }
    }
}