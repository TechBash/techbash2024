using ShoppingListSample.Shared;
using System.ComponentModel;

namespace ShoppingListSample.WinForms
{
    public partial class ShoppingListForm : Form
    {
        private BindingList<Item> items;
        private IList<Category> categories;

        public ShoppingListForm()
        {
            InitializeComponent();
            categories = ShoppingListHelpers.CreateCategories();
            items = new BindingList<Item>(ShoppingListHelpers.CreateDemoShoppingListItems())
            {
                RaiseListChangedEvents = true
            };

            itemsDataGridView.DataSource = items;
            categoryComboBox.DataSource = categories;
            categoryComboBox.SelectedIndex = -1;
        }

        private void addItemButton_Click(object sender, EventArgs e)
        {
            var newItem = new Item { Name = nameTextBox.Text, IsComplete = false, Category = categoryComboBox.SelectedItem as Category };
            items.Add(newItem);
            ClearEntryFields();
        }

        private void ClearEntryFields()
        {
            nameTextBox.Text = string.Empty;
            categoryComboBox.SelectedIndex = -1;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                               e.RowIndex >= 0)
            {
                items.RemoveAt(e.RowIndex);
            }
        }
    }
}
