namespace TreeAndChart.ViewModel
{
    using System.Windows.Input;
    using GalaSoft.MvvmLight;
    using GalaSoft.MvvmLight.Command;

    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            this.Selection = new ChartSelectionViewModel();
            this.Charts = new ChartManagerViewModel();

            this.MyCommandToExecute = new RelayCommand(this.MyCommandToExecuteMethod);
        }

        public ICommand MyCommandToExecute { get; }

        public ChartSelectionViewModel Selection { get; }

        public ChartManagerViewModel Charts { get; }

        public string MoreTestText => "More";

        private void MyCommandToExecuteMethod()
        {
            int i = 0;
            ++i;
            int j = i;
        }
    }
}
