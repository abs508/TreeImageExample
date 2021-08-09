using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeAndChart.ViewModel.Chart
{
    using GalaSoft.MvvmLight.Messaging;
    using Messages;

    public class AreaChartViewModel : ChartBase
    {
        public AreaChartViewModel()
        {
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
            //    10,
            //    5,
            //    15,
            //    28,
            //    2
            //};

            //AreaMessage message =
            //    new AreaMessage(
            //        titles,
            //        values);

            //Messenger.Default.Send(message);
        }

        public void SetNewData()
        {
            List<string> titles = new List<string>
            {
                "Point1",
                "Point2",
                "Point3",
                "Point4",
                "Point5",
            };
            List<double> values = new List<double>
            {
                10,
                5,
                15,
                28,
                2
            };

            AreaMessage message =
                new AreaMessage(
                    titles,
                    values);

            Messenger.Default.Send(message);
        }
    }
}
