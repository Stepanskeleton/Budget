namespace proga;
using System.Windows;
using System.Windows.Controls;

public  class Methods
{
    public double SubtotalPlane = 0;
    public double SubtotalFact = 0;
    public double SubTotalDifference = 0;
    public static string way = "C:\\projects C#\\proga\\BdOne.db";
    public string dbName = "entertainment";
    public List<string[]> data = new List<string[]>();
    public  db_control db = new db_control(way);
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
        this.db.UpdateFilteredValue(dbName, fname, fvalue, chname, value.ToString());
    }
    public void PlaneSubTotalUpdate(ref double oldValue, ref double newValue, ref TextBox  TextBoxSubTotalPlane)
    
    {
        this.SubtotalPlane -= oldValue;
        this.SubtotalPlane+= newValue;
        oldValue = newValue;
        TextBoxSubTotalPlane.Text = SubtotalPlane.ToString();
        UpdateDB("Name","TextBoxSubTotal","Plane", this.SubtotalPlane);
    }
    public void FactSubTotalUpdate(ref double oldValue, ref double newValue, ref double value, ref TextBox TextBoxSubTotalFact)
    
    {
        this.SubtotalFact -= oldValue;
        this.SubtotalFact += newValue;
        oldValue = newValue;
        TextBoxSubTotalFact.Text = this.SubtotalFact.ToString();
        UpdateDB("Name","TextBoxSubTotal","Fact", this.SubtotalFact);
    }
    public void DifferenceSubTotalUpdate(ref double oldValue,double newValue, ref TextBox  TextBoxSubTotalDifference)
    
    {
        this.SubTotalDifference -= oldValue;
        this.SubTotalDifference += newValue;
        oldValue = newValue;
        TextBoxSubTotalDifference.Text = this.SubTotalDifference.ToString();
        this.UpdateDB("Name","TextBoxSubTotal","Difference", this.SubTotalDifference);
    }
    public void DifferenseUpdate(ref TextBox tb1, ref TextBox tb2, ref TextBox Differense, ref double oldv, ref double oldv2, ref double oldv3, ref TextBox TextBoxSubTotalPlane, ref TextBox TextBoxSubTotalFact, ref TextBox TextBoxSubTotalDifference,int n = 0, string Name11 = "")
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
            this.PlaneSubTotalUpdate(ref oldv,ref text1, ref TextBoxSubTotalPlane);
            this.FactSubTotalUpdate(ref oldv2 , ref text2,ref SubtotalFact, ref TextBoxSubTotalFact);
            this.DifferenceSubTotalUpdate(ref oldv3,(text1 - text2), ref TextBoxSubTotalDifference);
            data[n][1] = text1.ToString();
            data[n][2] = text2.ToString();
            data[n][3] = (text1 - text2).ToString();
            this.UpdateDB("Name",Name11,"Plane", text1);
            this.UpdateDB("Name",Name11,"Fact", text2);
            this.UpdateDB("Name", Name11, "Difference",(text1 - text2));
        }
    }
}
