namespace UnoShoppingList.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return Name ?? string.Empty;
        }
    }
}
