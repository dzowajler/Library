using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace OpenLibraryApiConnection
{
    public class ApiConnection
    {
        private HttpClient httpClient { get; set; }

        public ApiConnection()
        {
            httpClient = new HttpClient();
        }

        public async Task Connect(string url = "")
        {
            await Task.Delay(10000);
            var results = await httpClient.GetAsync("https://openlibrary.org/search.json?q=the+lord+of+the+rings");
            var items = await results.Content.ReadAsStringAsync();
        }
    }
}
