
using CoffeeShopApp.View;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace CoffeeShopApp.ViewModel
{
	public partial class MainViewModel : ObservableObject
	{
		[RelayCommand]
		private async Task SeeMenu()
		{
			await Shell.Current.GoToAsync("//View/MenuPage");
		}
	}
}
