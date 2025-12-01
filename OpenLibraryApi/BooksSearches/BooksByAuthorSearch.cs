using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenLibraryApi.BooksSearches
{
    public class BooksByAuthorSearch : IBooksSearch
    {
        public string CreateSearchUrl(string authorSearchParams)
        {
            var authorParamsLowerCase = authorSearchParams
                .ToLower()
                .Replace(' ', '+');

            return string.Concat(BooksSearchValues.author, BooksSearchValues.equalitySign,
                authorParamsLowerCase);
        }
    }
}
