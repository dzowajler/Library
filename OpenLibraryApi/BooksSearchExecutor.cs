using OpenLibraryApi.BooksSearches;
using OpenLibraryApiConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenLibraryApi
{
    public class BooksSearchExecutor<T> where T: IBooksSearch
    {
        private IBooksSearch _booksSearch { get; set; }
        private ApiConnection _apiConnection { get; set; }
        private Dictionary<BooksSearchType, T> _searchFunctionDictionary { get; set; }

        public BooksSearchExecutor()
        {
            var item = new BooksByAuthorSearch();
            _searchFunctionDictionary = new Dictionary<BooksSearchType, T>()
            {
              
            };
        }

        //public void ExecuteSearch(BooksSearchType booksSearchType)
        //{
        //
        //}
        //
        //private IBooksSearch ReturnProperSearchType(BooksSearchType booksSearchType)
        //{
        //
        //}
    }
}
