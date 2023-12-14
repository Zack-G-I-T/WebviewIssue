using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebViewIssue
{
    public partial class MainPageViewModel : ObservableObject
    {

        [RelayCommand]
        public async void NextPage()
        {
            await Shell.Current.GoToAsync("WebViewPage");
        }
    }
}
