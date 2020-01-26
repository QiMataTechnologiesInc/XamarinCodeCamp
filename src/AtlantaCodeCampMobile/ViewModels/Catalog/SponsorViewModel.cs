using System;
using AtlantaCodeCampMobile.Models.AtlantaCodeCampMobile.Models;

namespace AtlantaCodeCampMobile.ViewModels.Catalog
{
    public class SponsorViewModel
    {
        private readonly Sponsor _sponsor;

        public SponsorViewModel(Sponsor sponsor)
        {
            _sponsor = sponsor;
        }

        public Uri ImagePath => _sponsor.ImageUrl;

        public string Name => _sponsor.Name;

        public string Author => _sponsor.SponsorLevel;

        public string Date => _sponsor.Link.ToString();

        public string AverageReadingTime => _sponsor.SponsorLevel;
    }
}