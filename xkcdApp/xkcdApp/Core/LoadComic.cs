using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace xkcdApp.Core
{
    public class LoadComic
    {
        /// <summary>
        /// Type task, need class object of model that utilises necesary data, comic strip only from json
        /// </summary>
        /// <param name="comicNumber"></param>
        /// <returns></returns>
        public async Task<ComicModel> NextComic(int comicNumber = 0)
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
                if (response.IsSuccessStatusCode)
                {
                    ComicModel comic = await response.Content.ReadAsAsync<ComicModel>();
                    
                    return comic;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
