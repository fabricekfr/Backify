using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Media;
using DataAccess;
using GalaSoft.MvvmLight;
using SciChart.Charting.Model.ChartSeries;
using SciChart.Charting.Model.DataSeries;

namespace Presentation
{
    public class ColumnGroupSeriesViewModel : ViewModelBase
    {
        public ObservableCollection<IRenderableSeriesViewModel> RenderableSeriesViewModels { get; set; }

        public ColumnGroupSeriesViewModel()
        {
            var dataService = new DesignDataService();
            var data = dataService.GetData().ToList();

            var weightDataSeries = new XyDataSeries<DateTime, double>();
            weightDataSeries.Append(data.Select(d => d.Date), data.Select(d => d.Weight));

            var bodyFatDataSeries = new XyDataSeries<DateTime, double>();
            bodyFatDataSeries.Append(data.Select(d => d.Date), data.Select(d => d.BodyFat));

            var bmiDataSeries = new XyDataSeries<DateTime, double>();
            bmiDataSeries.Append(data.Select(d => d.Date), data.Select(d => d.Bmi));

            RenderableSeriesViewModels = new ObservableCollection<IRenderableSeriesViewModel>()
            {
                new StackedColumnRenderableSeriesViewModel() {DataSeries = weightDataSeries, YAxisId = "LeftAxis", StackedGroupId = "weight", Spacing = 0.5, Fill = new SolidColorBrush(Colors.Chartreuse)},
                new StackedColumnRenderableSeriesViewModel() {DataSeries = bodyFatDataSeries, YAxisId = "RightAxis", StackedGroupId = "bodyFatBmi", Spacing = 0.5, Fill = new SolidColorBrush(Colors.Chocolate)},
                new StackedColumnRenderableSeriesViewModel() {DataSeries = bmiDataSeries, YAxisId = "RightAxis", StackedGroupId = "bodyFatBmi", Spacing = 0.5, Fill = new SolidColorBrush(Colors.Khaki)}
            };



        }
    }
}