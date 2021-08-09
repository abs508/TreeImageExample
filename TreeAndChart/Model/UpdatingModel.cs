using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeAndChart.Model
{
    using System.Timers;

    public class UpdatingModel
    {
        private Random r;

        public UpdatingModel()
        {
            r = new Random();

            this.Values = new List<double>();

            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Elapsed += timer_Tick;
            timer.Start();
        }

        public Action UpdateEvent { get; set; }

        public List<double> Values { get; private set; }

        private void timer_Tick(object sender, EventArgs e)
        {
            double nextValue = r.NextDouble() * 5;

            if (Values.Count >= 60)
            {
                this.Values.RemoveAt(0);
            }

            if (Values.Count == 0)
            {
                this.Values.Add(nextValue);
            }
            else
            {
                double valueToAdd = this.Values[this.Values.Count - 1] + nextValue;
                this.Values.Add(valueToAdd);
            }


            if (this.Values[this.Values.Count - 1] > 100)
            {
                double changedValue = this.Values[this.Values.Count - 1] - 100;
                this.Values[this.Values.Count - 1] = changedValue;
            }

            if (this.UpdateEvent != null)
            {
                this.UpdateEvent.Invoke();
            }
        }
    }
}
