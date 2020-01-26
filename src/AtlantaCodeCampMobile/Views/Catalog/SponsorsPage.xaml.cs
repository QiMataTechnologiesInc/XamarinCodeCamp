using AtlantaCodeCampMobile.ViewModels;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace AtlantaCodeCampMobile.Views.Catalog
{
    /// <summary>
    /// Page to list out article items.
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SponsorsPage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArticleListPage" /> class.
        /// </summary>
        public SponsorsPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (this.BindingContext is BaseViewModel vm)
            {
                vm?.OnAppearing();
            }
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            if (this.BindingContext is BaseViewModel vm)
            {
                vm?.OnDisappearing();
            }
        }
    }
}