using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mappers.BooksSearchModels
{

    public class Root
    {
       public AuthorSearchResult[] AuthorSearchResults;
    }

    public class AuthorSearchResult
    {
        public string authorKey { get; set; }
        public string authorName { get; set; }
        public string coverEditionKey { get; set; }
        public int coverId { get; set; }
        public string eBookAcces { get; set; }
        public int editionCount { get; set; }
        public int firstPublishYear { get; set; }
        public bool hasFullText { get; set; }
        public string title { get; set; }
    }
}
