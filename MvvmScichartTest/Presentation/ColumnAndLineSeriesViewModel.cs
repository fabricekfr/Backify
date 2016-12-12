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
    public class ColumnAndLineSeriesViewModel : ViewModelBase
    {
        public ObservableCollection<IRenderableSeriesViewModel> RenderableSeriesViewModels { get; set; }

        public ColumnAndLineSeriesViewModel()
        {
            var dataService = new DesignDataService();
            var data = dataService.GetData().ToList();

            var mountainDataSeries = new XyDataSeries<DateTime, double>();
            mountainDataSeries.Append(data.Select(d => d.Date), data.Select(d => d.Weight));

            var lineDataSeries = new XyDataSeries<DateTime, double>();
            lineDataSeries.Append(data.Select(d => d.Date), data.Select(d => d.BodyFat));

            RenderableSeriesViewModels = new ObservableCollection<IRenderableSeriesViewModel>()
            {
                new ColumnRenderableSeriesViewModel {DataSeries = mountainDataSeries, YAxisId = "LeftAxis"},
                new LineRenderableSeriesViewModel {DataSeries = lineDataSeries, Stroke = Colors.Red, YAxisId = "RightAxis"}
            };



        }

       

    }
}