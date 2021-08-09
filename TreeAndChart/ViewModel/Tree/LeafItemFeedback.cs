using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeAndChart.ViewModel.Tree
{
    using System.Windows.Input;
    using GalaSoft.MvvmLight.Command;

    public class LeafItemFeedback : TreeBase
    {
        private bool isRunning;

        public LeafItemFeedback(
            string name,
            ChartType request)
            : base(name, request)
        {
            this.isRunning = false;
            this.CommandToExecute = new RelayCommand(this.CommandToExecuteMethod);

            MessengerInstance.Register<RequestChartMessage>(this, this.ReceivedMessage);
        }

        public bool IsRunnig
        {
            get
            {
                return this.isRunning;
            }

            set
            {
                this.Set(ref this.isRunning, value);
            }
        }

        private void ReceivedMessage(RequestChartMessage message)
        {
            this.IsRunnig =
                message.Request == this.TypeToRequest;
        }
    }
}
