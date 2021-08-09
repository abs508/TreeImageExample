using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeAndChart.ViewModel
{
    using System.Collections.ObjectModel;
    using GalaSoft.MvvmLight;
    using Tree;

    public class ChartSelectionViewModel : ViewModelBase
    {
        public ChartSelectionViewModel()
        {
            LeafItem pie1 = new LeafItem("Pie 1", ChartType.Pie1);
            LeafItem pie2 = new LeafItem("Pie 2", ChartType.Pie2);

            ObservableCollection<TreeBase> pies =
                new ObservableCollection<TreeBase>
                {
                    pie1,
                    pie2
                };

            TitleItem pie =
                new TitleItem(
                    pies,
                    "Pie Charts");

            LeafItem lineChart = new LeafItem("Line Chart", ChartType.Line);
            LeafItem areaChart = new LeafItem("Area Chart", ChartType.Area);
            LeafItem mixedChart = new LeafItem("Overlayed", ChartType.LineAndArea);
            LeafItemFeedback updatingChart = new LeafItemFeedback("Animating", ChartType.Animated);

            ObservableCollection<TreeBase> xyCharts =
                new ObservableCollection<TreeBase>
                {
                    lineChart,
                    areaChart,
                    mixedChart,
                    updatingChart
                };

            TitleItem xyChart =
                new TitleItem(
                    xyCharts,
                    "X-Y Charts");

            this.Leaves =
                new ObservableCollection<TitleItem>
                {
                    pie,
                    xyChart
                };
        }

        public string TestText => "Test Text";

        public ObservableCollection<TitleItem> Leaves { get; }
    }
}
