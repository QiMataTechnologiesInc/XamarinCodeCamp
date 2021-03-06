using AtlantaCodeCampMobile.ViewModels;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace AtlantaCodeCampMobile.Views.Catalog
{
    /// <summary>
    /// Page to show the catalog list. 
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SessionPage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SessionPage" /> class.
        /// </summary>
        public SessionPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (BindingContext is BaseViewModel vm)
            {
                vm.OnAppearing();
            }
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            if (BindingContext is BaseViewModel vm)
            {
                vm.OnDisappearing();
            }
        }
    }
}