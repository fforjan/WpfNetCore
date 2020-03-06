namespace WpfNetCore
{
    using Microsoft.Extensions.Options;
    using ServiceInterfaces;
    using System.Windows;
    using WpfNetCore.Models;
    using WpfNetCore.ViewModel;

    public partial class MainWindow : Window
    {
        private readonly ISampleService sampleService;
        private readonly AppSettings settings;

        public MainWindow(MainWindowViewModel viewModel, ISampleService sampleService, IOptions<AppSettings> settings)
        {
            InitializeComponent();

            this.sampleService = sampleService;
            this.settings = settings.Value;

            this.DataContext = viewModel;
        }
    }
}
