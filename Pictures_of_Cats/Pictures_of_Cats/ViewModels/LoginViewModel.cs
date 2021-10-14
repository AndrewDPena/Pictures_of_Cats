using System;  
using System.ComponentModel;  
using System.Windows.Input;  
using Xamarin.Forms;  

namespace Pictures_of_Cats.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        public Action DisplayInvalidLoginPrompt;
        private string _email;  
        public string Email
        {  
            get => _email;
            set => SetProperty(ref _email, value);
        }  
        private string _password;    
        public string Password
        {  
            get => _password;
            set => SetProperty(ref _password, value);
        }  
        public ICommand SubmitCommand { protected set; get; }  
        public LoginViewModel()  
        {  
            SubmitCommand = new Command(OnSubmit);  
        }  
        private async void OnSubmit()  
        {  
            if (_email != "andrewdpena@gmail.com" || _password != "MalPaws")  
            {  
                DisplayInvalidLoginPrompt();  
            }
            else
            {
                await App.NavigationService.NavigateAsync("GalleryPage");
            }
        } 
    }
}