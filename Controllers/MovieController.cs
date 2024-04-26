using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ReelRemyTest.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ReelRemyTest.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        [HttpGet]
        // GET: /<controller>/
        public IEnumerable<Movie> GetMovies()
        {
            return MovieRepository.Movies;

        }
    }
}

