using Mappers.BooksSearchViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mappers
{
    public class MappingExecutor
    {
        private delegate IEnumerable<SearchResultVm> SearchDelegate(string jsonContent); 
        private Dictionary<string, SearchDelegate> _mappingFunctionsDict { get; set; }
        private MapApiModelsToViewModels _mapApiModelsToViewModels { get; set; }

        public MappingExecutor()
        {
            _mapApiModelsToViewModels = new MapApiModelsToViewModels();
            _mappingFunctionsDict = new Dictionary<string, SearchDelegate>()
            {
                {"ByAuthor", _mapApiModelsToViewModels.MapAuthorSearchResultToVm},
                {"ByCategory", _mapApiModelsToViewModels.MapCategorySearchResultToVm}
            };
        }

        public IEnumerable<SearchResultVm> Execute(string booksSearchType, string jsonContent)
        {
             return _mappingFunctionsDict[booksSearchType](jsonContent);
        }
    }
}
