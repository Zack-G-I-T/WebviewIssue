using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebViewIssue
{
    public partial class WebViewPageViewModel : ObservableObject
    {
        public WebViewPageViewModel()
        {
            text = new List<string?>()
            {
                @"<span><p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus interdum libero nec erat porttitor, eu porta tortor porta. </p>     <p>Cras a scelerisque dui, sed lacinia massa. Proin venenatis bibendum libero, ut viverra turpis molestie vel. Etiam id consectetur dui. Fusce eget nisi enim. Aliquam odio enim, auctor ac tincidunt eget, placerat sit amet ex. Praesent nec sapien sed mi ullamcorper commodo. Integer facilisis urna sit amet bibendum finibus. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Nulla ut interdum massa. Nunc et nunc ut odio molestie efficitur. Donec vitae maximus magna. </p>  </span>",
                @"<span><p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus interdum libero nec erat porttitor, eu porta tortor porta. </p>     <p>Cras a scelerisque dui, sed lacinia massa. Proin venenatis bibendum libero, ut viverra turpis molestie vel. Etiam id consectetur dui. Fusce eget nisi enim. Aliquam odio enim, auctor ac tincidunt eget, placerat sit amet ex. Praesent nec sapien sed mi ullamcorper commodo. Integer facilisis urna sit amet bibendum finibus. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Nulla ut interdum massa. Nunc et nunc ut odio molestie efficitur. Donec vitae maximus magna. </p>  </span>",
                @"<span><p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus interdum libero nec erat porttitor, eu porta tortor porta. </p>     <p>Cras a scelerisque dui, sed lacinia massa. Proin venenatis bibendum libero, ut viverra turpis molestie vel. Etiam id consectetur dui. Fusce eget nisi enim. Aliquam odio enim, auctor ac tincidunt eget, placerat sit amet ex. Praesent nec sapien sed mi ullamcorper commodo. Integer facilisis urna sit amet bibendum finibus. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Nulla ut interdum massa. Nunc et nunc ut odio molestie efficitur. Donec vitae maximus magna. </p>  </span>"
            };
        }

        [RelayCommand]
        public async void NextPage()
        {
            await Shell.Current.GoToAsync("WebViewPage");
        }

        [ObservableProperty] List<string?> text;
    }
}
