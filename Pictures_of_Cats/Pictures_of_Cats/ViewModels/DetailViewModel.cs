using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace Pictures_of_Cats.ViewModels
{
    public class DetailViewModel : ViewModelBase
    {
        private CatModel _cat;
        private List<CatPic> _catPics;
        public CatModel Cat
        {
            get => _cat;
            set
            {
                SetProperty(ref _cat, value);
                CreateCatImageList();
            }
        }

        public List<CatPic> CatPics
        {
            get => _catPics;
            set => SetProperty(ref _catPics, value);
        }

        public class CatPic
        {
            public ImageSource Image { get; set; }
        }
        private void CreateCatImageList()
        {
            var resources = GetType().Assembly.GetManifestResourceNames();
            CatPics = (from resource in resources where resource.Contains(Cat.Name) && 
                                                        !resource.EndsWith(".json") select new CatPic{Image = ImageSource.FromResource(resource)}).ToList();
        }
    }
}