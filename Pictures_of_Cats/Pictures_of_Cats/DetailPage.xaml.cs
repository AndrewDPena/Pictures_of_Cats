using Pictures_of_Cats.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pictures_of_Cats
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPage : ContentPage
    {
        private CatModel _cat;
        public DetailPage(CatModel cat)
        {
            this._cat = cat;
            var vm = new DetailViewModel
            {
                Cat = _cat
            };
            BindingContext = vm;  
            InitializeComponent();
        }
    }
}