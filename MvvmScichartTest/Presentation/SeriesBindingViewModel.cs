using System;
using System.Collections.ObjectModel;
using System.Linq;
using DataAccess;
using GalaSoft.MvvmLight;
using SciChart.Charting.Model.ChartSeries;
using SciChart.Charting.Model.DataSeries;

namespace Presentation
{
    public class SeriesBindingViewModel : ViewModelBase
    {
        public ObservableCollection<IRenderableSeriesViewModel> RenderableSeriesViewModels { get; set; }

        public SeriesBindingViewModel()
        {
            var dataService = new DesignDataService();
            var data = dataService.GetData().ToList();

            var lineDataSeries = new XyDataSeries<DateTime, double>();
            lineDataSeries.Append(data.Select(d => d.Date), data.Select(d => d.Weight));

            RenderableSeriesViewModels = new ObservableCollection<IRenderableSeriesViewModel>()
            {
                new ColumnRenderableSeriesViewModel {DataSeries = lineDataSeries},
                new LineRenderableSeriesViewModel {DataSeries = lineDataSeries}
            };
        }

       

    }
}