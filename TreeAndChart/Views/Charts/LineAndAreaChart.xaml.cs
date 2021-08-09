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

    /// <summary>
    /// Interaction logic for LineAndAreaChart.xaml
    /// </summary>
    public partial class LineAndAreaChart : UserControl
    {
        private string areaSeriesName = "Area Series";
        private string lineSeriesName = "Line Series";

        public LineAndAreaChart()
        {
            InitializeComponent();

            Series areaSeries = this.chart1.Series.Add(areaSeriesName);
            areaSeries.ChartType = SeriesChartType.Area;
            areaSeries.Color = System.Drawing.Color.Purple;

            Series lineSeries = this.chart1.Series.Add(lineSeriesName);
            lineSeries.ChartType = SeriesChartType.Line;

            IEnumerable<string> titles = new List<string>
            {
                "Point1",
                "Point2",
                "Point3",
                "Point4",
                "Point5",
            };
            IEnumerable<double> lineValues = new List<double>
            {
                10,
                5,
                15,
                28,
                2
            };

            IEnumerable<double> areaValues = new List<double>
            {
                150,
                280,
                100,
                50,
                120
            };

            this.chart1.Series[lineSeriesName].Points.DataBindXY(titles, lineValues);
            this.chart1.Series[areaSeriesName].Points.DataBindXY(titles, areaValues);

            this.chart1.Series[areaSeriesName].YAxisType = AxisType.Secondary;

            this.myChartArea.AxisY2.MajorGrid.Enabled = false;
            this.myChartArea.AxisY2.Enabled = AxisEnabled.True;
        }
    }
}
