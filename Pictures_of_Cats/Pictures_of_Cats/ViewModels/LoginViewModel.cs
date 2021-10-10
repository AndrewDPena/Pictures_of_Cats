using System;  
using System.ComponentModel;  
using System.Windows.Input;  
using Xamarin.Forms;  

namespace Pictures_of_Cats.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        public Action DisplayInvalidLoginPrompt;
        public Action DisplaySuccessfulLogin;
        public event PropertyChangedEventHandler PropertyChanged = delegate { };  
        private string _email;  
        public string Email
        {  
            get => _email;
            set  
            {  
                _email = value;  
                PropertyChanged(this, new PropertyChangedEventArgs("Email"));  
            }  
        }  
        private string _password;    
        public string Password
        {  
            get => _password;
            set  
            {  
                _password= value;  
                PropertyChanged(this, new PropertyChangedEventArgs("Password"));  
            }  
        }  
        public ICommand SubmitCommand { protected set; get; }  
        public LoginViewModel()  
        {  
            SubmitCommand = new Command(OnSubmit);  
        }  
        private void OnSubmit()  
        {  
            if (_email != "andrewdpena@gmail.com" || _password != "MalPaws")  
            {  
                DisplayInvalidLoginPrompt();  
            }
            else
            {
                Application.Current.MainPage = new GalleryPage();
                //DisplaySuccessfulLogin();
            }
        } 
    }
}