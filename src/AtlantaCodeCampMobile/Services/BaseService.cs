using System;
using System.Net.Http;
using AtlantaCodeCampMobile.Services.Exceptions;
using Xamarin.Essentials;

namespace AtlantaCodeCampMobile.Services
{
    public class BaseService
    {
        internal const string BaseUrl = "https://atlantacodecamp.com/2019/";
        
        protected internal static HttpClient Client;

        static BaseService()
        {
            Client = new HttpClient();
        }

        protected void ThrowIfNoInternet()
        {
            if (Connectivity.NetworkAccess != NetworkAccess.Internet)
            {
                throw new NetworkConnectivityException("This service can not connect to the internet");
            }
        }
    }
}