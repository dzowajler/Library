using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OpenLibraryApiConnection;
using OpenLibraryApi;

namespace Library.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BooksSearchController : ControllerBase
    {
        private readonly ILogger<BooksSearchController> _logger;
        private BooksSearchExecutor _booksSearchExecutor;

        public BooksSearchController(ILogger<BooksSearchController> logger)
        {
            _logger = logger;
            _booksSearchExecutor = new BooksSearchExecutor();
        }


        [HttpGet("/booksByAuthorSearch")]
        public async Task GetBooksByAuthor(string author)
        {
            await _booksSearchExecutor.ExecuteSearch(BooksSearchType.ByAuthor, author);
        }

        [HttpGet("/books2")]
        public async Task GetBooks2()
        {
            await _booksSearchExecutor.ExecuteSearch(BooksSearchType.ByCategory, string.Empty);
        }
    }
}
