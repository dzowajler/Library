using Mappers.BooksSearchModels;
using Mappers.BooksSearchViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mappers
{
    public class MapApiModelsToViewModels
    {
        public IEnumerable<AuthorSearchResultVm> MapAuthorSearchResultToVm(string jsonResult)
        {
            var result = JsonConvert.DeserializeObject<ApiResult>(jsonResult);
            var items = new List<AuthorSearchResultVm>();

            if (result == null || result.NumberOfResults == 0)
                return Enumerable.Empty<AuthorSearchResultVm>();

            foreach(var item in result.AuthorSearchApiResult)
            {
                items.Add(new AuthorSearchResultVm()
                {
                    AuthorKey = item.authorKey.FirstOrDefault(),
                    AuthorName = item.authorName.FirstOrDefault(),
                    EBookAcces = item.eBookAcces,
                    CoverEditionKey = item.coverEditionKey,
                    CoverId = item.coverId,
                    EditionCount = item.editionCount,
                    FirstPublishYear = item.firstPublishYear,
                    HasFullText = item.hasFullText,
                    Title = item.title,
                });
            }

            return items;
        }
    }
}
