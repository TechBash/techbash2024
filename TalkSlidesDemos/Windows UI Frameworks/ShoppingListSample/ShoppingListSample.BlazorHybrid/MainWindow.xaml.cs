using System.Windows;
using Microsoft.Extensions.DependencyInjection;

namespace ShoppingListSample.BlazorHybrid
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddWpfBlazorWebView();
            Resources.Add("services", serviceCollection.BuildServiceProvider());

            AppDomain.CurrentDomain.UnhandledException += (sender, error) =>
            {
#if DEBUG
                MessageBox.Show(error.ExceptionObject.ToString(), "Error");
#else
    MessageBox.Show("An error has occurred.", "Error");
#endif

                // Log the error information (error.ExceptionObject)
            };
        }
    }
}