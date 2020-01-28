using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using AtlantaCodeCampMobile.Helpers;
using AtlantaCodeCampMobile.Models;
using AtlantaCodeCampMobile.Services;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Model = AtlantaCodeCampMobile.Models.Article;

namespace AtlantaCodeCampMobile.ViewModels.Catalog
{
    /// <summary>
    /// ViewModel for article list page.
    /// </summary> 
    [Preserve(AllMembers = true)]
    public class SpeakersViewModel : BaseViewModel
    {
        #region Fields

        private ObservableCollection<Speaker> featuredStories;

        private ObservableCollection<Speaker> latestStories;

        private SpeakerService _speakerService;

        private BackgroundTaskHelper _backgroundTaskHelper;

        #endregion

        #region Constructor
        /// <summary>
        /// Initializes a new instance for the <see cref="ArticleListViewModel" /> class.
        /// </summary>
        public SpeakersViewModel()
        {
            FeaturedStories = new ObservableCollection<Speaker>();
            LatestStories = new ObservableCollection<Speaker>();
            _speakerService = new SpeakerService();
            _backgroundTaskHelper = new BackgroundTaskHelper(GetSpeakers);
            this.MenuCommand = new Command(this.MenuClicked);
            this.BookmarkCommand = new Command(this.BookmarkButtonClicked);
            this.FeatureStoriesCommand = new Command(this.FeatureStoriesClicked);
            this.ItemSelectedCommand = new Command(this.ItemSelected);
        }
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the property that has been bound with the rotator view, which displays the articles featured stories items.
        /// </summary>
        public ObservableCollection<Speaker> FeaturedStories
        {
            get
            {
                return this.featuredStories;
            }

            set
            {
                if (this.featuredStories == value)
                {
                    return;
                }

                this.featuredStories = value;
                this.NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the property that has been bound with the list view, which displays the articles latest stories items.
        /// </summary>
        public ObservableCollection<Speaker> LatestStories
        {
            get
            {
                return this.latestStories;
            }

            set
            {
                if (this.latestStories == value)
                {
                    return;
                }

                this.latestStories = value;
                this.NotifyPropertyChanged();
            }
        }
        #endregion

        #region Command

        /// <summary>
        /// Gets or sets the command that will be executed when the menu button is clicked.
        /// </summary>
        public Command MenuCommand { get; set; }

        /// <summary>
        /// Gets or sets the command that will be executed when the bookmark button is clicked.
        /// </summary>
        public Command BookmarkCommand { get; set; }

        /// <summary>
        /// Gets or sets the command that will executed when the feature stories item is clicked.
        /// </summary>
        public Command FeatureStoriesCommand { get; set; }

        /// <summary>
        /// Gets or sets the command that will be executed when an item is selected.
        /// </summary>
        public Command ItemSelectedCommand { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Invoked when the menu button is clicked.
        /// </summary>
        /// <param name="obj">The Object</param>
        private void MenuClicked(object obj)
        {
            // Do something
        }

        /// <summary>
        /// Invoked when the bookmark button is clicked.
        /// </summary>
        /// <param name="obj">The object</param>
        private void BookmarkButtonClicked(object obj)
        {
            if (obj is Model article)
            {
                article.IsBookmarked = !article.IsBookmarked;
            }
        }

        /// <summary>
        /// Invoked when the the feature stories item is clicked.
        /// </summary>
        /// <param name="obj">The object</param>
        private void FeatureStoriesClicked(object obj)
        {
            // Do something
        }

        /// <summary>
        /// Invoked when an item is selected.
        /// </summary>
        /// <param name="obj">The Object</param>
        private void ItemSelected(object obj)
        {
            // Do something
        }

        private async Task GetSpeakers()
        {
            try
            {
                var speakerDtos = (await _speakerService.GetSpeakersAsync()).ToList();
                LatestStories.Clear();
                FeaturedStories.Clear();

                var featuredSpeakers = speakerDtos.OrderBy(x => Guid.NewGuid()).Take(5);

                foreach (var speaker in featuredSpeakers)
                {
                    featuredStories.Add(speaker);
                }

                foreach (var speaker in speakerDtos)
                {
                    LatestStories.Add(speaker);
                }
            }
            catch (Exception e)
            {
            }
        }

        internal override void OnAppearing()
        {
            base.OnAppearing();
            if (!LatestStories.Any() && _backgroundTaskHelper.BackgroundTaskIsCompleted())
            {
                _backgroundTaskHelper.StartBackgroundTask();
            }
        }

        #endregion
    }
}
