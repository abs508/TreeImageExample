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
    /// <summary>
    /// Interaction logic for LineChart.xaml
    /// </summary>
    public partial class LineChart : UserControl
    {
        public LineChart()
        {
            InitializeComponent();
            SetupChartProperties();
        }

        private void SetupChartProperties()
        {
            IEnumerable<string> titles = new List<string>
            {
                "Point1",
                "Point2",
                "Point3",
                "Point4",
                "Point5",
            };
            IEnumerable<double> values = new List<double>
            {
                10,
                5,
                15,
                28,
                2
            };
            //this.chart1.Series[0].ChartType = SeriesChartType.Pie;
            this.chart1.Series[0].Points.DataBindXY(titles, values);
            this.chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
        }
    }
}
