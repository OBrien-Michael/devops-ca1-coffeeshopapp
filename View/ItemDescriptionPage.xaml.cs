using CoffeeShopApp.ViewModel;

namespace CoffeeShopApp.View;

public partial class ItemDescriptionPage : ContentPage
{
	public ItemDescriptionPage(ItemDescriptionViewModel itemDescriptionViewModel)
	{
		InitializeComponent();
		BindingContext = itemDescriptionViewModel;
	}
}