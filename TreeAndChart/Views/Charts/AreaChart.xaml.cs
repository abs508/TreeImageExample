namespace TreeAndChart.Views.Charts
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Controls;
    using System.Windows.Forms.DataVisualization.Charting;
    using System.Windows.Threading;
    using GalaSoft.MvvmLight.Messaging;
    using Messages;
    using TreeAndChart.Model;
    using TreeAndChart.ViewModel;
    using CommonServiceLocator;

    /// <summary>
    /// Interaction logic for AreaChart.xaml
    /// </summary>
    public partial class AreaChart : UserControl
    {
        private string mySeriesName = "Test Series";

        private double lastValue = 1;
        private int counter = 0;
        private AreaModel model;

        public AreaChart()
        {
            //ViewModelLocator vml = new ViewModelLocator();
            //this.model = vml.AreaModel;

            this.model = ServiceLocator.Current.GetInstance<AreaModel>();

            //this.model = model;
            InitializeComponent();
            SetupChartProperties();

            //DispatcherTimer timer = new DispatcherTimer();
            //timer.Interval = TimeSpan.FromMilliseconds(10);
            //timer.Tick += timer_Tick;
            //timer.Start();
        }

        private void SetupChartProperties()
        {
            chart1.Series.Clear();
            Series s = this.chart1.Series.Add(mySeriesName);
            s.ChartType = SeriesChartType.Area;
            //IEnumerable<string> titles = new List<string>
            //{
            //    "Point1",
            //    "Point2",
            //    "Point3",
            //    "Point4",
            //    "Point5",
            //};
            //IEnumerable<double> values = new List<double>
            //{
            //    5,
            //    5,
            //    5,
            //    5,
            //    2
            //};
            //this.chart1.Series[mySeriesName].Points.DataBindXY(titles, values);
            this.chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            this.chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;

            for (int index = 0; index < (this.model.Values).Count; ++index)
            {
                this.chart1.Series[mySeriesName].Points.AddXY(this.model.Titles[index], this.model.Values[index]);
            }

            //Messenger.Default.Register<AreaMessage>(this, this.NewAreaMessage);
        }

        private void NewAreaMessage(AreaMessage message)
        {
            if (chart1.Series.Count > 6)
            {
                return;
            }

            //this.chart1.Series.Add(mySeriesName);
            this.chart1.Series.SuspendUpdates();

            for (int index = 0; index < (message.Values).Count; ++index)
            {
                this.chart1.Series[mySeriesName].Points.AddXY(message.XAxis[index], message.Values[index]);
            }
            this.chart1.Series.ResumeUpdates();
            this.chart1.Update();
        }

        //private void UpdateChart()
        //{
        //    if (chart1.InvokeRequired)
        //    {
        //        chart1.Invoke(new Action(() =>
        //        {
        //            UpdateChart();
        //        }
        //        ));
        //    }
        //    else
        //    {
        //        chart1.Series[0].Points.AddXY(100, 200);
        //    }

        //}

        void timer_Tick(object sender, EventArgs e)
        {
            double newValue;
            if (lastValue == 1)
            {
                newValue = 2;
            }
            else
            {
                newValue = 1;
            }

            this.chart1.Series[mySeriesName].Points.AddXY($"P{this.counter}", newValue);
            //double dValueX = (double)(DateTime.Now.Subtract(timeStarted).TotalSeconds);
            //graphUC.AddPointToLine("trial", yValue + (rand.NextDouble() - dVariance), dValueX);
            ++counter;
            this.lastValue = newValue;
        }
    }
}