using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using AtlantaCodeCampMobile.ViewModels.Catalog;

namespace AtlantaCodeCampMobile.ViewModels
{
    class HomeViewModel : BaseViewModel
    {

        public HomeViewModel()
        {
            RotatorImageViewModels = new ObservableCollection<RotatorImageViewModel>
            {
                new RotatorImageViewModel ("top_1.jpg"),
                new RotatorImageViewModel ("top_2.jpg"),
                new RotatorImageViewModel ("top_3.jpg"),
                new RotatorImageViewModel ("top_4.jpg")
            };

        }

        public string Title
        {
            get => "Atlanta Code Camp";
        }

        public string HeaderImageText
        {
            get => "Atlanta Code Camp 2019 is over!";
        }

        public ObservableCollection<RotatorImageViewModel> RotatorImageViewModels { get; }
    }
}
