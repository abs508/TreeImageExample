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
    /// Interaction logic for Pie1Chart.xaml
    /// </summary>
    public partial class Pie1Chart : UserControl
    {
        public Pie1Chart()
        {
            InitializeComponent();
            SetupChartProperties();
        }

        private void SetupChartProperties()
        {
            this.chart1.Series[0].ChartType = SeriesChartType.Pie;
            this.chart1.Series[0].Points.AddXY("Set1", 20);
            this.chart1.Series[0].Points.AddXY("Set2", 40);
            this.chart1.Series[0].Points.AddXY("Set3", 40);
            this.chart1.Series[0].Points.AddXY("Set4", 5);
            this.chart1.Series[0].Points.AddXY("Set5", 120);
        }
    }
}
