using CoffeeShopApp.Model;


namespace CoffeeShopApp.Services;

public class ItemService
{

	public List<Item> GetAllItems()
	{
		return ItemList;
	}



	public ItemService()
	{

	}




	List<Item> ItemList = new()
    {
		new Item
		{
			ItemName = "Espresso",
			ItemType = "HotDrink",
			ItemDescription = "Strong black coffee made by forcing steam through finely-ground coffee beans",
			ItemPrice = 2.50,
			ItemImage = "hotdrink.png"
		},
		new Item
		{
			ItemName = "Mocha",
			ItemType = "HotDrink",
			ItemDescription = "Espresso with steamed milk and chocolate",
			ItemPrice = 4.50,
			ItemImage = "hotdrink.png"
		},
		new Item
		{
			ItemName = "Americano",
			ItemType = "HotDrink",
			ItemDescription = "Espresso with hot water",
			ItemPrice = 3.00,
			ItemImage = "hotdrink.png"
		},
		new Item
		{
			ItemName = "Chai Latte",
			ItemType = "HotDrink",
			ItemDescription = "Spiced tea with steamed milk",
			ItemPrice = 4.00,
			ItemImage = "hotdrink.png"
		},
		new Item
		{
			ItemName = "Hot Chocolate",
			ItemType = "HotDrink",
			ItemDescription = "Melted chocolate with steamed milk",
			ItemPrice = 4.50,
			ItemImage = "hotdrink.png"
		},
		new Item
		{
			ItemName = "Iced Tea",
			ItemType = "ColdDrink",
			ItemDescription = "Chilled tea served over ice cubes",
			ItemPrice = 2.50,
			ItemImage = "colddrink.png"
		},
		new Item
		{
			ItemName = "Frappe",
			ItemType = "ColdDrink",
			ItemDescription = "Blended coffee drink with ice and milk",
			ItemPrice = 4.50,
			ItemImage = "colddrink.png"
		},
		new Item
		{
			ItemName = "Smoothie",
			ItemType = "ColdDrink",
			ItemDescription = "Fruit-based drink blended with ice",
			ItemPrice = 4.00,
			ItemImage = "colddrink.png"
		},
		new Item
		{
			ItemName = "Lemonade",
			ItemType = "ColdDrink",
			ItemDescription = "Chilled lemon-flavored drink",
			ItemPrice = 3.00,
			ItemImage = "colddrink.png"
		},
		new Item
		{
			ItemName = "Cold Brew",
			ItemType = "ColdDrink",
			ItemDescription = "Coffee brewed with cold water over an extended period",
			ItemPrice = 3.50,
			ItemImage = "colddrink.png"
		},
		new Item
		{
			ItemName = "Egg and Cheese Croissant",
			ItemType = "Breakfast",
			ItemDescription = "Croissant filled with scrambled eggs and melted cheese",
			ItemPrice = 5.00,
			ItemImage = "breakfast.png"
		},
		new Item
		{
			ItemName = "Avocado Toast",
			ItemType = "Breakfast",
			ItemDescription = "Toasted bread topped with mashed avocado, salt, and pepper",
			ItemPrice = 6.00,
			ItemImage = "breakfast.png"
		},
		new Item
		{
			ItemName = "Pancakes",
			ItemType = "Breakfast",
			ItemDescription = "Fluffy pancakes served with maple syrup",
			ItemPrice = 7.00,
			ItemImage = "breakfast.png"
		},
		new Item
		{
			ItemName = "Breakfast Burrito",
			ItemType = "Breakfast",
			ItemDescription = "Flour tortilla filled with scrambled eggs, cheese, and choice of meat",
			ItemPrice = 8.00,
			ItemImage = "breakfast.png"
		},
		new Item
		{
			ItemName = "Granola Bowl",
			ItemType = "Breakfast",
			ItemDescription = "Greek yogurt topped with granola, fruits, and honey",
			ItemPrice = 6.50,
			ItemImage = "breakfast.png"
		},
		new Item
		{
			ItemName = "Croissant",
			ItemType = "Bakery",
			ItemDescription = "Buttery and flaky pastry",
			ItemPrice = 2.50,
			ItemImage = "bakery.png"
		},
		new Item
		{
			ItemName = "Blueberry Muffin",
			ItemType = "Bakery",
			ItemDescription = "Moist muffin filled with blueberries",
			ItemPrice = 3.00,
			ItemImage = "bakery.png"
		},
		new Item
		{
			ItemName = "Chocolate Chip Cookie",
			ItemType = "Bakery",
			ItemDescription = "Soft and chewy cookie with chocolate chips",
			ItemPrice = 2.00,
			ItemImage = "bakery.png"
		},
		new Item
		{
			ItemName = "Banana Bread",
			ItemType = "Bakery",
			ItemDescription = "Moist bread with mashed bananas and nuts",
			ItemPrice = 3.50,
			ItemImage = "bakery.png"
		},
		new Item
		{
			ItemName = "Turkey Club",
			ItemType = "Sandwich",
			ItemDescription = "Triple-decker sandwich with turkey, bacon, lettuce, tomato, and mayonnaise",
			ItemPrice = 8.50,
			ItemImage = "sandwich.png"
		},
		new Item
		{
			ItemName = "Caprese Sandwich",
			ItemType = "Sandwich",
			ItemDescription = "Sandwich with fresh mozzarella, tomatoes, basil, and balsamic glaze",
			ItemPrice = 7.50,
			ItemImage = "sandwich.png"
		},
		new Item
		{
			ItemName = "Grilled Cheese",
			ItemType = "Sandwich",
			ItemDescription = "Toasted bread with melted cheese",
			ItemPrice = 5.00,
			ItemImage = "sandwich.png"
		},
		new Item
		{
			ItemName = "BLT",
			ItemType = "Sandwich",
			ItemDescription = "Sandwich with bacon, lettuce, tomato, and mayonnaise",
			ItemPrice = 6.50,
			ItemImage = "sandwich.png"
		},
		new Item
		{
			ItemName = "Tuna Salad Sandwich",
			ItemType = "Sandwich",
			ItemDescription = "Sandwich with tuna salad, lettuce, and tomato",
			ItemPrice = 7.00,
			ItemImage = "sandwich.png"
		},
		new Item
		{
			ItemName = "Fries",
			ItemType = "Other",
			ItemDescription = "Crispy fried potato sticks",
			ItemPrice = 3.50,
			ItemImage = "other.png"
		},
		new Item
		{
			ItemName = "Chicken Wings",
			ItemType = "Other",
			ItemDescription = "Fried chicken wings served with dipping sauce",
			ItemPrice = 6.00,
			ItemImage = "other.png"
		},
		new Item
		{
			ItemName = "Soup of the Day",
			ItemType = "Other",
			ItemDescription = "Daily selection of hot soup",
			ItemPrice = 5.00,
			ItemImage = "other.png"
		},
		new Item
		{
			ItemName = "Side Salad",
			ItemType = "Other",
			ItemDescription = "Mixed greens with choice of dressing",
			ItemPrice = 4.00,
			ItemImage = "other.png"
		}
	};

}