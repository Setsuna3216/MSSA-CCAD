using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MonkeyFinder.Models;
namespace MonkeyFinder.ViewModels
{
    [QueryProperty("Monkey","Monkey")]
    public partial class DetailsViewModel:BaseViewModel
    {
        IMap map;
        public DetailsViewModel(IMap _map)
        {
            map = _map;
            Title = "Monkey Details";
        }
        [ObservableProperty]
        Monkey monkey;

        
        [RelayCommand]
        private async Task OpenMapAsync()
        {
            try
            {
                await map.OpenAsync(Monkey.Latitude, Monkey.Longitude, new MapLaunchOptions
                {
                    Name=Monkey.Name,
                    NavigationMode=NavigationMode.Driving
                }
                );
            }
            catch(Exception ex)
            {
                await Shell.Current.DisplayAlert("Error", $"Unable to open maps : {ex.Message}", "Ok");
            }

        }
        
    }
}
