namespace CoffeeShopApp.Model;

public class Order
{
    public int OrderNumber { get; set; }
    public Customer Customer { get; set; }
    public List<Item> OrderItems { get; set; }
    public DateTime OrderDate { get; set; }
    public double TotalPrice { get; set; }
    public string OrderNotes { get; set; }
}