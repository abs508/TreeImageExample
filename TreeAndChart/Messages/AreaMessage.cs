using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeAndChart.Messages
{
    public class AreaMessage
    {
        public AreaMessage(
            List<string> xAxis,
            List<double> values)
        {
            this.XAxis = xAxis;
            this.Values = values;
        }

        public List<string> XAxis { get; }

        public List<double> Values { get; }
    }
}
