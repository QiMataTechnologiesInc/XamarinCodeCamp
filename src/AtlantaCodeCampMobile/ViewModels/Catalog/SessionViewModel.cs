using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using AtlantaCodeCampMobile.Models;

namespace AtlantaCodeCampMobile.ViewModels.Catalog
{
    class SessionViewModel
    {
        private TalkDTO _talkDTO;

        public SessionViewModel(TalkDTO talkDto)
        {
            _talkDTO = talkDto;
        }

        public Uri PreviewImage => _talkDTO.Speaker.ImageUrl;

        public string Name => _talkDTO.Title;

        public bool IsFavorite => _talkDTO.Favorite;

        public string Summary => _talkDTO.Abstract;

        public string Category => Regex.Replace(_talkDTO.Category.ToString(),
            @"(\B[A-Z]+?(?=[A-Z][^A-Z])|\B[A-Z]+?(?=[^A-Z]))"," $1");
    }
}
