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

        public async Task ExecuteSearch(BooksSearchType booksSearchType, string searchParams)
        {
            IBooksSearch booksSearch = GetSearchBooksObject(booksSearchType);
            var searchUrl = booksSearch.CreateSearchUrl(searchParams);

             await _apiConnection.Connect(searchUrl); //ciekawy przypadek bez await - ogarnąć to
            //bez await/wait nie czekam aż ten blok kodu się zakończy tylko program idzie dalej
            //a operacja asynchroniczna idzie sama sobie i nie zwraca rezultatu do wątku głównego
            // OGÓLNIE - await zwalnia wątek wywołujący, aby mógł wykonać inne operacje, przez co nie blokuje np. UI / wait nie zwalnia wątku wywołującego
            // metodę asynchroniczną tylko każe czekać do momentu zakończenia metody asynchroniczej
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
