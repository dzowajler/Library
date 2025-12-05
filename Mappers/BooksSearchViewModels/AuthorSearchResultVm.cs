using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mappers.BooksSearchViewModels
{
    public class AuthorSearchResultVm
    {
        public string AuthorKey { get; set; }
        public string AuthorName { get; set; }
        public string CoverEditionKey { get; set; }
        public int CoverId { get; set; }
        public string EBookAcces { get; set; }
        public int EditionCount { get; set; }
        public int FirstPublishYear { get; set; }
        public bool HasFullText { get; set; }
        public string Title { get; set; }
    }
}
