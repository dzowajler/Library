using OpenLibraryApi.BooksSearches;
using OpenLibraryApiConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenLibraryApi
{
    public class BooksSearchExecutor 
    {
        private IBooksSearch _booksSearch { get; set; }
        private ApiConnection _apiConnection { get; set; }

        public BooksSearchExecutor()
        {
             _apiConnection = new ApiConnection();       
        }

        public async Task ExecuteSearch(BooksSearchType booksSearchType)
        {
            IBooksSearch booksSearch = GetSearchBooksObject(booksSearchType);
            var searchUrl = booksSearch.CreateSearchUrl();

            await _apiConnection.Connect(searchUrl);
        }
        
        private IBooksSearch GetSearchBooksObject(BooksSearchType booksSearchType)
        {
            // to ma złożoność obliczeniowa O(n) - bo ile typów tyle wyszukiwań
            // jak się to włoży do słownika to będzie złożoność obliczeniowa O(1)
            if (booksSearchType == BooksSearchType.ByAuthor)
                _booksSearch = new BooksByAuthorSearch();
            else if (booksSearchType == BooksSearchType.ByCategory)
                _booksSearch = new BooksByCategorySearch();

            return _booksSearch;
        }
    }
}
