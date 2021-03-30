using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuestAPI.Model;

namespace QuestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuotesController : ControllerBase
    {
        static List<Quotes> _quotes = new List<Quotes>
        {
            new Quotes{ID = 1, Author = "kamal", Description = "The Dummy Project", Title = "The Dummy Project"}
        };

        [HttpGet]
        public IEnumerable<Quotes> Get()
        {
            return _quotes;
        }

        [HttpPost]
        public void Post([FromBody] Quotes quotes)
        {
            _quotes.Add(quotes);
        }
    }
}
