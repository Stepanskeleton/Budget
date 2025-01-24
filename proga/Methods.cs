namespace proga;
using System.Windows;
using System.Windows.Controls;

public  class Methods
{
    public double SubtotalPlane = 0;
    public double SubtotalFact = 0;
    public double SubTotalDifference = 0;
    private double Count = 0;
    public static string way = "BdOne.db";
    public string dbName = "entertainment";
    public List<double> Planevalues = new List<double>();
    public List<double> Factvalues = new List<double>();
    public List<string[]> data = new List<string[]>();
    public  db_control db = new db_control(way);
    public List<double[]> Values = new List<double[]>();
    public Methods() {}
    public Methods(int count)
    {
        if (count > 0)
        {
            this.Count = count;
            for (int i = 0; i < count; i++)
            {
                this.Values.Add(new double[3]);
            }
        }
    }
        /// <summary>
        /// Обновление ViewModel
        /// </summary>
        /// <returns></returns>
    public ViewModel GraphicUpdate() =>  new ViewModel(this.Planevalues, this.Factvalues);
    public void TextBoxAnd_OldValuesUpdate(ref TextBox textBoxPlane, ref TextBox textboxFact, ref TextBox TbDifference, int n)
    {
        textBoxPlane.Text =this.data[n][1];
        textboxFact.Text = this.data[n][2];
        TbDifference.Text = this.data[n][3];
        this.Values[n][0] = Convert.ToDouble(textBoxPlane.Text);
        this.Values[n][1] = Convert.ToDouble(textboxFact.Text);
        this.Values[n][2] = Convert.ToDouble(TbDifference.Text);
        this.Planevalues.Add(this.Values[n][0]);
        this.Factvalues.Add(this.Values[n][1]);
        if (this.data.Count == this.Count)
        {
            this.SubtotalPlane = Convert.ToDouble(this.data[this.data.Count -1][1]);
            SubtotalFact = Convert.ToDouble(this.data[this.data.Count - 1][2]);
            SubTotalDifference = Convert.ToDouble(this.data[this.data.Count -1 ][3]);
        }
    }
    /// <summary>
    /// Обновление данных в бд
    /// </summary>
    /// <param name="fname">Имя поля, по которому идёт филтрация</param>
    /// <param name="fvalue">Нужное значение в этом поле</param>
    /// <param name="chname">Изменяемое поле</param>
    /// <param name="value">Значение</param>
    public void UpdateDB(string fname, string fvalue, string chname, double value)
    {
        this.db.UpdateFilteredValue(this.dbName, fname, fvalue, chname, value.ToString());
    }
    /// <summary>
    /// Обновление данных в текстбоксе с промежуточным плановым расходом
    /// </summary>
    /// <param name="oldValue">Ссылка на старое значение</param>
    /// <param name="newValue">Новое значение</param>
    /// <param name="TextBoxSubTotalPlane">Ссылка на сам текстбокс</param>
    public void PlaneSubTotalUpdate(ref double oldValue, double newValue, ref TextBox  TextBoxSubTotalPlane)
    {
        this.SubtotalPlane -= oldValue;
        this.SubtotalPlane+= newValue;
        oldValue = newValue;
        TextBoxSubTotalPlane.Text = SubtotalPlane.ToString();
        this.UpdateDB("Name","TextBoxSubTotal","Plane", this.SubtotalPlane);
    }
    /// <summary>
    /// Обновление данных в текстбоксе с промежуточным Фактическим расходом
    /// </summary>
    /// <param name="oldValue">Ссылка на старое значение</param>
    /// <param name="newValue">Новое значение</param>
    /// <param name="TextBoxSubTotalFact">Ссылка на сам текстбокс</param>
    public void FactSubTotalUpdate(ref double oldValue,double newValue, ref TextBox TextBoxSubTotalFact)
    {
        this.SubtotalFact -= oldValue;
        this.SubtotalFact += newValue;
        oldValue = newValue;
        TextBoxSubTotalFact.Text = this.SubtotalFact.ToString();
        UpdateDB("Name","TextBoxSubTotal","Fact", this.SubtotalFact);
    }
    /// <summary>
    /// Обновление данных в текстбоксе с разницей
    /// </summary>
    /// <param name="oldValue">Ссылка на старое значение</param>
    /// <param name="newValue">Новое значение</param>
    /// <param name="TextBoxSubTotalDifference">Ссылка на сам текстбокс</param>
    public void DifferenceSubTotalUpdate(ref double oldValue,double newValue, ref TextBox  TextBoxSubTotalDifference)
    {
        this.SubTotalDifference -= oldValue;
        this.SubTotalDifference += newValue;
        oldValue = newValue;
        TextBoxSubTotalDifference.Text = this.SubTotalDifference.ToString();
        this.UpdateDB("Name","TextBoxSubTotal","Difference", this.SubTotalDifference);
    }
    /// <summary>
    /// Обновление текстбоксов, после ввода в них данных
    /// </summary>
    /// <param name="tb1">Ссылка на текстбокс с плановыми значениями</param>
    /// <param name="tb2">Ссылка на текстбокс с фактическими значениями</param>
    /// <param name="Differense">Ссылка на текстбокс с разницей</param>
    /// <param name="TextBoxSubTotalPlane">Ссылка на текстбокс с промежуточными плановыми значениями</param>
    /// <param name="TextBoxSubTotalFact">Ссылка на текстбокс с промежуточными фактическими значениями</param>
    /// <param name="TextBoxSubTotalDifference">Ссылка на текстбокс с промежуточной разницей</param>
    /// <param name="n">Индекс текстбоксов</param>
    /// <param name="Name11">Имя текстбоксов</param>
    public void DifferenseUpdate(ref TextBox tb1, ref TextBox tb2, ref TextBox Differense, ref TextBox TextBoxSubTotalPlane, ref TextBox TextBoxSubTotalFact, ref TextBox TextBoxSubTotalDifference,int n, string Name11)
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
            this.PlaneSubTotalUpdate(ref this.Values[n][0], text1, ref TextBoxSubTotalPlane);
            this.FactSubTotalUpdate(ref  this.Values[n][1] , text2, ref TextBoxSubTotalFact);
            this.DifferenceSubTotalUpdate(ref this.Values[n][2],(text1 - text2), ref TextBoxSubTotalDifference);
            data[n][1] = text1.ToString();
            data[n][2] = text2.ToString();
            data[n][3] = (text1 - text2).ToString();
            if (n < Planevalues.Count)
            {
                Planevalues[n] = text1;
                Factvalues[n] = text2;
            };
            this.UpdateDB("Name",Name11,"Plane", text1);
            this.UpdateDB("Name",Name11,"Fact", text2);
            this.UpdateDB("Name", Name11, "Difference",(text1 - text2));
        }
    }
}
