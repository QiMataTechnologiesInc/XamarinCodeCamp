using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace AtlantaCodeCampMobile.ViewModels.Catalog
{
    class RotatorImageViewModel : BaseViewModel
    {
        public RotatorImageViewModel(string imageUri)
        {
            ImageSource = new FileImageSource
            {
                File = imageUri
            };
        }

        public FileImageSource ImageSource { get; }
    }
}
