using CoffeeShopApp.ViewModel;

namespace CoffeeShopApp.View;

public partial class MenuPage : ContentPage
{
	public MenuPage()
	{
		InitializeComponent();
		BindingContext = new MenuViewModel();
	}
}