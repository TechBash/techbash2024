using ShoppingListSample.Shared;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace ShoppingListSample.Wpf8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private CollectionViewSource itemViewSource;
        private ObservableCollection<Item> items;
        private IList<Category> categories;

        public MainWindow()
        {
            InitializeComponent();
            itemViewSource = (CollectionViewSource)FindResource(nameof(itemViewSource));
            categories = ShoppingListHelpers.CreateCategories();
            items = new ObservableCollection<Item>(ShoppingListHelpers.CreateDemoShoppingListItems());
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // bind to the source
            itemViewSource.Source = items;
            categoryComboBox.ItemsSource = categories;
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            var newItem = new Item { Name = nameTextBox.Text, IsComplete = false, Category = (Category)categoryComboBox.SelectedItem };
            items.Add(newItem);
            itemViewSource.View.MoveCurrentTo(newItem);
            ClearEntryFields();
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            var item = (Item)((Button)sender).DataContext;
            items.Remove(item);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Save not implemented");
        }

        private void ClearEntryFields()
        {
            nameTextBox.Text = string.Empty;
            categoryComboBox.SelectedIndex = -1;
        }
    }
}