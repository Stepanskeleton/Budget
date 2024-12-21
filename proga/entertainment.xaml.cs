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
    private string dbName = "entertainment";
    List<string[]> data = new List<string[]>();
    db_control db = new db_control(way);
    public double SubtotalPlane = 0;
    public double SubtotalFact = 0;
    public double SubTotalDifference = 0;
    public void TextBoxAnd_OldValuesUpdate(ref TextBox textBoxPlane, ref TextBox textboxFact, ref TextBox TbDifference,ref  string NewPlane,ref string NewFact, ref string NewTbDifference, ref double oldPlane, ref double oldFact, ref double oldTbDifference)
    {
        textBoxPlane.Text = NewPlane;
        textboxFact.Text = NewFact;
        TbDifference.Text = NewTbDifference;
        oldPlane = Convert.ToDouble(textBoxPlane.Text);
        oldFact = Convert.ToDouble(textboxFact.Text);
        oldTbDifference = Convert.ToDouble(TbDifference.Text);
    }
    public void UpdateDB(string fname, string fvalue, string chname, double value)
    {
        db.UpdateFilteredValue(dbName, fname, fvalue, chname, value.ToString());
    }
    public void PlaneSubTotalUpdate(ref double oldValue, ref double newValue)
    
    {
        SubtotalPlane -= oldValue;
        SubtotalPlane+= newValue;
        oldValue = newValue;
        TextBoxSubTotalPlane.Text = SubtotalPlane.ToString();
        UpdateDB("Name","TextBoxSubTotal","Plane", SubtotalPlane);
    }
    public void FactSubTotalUpdate(ref double oldValue, ref double newValue, ref double value)
    
    {
        SubtotalFact -= oldValue;
        SubtotalFact += newValue;
        oldValue = newValue;
        TextBoxSubTotalFact.Text = SubtotalFact.ToString();
        UpdateDB("Name","TextBoxSubTotal","Fact", SubtotalFact);
    }
    public void DifferenceSubTotalUpdate(ref double oldValue,double newValue)
    
    {
        SubTotalDifference -= oldValue;
        SubTotalDifference += newValue;
        oldValue = newValue;
        TextBoxSubTotalDifference.Text = SubTotalDifference.ToString();
    }
    public void DifferenseUpdate(ref TextBox tb1, ref TextBox tb2, ref TextBox Differense, ref double oldv, ref double oldv2, ref double oldv3,int n = 0, string Name11 = "")
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
            data[n][1] = text1.ToString();
            data[n][2] = text2.ToString();
            data[n][3] = (text1 - text2).ToString();
            UpdateDB("Name",Name11,"Plane", text1);
            UpdateDB("Name",Name11,"Fact", text2);
            UpdateDB("Name", Name11, "Difference",(text1 - text2));
        }
    }
    public double VideoPlaneOld = 0;
    public double VideoFactOld = 0;
    public double VideoDifferenceOld= 0;
    private void VideoChangeText(object sender, TextChangedEventArgs e)
    {
      DifferenseUpdate(ref VideoPlane, ref VideoFact, ref VideoDifferent, ref VideoPlaneOld, ref VideoFactOld, ref VideoDifferenceOld, 0, "Video");
    }
    public double MusicPlaneOld = 0;
    public double MusicFactOld = 0;
    public double MusicDifferenceOld= 0;
    private void MusicChangeText(object sender, TextChangedEventArgs e)
    {
        DifferenseUpdate(ref MusicPlane, ref MusicFact, ref MusicDifferent, ref MusicPlaneOld, ref MusicFactOld, ref MusicDifferenceOld, 1 ,"Music");
    }
    public double FilmPlaneOld = 0;
    public double FilmFactOld = 0;
    public double FilmDifferenceOld= 0;
    private void FilmChangeText(object sender, TextChangedEventArgs e)
    {
        DifferenseUpdate(ref FilmsPlane, ref FilmFact, ref FilmsDifferent, ref FilmPlaneOld, ref FilmFactOld, ref FilmDifferenceOld, 2 ,"Films");
    }
    public double  ConcertsPlaneOld = 0;
    public double  ConcertsFactOld = 0;
    public double  ConcertsDifferenceOld= 0;
    private void ConcertsText(object sender, TextChangedEventArgs e)
    {
        DifferenseUpdate(ref ConcertsPlane, ref ConcertsFact, ref ConcertsDifference, ref  ConcertsPlaneOld, ref ConcertsFactOld, ref ConcertsDifferenceOld, 3,"Concerts");
    }
    public double SportIventsPlaneOld = 0;
    public double  SportIventsFactOld = 0;
    public double SportIventsDifferenceOld= 0;
    private void SportIventsText(object sender, TextChangedEventArgs e)
    {
        DifferenseUpdate(ref SportsIventsPlane, ref SportsIventsFact, ref SportsIventsDifference, ref  SportIventsPlaneOld, ref SportIventsFactOld, ref SportIventsDifferenceOld, 4,"SportsIvents");
        
    }
    public double TheatrePlaneOld = 0;
    public double  TheatreFactOld = 0;
    public double TheatreDifferenceOld= 0;
    private void TheatreText(object sender, TextChangedEventArgs e)
    {
        DifferenseUpdate(ref TheatrePlane, ref TheatreFact, ref TheatreDifferent, ref  TheatrePlaneOld, ref TheatreFactOld, ref TheatreDifferenceOld,5,"Theatre");
    }
    public double Other1PlaneOld = 0;
    public double  Other1FactOld = 0;
    public double Other1DifferenceOld= 0;
    private void Other1Text(object sender, TextChangedEventArgs e)
    {
        DifferenseUpdate(ref Other1Plane, ref Other1Fact, ref Other1Difference, ref  Other1PlaneOld, ref Other1FactOld, ref Other1DifferenceOld, 6,"Other1");
    }
    public double Other2PlaneOld = 0;
    public double  Other2FactOld = 0;
    public double Other2DifferenceOld= 0;
    private void Other2Text(object sender, TextChangedEventArgs e)
    {
        DifferenseUpdate(ref Other2Plane, ref Other2Fact, ref Other2Difference, ref  Other2PlaneOld, ref Other2FactOld, ref Other2DifferenceOld, 7,"Other2");
    }
    public double Other3PlaneOld = 0;
    public double  Other3FactOld = 0;
    public double Other3DifferenceOld= 0;
    private void Other3Text(object sender, TextChangedEventArgs e)
    {
        DifferenseUpdate(ref Other3Plane, ref Other3Fact, ref Other3Difference, ref  Other3PlaneOld, ref Other3FactOld, ref Other3DifferenceOld,8,"Other3");
    }

    private void Entertainment_OnLoaded(object sender, RoutedEventArgs e)
    {
        if (db.GetEntireTable(4, out data, dbName))
        {
            SubtotalPlane = Convert.ToDouble(data[9][1]);
            TextBoxSubTotalPlane.Text = SubtotalPlane.ToString();
            SubtotalFact = Convert.ToDouble(data[9][2]);
            TextBoxSubTotalFact.Text = SubtotalPlane.ToString();
            SubTotalDifference = Convert.ToDouble(data[9][3]);
            TextBoxSubTotalDifference.Text = SubTotalDifference.ToString();
            TextBoxAnd_OldValuesUpdate(ref VideoPlane, ref VideoFact, ref VideoDifferent, ref data[0][1], ref data[0][2], ref data[0][3], ref VideoPlaneOld,ref VideoFactOld,ref VideoDifferenceOld);
            TextBoxAnd_OldValuesUpdate(ref MusicPlane, ref MusicFact, ref MusicDifferent, ref data[1][1], ref data[1][2], ref data[1][3], ref MusicPlaneOld,ref MusicFactOld,ref MusicDifferenceOld);
            TextBoxAnd_OldValuesUpdate(ref FilmsPlane, ref FilmFact, ref FilmsDifferent, ref data[2][1], ref data[2][2], ref data[2][3], ref FilmPlaneOld,ref FilmFactOld,ref FilmDifferenceOld);
            TextBoxAnd_OldValuesUpdate( ref ConcertsPlane, ref ConcertsFact, ref ConcertsDifference, ref data[3][1], ref data[3][2], ref data[3][3],  ref ConcertsPlaneOld,ref ConcertsFactOld,ref ConcertsDifferenceOld);
            TextBoxAnd_OldValuesUpdate(ref SportsIventsPlane, ref SportsIventsFact, ref SportsIventsDifference, ref data[4][1], ref data[4][2], ref data[4][3], ref SportIventsPlaneOld, ref SportIventsFactOld,ref SportIventsDifferenceOld);
            TextBoxAnd_OldValuesUpdate(ref TheatrePlane, ref TheatreFact, ref TheatreDifferent, ref data[5][1],ref data[5][2],ref data[5][3], ref TheatrePlaneOld, ref TheatreFactOld,ref TheatreDifferenceOld);
            TextBoxAnd_OldValuesUpdate(ref Other1Plane, ref Other1Fact, ref Other1Difference, ref data[6][1], ref data[6][2], ref data[6][3], ref Other1PlaneOld, ref Other1FactOld, ref Other1DifferenceOld);
            TextBoxAnd_OldValuesUpdate(ref Other2Plane, ref Other2Fact, ref Other2Difference, ref data[7][1], ref data[7][2], ref data[7][3], ref Other2PlaneOld, ref Other2FactOld, ref Other2DifferenceOld);
            TextBoxAnd_OldValuesUpdate(ref Other3Plane, ref Other3Fact, ref Other3Difference, ref data[8][1], ref data[8][2], ref data[8][3], ref Other3PlaneOld, ref Other3FactOld, ref Other3DifferenceOld);
        }
    }
}