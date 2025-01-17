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
    private readonly List<List<double>> ValuesLists = new();
    private readonly List<string> LegendsNames = new();
    private readonly List<SKColor> Colors = new List<SKColor>
    {
         (new SKColor(237, 61, 21)),
         (new SKColor(17, 39, 209)),
         (new SKColor(252, 186, 3)),
         (new SKColor(199, 42, 167)),
         (new SKColor(102, 68, 95)),
         (new SKColor(169, 197, 209)),
         (new SKColor(44, 148, 65)),
         (new SKColor(70, 120, 219)),
         (new SKColor(224, 117, 117)),
         (new SKColor(89, 212, 165)),
         (new SKColor(1, 8, 5)),
         (new SKColor(0,0,0)),
    };
    public ViewModelMainPage(List<double> values, List<string > legendsNames = null)
    {
        // Создание коллекций со значениями
        for (int i = 0; i < values.Count; i++)
        {
            ValuesLists.Add(new List<double> { Math.Abs(values[i]) });
        }
        // Создание коллекции с именами для легенды
        if (legendsNames == null)
        {
            LegendsNames = new List<string>
            {
                "Плановый остаток",  "Фактический остаток", "Разница"
            };
        }
        else
        {
            LegendsNames = new List<string>();
            for (int i = 0; i < legendsNames.Count; i++)
            {
                LegendsNames.Add(legendsNames[i]);
            }
        }
        Series = new ISeries[values.Count];
        for (int i = 0; i < values.Count; i++)
        {
            Series[i] = new PieSeries<double>
            {
                Name = LegendsNames[i],
                Values = ValuesLists[i],
                // Используем функцию для генерации уникальных цветов
                Fill = new SolidColorPaint(Colors[i])
            };
        }
    }
    public ViewModelMainPage(List<double> values,string[] legendsNames)
    {
        // Создание коллекций со значениями
        for (int i = 0; i < values.Count; i++)
        {
            ValuesLists.Add(new List<double> { Math.Abs(values[i]) });
        }
        // Создание коллекции с именами для легенды
        if (legendsNames == null)
        {
            LegendsNames = new List<string>
            {
                "Плановый остаток",  "Фактический остаток", "Разница"
            };
        }
        else
        {
            LegendsNames = new List<string>();
            for (int i = 0; i < legendsNames.Length; i++)
            {
                LegendsNames.Add(legendsNames[i]);
            }
        }
        Series = new ISeries[values.Count];
        for (int i = 0; i < values.Count; i++)
        {
            Series[i] = new PieSeries<double>
            {
                Name = LegendsNames[i],
                Values = ValuesLists[i],
                // Используем функцию для генерации уникальных цветов
                Fill = new SolidColorPaint(Colors[i])
            };
        }
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
