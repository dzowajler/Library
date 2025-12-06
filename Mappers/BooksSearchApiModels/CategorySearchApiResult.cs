using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mappers.BooksSearchModels
{
    public class ApiResultRootCategory
    {
        [JsonProperty("numFound")]
        public int NumberOfResults { get; set; }

        [JsonProperty("docs")]
        public CategorySearchApiResult[] AuthorSearchApiResult { get; set; }
    }

    public class CategorySearchApiResult
    {
    }
}
