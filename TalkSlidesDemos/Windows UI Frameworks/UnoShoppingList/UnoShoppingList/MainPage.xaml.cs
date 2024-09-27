namespace UnoShoppingList;

public sealed partial class MainPage : Page
{
    private MainViewModel viewModel;

    public MainPage()
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
