﻿using System.Windows.Controls;

namespace proga;

public partial class gifts_and_donations : Page
{
    public gifts_and_donations()
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
    public double PlaneOld = 0;
    public double FactOld = 0;
    public double DifferenceOld= 0;
    private void ChangeText(object sender, TextChangedEventArgs e)
    {
       
    }
    public double Num1PlaneOld = 0;
    public double Num1FactOld = 0;
    public double Num1DifferenceOld= 0;
    private void Num1ChangeText(object sender, TextChangedEventArgs e)
    {
       DifferenseUpdate(ref Num1Plane, ref Num1Fact, ref Num1Difference, ref Num1PlaneOld, ref Num1FactOld, ref Num1DifferenceOld);
    }
    public double Num2PlaneOld = 0;
    public double Num2FactOld = 0;
    public double Num2DifferenceOld= 0;
    private void Num2ChangeText(object sender, TextChangedEventArgs e)
    {
        DifferenseUpdate(ref Num2Plane, ref Num2Fact, ref Num2Difference, ref Num2PlaneOld, ref Num2FactOld, ref Num2DifferenceOld);
    }
    public double Num3PlaneOld = 0;
    public double Num3FactOld = 0;
    public double Num3DifferenceOld= 0;
    private void Num3ChangeText(object sender, TextChangedEventArgs e)
    {
        DifferenseUpdate(ref Num3Plane, ref Num3Fact, ref Num3Difference, ref Num3PlaneOld, ref Num3FactOld, ref Num3DifferenceOld);
    }
}