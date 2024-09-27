namespace UnoShoppingList.Models
{
    public static class ShoppingListHelpers
    {
        public static IList<Category> CreateCategories()
        {
            return new List<Category>
            {
                new Category() { Name = "Produce", CategoryId = 1 },
                new Category() { Name = "Dairy", CategoryId = 2 },
                new Category() { Name = "Bakery", CategoryId = 3 },
                new Category() { Name = "Meat", CategoryId = 4 },
                new Category() { Name = "Frozen", CategoryId = 5 },
                new Category() { Name = "Canned", CategoryId = 6 },
                new Category() { Name = "Beverages", CategoryId = 7 },
                new Category() { Name = "Snacks", CategoryId = 8 }
            };
        }

        public static IList<Item> CreateDemoShoppingListItems()
        {
            return new List<Item>
            {
                new Item() { Name = "Apples", Category = new Category() { Name = "Produce" } },
                new Item() { Name = "Bananas", Category = new Category() { Name = "Produce" } },
                new Item() { Name = "Oranges", Category = new Category() { Name = "Produce" }, IsComplete = true },
                new Item() { Name = "Milk", Category = new Category() { Name = "Dairy" } },
                new Item() { Name = "Eggs", Category = new Category() { Name = "Dairy" }, IsComplete = true },
                new Item() { Name = "Bread", Category = new Category() { Name = "Bakery" }, IsComplete = true },
                new Item() { Name = "Chicken", Category = new Category() { Name = "Meat" } },
                new Item() { Name = "Beef", Category = new Category() { Name = "Meat" } },
                new Item() { Name = "Pork", Category = new Category() { Name = "Meat" }, IsComplete = true },
                new Item() { Name = "Ice Cream", Category = new Category() { Name = "Frozen" } }
            };
        }
    }
}
