using Mappers;
using Mappers.BooksSearchViewModels;
using OpenLibraryApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Mediators
{
    public class BooksSearchMediator
    {
        private BooksSearchExecutor _booksSearchExecutor;
        private MapApiModelsToViewModels _mapApiModelsToViewModel;

        public BooksSearchMediator()
        {
            _booksSearchExecutor = new BooksSearchExecutor();
            _mapApiModelsToViewModel = new MapApiModelsToViewModels();
        }

        public async Task<IEnumerable<AuthorSearchResultVm>> UsePipe(BooksSearchType booksSearchType, string searchParams)
        {
            var result = await _booksSearchExecutor.ExecuteSearch(booksSearchType, searchParams);

            return _mapApiModelsToViewModel.MapAuthorSearchResultToVm(result);
        }
    }
}
