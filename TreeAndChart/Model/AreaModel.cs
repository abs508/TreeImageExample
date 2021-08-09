using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeAndChart.Model
{
    public class AreaModel
    {
        private List<string> titles;
        private List<double> values;

        public AreaModel()
        {
            this.titles = new List<string>
            {
                "Point1",
                "Point2",
                "Point3",
                "Point4",
                "Point5",
            };
            this.values = new List<double>
            {
                10,
                5,
                15,
                28,
                2
            };
        }

        public int TestInt => 18;

        public List<string> Titles => this.titles;
        public List<double> Values => this.values;
    }
}
