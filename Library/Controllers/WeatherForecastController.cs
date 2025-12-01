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
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private BooksSearchExecutor _booksSearchExecutor;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
            _booksSearchExecutor = new BooksSearchExecutor();
        }

        [HttpGet("/weather")]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
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
