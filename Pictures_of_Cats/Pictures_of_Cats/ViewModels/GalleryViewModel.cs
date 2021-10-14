using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace Pictures_of_Cats.ViewModels
{
    public class GalleryViewModel : ViewModelBase
    {
        private const string CatDirectory = "Pictures_of_Cats.CatPics.";
        private readonly List<CatModel> _catList;
        public List<CatModel> CatList => _catList;

        public GalleryViewModel()
        {
            _catList = new List<CatModel>();
            LoadCatData();
        }
        private void LoadCatData()
        {
            _catList.Clear();
            var resources = GetType().Assembly.GetManifestResourceNames();
            var infoFiles = from resource in resources where resource.EndsWith(".json") select resource;
            foreach (var file in infoFiles)
            {
                var stream = GetType().Assembly.GetManifestResourceStream(file);
                var info = new Details();
                if (stream != null)
                    using (var reader = new StreamReader(stream))
                    {
                        info = JsonConvert.DeserializeObject<Details>(reader.ReadToEnd());
                    }
                if (info != null)
                    _catList.Add(new CatModel
                    {
                        PicFilepath = ImageSource.FromResource(CatDirectory + info.Name + ".0.jpg"), Name = info.Name, Bio = info.Bio
                    });
            }
        }

        public async void CreateDetailPage(CatModel cat)
        {
            await App.NavigationService.NavigateAsync("DetailPage", cat);
        }

        public class Details
        {
            public string Name { get; set; }
            public string Bio { get; set; }
        }
    }
}