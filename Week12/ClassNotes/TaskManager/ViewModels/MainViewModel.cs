using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.ViewModels
{
    public partial class MainViewModel:ObservableObject
    {
        IConnectivity connectivity;
        public MainViewModel(IConnectivity _connectivity)
        {
            connectivity = _connectivity;
            Items = new ObservableCollection<string>();
            
        }

        [ObservableProperty]
        string text;// name of task

        [ObservableProperty]
        ObservableCollection<string> items;//collection of tasks

        [RelayCommand]
        private async void Add()
        {
            if(string.IsNullOrEmpty(Text))
            {
                await App.Current.MainPage.DisplayAlert("Error", "Task cannot be blank", "Ok");
                return;
            }
            if(connectivity.NetworkAccess!=NetworkAccess.Internet)
            {
                await App.Current.MainPage.DisplayAlert("Error", "No internet service, try later", "Ok");
                return;
            }
            Items.Add(Text);
            Text = string.Empty;
        }
        [RelayCommand]
        private void Delete(string item)
        {
            if(Items.Contains(item))
            {
                Items.Remove(item);
            }
        }
        [RelayCommand]
        private async Task Tap(string s)
        {
            await Shell.Current.GoToAsync($"{nameof(DetailsPage)}?Text={s}");
        }
    }
}
