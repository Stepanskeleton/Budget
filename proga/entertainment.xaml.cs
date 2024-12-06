using System.Windows.Controls;

namespace proga;

public partial class entertainment : Page
{
    public entertainment()
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
    public double VideoPlaneOld = 0;
    public double VideoFactOld = 0;
    public double VideoDifferenceOld= 0;
    private void VideoChangeText(object sender, TextChangedEventArgs e)
    {
      DifferenseUpdate(ref VideoPlane, ref VideoFact, ref VideoDifferent, ref VideoPlaneOld, ref VideoFactOld, ref VideoDifferenceOld);
    }
    public double MusicPlaneOld = 0;
    public double MusicFactOld = 0;
    public double MusicDifferenceOld= 0;
    private void MusicChangeText(object sender, TextChangedEventArgs e)
    {
        DifferenseUpdate(ref MusicPlane, ref MusicFact, ref MusicDifferent, ref MusicPlaneOld, ref MusicFactOld, ref MusicDifferenceOld);
    }
    public double FilmPlaneOld = 0;
    public double FilmFactOld = 0;
    public double FilmDifferenceOld= 0;
    private void FilmChangeText(object sender, TextChangedEventArgs e)
    {
        DifferenseUpdate(ref FilmsPlane, ref FilmFact, ref FilmsDifferent, ref FilmPlaneOld, ref FilmFactOld, ref FilmDifferenceOld);
    }
}