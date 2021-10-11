using System.Collections.Generic;

namespace Pictures_of_Cats.ViewModels
{
    public class GalleryViewModel
    {
        private readonly List<CatModel> _catList = new List<CatModel>();
        public List<CatModel> LoadCatData()
        {
            _catList.Clear();
            
            _catList.Add(new CatModel {PicFilepath="Pictures_of_Cats/Pictures_of_Cats/CatPics/Mal/0.jpg", Name="Mal", Bio="A Chonky Boy"});
            return _catList;
        }
    }
}