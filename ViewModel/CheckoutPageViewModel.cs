using CoffeeShopApp.Model;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace CoffeeShopApp.ViewModel
{
	[QueryProperty(nameof(Order), "OrderNumber")]
	public partial class CheckoutPageViewModel : ObservableObject
	{
		[ObservableProperty]
		Order order;

		[RelayCommand]
		void PlaceOrder()
		{
			if (Order == null) return;

			Order = null;
		}
	}
}
