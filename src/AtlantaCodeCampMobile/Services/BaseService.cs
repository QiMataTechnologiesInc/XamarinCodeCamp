using System;
using System.Net.Http;

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
    }
}