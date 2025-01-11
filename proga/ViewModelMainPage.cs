namespace proga;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using CommunityToolkit.Mvvm.Input;
using LiveChartsCore;
using LiveChartsCore.Defaults;
using LiveChartsCore.Kernel.Events;
using LiveChartsCore.Kernel.Sketches;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Drawing;
using LiveChartsCore.SkiaSharpView.Painting;
using SkiaSharp;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using SkiaSharp;
using LiveChartsCore.Measure;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using SkiaSharp;
using System.Collections.Generic;
using System.Collections.ObjectModel;
public partial class ViewModelMainPage : ObservableObject
{
    private bool _isDown = false;
    private readonly ObservableCollection<ObservablePoint> _values = new();
    private readonly List<double> values1 = new();
    private readonly List<double> values2 = new();
    private readonly List<double> values3 = new();
    public ViewModelMainPage(List<double> values)
    {
        for (int i = 0; i < values.Count; i++)
        {
            _values.Add(new ObservablePoint(i, values[i]));
        }
       values1.Add(Math.Abs(values[0]));
       values2.Add(Math.Abs(values[1]));
       values3.Add(Math.Abs(values[2]));
        /*Series = new ISeries[]
        {
            new PieSeries<ObservablePoint>
            {
                Values = _values,
                
                  //Fill  = new SolidColorPaint(new SKColor(237, 61, 21))
            }
        };*/
        Random r = new Random();
        Series = new ISeries[]
        {
            new PieSeries<double>
            {
                Name = "Плановый остаток",
                Values = values1,
                // Используем функцию для генерации уникальных цветов
                Fill = new SolidColorPaint(new SKColor(237, 61, 21))
            },
            new PieSeries<double>
            {
                Name = "Фактический остаток",
                Values = values2,
            // Используем функцию для генерации уникальных цветов
            Fill = new SolidColorPaint(new SKColor(17, 39, 209))
            },
            new PieSeries<double>
            {
                Name = "Разница",
                Values = values3,
                // Используем функцию для генерации уникальных цветов
               
            }
        };
        
    }
    public ViewModelMainPage()
    {
        var trend = 1000;
        var r = new Random();
        // Добавление данных для диаграммы
        for (var i = 0; i < 500; i++)
        {
            // Генерация случайных изменений для тренда
            _values.Add(new ObservablePoint(i, trend += r.Next(-40, 40)));
        }
        // Инициализация основной серии графика
        Series = new ISeries[]
        {
            new LineSeries<ObservablePoint>
            {
                Values = _values,
                GeometryStroke = null,
                GeometryFill = null,
                DataPadding = new(0, 1)
            }
        };
        // Инициализация серии для полосы прокрутки
        // Настройка отступов графика
        Margin = new(100, LiveChartsCore.Measure.Margin.Auto, 50, LiveChartsCore.Measure.Margin.Auto);
    }
    // Свойства для привязки данных к представлению
    public ISeries[] Series { get; set; }
    public LiveChartsCore.Measure.Margin Margin { get; set; }

    // Команда, вызываемая при нажатии мыши на график
    [RelayCommand]
    public void PointerDown(PointerCommandArgs args)
    {
        _isDown = true;
    }

    // Команда, вызываемая при перемещении мыши над графиком
    [RelayCommand]
    public void PointerMove(PointerCommandArgs args)
    {
        if (!_isDown) return;
        // Логика для взаимодействия с круговой диаграммой при перемещении мыши
    }

    // Команда, вызываемая при отпускании мыши над графиком
    [RelayCommand]
    public void PointerUp(PointerCommandArgs args)
    {
        _isDown = false;
    }
}
