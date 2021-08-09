using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeAndChart.ViewModel
{
    using GalaSoft.MvvmLight;
    using ViewModel.Chart;

    public class ChartManagerViewModel : ViewModelBase
    {
        private ChartBase myChart;

        public ChartManagerViewModel()
        {
            MessengerInstance.Register<RequestChartMessage>(this, this.ReceivedMessage);
        }

        public ChartBase MyChart
        {
            get
            {
                return this.myChart;
            }

            set
            {
                this.Set(ref this.myChart, value);
            }
        }

        private void ReceivedMessage(RequestChartMessage message)
        {
            switch (message.Request)
            {
                case ChartType.Pie1:
                    this.MyChart = new Pie1ChartViewModel();
                    break;

                case ChartType.Pie2:
                    this.MyChart = new Pie2ChartViewModel();
                    break;

                case ChartType.Line:
                    this.MyChart = new LineChartViewModel();
                    break;

                case ChartType.Area:
                    this.MyChart = new AreaChartViewModel();
                    ((AreaChartViewModel)this.MyChart).SetNewData();
                    break;

                case ChartType.LineAndArea:
                    this.MyChart = new LineAndAreaChartViewModel();
                    break;

                case ChartType.Animated:
                    this.MyChart = new AnimatedChartViewModel();
                    break;

                default:
                    this.MyChart = null;
                    break;
            }
        }
    }
}
