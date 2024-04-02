using System.Collections.ObjectModel;
using CoffeeShopApp.Model;
using CoffeeShopApp.Services;
using CoffeeShopApp.View;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace CoffeeShopApp.ViewModel
{
    public partial class MenuViewModel : ObservableObject
    {
	    private ItemService itemService;
	    public ObservableCollection<Item> ItemCollection { get; set; } = new ObservableCollection<Item>();

		public MenuViewModel()
		{
			itemService = new ItemService();
			ShowAllMenuItems();
		}

		private void ShowAllMenuItems()
	    {
		    var items = itemService.GetAllItems();
		    foreach (var item in items)
		    {
			    ItemCollection.Add(item);
		    }
	    }

	    [ObservableProperty]
	    Item selectedItem;

	    [RelayCommand]
	    async Task GetItemDescription()
	    {
		    if (SelectedItem == null) return;
		    await Shell.Current.GoToAsync($"{nameof(ItemDescriptionPage)}",
			    new Dictionary<string, object>
			    {
				    {"Item", SelectedItem}
			    });
		    SelectedItem = null;
	    }
	}
}
