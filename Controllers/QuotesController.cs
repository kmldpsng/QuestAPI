﻿using Microsoft.AspNetCore.Mvc;
using QuestAPI.Data;
using QuestAPI.Model;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace QuestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuotesController : ControllerBase
    {
        private QuotesDbContext _quotesDbContext;

        public QuotesController(QuotesDbContext quotesDbContext)
        {
            _quotesDbContext = quotesDbContext;
        }
        // GET: api/<QuotesController>
        [HttpGet]
        public IActionResult Get()
        {
            //return _quotesDbContext.Quotes;

            return Ok(_quotesDbContext.Quotes);
        }

        // GET api/<QuotesController>/5
        [HttpGet("{id}")]
        public Quotes Get(int id)
        {
            return _quotesDbContext.Quotes.Find(id);
        }

        // POST api/<QuotesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<QuotesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<QuotesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
