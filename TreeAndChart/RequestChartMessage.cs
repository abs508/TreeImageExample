using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeAndChart
{
    public class RequestChartMessage
    {
        public RequestChartMessage(
            ChartType request)
        {
            this.Request = request;
        }

        public ChartType Request { get; }
    }
}
