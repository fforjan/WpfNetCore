namespace WpfNetCore
{
    using Microsoft.Extensions.Options;
    using ServiceInterfaces;
    using System.Windows;
    using WpfNetCore.Models;

    public partial class MainWindow : Window
    {
        private readonly ISampleService sampleService;
        private readonly AppSettings settings;

        public MainWindow(ISampleService sampleService, IOptions<AppSettings> settings)
        {
            InitializeComponent();

            this.sampleService = sampleService;
            this.settings = settings.Value;
        }
    }
}
