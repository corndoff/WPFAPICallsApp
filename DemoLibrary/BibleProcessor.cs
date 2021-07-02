using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class BibleProcessor
    { 
        public static async Task<BibleModel> LoadBibleVerse()
        {
            string url = "http://quotes.rest/bible/vod.json";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    BibleResultModel verse = await response.Content.ReadAsAsync<BibleResultModel>();

                    return verse.Contents;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        public static async Task<BibleModel> LoadRandomVerse()
        {
            string url = "http://quotes.rest/bible/verse.json";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    BibleResultModel verse = await response.Content.ReadAsAsync<BibleResultModel>();

                    return verse.Contents;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
