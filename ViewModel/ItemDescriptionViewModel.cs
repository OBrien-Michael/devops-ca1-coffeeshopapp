using CoffeeShopApp.Model;
using CommunityToolkit.Mvvm.ComponentModel;

namespace CoffeeShopApp.ViewModel
{
	[QueryProperty(nameof(Item), "ItemName")]
	public partial class ItemDescriptionViewModel : ObservableObject
	{
		[ObservableProperty]
		Item item;
	}
}
