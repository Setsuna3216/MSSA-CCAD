using CommunityToolkit.Mvvm.Input;
using MonkeyFinder.Models;
using MonkeyFinder.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyFinder.ViewModels
{
    public partial class MonkeysViewModel:BaseViewModel
    {
        MonkeyService monkeyService;
        IConnectivity connectivity;
        IGeolocation geolocation;
        public ObservableCollection<Monkey> Monkeys { get; } = new ObservableCollection<Monkey>();
        public MonkeysViewModel(MonkeyService _monkeyService,IConnectivity _connectivity,IGeolocation _geolocation)
        {
            monkeyService = _monkeyService;
            connectivity = _connectivity;
            geolocation = _geolocation;
        }

        [RelayCommand]
        private async Task GetMonkeysAsync()
        {
            if (IsBusy)
                return;
            try
            {
                if(connectivity.NetworkAccess!=NetworkAccess.Internet)
                {
                    await Shell.Current.DisplayAlert("Error", "No internet, please try again later", "Ok");
                    return;
                }
                IsBusy = true;
                var monkeys = await monkeyService.GetMonkeys();
                if(Monkeys.Count!=0)
                {
                    Monkeys.Clear();
                }
                foreach(var m in monkeys)
                {
                    Monkeys.Add(m);
                }
            }
            catch(Exception ex)
            {
                await Shell.Current.DisplayAlert("Error!", $"unable to fetch monkeys : {ex.Message}", "Ok");
            }
            finally
            {
                IsBusy = false;
            }
        }

        [RelayCommand]
        private async Task GetClosestMonkey()
        {
            if(IsBusy ||Monkeys.Count==0)
            {
                await Shell.Current.DisplayAlert("No monkeys", "Either app is busy or get monkeys first", "Ok");
                return;
            }
            try
            {
                var location = await geolocation.GetLastKnownLocationAsync();
                if(location ==null)
                {
                    location = await geolocation.GetLocationAsync(new GeolocationRequest
                    {
                        DesiredAccuracy=GeolocationAccuracy.Medium,
                        Timeout=TimeSpan.FromSeconds(15)

                    });
                }
                if(location==null)
                {
                    await Shell.Current.DisplayAlert("No location", "Unable to get location", "Ok");
                    return;
                }
                var first = Monkeys.OrderBy(m => location.CalculateDistance(m.Latitude, m.Longitude, DistanceUnits.Miles)).FirstOrDefault();
                if(first!=null)
                {
                    await Shell.Current.DisplayAlert("Closest Monkey", $"{first.Name} is the closest monkey , located at {first.Location}", "Ok");
                }
            }
            catch(Exception ex)
            {
                await Shell.Current.DisplayAlert("Error!", $"Unable to display closest monkey :{ex.Message}", "ok");
            }
        }

        [RelayCommand]
        private async Task GoToDetailsAsync(Monkey monkey)
        {
            if (monkey == null)
                return;
            await Shell.Current.GoToAsync(nameof(DetailsPage), true, new Dictionary<string, object>
            {
                {"Monkey",monkey}
            });
        }


    }
}
