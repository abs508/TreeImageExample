using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TreeAndChart.Views.Charts
{
    using System.Windows.Forms.DataVisualization.Charting;
    using CommonServiceLocator;
    using TreeAndChart.Model;

    /// <summary>
    /// Interaction logic for AnimatedChart.xaml
    /// </summary>
    public partial class AnimatedChart : UserControl
    {
        private UpdatingModel model;
        private string mySeriesName = "Test Series";

        public AnimatedChart()
        {
            this.model = ServiceLocator.Current.GetInstance<UpdatingModel>();

            InitializeComponent();

            this.chart1.Series.Clear();
            Series s = this.chart1.Series.Add(mySeriesName);
            s.ChartType = SeriesChartType.Area;
            this.chart1.Series[mySeriesName].Points.AddXY("TestPoint", 10);

            for (int index = 0; index < (this.model.Values).Count; ++index)
            {
                this.chart1.Series[mySeriesName].Points.AddXY($"{index}", this.model.Values[index]);
            }

            this.model.UpdateEvent += ModelUpdated;
        }

        private void ModelUpdated()
        {
            try
            {

                if (chart1.InvokeRequired)
                {
                    chart1.Invoke(new Action(() =>
                    {
                        ModelUpdated();
                    }
                    ));
                }
                else
                {
                    this.chart1.Series.Clear();
                    Series s = this.chart1.Series.Add(mySeriesName);
                    s.ChartType = SeriesChartType.Area;
                    this.chart1.Series[mySeriesName].Points.AddXY("TestPoint", 10);

                    for (int index = 0; index < (this.model.Values).Count; ++index)
                    {
                        Console.WriteLine($"Index is {index}");
                        this.chart1.Series[mySeriesName].Points.AddXY($"{index}", this.model.Values[index]);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex}");
            }

            ////this.chart1.Series.SuspendUpdates();

            ////this.chart1.Series.Clear();
            ////Series s = this.chart1.Series.Add(mySeriesName);

            //for (int index = 0; index < (this.model.Values).Count; ++index)
            //{
            //    Console.WriteLine($"Index is {index}");
            //    this.chart1.Series[0].Points.AddXY($"{index}", this.model.Values[index]);
            //    Console.WriteLine($"Index is (2) {index}");
            //}
            ////this.chart1.Series.ResumeUpdates();
        }
    }
}
