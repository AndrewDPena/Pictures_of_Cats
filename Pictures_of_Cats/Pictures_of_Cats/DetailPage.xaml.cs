using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pictures_of_Cats.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pictures_of_Cats
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPage : ContentPage
    {
        public DetailPage()
        {
            var vm = new DetailViewModel();  
            BindingContext = vm;  
            InitializeComponent();
        }
    }
}