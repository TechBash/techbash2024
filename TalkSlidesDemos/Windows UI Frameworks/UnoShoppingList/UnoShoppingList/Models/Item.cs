namespace UnoShoppingList.Models
{
    public class Item
    {
        public string Name { get; set; }
        public virtual Category Category { get; set; }
        public bool IsComplete { get; set; }
    }
}
