using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeAndChart.ViewModel.Tree
{
    using System.Windows.Input;
    using GalaSoft.MvvmLight;

    public class TreeBase : ViewModelBase
    {
        public TreeBase(
            string name,
            ChartType request)
        {
            this.Name = name;
            this.TypeToRequest = request;
        }

        /// <summary>
        ///
        /// </summary>
        public string Name { get; }

        public ChartType TypeToRequest { get; }

        public virtual ICommand CommandToExecute { get; protected set; }


        protected void CommandToExecuteMethod()
        {
            RequestChartMessage message =
                 new RequestChartMessage(
                     this.TypeToRequest);
            MessengerInstance.Send(message);
        }

    }
}
