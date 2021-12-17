using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace xkcdApp.Core
{
   public static class ApiHelper
    {/// <summary>
     /// Static prop as we are only running this class once per application. Designed to be thread safe.
     /// </summary>
        public static HttpClient HttpClient { get; set; }

        public static void InitializeClient()
        {
            HttpClient = new HttpClient();
            HttpClient.DefaultRequestHeaders.Accept.Clear();
            HttpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }

    }
}
