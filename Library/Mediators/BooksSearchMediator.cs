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
        private MappingExecutor _mappingExecutor;

        public BooksSearchMediator()
        {
            _booksSearchExecutor = new BooksSearchExecutor();
            _mappingExecutor = new MappingExecutor();
        }

        public async Task<IEnumerable<SearchResultVm>> UsePipe(BooksSearchType booksSearchType, string searchParams)
        {
            var result = await _booksSearchExecutor.ExecuteSearch(booksSearchType, searchParams);

            return _mappingExecutor.Execute(booksSearchType.ToString(), result);
        }
    }
}
