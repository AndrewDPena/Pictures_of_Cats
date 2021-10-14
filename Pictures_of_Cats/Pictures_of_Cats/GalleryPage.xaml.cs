using System;
using Pictures_of_Cats.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pictures_of_Cats
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GalleryPage : ContentPage
    {
        public GalleryPage()
        {
            var vm = new GalleryViewModel();  
            BindingContext = vm;  
            InitializeComponent();
            
            ListView.ItemSelected += (e, s) =>
            {
                if (s.SelectedItem is CatModel cat)
                {
                    vm.CreateDetailPage(cat);
                }
                ((ListView)e).SelectedItem = null; ; 
            };
        }
        
    }
}