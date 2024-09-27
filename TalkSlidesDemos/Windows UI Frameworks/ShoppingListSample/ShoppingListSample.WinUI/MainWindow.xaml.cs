using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using ShoppingListSample.Shared;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ShoppingListSample.WinUI
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        private MainViewModel viewModel;

        public MainWindow()
        {
            this.InitializeComponent();
            viewModel = new MainViewModel();
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            var item = (Item)((Button)sender).DataContext;
            viewModel.Items.Remove(item);
        }
    }
}