using ShoppingListSample.Shared;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace ShoppingListSample.Uwp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public IList<Category> Categories { get; set; }
        public ObservableCollection<Item> Items { get; set; }

        public MainPage()
        {
            this.InitializeComponent();
            Categories = ShoppingListHelpers.CreateCategories();
            Items = new ObservableCollection<Item>(ShoppingListHelpers.CreateDemoShoppingListItems());
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            var newItem = new Item { Name = nameTextBox.Text, IsComplete = false, Category = (Category)categoryComboBox.SelectedItem };
            Items.Add(newItem);
            ClearEntryFields();
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            var item = (Item)((Button)sender).DataContext;
            Items.Remove(item);
        }

        private void ClearEntryFields()
        {
            nameTextBox.Text = string.Empty;
            categoryComboBox.SelectedIndex = -1;
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            var messageDialog = new MessageDialog("Save not implemented.");
            await messageDialog.ShowAsync();
        }
    }
}