using System.Collections.Generic;
using Xamarin.Forms;

namespace Pictures_of_Cats.ViewModels
{
    public class GalleryViewModel
    {
        private readonly List<CatModel> _catList = new List<CatModel>();
        public List<CatModel> LoadCatData()
        {
            _catList.Clear();
            
            _catList.Add(new CatModel {PicFilepath=ImageSource.FromResource("Pictures_of_Cats.CatPics.Mal.0.jpg"), Name="Mal", Bio="A Chonky Boy"});
            _catList.Add(new CatModel {PicFilepath=ImageSource.FromResource("Pictures_of_Cats.CatPics.Mister.0.jpg"), Name="Mister", Bio="Laid Back and Too Cool for this World"});

            return _catList;
        }
    }
}