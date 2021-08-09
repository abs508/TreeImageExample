namespace TreeAndChart.ViewModel.Tree
{
    using System;
    using System.Collections.Generic;
    using System.Windows;
    using System.Collections.ObjectModel;

    using GalaSoft.MvvmLight;

    public class TitleItem : TreeBase
    {
        public TitleItem(
            ObservableCollection<TreeBase> leaves,
            string name)
            : base (name, ChartType.None)
        {
            this.Leaves = leaves;
        }

        public ObservableCollection<TreeBase> Leaves { get; }
    }
}
