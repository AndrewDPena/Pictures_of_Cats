using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Pictures_of_Cats.ViewModels;
using Xamarin.Forms.Xaml;

namespace Pictures_of_Cats
{
    [XamlCompilation(XamlCompilationOptions.Compile)]  
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            var vm = new LoginViewModel();  
            this.BindingContext = vm;  
            vm.DisplayInvalidLoginPrompt += () => DisplayAlert("Error", "Invalid Login, try again", "OK");  
            InitializeComponent();  
  
            Email.Completed += (object sender, EventArgs e) =>  
            {  
                Password.Focus();  
            };  
  
            Password.Completed += (object sender, EventArgs e) =>  
            {  
                vm.SubmitCommand.Execute(null);  
            }; 
        }
    }
}