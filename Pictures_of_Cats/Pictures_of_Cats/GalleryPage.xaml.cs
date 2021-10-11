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
    public partial class GalleryPage : ContentPage
    {
        private List<CatModel> _catList;

        public GalleryPage()
        {
            var vm = new GalleryViewModel();  
            this.BindingContext = vm;  
            InitializeComponent();

            _catList = vm.LoadCatData();
            ListView.ItemsSource = _catList;
            //CreateImageCells();
        }

        private void CreateImageCells()
        {
            foreach (var cat in _catList)
            {
                var imageCell = new ImageCell
                {
                    ImageSource = cat.PicFilepath,
                    Text = cat.Name,
                    Detail = cat.Bio
                };
            }
        }
    }
}