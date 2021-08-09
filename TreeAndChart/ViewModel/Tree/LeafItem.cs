using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeAndChart.ViewModel.Tree
{
    using GalaSoft.MvvmLight.Command;

    public class LeafItem : TreeBase
    {
        public LeafItem(
            string name,
            ChartType request)
            : base (name, request)
        {
            this.CommandToExecute = new RelayCommand(this.CommandToExecuteMethod);
        }
    }
}
