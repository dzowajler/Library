using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mappers.BooksSearchModels
{

    //public class Root
    //{
    //    public ApiResult ApiResult { get; set; }
    //}

    public class ApiResult
    {
        [JsonProperty("numFound")]
        public int NumberOfResults { get; set; }

        [JsonProperty("docs")]
        public AuthorSearchApiResult[] AuthorSearchApiResult { get; set; }
    }

    public class AuthorSearchApiResult
    {
        [JsonProperty("author_key")]
        public string[] authorKey { get; set; }

        [JsonProperty("author_name")]
        public string[] authorName { get; set; }

        [JsonProperty("cover_edition_key")]
        public string coverEditionKey { get; set; }

        [JsonProperty("cover_i")]
        public int coverId { get; set; }

        [JsonProperty("ebook_access")]
        public string eBookAcces { get; set; }

        [JsonProperty("edition_count")]
        public int editionCount { get; set; }

        [JsonProperty("first_publish_year")]
        public int firstPublishYear { get; set; }

        [JsonProperty("has_FullText")]
        public bool hasFullText { get; set; }

        [JsonProperty("title")]
        public string title { get; set; }
    }
}
