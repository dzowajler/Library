using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace OpenLibraryApiConnection
{
    public class ApiConnection
    {
        private HttpClient httpClient { get; set; }
        private string baseUrl = "https://openlibrary.org/search.json?";

        public ApiConnection()
        {
            httpClient = new HttpClient();
        }

        public async Task<string> Connect(string searchValues = "")
        {
            //await Task.Delay(10000);

            var searchUrl = string.Concat(baseUrl, searchValues);
            var results = await httpClient.GetAsync(searchUrl);
            return await results.Content.ReadAsStringAsync();
        }
    }
}
