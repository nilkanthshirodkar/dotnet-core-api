﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingApp.API.Data;
using DatingApp.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly DataContext _Context;

        public ValuesController(DataContext context)
        {
            _Context = context;
        }

        // GET api/values
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Value>>> Get()
        {
            return await _Context.Values.ToListAsync();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Value>> Get(int id)
        {
            var value = await _Context.Values.FindAsync(id);

            if(value == null){
                return NotFound();
            } 

            return value;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
