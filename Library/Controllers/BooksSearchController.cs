using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OpenLibraryApiConnection;
using OpenLibraryApi;
using Library.Mediators;
using Mappers.BooksSearchViewModels;

namespace Library.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BooksSearchController : ControllerBase
    {
        private readonly ILogger<BooksSearchController> _logger;
        private BooksSearchMediator _booksSearchMediator;

        public BooksSearchController(ILogger<BooksSearchController> logger)
        {
            _logger = logger;
            _booksSearchMediator = new BooksSearchMediator();
        }

        [HttpGet("/booksByAuthorSearch")]
        public async Task<IEnumerable<AuthorSearchResultVm>> GetBooksByAuthor(string author)
        {
            return await _booksSearchMediator.UsePipe(BooksSearchType.ByAuthor, author) as List<AuthorSearchResultVm>;
        }

        [HttpGet("/books2")]
        public async Task<IEnumerable<CategorySearchResultVm>> GetBooksByCategorySearch(string category)
        {
            return await _booksSearchMediator.UsePipe(BooksSearchType.ByCategory, category) as List<CategorySearchResultVm>;
        }
    }
}
