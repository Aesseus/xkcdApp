using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace xkcdApp.Core
{
    public class LoadComic
    {
        public async Task NextComic(int comicNumber = 0)
        {
            string url = "";
            if (comicNumber > 0)
            {
                url = $"https://xkcd.com/{ comicNumber }/info.0.json";
            }
            else
            {
                url = "https://xkcd.com/info.0.json";
            }
            /// This will open up a call/request offf our api client and wait for the response
            using (HttpResponseMessage response = await ApiHelper.HttpClient.GetAsync(url))
            {

            }
        }
    }
}
